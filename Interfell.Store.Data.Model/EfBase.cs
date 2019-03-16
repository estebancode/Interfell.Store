
#region MyRegion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfell.Store.Data.Entities.Database;

#endregion

namespace Interfell.Store.Data.Model
{
    public class EfBase
    {

        protected readonly InterfellStoreContext _context;

        public EfBase()
        {
            _context = new InterfellStoreContext();
            _context.Configuration.ProxyCreationEnabled = false;

#if DEBUG
            _context.Database.Log = WriteEFLog;
#endif 
        }

#if DEBUG
        private void WriteEFLog(string logMessage)
        {
            System.Diagnostics.Debug.WriteLine(logMessage, "EF Log");
        }
#endif

    }
}
