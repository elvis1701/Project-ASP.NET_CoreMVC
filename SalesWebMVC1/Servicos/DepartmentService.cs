using SalesWebMVC1.Data;
using SalesWebMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC1.Servicos
{
    public class DepartmentService
    {
        private readonly SalesWebMVC1Context _context;

        public DepartmentService(SalesWebMVC1Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
