using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class GenericPagination
    {
        public static IQueryable<T> Page<T>(this IQueryable<T> query, int pageNumber, int pageSize)
        {
            if (pageSize == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize), " pagesize cannot be zero");
            }

            if (pageNumber != 0)
            {
                query = query.Skip((pageNumber - 1) * pageSize);
            }
            return query.Take(pageSize);
        }
    }
}
