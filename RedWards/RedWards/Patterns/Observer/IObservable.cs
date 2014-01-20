using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWards.Patterns.Observer
{
    /// <summary>
    /// Simpler version of of the .NET Framework's IObservable<T> interface, in the System namespace.  This allows objects to oba without needing to pass an IDisposable object, and without needing to specify the type being observed.  
    /// </summary>
    public interface IObservable
    {

        /// <summary>
        /// Attach an IObserver to this object, that will be notified whenever the notify() method is called.
        /// </summary>
        /// <param name="obs">The IObserver to be added.</param>
        /// <returns>true if the attach was successful, false if not.</returns>
        bool attach(IObserver obs);
        
        /// <summary>
        /// Removes a given IObserver from this object's list of observers, if present.  It will stop receiving notifications from this object.
        /// </summary>
        /// <param name="obs">The IObserver object to be removed.</param>
        /// <returns>true if the detach was successful, false if not.</returns>
        bool detach(IObserver obs);
        
        /// <summary>
        /// This method will notify all observers that a change has taken place in this object, and to update their respective states.
        /// </summary>
        void notify(); //should call the update() method of all observers

    }
}
