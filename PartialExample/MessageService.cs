using PartialExample.Models;

namespace PartialExample
{
    public class MessageService
    {
        public List<Message> GetMessages(string group, int id)
        {
            // Mock data for demonstration purposes
            return new List<Message>
            {
                new Message { User = "User1", Text = "This is a message", Timestamp = DateTime.Now.AddMinutes(-10) },
                new Message { User = "User2", Text = "This is another message", Timestamp = DateTime.Now.AddMinutes(-5) },
                new Message { User = "User3", Text = "Yet another message", Timestamp = DateTime.Now.AddMinutes(-1) }
            };
        }
    }
}
