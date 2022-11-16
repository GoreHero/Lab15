using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class ArithProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;
        public int GetNext()
        {
            currentValue+=step;
            return currentValue;
        }

        public int Reset()
        {
            currentValue = startValue;
            return currentValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
