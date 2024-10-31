using System.ComponentModel.DataAnnotations;

namespace Nertan_Oana_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Full Name")] 
        public string FullName 
        { get 
            { return Name; 
            } 
        }

        public ICollection<Book>? Books { get; set; }

    }
}
