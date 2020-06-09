using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ItemRepository : IRepository<Item>
    {
        UnitOfWork _unitOfWork;

        private readonly DataClassesDataContext dataContext;
        public ItemRepository(DataClassesDataContext dataClassesDataContext)
        {
            dataContext = dataClassesDataContext;
            _unitOfWork = new UnitOfWork(dataContext);
        }
        public void Add(Item item)
        {
            dataContext.Items.InsertOnSubmit(item);
            _unitOfWork.Save();
        }

        public void Remove(Item item)
        {
            dataContext.Items.DeleteOnSubmit(item);
            _unitOfWork.Save();
        }

        public void Update(Item item)
        {
            _unitOfWork.Save();
        }

        public int GetLastId()
        {
            var query = (from q in
                dataContext.Items
                select q.Id).Max();
            return query;
        }

        public Item GetById(int id)
        {
            return dataContext.Items.FirstOrDefault(d=>d.Id == id);
        }

        public bool CheckExistingOfId(int? id)
        {
            return dataContext.Items.Any(d => d.Id == id);
        }
    }
}
