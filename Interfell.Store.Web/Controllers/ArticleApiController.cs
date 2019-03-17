
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
using Interfell.Store.Module.Commons.Utilities;

#endregion

namespace Interfell.Store.Web.Controllers
{
    /// <summary>
    /// articulos
    /// </summary>
    [Route("Services/Articles/")]
    public class ArticleApiController : ApiController
    {
       private IStoreBusiness storeBusiness { get { return new StoreBusiness(); } }

        private IArticleBusiness articleBusiness { get { return new ArticleBusiness();  } }

        /// <summary>
        /// Obtener todos los articulos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseDTO<List<ArticleDTO>>> Get()
        {
            var response = await articleBusiness.GetAll();

            if (response.SuccessfulOperation)
            {
                var responseStores = await storeBusiness.GetAll();
                var listStores = responseStores.Result;

                response.Result.ForEach(x=> 
                {
                    x.StoreName = listStores.FirstOrDefault(s=> s.IdStore == x.StoreId).Name;
                });

                return response.Result.AsResponseDTO(Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.OK,totalResult:response.Result.Count);
            }
            else
            {
                return Extensions.AsResponseDTO<List<ArticleDTO>>(null, Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.ERROR, response.Message);
            }
        }

        /// <summary>
        ///  create article
        /// </summary>
        /// <param name="articleDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseDTO<ArticleDTO>> Post([FromBody]ArticleDTO articleDTO)
        {
            var response = await articleBusiness.CreateAsync(articleDTO);

            if (response.SuccessfulOperation)
            {
                return response.Result.AsResponseDTO(Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.OK);
            }
            else
            {
                return Extensions.AsResponseDTO<ArticleDTO>(null, Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.ERROR, response.Message);
            }
        }

        /// <summary>
        /// Edit article
        /// </summary>
        /// <param name="id"></param>
        /// <param name="articleDTO"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Services/Articles/{id}")]
        public async Task<ResponseDTO<bool>> Put(int id, [FromBody]ArticleDTO articleDTO)
        {
            var response = await articleBusiness.EditAsync(articleDTO);

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
        /// Obtener todos los articulos by store id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Services/Articles/Stores/{id}")]
        public async Task<ResponseDTO<List<ArticleDTO>>> GetByStore(int id)
        {
            var response = await articleBusiness.GetAllBy(s=> s.StoreId == id);

            if (response.SuccessfulOperation)
            {

                var storeResponse = await storeBusiness.GetById(id);

                response.Result.ForEach(x =>
                {
                    x.StoreName = storeResponse.Result.Name;
                });

                return response.Result.AsResponseDTO(Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.OK, totalResult: response.Result.Count);
            }
            else
            {
                return Extensions.AsResponseDTO<List<ArticleDTO>>(null, Interfell.Store.Module.Commons.Enums.WebApi.ResponseCode.ERROR, response.Message);
            }
        }

    }
}
