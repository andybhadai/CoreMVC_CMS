using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoBergCMS.Models;

namespace TechnoBergCMS.Services
{
    public class InMemoryBlogRepository : IBlogRepository
    {
        private List<Blog> _blogs = new List<Blog>
        {
        }

        public IEnumerable<Blog> GetAllBLogs()
        {
            throw new NotImplementedException();
        }
    }
}
