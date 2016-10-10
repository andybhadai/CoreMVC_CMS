using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoBergCMS.Models;

namespace TechnoBergCMS.Services
{
    public class InMemoryBlogRepository : IBlogRepository
    {
        private List<Blog> Blogs = new List<Blog>
        {
            new Blog {Id = 1, Title = "Sample blog 1", Text = "A blog with some text", Author = "Andy Bhadai", DateTime = "000000" },
            new Blog {Id = 2, Title = "Sample blog 2", Text = "A blog with, again, some text", Author = "Andy Bhadai", DateTime = ""},
            new Blog {Id = 3, Title = "Sample blog 3", Text = "A blog with some extra text, which you have never seen before", Author = "Andy Bhadai", DateTime = ""},
            new Blog {Id = 4, Title = "Sample blog 4", Text = "A blog with not much text", Author = "Andy Bhadai", DateTime = "" }
        };

        public void AddBlog(Blog blog)
        {
            blog.Id = this.Blogs.Max(b => b.Id) + 1;
            this.Blogs.Add(blog);
        }

        public Blog Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Blog> GetAllBlogs()
        {
            return this.Blogs;
        }

        public Blog Update(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        void IBlogRepository.Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
