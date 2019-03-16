
#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Result.Base;
using Interfell.Store.Data.Business.Interfaces;
using Interfell.Store.Data.Model.Interfaces;
using Interfell.Store.Data.Model.Implementation;
using Interfell.Store.Module.Commons.DTO;
using System.Linq.Expressions;
using Interfell.Store.Module.Commons.Resources;

#endregion

namespace Interfell.Store.Data.Business.Implementation
{
    public class ArticleBusiness : IArticleBusiness
    {
        /// <summary>
        /// instancia del modelo
        /// </summary>
        private IArticleModel _iarticleModel;

        public ArticleBusiness()
        {
            _iarticleModel = new ArticleModel();
        }

        public ArticleBusiness(IArticleModel articleModel)
        {
            _iarticleModel = articleModel;
        }

        public async Task<BusinessResult<ArticleDTO>> CreateAsync(ArticleDTO entity)
        {
            try
            {
                var resultOperation = await _iarticleModel.CreateAsync(entity);
                return BusinessResult<ArticleDTO>.Success(resultOperation,General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<ArticleDTO>.Issue(null,General.OperationIssue,ex);
            }
        }

        public Task<BusinessResult<bool>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<bool>> EditAsync(ArticleDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<List<ArticleDTO>>> GetAll(int quantity = 0)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<List<ArticleDTO>>> GetAllBy(Expression<Func<ArticleDTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<ArticleDTO>> GetBy(Expression<Func<ArticleDTO, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessResult<ArticleDTO>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
