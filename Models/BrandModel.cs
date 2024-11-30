namespace mauiProject.Models
{
    public class BrandModel
    {
        public BrandModel()
        {}
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool active { get; set; }
        public DateTime creationDate { get; set; }
    }
}