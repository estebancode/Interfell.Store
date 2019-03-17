
#region Usings

using Interfell.Store.Module.Commons.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion
namespace Interfell.Store.Module.Commons.Utilities
{
    public static class Extensions
    {

        public static ResponseDTO<T> AsResponseDTO<T>(this T resultDTO, Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode code, string message = "",int totalResult=0)
        {
            var responseDTO = new ResponseDTO<T>();
            responseDTO.Data = resultDTO;
            responseDTO.total_elements = totalResult;
            responseDTO.Header = new HeaderDTO() { ResponseCode = code, Message = message };

            return responseDTO;
        }

        public static ResponseDTO<object> ResponseDTO(Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode code, string message = "")
        {
            var responseDTO = new ResponseDTO<object>();
            responseDTO.Header = new HeaderDTO() { ResponseCode = code, Message = message };

            return responseDTO;
        }

    }
}
