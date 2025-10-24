using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Voter
    {
        [UserVotes(AgeProperty ="Age",AllowVoteProperty = "AllowVote")]
        public int? Age { get; set; }
        
        public string? AllowVote { get; set; }

             

    }

   
}
