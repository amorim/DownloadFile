using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadLib
{
    public class DownloadSubject
    {
        private List<Observer> observers = new List<Observer>();
        
        public void Next(string message)
        {
            Notify(message);
        }

        public void Attach(Observer o)
        {
            observers.Add(o);
        }
        
        void Notify(string message)
        {
            observers.ForEach(o => o.Notify(message));
        }

    }
}
