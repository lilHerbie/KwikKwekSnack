using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SnackLine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Snack Snack { get; set; }
        [ForeignKey("Snack")]
        public int SnackId { get; set; }
        public string SnackName { get; set; }
        public List<ExtraLine> ExtraLines { get; set; }

        public SnackLine()
        {
            ExtraLines = new List<ExtraLine>();

        }
        
    }
}
