using Microsoft.EntityFrameworkCore;
using PortfolioAPI.Models;

namespace PortfolioAPI.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _dbContext;

        public DataInitializer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void MigrateData()
        {
            _dbContext.Database.Migrate();
            SeedData();
            _dbContext.SaveChanges();
        }

        private void SeedData()
        {
           // throw new NotImplementedException();
           if (!_dbContext.AllprojectsapiDBSet
           .Any(e => e.projectID == 1))
           {
               _dbContext.Add(new AllProjects()
               {
                   name = "Bank App",
                   description = "https://karambank.azurewebsites.net/",
                   datetimenow = DateTime.Now
               });
           }
           
           if (!_dbContext.AllprojectsapiDBSet
                   .Any(e => e.projectID == 2))
           {
               _dbContext.Add(new AllProjects()
               {
                   name = "Annonse API",
                   description = "https://annonseapi.azurewebsites.net/api/AnnonsAPI",
                   datetimenow = DateTime.Now
               });
           }
           if (!_dbContext.AllprojectsapiDBSet
                   .Any(e => e.projectID == 3))
           {
               _dbContext.Add(new AllProjects()
               {
                   name = "Fixxo Site",
                   description = "https://github.com/KARAMLM10/kyh-fontend-git/tree/master/Fixxo/Fixxo.Webbsite",
                   datetimenow = DateTime.Now
               });
           }

        }
    }

}
