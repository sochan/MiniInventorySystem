using System;
using System.Collections.Generic;

namespace Blazor.CIMS.ViewModel
{
    public class PaginatedItemsViewModel<T> where T : class
    {
        public int ActualPage { get; private set; }

        public int ItemsPerPage { get; private set; }

        public long TotalItems { get; private set; }

        public int TotalPages { get; set; }

        public IEnumerable<T> Data { get; private set; }

        public PaginatedItemsViewModel(int pageIndex, int pageSize, long count, IEnumerable<T> data)
        {
            ActualPage = pageIndex;
            ItemsPerPage = pageSize;
            TotalItems = count;
            TotalPages = (int)Math.Ceiling(((decimal)count / pageSize));
            Data = data;
        }
    }
}
