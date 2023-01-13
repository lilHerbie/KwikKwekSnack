using ClassLibrary;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class ViewModel
    {
        public string PartialView { get; set; }
        public int SnackId { get; set; }
        public string SnackName { get; set; }
        public string SnackUrl { get; set; }
        public List<int> ExtraIds { get; set; }
        public List<SnackLine> SnackLines { get; set; }
        public List<DrinkLine> DrinkLines { get; set; }
        public SnackLine CurrentSnackLine { get; set; }

        public ViewModel()
        {
            SnackLines = new();
            DrinkLines = new();
            ExtraIds = new();
        }
        
    }
}
