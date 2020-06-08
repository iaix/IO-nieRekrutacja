using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IItemLogic
    {

        void UpdateLastItem();
        void AddNewItem();
        void DeleteLastItem();
    }
}
