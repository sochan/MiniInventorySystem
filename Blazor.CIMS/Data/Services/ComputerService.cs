using System;
using System.Collections.Generic;
using System.Linq;
using Blazor.CIMS.Helpers;
using Blazor.CIMS.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Blazor.CIMS.Data
{
    public class ComputerService : IComputerService
    {
        private readonly MyDbContext _context;
        public ComputerService(MyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Computer> GetAll()
        {
            //To avoid not fetching from Cache memeory
            var empList = _context.Computers.AsNoTracking();
            return empList;
        }
       
        public Computer Create(Computer obj)
        {
            _context.Computers.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Computer GetById(Guid id)
        {
            return _context.Computers.Find(id);
        }
        public void Update(Computer obj)
        {
            var obj_ = _context.Computers.Find(obj.Id);

            if (obj_ == null)
                throw new AppException("Object not found");

            _context.Computers.Update(obj);
            _context.SaveChanges();
        }
        public string Delete(Computer obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
            return "Data has been deleted";
        }

        //For Custom Pagination
        public PaginatedItemsViewModel<Computer> GetDataPaginated(int pageSize = 10, int pageIndex = 0)
        {
            var list = _context.Computers
                //.Include(e=>e.WorkRight.Vevo)
                .Where(e => e.IsDeleted == false && e.IsActive == true)
                .AsNoTracking().ToList();

            var itemsOnPage = list
                .OrderBy(c => c.Id)
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToList();

            return new PaginatedItemsViewModel<Computer>(
                pageIndex, pageSize, list.Count, itemsOnPage);
        }
    }
}
