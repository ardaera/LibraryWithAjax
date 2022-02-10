using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_HW_14000405_1_2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Publish { get; set; }
        public int Price { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
