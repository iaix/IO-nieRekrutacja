using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UnitOfWork
    {
        private DataClassesDataContext _dataClassesDataContext;
        private ItemRepository _itemRepository;
        private ElementRepository _elementRepository;

        public UnitOfWork(DataClassesDataContext dataClassesDataContext)
        {
            _dataClassesDataContext = dataClassesDataContext;
        }

        public ItemRepository ItemRepository
        {
            get
            {
                if (_itemRepository == null)
                {
                    _itemRepository = new ItemRepository(_dataClassesDataContext);
                }
                return _itemRepository;
            }
        }

        public ElementRepository ElementRepository
        {
            get
            {
                if(_elementRepository==null)
                {
                    _elementRepository = new ElementRepository(_dataClassesDataContext);
                }
                return _elementRepository;
            }
        }


        public void Save()
        {
            System.Data.Common.DbTransaction transaction = null;
            _dataClassesDataContext.Connection.Open();
            transaction = _dataClassesDataContext.Connection.BeginTransaction();
            _dataClassesDataContext.Transaction = transaction;
            
            try
            {
                _dataClassesDataContext.SubmitChanges();

                
            transaction.Commit();
            }
            catch(Exception)
            {
                if (transaction != null)
                    transaction.Rollback();
            }
        }
    }
}
