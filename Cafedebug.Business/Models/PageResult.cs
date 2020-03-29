using System.Collections.Generic;

namespace Cafedebug.Business.Models
{
    public class PageResult<T>
    {
        public IList<T> Items {get;set;}

        public int ItemsPerPage {get;set;}

        public int TotalPages {get;set;}

        public int TotalItems {get; set;}

        public PageResult()
        {}

        public PageResult(int itemsPerPage, int totalItems, IList<T> items) 
        { 
            ItemsPerPage = itemsPerPage;
            TotalItems = totalItems;
            if (ItemsPerPage > 0)
            {
                TotalPages = ((totalItems % itemsPerPage == 0) ? (totalItems / itemsPerPage) : (totalItems / itemsPerPage + 1));
            }
            Items = items;
        }
    }
}