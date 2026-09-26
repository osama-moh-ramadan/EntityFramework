using System.Security.Principal;

namespace EntityFramework;

public class Wallet
{
    public int Id { get; set; }
    public decimal? Balance { get; set; }
    public string? Holder { get; set; }
    public override string ToString()
    {
        return $"[{Id}] {Holder} ({Balance})"; 
    }
}