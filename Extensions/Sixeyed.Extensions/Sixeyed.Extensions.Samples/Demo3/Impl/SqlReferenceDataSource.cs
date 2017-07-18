using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Samples.Demo3.Impl
{
    public abstract class SqlDataSource
    {
        public string Name = "Sql";
    }
    public class SqlReferenceDataSource : SqlDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem
                {
                    Code="xyz",
                    Description="from API"
                },
                new ReferenceDataItem
                {
                    Code = "xyz",
                    Description = "from API 2"
                }
            };
        }
    }
}
