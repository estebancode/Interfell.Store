
#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Interfell.Store.Data.Business.Interfaces;
using Interfell.Store.Data.Business.Implementation;

#endregion

namespace Interfell.Store.Web.Controllers
{
    public class ArticleApiController : ApiController
    {
       private IStoreBusiness storeBusiness { get { return new StoreBusiness(); } }
    }
}
