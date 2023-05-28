using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.Models
{
    public class AllProjects
    {
        [Key]
        public int projectID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime datetimenow { get; set; }
    }
}
