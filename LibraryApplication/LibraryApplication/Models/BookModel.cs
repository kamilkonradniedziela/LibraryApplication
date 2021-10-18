using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    [Table("Books")]
    public class BookModel
    {
        [Key]
        [DisplayName("ID")]
        public int bookID { get; set; }

        [DisplayName("Nazwa")]
        [Required(ErrorMessage = "Pole nazwa jest wymagane!")]
        [MaxLength(50)]
        public string name { get; set; }

        [DisplayName("Autor")]
        [Required(ErrorMessage = "Pole autor jest wymagane!")]
        [MaxLength(50)]
        public string author { get; set; }

        [DisplayName("Data publikacji")]
        [Required(ErrorMessage = "Pole data publikacji jest wymagane!")]
        public DateTime dateOfPublication { get; set; }

        [DisplayName("Opis")]
        [MaxLength(2000)]
        public string description { get; set; }
    }
}
