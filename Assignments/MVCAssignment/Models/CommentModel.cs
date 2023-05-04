using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssignment.Models
{
    public class CommentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public int EventId { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
