using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    /*
метод void SetStart(int x) - устанавливает начальное значение
метод int GetNext() - возвращает следующее число ряда
метод void Reset() - выполняет сброс к начальному значению
     */
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        int Reset();
    }

}
