using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC1.Data;
using SalesWebMVC1.Models;

namespace SalesWebMVC1.Servicos
{
    public class SellerService
    {
        private readonly SalesWebMVC1Context _context;

        public SellerService(SalesWebMVC1Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
