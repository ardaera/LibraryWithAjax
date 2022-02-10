using System.Collections.Generic;

namespace ArdalanAraghi_HW_14000405_1_2.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Family { get; set; }
        public List<Book> Books { get; set; }
    }
}