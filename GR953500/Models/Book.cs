using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GR953500.Models
{
    public class Book
    {        
        [Key]
        public int BookId { get; set; }
        [Required(ErrorMessage ="Введите название книги")]
        [Display(Name ="Название книги")]
        public string Name { get; set; }  
        [Required]
        public string Author { get; set; }
    }
}
