using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class StandardCatalog : ISaveable, IPersistable
    {
        public void Load()
        {

        }

        public String Save()
        {
            return "Catalog Save";
        }

        public class ExplicitCatalog : ISaveable, IPersistable
        {
            public String Save()
            {
                return "Catalog Save";
            }

            string ISaveable.Save()
            {
                return "ISaveable Save";
            }

            string IPersistable.Save()
            {
                return "IPersistable Save";
            }
        }

        public class Catalog : ISaveable, IVoidSaveable
        {
            public string Save()
            {
                throw new NotImplementedException();
            }

            void IVoidSaveable.Save()
            {
                throw new NotImplementedException();
            }
        }

        public class EnumerableCatalog : IEnumerable<string>
        {
            public IEnumerator<string> GetEnumerator()
            {
                // All our code
                return null; 
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }
    }
}
