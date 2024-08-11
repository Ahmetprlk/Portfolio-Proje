using System.ComponentModel.DataAnnotations;

namespace PortfolioProjectAPP.DAL.Entities
{
    public class Admin
    {
        [Key]
        public int USerID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
