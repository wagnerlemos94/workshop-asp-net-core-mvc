using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using SalesWebMvc.Services.Excepitons;

namespace SalesWebMvc.Controllers.Services
    {
    public class SellerService
        {

        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
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

        public Seller FindById(int id)
            {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
            }

        public void remove(int id)
            {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
            }

        public void Update(Seller obj)
            {
            if (!_context.Seller.Any(X500DistinguishedName => X500DistinguishedName.Id == obj.Id))
                {
                throw new NotFoundException("Id not found");
                }
            try
                {
                _context.Update(obj);
                _context.SaveChanges();
                }
            catch(DbConcurrencyException e)
                {
                throw new DbConcurrencyException(e.Message);
                }
            }

        }
    }
