using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TweetCool.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public static Dictionary<string, List<Message>> Comments = new Dictionary<string, List<Message>>();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost(
            [FromForm(Name = "username")]string username,
            [FromForm(Name = "message")] string message)
        {
            List<Message> comments;
            if (Comments.ContainsKey(username))
            {
                comments = Comments[username];
            }
            else
            {
                comments = new List<Message>();
                Comments[username] = comments;
            }
            comments.Add(new Message(username, message));


            Response.Redirect("/Succes");

        }
    }
}
