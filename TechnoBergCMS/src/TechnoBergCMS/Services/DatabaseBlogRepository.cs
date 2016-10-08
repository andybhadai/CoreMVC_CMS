using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoBergCMS.Data;
using TechnoBergCMS.Models;

namespace TechnoBergCMS.Services
{
    public class DatabaseBlogRepository : IBlogRepository
    {
        private readonly ApplicationDbContext DbContext;

        public DatabaseBlogRepository(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public void AddBlog(Blog blog)
        {
            this.DbContext.Add(blog);
            this.DbContext.SaveChanges();
        }

        public IEnumerable<Blog> GetAllBlogs()
        {
            return this.DbContext.Blogs;
        }
    }
}
