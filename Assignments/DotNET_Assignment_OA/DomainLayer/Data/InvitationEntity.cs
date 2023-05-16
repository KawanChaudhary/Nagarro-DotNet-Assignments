namespace DomainLayer.Data
{
    public class InvitationEntity
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public int EventId { get; set; }
    }
}
