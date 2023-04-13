using Chatty.Api.Models;

namespace Chatty.Api.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
