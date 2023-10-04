using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveParrern.Models
{
    internal interface Isubject
    {
        void Register(IAgencys agency);

        void Notify();
    }
}
