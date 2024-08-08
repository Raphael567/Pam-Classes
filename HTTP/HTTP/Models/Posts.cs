using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP.Models
{
    public class Posts
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }

    }
}
