using System;

namespace DomainLayer.Data
{
    public class CommentEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserId{ get; set; }
        public int EventId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
