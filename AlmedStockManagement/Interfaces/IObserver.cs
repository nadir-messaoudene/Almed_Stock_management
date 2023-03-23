using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmedStockManagement
{
    public interface IObserver
    {
        void Update(bool ctr);
    }
}
