using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using KwikKwekSnack_ClassLibary;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KwikKwekSnack_ClassLibary
{
    public class Snack
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal StartPrice { get; set; }
        


    }
}
