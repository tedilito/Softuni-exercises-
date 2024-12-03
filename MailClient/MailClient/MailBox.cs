using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>(Capacity);
            Archive = new List<Mail>();

        }

        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }


        public bool DeleteMail(string sender)
        {
            return Inbox.Remove(Inbox.FirstOrDefault(x => x.Sender == sender));
        }

        public int ArchiveInboxMessages()
        {
            int count = 0; 
            foreach (Mail mail in Inbox)
            {
                Archive.Add(mail);
                count++;
               
            }
            Inbox.Clear();
            return count;
        }

        public string GetLongestMessage()
        {
            return Inbox.OrderByDescending(x => x.Body.Length).FirstOrDefault().ToString();
        }

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:"); 
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}
