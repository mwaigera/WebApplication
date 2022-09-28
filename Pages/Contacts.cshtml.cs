using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class ContactsModel : PageModel
    {
        //variables containing data for the various fields
        public bool hasData=false;
        public string firstname = "";
        public string lastname = "";
        public string message = ""; 
        public void OnGet()
        {
        }
        public void OnPost()
        {
            // initializing the variables on onPost()methode
            hasData = true;
            firstname = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            message = Request.Form["Message"];
        }
    }
}
