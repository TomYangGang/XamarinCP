using SQLite;

namespace XamarinCP.Model
{
    public class Company
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
    }
    
}