using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;


namespace Services
{
    public interface IElementService : IRepository<Element> { }
    class ElementService : IElementService
    {
        private readonly ElementRepository elementRepository;

        public ElementService(ElementRepository elementRepository)
        {
            this.elementRepository = elementRepository;
        }
        public void Add(Element item)
        {
            elementRepository.Add(item);
        }

        public Element GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Element item)
        {
            elementRepository.Remove(item);
        }

        public void Update(Element item)
        {
            elementRepository.Update(item);
        }
    }
}
