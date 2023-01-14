using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ExtraLine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Extra Extra { get; set; }
        [NotMapped]
        public string ExtraName { get; set; }
        public int ExtraId { get; set; }
        public int SnackLineId { get; set; }
    }
}
