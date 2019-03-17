
#region Usings

using Interfell.Store.Module.Commons.Enums.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace Interfell.Store.Module.Commons.DTO
{
    public class HeaderDTO
    {
        public ResponseCode ResponseCode { get; set; }

        public string Message { get; set; }

        public bool Success
        {
            get
            {
                var code = (int)this.ResponseCode;

                if (code >= 200 && code < 300)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
