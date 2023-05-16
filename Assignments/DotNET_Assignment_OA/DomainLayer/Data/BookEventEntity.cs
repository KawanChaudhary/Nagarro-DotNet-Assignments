using DomainLayer.OtherFiles;
using System;

namespace DomainLayer.Data
{
    public class BookEventEntity
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }

        public string Location { get; set; }

        public EventType Type { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }
        public string OtherDetails { get; set; }

        public string InviteByEmail { get; set; }
        public int Count { get; set; }

        public string CreatedBy { get; set; }

        public string CommentAdded { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
