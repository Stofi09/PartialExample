using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PartialExample.Models;

namespace PartialExample.Pages
{
    public class InvoicesModel : PageModel
    {
        public int InvoiceId { get; set; }
        private readonly MessageService _messageService;
        public MessageBox MessageBox { get; set; }
        public InvoicesModel(MessageService messageService)
        {
            _messageService = messageService;
        }
        public void OnGet(int id)
        {
            InvoiceId = id;
            MessageBox = new MessageBox
            {
                Group = "invoice",
                Id = id,
                Messages = _messageService.GetMessages("invoice", id)
            };
            // Other initialization logic here
        }
    }
}
