using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    public class Patron
    {
        [Key]
        public int PatronId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        [NotMapped]
        public string FullName { get { return $"{LastName}, {FirstName}"; } }
    }
}
