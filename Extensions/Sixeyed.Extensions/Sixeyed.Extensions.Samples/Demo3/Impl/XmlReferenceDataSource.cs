using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Samples.Demo3.Impl
{
    public abstract class XmlDataSource
    {
        public string Name = "Xml";
    }
    public class XmlReferenceDataSource : XmlDataSource, IReferenceDataSource
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
