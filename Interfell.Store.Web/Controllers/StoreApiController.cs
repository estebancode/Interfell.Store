
#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Interfell.Store.Data.Business.Interfaces;
using Interfell.Store.Data.Business.Implementation;
using Interfell.Store.Module.Commons.DTO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Interfell.Store.Module.Commons.Utilities;
using Interfell.Store.Module.Commons.Enums;

#endregion

namespace Interfell.Store.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("Services/Stores/")]
    public class StoreApiController : ApiController
    {
        private IStoreBusiness storeBusiness { get { return new StoreBusiness(); } }

        /// <summary>
        ///  create store
        /// </summary>
        /// <param name="storeDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseDTO<StoreDTO>> Post([FromBody]StoreDTO storeDTO)
        {
            var response = await storeBusiness.CreateAsync(storeDTO);

            if (response.SuccessfulOperation)
            {
                return response.Result.AsResponseDTO(Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.OK);
            }
            else
            {
                return Extensions.AsResponseDTO<StoreDTO>(null,Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.ERROR,response.Message);
            }
        }

        /// <summary>
        /// Edit store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Services/Stores/{id}")]
        public async Task<ResponseDTO<bool>> Put(int id,[FromBody]StoreDTO storeDTO)
        {
            var response = await storeBusiness.EditAsync(storeDTO);

            if (response.SuccessfulOperation)
            {
                return response.Result.AsResponseDTO(Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.OK);
            }
            else
            {
                return Extensions.AsResponseDTO<bool>(false, Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.ERROR, response.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseDTO<List<StoreDTO>>> Get()
        {
            var response = await storeBusiness.GetAll();

            if (response.SuccessfulOperation)
            {
                return response.Result.AsResponseDTO(Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.OK,totalResult:response.Result.Count);
            }
            else
            {
                return Extensions.AsResponseDTO<List<StoreDTO>>(null, Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.ERROR, response.Message);
            }
        }
    }
}
