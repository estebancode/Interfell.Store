
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

        public async Task<BusinessResult<bool>> EditAsync(StoreDTO entity)
        {
            try
            {
                var resultOperation = await _istoreModel.EditAsync(entity);
                return BusinessResult<bool>.Success(true, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<bool>.Issue(false, General.OperationIssue, ex);
            }
        }

        public async Task<BusinessResult<List<StoreDTO>>> GetAll(int quantity = 0)
        {
            try
            {
                var result = await _istoreModel.GetAll(quantity);
                return BusinessResult<List<StoreDTO>>.Success(result, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<List<StoreDTO>>.Issue(null, General.OperationIssue, ex);
            }
        }

        public async Task<BusinessResult<List<StoreDTO>>> GetAllBy(Expression<Func<StoreDTO, bool>> condition)
        {
            try
            {
                var result = await _istoreModel.GetAllBy(condition);
                return BusinessResult<List<StoreDTO>>.Success(result, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<List<StoreDTO>>.Issue(null, General.OperationIssue, ex);
            }
        }

        public async Task<BusinessResult<StoreDTO>> GetBy(Expression<Func<StoreDTO, bool>> condition)
        {
            try
            {
                var result = await _istoreModel.GetBy(condition);
                return BusinessResult<StoreDTO>.Success(result, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<StoreDTO>.Issue(null, General.OperationIssue, ex);
            }
        }

        public async Task<BusinessResult<StoreDTO>> GetById(int id)
        {
            try
            {
                var result = await _istoreModel.GetById(id);
                return BusinessResult<StoreDTO>.Success(result, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<StoreDTO>.Issue(null, General.OperationIssue, ex);
            }
        }
    }
}
