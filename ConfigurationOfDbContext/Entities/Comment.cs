using System.ComponentModel.DataAnnotations.Schema;

namespace ConfigrationByConvention.Entities;
[Table("tblComments")]
public class Comment
{
    public int CommentId { get; set; }
    public int TweetId { get; set; }
    public int UserId { get; set; }
    public string CommentText { get; set; }
    public DateTime CreatedAt { get; set; }
}