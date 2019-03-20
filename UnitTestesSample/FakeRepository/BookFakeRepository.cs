using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestesSample.Domain.Contracts;

namespace UnitTestesSample.FakeRepository
{
    public class BookFakeRepository : IBookRepository
    {
        public List<DateTime> GetByDate(DateTime startDate, DateTime endDate)
        {
            List<DateTime> result = new List<DateTime>();
            result.Add(startDate);
            return result;
        }
    }
}
