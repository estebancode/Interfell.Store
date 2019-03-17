
#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace Interfell.Store.Module.Commons.DTO
{
    public class ResponseDTO<TData>
    {
        private HeaderDTO _header;
        public HeaderDTO Header
        {
            get
            {
                if (_header == null)
                {
                    _header = new HeaderDTO();
                }

                return _header;
            }
            set
            {
                _header = value;
            }
        }

        public TData Data { get; set; }

        public int total_elements { get; set; }
    }
}
