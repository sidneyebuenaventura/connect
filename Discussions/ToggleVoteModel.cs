using EfVueMantle;
using System.ComponentModel.DataAnnotations.Schema;

namespace DidacticVerse.Models;

public class ToggleVoteModel
{
    public bool Status { get; set; }
    public int VoteCount { get; set; }
}