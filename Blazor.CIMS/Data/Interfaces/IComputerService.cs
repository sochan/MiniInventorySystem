using System;
using System.Collections.Generic;
using Blazor.CIMS.ViewModel;

namespace Blazor.CIMS.Data
{
    public interface IComputerService
    {
        Computer Create(Computer obj);

        string Delete(Computer obj);

        IEnumerable<Computer> GetAll();

        Computer GetById(Guid id);

        PaginatedItemsViewModel<Computer> GetDataPaginated(int pageSize = 10, int pageIndex = 0);

        void Update(Computer obj);
    }
}
