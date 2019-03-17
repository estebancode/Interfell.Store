
#region Usings

using Interfell.Store.Data.Business.Implementation;
using Interfell.Store.Data.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

#endregion

namespace Interfell.Store.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class StoreController : Controller
    {
        /// <summary>
        /// Instancia de la capa de negocio
        /// </summary>
        private IStoreBusiness storeBusiness { get { return new StoreBusiness(); } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ActionResult> Detail(int id)
        {

            var response = await storeBusiness.GetById(id);

            if (response.SuccessfulOperation)
            {
                return View(response.Result);
            }
            else
            {
                return RedirectToAction("Index","Home",null);
            }
        }
    }
}
