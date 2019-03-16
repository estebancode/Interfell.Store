
#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Result.Base;
using Interfell.Store.Data.Business.Interfaces;
using Interfell.Store.Data.Model.Interfaces;
using Interfell.Store.Data.Model.Implementation;
using Interfell.Store.Module.Commons.DTO;
using Interfell.Store.Module.Commons.Resources;

#endregion

namespace Interfell.Store.Data.Business.Implementation
{
    public class StoreBusiness : IStoreBusiness
    {
        /// <summary>
        /// Instancia del modelo
        /// </summary>
        private IStoreModel _istoreModel;

        public StoreBusiness()
        {
            _istoreModel = new StoreModel();
        }

        public StoreBusiness(IStoreModel istoreModel)
        {
            _istoreModel = istoreModel;
        }

        public async Task<BusinessResult<StoreDTO>> CreateAsync(StoreDTO entity)
        {
            try
            {
               var resultOperation = await _istoreModel.CreateAsync(entity);
                return BusinessResult<StoreDTO>.Success(resultOperation,General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<StoreDTO>.Issue(null,General.OperationIssue, ex);
            }
        }

        public Task<BusinessResult<bool>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<bool>> EditAsync(StoreDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<List<StoreDTO>>> GetAll(int quantity = 0)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<List<StoreDTO>>> GetAllBy(Expression<Func<StoreDTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<StoreDTO>> GetBy(Expression<Func<StoreDTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<StoreDTO>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
