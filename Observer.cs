using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadLib
{
    public abstract class Observer
    {
        public abstract void Notify(string message);
    }
}
