
#region Usings

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Interfell.Store.Data.Entities.Entity;
using Interfell.Store.Data.Model.Interfaces;
using Interfell.Store.Module.Commons.DTO;

#endregion

namespace Interfell.Store.Data.Model.Implementation
{
    public class ArticleModel : EfBase, IArticleModel
    {
        public async Task<ArticleDTO> CreateAsync(ArticleDTO entity)
        {
            var entitie = Mapper.Map<ArticleDTO, Articles>(entity);
            _context.Articles.Add(entitie);
            await _context.SaveChangesAsync();
            return Mapper.Map<Articles, ArticleDTO>(entitie);
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EditAsync(ArticleDTO entity)
        {
            var entitie = new Articles()
            {
                IdArticle = entity.IdArticle,
            };

            _context.Articles.Attach(entitie);

            //Ese necesario asignar los valores despues de "atachar" la entidad
            entitie.Name = entity.Name;
            entitie.Description = entity.Description;
            entitie.Price = entity.Price;
            entitie.TotalInShelf = entity.TotalInShelf;
            entitie.TotalInVault = entity.TotalInVault;

            _context.Configuration.ValidateOnSaveEnabled = false;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<ArticleDTO>> GetAll(int quantity = 0)
        {
            if (quantity == 0)
                return await _context.Articles.ProjectTo<ArticleDTO>().ToListAsync();
            else
            {
                return await _context.Articles.Take(quantity).ProjectTo<ArticleDTO>().ToListAsync();
            }
        }

        public async Task<List<ArticleDTO>> GetAllBy(Expression<Func<ArticleDTO, bool>> condition)
        {
            return await _context.Articles.ProjectTo<ArticleDTO>().Where(condition).ToListAsync();
        }

        public async Task<ArticleDTO> GetBy(Expression<Func<ArticleDTO, bool>> condition)
        {
            return await _context.Articles.ProjectTo<ArticleDTO>().FirstOrDefaultAsync(condition);
        }

        public async Task<ArticleDTO> GetById(int id)
        {
            var entity = await _context.Articles.FindAsync(id);
            return Mapper.Map<Articles, ArticleDTO>(entity);
        }
    }
}
