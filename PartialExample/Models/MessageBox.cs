namespace PartialExample.Models
{
    public class MessageBox
    {
        public string Group { get; set; }
        public int Id { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
