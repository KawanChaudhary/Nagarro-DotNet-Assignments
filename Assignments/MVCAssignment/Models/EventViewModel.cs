using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssignment.Models
{
    public class EventViewModel
    {
        public BookEventModel EventDetails { get; set; }

        public CommentModel Comment { get; set; }

        public EditEventModel EditEventDetails { get; set; }
    }
}
