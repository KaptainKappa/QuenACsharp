using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedWards.Patterns.Observer
{
    /// <summary>
    /// Weaker version of of the .NET Framework's IObserver<T> interface, in the System namespace.  This allows objects to observe objects implementing IObservable without needing to be passed an IDisposable object, and without needing to specify the type being observed.  
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// This method should update this object's state in response to a change in the object being observed.
        /// </summary>
        void update();
    }
}
