using DidacticVerse.Accounts;
using DidacticVerse.Models;
using EfVueMantle;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DidacticVerse.Services;

public class DiscussionService : ServiceBase<DiscussionModel, long>
{
    private readonly DidacticVerseContext _context;
    private readonly DbSet<DiscussionModel> _discussions;
    private readonly AccountProvider _accountProvider;

    public DiscussionService(DidacticVerseContext context, AccountProvider accountProvider) : base(context.Discussions, context)
    {
        _context = context;
        _discussions = context.Discussions;
        _accountProvider = accountProvider;
    }

    public override DiscussionModel Save(DiscussionModel data)
    {
        data.UserId = _accountProvider.GetAccountId();
        return base.Save(data);
    }

    public List<ToggleVoteModel> ToggleVote(long discussionId, long accountId)
    {
        //TODO real user ID
        var val = new List<ToggleVoteModel>();
        var vote = _context.DiscussionVotes.Where(x => x.DiscussionId == discussionId && x.UserId == accountId).FirstOrDefault();
        if (vote == null)
        {
            _context.DiscussionVotes.Add(new DiscussionVoteModel() { DiscussionId = discussionId, UserId = accountId });
            _context.SaveChanges();
            var getCount = _context.DiscussionVotes.Where(y => y.DiscussionId == discussionId).Count();
            val.Add(new ToggleVoteModel
            {
                Status = true,
                VoteCount = getCount,
            });
            return val;
        }
        else
        {
            _context.DiscussionVotes.Remove(vote);
            _context.SaveChanges();
            var getCount = _context.DiscussionVotes.Where(y => y.DiscussionId == discussionId).Count();
            val.Add(new ToggleVoteModel
            {
                Status = false,
                VoteCount = getCount,
            });
            return val;
        }
    }

    public bool Report(ReportDTO reportDTO, long userId)
    {
        if (reportDTO == null) return false; //TODO or error out?
        var discussionReport = new DiscussionReportModel()
        {
            DiscussionId = reportDTO.Id,
            ReportingUserId = userId,
            ReportReason = reportDTO.ReportReason
        };
        _context.DiscussionReports.Add(discussionReport);
        _context.SaveChanges();
        return true;
    }

    public bool Hide(long dicussionId, long userId)
    {
        var hide = new DiscussionHiddenModel()
        {
            DiscussionId = dicussionId,
            UserId = userId,
        };
        _context.DiscussionHides.Add(hide);
        _context.SaveChanges();
        return true;
    }

    public long? GetDaily()
    {
        return _context.DailyDiscussion
            .Where(x => x.StartDate < DateTime.Now)
            .OrderByDescending(x => x.StartDate)
            .FirstOrDefault()?
            .DiscussionId;
    }

    public List<long> GetFutures()
    {
        return _context.DailyDiscussion
            .Where(x => x.StartDate > DateTime.Now.AddDays(-1))
            .Select(x => x.DiscussionId)
            .ToList();
    }

    public List<DiscussionModel> GetAllDiscussion()
    {
        var disFinal = new List<DiscussionModel>();
        var comIds = new List<int>();
        var discussionList = _context.Discussions.ToList();

        foreach (var discussion in discussionList)
        {
            var comCount = _context.Comments.Where(x => x.DiscussionId == discussion.Id).Count();
            var disVoteCount = _context.DiscussionVotes.Where(x => x.DiscussionId == discussion.Id).Count();
            var currentVote = IsCurrentVote(discussion.Id, discussion.UserId);
            disFinal.Add(new DiscussionModel
            {
                Id = discussion.Id,
                Content = discussion.Content,
                UserId = discussion.UserId,
                User = discussion.User,
                CommentsCount = comCount,
                DiscussionVoteCount = disVoteCount,
                CurrentDiscussionVote = currentVote

            });
        }
        return disFinal;
    }
    public List<DiscussionModel>? GetItemDiscussion(long discussionId)
    {
        var discussionItem = new List<DiscussionModel>();
        var discussionList = GetAllDiscussion();
        var item = discussionList.Where(x => x.Id == discussionId).FirstOrDefault();
        if (item != null)
        {
            discussionItem.Add(item);
        }
        return discussionItem;
    }
    //public List<AccountModel>? GetUser(long discussionId)
    //{
    //    var discussionList = GetAllDiscussion();

    //}

    public bool IsCurrentVote(long discussionId, long userId)
    {
        var vote = _context.DiscussionVotes.Where(x => x.DiscussionId == discussionId && x.UserId == userId).FirstOrDefault();
        if(vote == null)
        {
            return false;
        }
        return true;
    }
}
