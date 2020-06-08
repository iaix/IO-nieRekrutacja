using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ElementRepository : IRepository<Element>
    {
        private readonly DataClassesDataContext dataClassesDataContext;

        public ElementRepository(DataClassesDataContext dataClassesDataContext)
        {
            this.dataClassesDataContext = dataClassesDataContext;
        }
        public void Add(Element element)
        {
            dataClassesDataContext.Elements.InsertOnSubmit(element);
        }

        public Element GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Element element)
        {
            dataClassesDataContext.Elements.DeleteOnSubmit(element);
        }

        public void Update(Element element)
        {
            dataClassesDataContext.SubmitChanges();
        }
    }
}
