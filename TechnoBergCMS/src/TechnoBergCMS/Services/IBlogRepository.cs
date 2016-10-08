using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoBergCMS.Models;

namespace TechnoBergCMS.Services
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetAllBLogs();
    }
}
