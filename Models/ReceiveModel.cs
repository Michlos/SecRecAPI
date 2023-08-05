namespace SecRecAPI.Models
{
    public class ReceiveModel
    {
        public int Id { get; set; }
        public int MailId { get; set; }
        public DateTime ReceiveDate { get; set; } = DateTime.Now;
    }
}
