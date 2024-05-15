namespace APIContato.Models
{
    public class SendMailModel
    {
        public string[] Emails { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }

    }
}
