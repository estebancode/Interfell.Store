
#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Interfell.Store.Data.Model.Interfaces;
using Interfell.Store.Module.Commons.DTO;

#endregion

namespace Interfell.Store.Data.Model.Implementation
{
    public class StoreModel : EfBase, IStoreModel
    {

        public StoreModel()
        {

        }

        public Task<StoreDTO> CreateAsync(StoreDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(StoreDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<StoreDTO>> GetAll(int quantity = 0)
        {
            throw new NotImplementedException();
        }

        public Task<List<StoreDTO>> GetAllBy(Expression<Func<StoreDTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<StoreDTO> GetBy(Expression<Func<StoreDTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<StoreDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
