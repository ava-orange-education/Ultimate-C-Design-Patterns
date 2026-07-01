using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8._04_Examples_Iterator.Paging_ASP
{
    class SearchResults
    {
        private readonly List<string> _entries;

        public SearchResults()
        {
            _entries = Enumerable.Range(1, 100)
                .Select(i => $"Result #{i}")
                .ToList();
        }

        public IEnumerable<string> GetPage(int pageSize, int pageNumber)
        {
            return _entries
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }
    }
}
