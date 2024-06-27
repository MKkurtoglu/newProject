namespace newProject.Models
{
    public class ContactModel
    {
        //report controller'da kullanılması için oluşturuldu
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string ContactMail { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactDate { get; set; }
    }
}
