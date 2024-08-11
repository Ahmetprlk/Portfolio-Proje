using System.ComponentModel.DataAnnotations;

namespace PortfolioProjectAPP.DAL.Entities
{
    public class Works
    {
        [Key]
        public int WorkId { get; set; }
        public string WorkName { get; set; }
        public string WorkDescription { get; set; }

    }
}
