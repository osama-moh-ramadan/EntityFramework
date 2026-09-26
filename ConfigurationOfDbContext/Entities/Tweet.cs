using System.ComponentModel.DataAnnotations.Schema;

namespace ConfigrationByConvention.Entities;
[Table("tblTweets")]
public class Tweet
{
    public int TweetId { get; set; }
    public int UserId { get; set; }
    [Column("TweetText")]
    public string TweetText { get; set; }
    public DateTime CreatedAt { get; set; }
}