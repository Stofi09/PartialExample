using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PartialExample.Pages
{
    public class InvoicesModel : PageModel
    {
        public int InvoiceId { get; set; }

        public void OnGet(int id)
        {
            InvoiceId = id;
            // Other initialization logic here
        }
    }
}
