namespace newProject.Models
{
    public class NewsModel
    {
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime NewsDate { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
