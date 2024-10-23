namespace Nertan_Oana_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
