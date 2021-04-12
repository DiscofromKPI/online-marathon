using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Disposing by developer");
                    Close();
                }
                else
                {
                    Console.WriteLine("Disposing by GC");
                    Close();
                }
                disposed = true;
            }
        }
        ~DisposePatternImplementer()
        {
            Dispose(false);
        }
    }
    public abstract class CloseableResource
    {
        public void Close()
        {

        }
    }
}
