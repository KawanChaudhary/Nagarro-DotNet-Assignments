using System.Collections.Generic;

namespace DomainLayer.Models
{
    public class EventViewModel
    {
        public BookEventModel EventDetails { get; set; }

        public CommentModel Comment { get; set; }

        public EditEventModel EditEventDetails { get; set; }

        public List<CommentModel> AllComments { get; set; }

    }
}
