using Microsoft.AspNetCore.Identity;

namespace ChatHub.Shared.Lib;

public class ApplicationUser : IdentityUser
{
    public virtual ICollection<ChatMessage> ChatMessagesFromUsers { get; set; }
    public virtual ICollection<ChatMessage> ChatMessagesToUsers { get; set; }
    public ApplicationUser()
    {
        ChatMessagesFromUsers = new HashSet<ChatMessage>();
        ChatMessagesToUsers = new HashSet<ChatMessage>();
    }

}
