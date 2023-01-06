using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikKwekSnack_ClassLibary
{
    public class Extra
    {
        [Key()]
        public int Id { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int SnackLineId { get; set; }
        public SnackLine SnackLine { get; set; }

        public Extra(){
            
        }
    }

}
