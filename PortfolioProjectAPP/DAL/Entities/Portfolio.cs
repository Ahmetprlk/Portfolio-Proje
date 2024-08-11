using System.ComponentModel.DataAnnotations;

namespace PortfolioProjectAPP.DAL.Entities
{
    public class Portfolio
    {
        [Key]
        public int  PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string  PortfolioDescription { get; set; }
    }
}
