using Bogus.DataSets;
using DidacticVerse.Accounts;
using DidacticVerse.Models;
using EfVueMantle;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;

namespace DidacticVerse.Services;

public class CommentService : ServiceBase<CommentModel>
{
    private readonly DidacticVerseContext _context;
    private readonly DbSet<CommentModel> _comments;
    private readonly AccountProvider _accountProvider;
    private readonly AccountService _accountService;

    public CommentService(DidacticVerseContext context, AccountProvider accountProvider, AccountService accountService) : base(context.Comments, context)
    {
        _context = context;
        _comments = context.Comments;
        _accountProvider = accountProvider;
        _accountService = accountService;
    }

    public override CommentModel Save(CommentModel data)
    {
        data.UserId = _accountProvider.GetAccountId();
        return base.Save(data);
    }

    public bool Report(ReportDTO reportDTO, long userId)
    {
        if (reportDTO == null) return false; //TODO or error out?
        var commentReport = new CommentReportModel()
        {
            CommentId = reportDTO.Id,
            ReportingUserId = userId,
            ReportReason = reportDTO.ReportReason
        };
        _context.CommentReports.Add(commentReport);
        _context.SaveChanges();
        return true;
    }

    public bool Hide(long commentId, long userId)
    {
        var hide = new CommentHiddenModel()
        {
            CommentId = commentId,
            UserId = userId,
        };
        _context.CommentHides.Add(hide);
        _context.SaveChanges();
        return true;
    }

    //public CommentModel SaveComment(CommentModel comment)
    //{
    //    comment.UserId = _accountProvider.GetAccountId();

    //}
    //public List<CommentModel>? SaveComment(CommentModel data)
    //{
    //    var comments = new List<CommentModel>();
    //    data.UserId = _accountProvider.GetAccountId();
    //    comments.Add(new CommentModel()
    //    {
    //        Id = data.Id,
    //        Content = data.Content,
    //        DiscussionId = data.DiscussionId,
    //        ParentCommentId = data.ParentCommentId,
    //        UserId = data.UserId,
    //        User = data.User,
    //        ChildCommentsIds = data.ChildCommentsIds,
    //        ChildComments = data.ChildComments
    //    });
    //    _context.Add(comments);
    //    _context.SaveChanges();

    //    return comments;

    //}

    public List<CommentModel>? GetAllComment(int discussionId)
    {
        var newComment = new List<CommentModel>();
        var commentList = _comments.Where(x => x.DiscussionId == discussionId).ToList();

        foreach (var comment in commentList)
        {
            if(comment.ParentCommentId == null)
            {
                var user = _context.Accounts.Where(x => x.Id == comment.UserId).FirstOrDefault();
                newComment.Add(new CommentModel
                {
                    Id = comment.Id,
                    Content = comment.Content,
                    DiscussionId = comment.DiscussionId,
                    ParentCommentId = comment.ParentCommentId,
                    UserId = comment.UserId,
                    User = user,
                    ChildCommentsIds = comment.ChildCommentsIds,
                    ChildComments = comment.ChildComments
                });
            }  
        }
        return newComment;

    }

}
