using System.ComponentModel.DataAnnotations;

namespace PortfolioProjectAPP.DAL.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutName { get; set; }
        public string AboutDescription { get; set; }
    }
}
