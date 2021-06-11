using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Website.Models
{
    public class Paginated_List<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; set; }
        public Paginated_List(List<T> items,int count,int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);

        }
        public bool previousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }
        public bool nextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }
        public static async Task<Paginated_List<T>> CreateAsync(IQueryable<T> source,int pageIndex,int pageSize)
        {
            var count = await source.CountAsync();
            var items= await source.Skip((pageIndex - 1)* pageSize).Take(pageSize).ToListAsync();
            return new Paginated_List<T>(items, count, pageIndex, pageSize);
        }
    }
}
