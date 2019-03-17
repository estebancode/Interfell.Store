
#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Interfell.Store.Data.Model.Interfaces;
using Interfell.Store.Module.Commons.DTO;
using Interfell.Store.Data.Entities.Entity;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;

#endregion

namespace Interfell.Store.Data.Model.Implementation
{
    public class StoreModel : EfBase, IStoreModel
    {

        public StoreModel()
        {

        }

        public async Task<StoreDTO> CreateAsync(StoreDTO entity)
        {
            var entitie = Mapper.Map<StoreDTO, Stores>(entity);
            _context.Stores.Add(entitie);
            await _context.SaveChangesAsync();
            return Mapper.Map<Stores, StoreDTO>(entitie);
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EditAsync(StoreDTO entity)
        {
            var entitie = new Stores()
            {
                IdStore = entity.IdStore,
            };

            _context.Stores.Attach(entitie);

            //Ese necesario asignar los valores despues de "atachar" la entidad
            entitie.Name = entity.Name;
            entitie.Address = entity.Address;

            _context.Configuration.ValidateOnSaveEnabled = false;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<StoreDTO>> GetAll(int quantity = 0)
        {
            if (quantity == 0)
                return await _context.Stores.ProjectTo<StoreDTO>().ToListAsync();
            else
            {
                return await _context.Stores.Take(quantity).ProjectTo<StoreDTO>().ToListAsync();
            }
        }

        public async Task<List<StoreDTO>> GetAllBy(Expression<Func<StoreDTO, bool>> condition)
        {
            return await _context.Stores.ProjectTo<StoreDTO>().Where(condition).ToListAsync();
        }

        public async Task<StoreDTO> GetBy(Expression<Func<StoreDTO, bool>> condition)
        {
            return await _context.Stores.ProjectTo<StoreDTO>().FirstOrDefaultAsync(condition);
        }

        public async Task<StoreDTO> GetById(int id)
        {
            var entity = await _context.Stores.FindAsync(id);
            return Mapper.Map<Stores, StoreDTO>(entity);
        }
    }
}
