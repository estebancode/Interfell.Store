
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
    public class ArticleModel : EfBase, IArticleModel
    {
        public Task<ArticleDTO> CreateAsync(ArticleDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditAsync(ArticleDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticleDTO>> GetAll(int quantity = 0)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticleDTO>> GetAllBy(Expression<Func<ArticleDTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<ArticleDTO> GetBy(Expression<Func<ArticleDTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<ArticleDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
