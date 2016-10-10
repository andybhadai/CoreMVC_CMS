using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
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

        public Blog Find(int id)
        {
            Blog blog;
            blog = this.DbContext.Blogs.SingleOrDefault(b => b.Id == id);
            return blog;
        }

        public IEnumerable<Blog> GetAllBlogs()
        {
            return this.DbContext.Blogs;
        }

        public void Update(Blog blog)
        {
            this.DbContext.Update(blog);
            this.DbContext.SaveChanges();
        }
    }
}
