
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

        public async Task<BusinessResult<bool>> EditAsync(ArticleDTO entity)
        {
            try
            {
                var resultOperation = await _iarticleModel.EditAsync(entity);
                return BusinessResult<bool>.Success(true, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<bool>.Issue(false, General.OperationIssue, ex);
            }
        }

        public async Task<BusinessResult<List<ArticleDTO>>> GetAll(int quantity = 0)
        {
            try
            {
                var result = await _iarticleModel.GetAll(quantity);
                return BusinessResult<List<ArticleDTO>>.Success(result, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<List<ArticleDTO>>.Issue(null, General.OperationIssue, ex);
            }
        }

        public async Task<BusinessResult<List<ArticleDTO>>> GetAllBy(Expression<Func<ArticleDTO, bool>> condition)
        {
            try
            {
                var result = await _iarticleModel.GetAllBy(condition);
                return BusinessResult<List<ArticleDTO>>.Success(result, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<List<ArticleDTO>>.Issue(null, General.OperationIssue, ex);
            }
        }

        public async Task<BusinessResult<ArticleDTO>> GetBy(Expression<Func<ArticleDTO, bool>> condition)
        {
            try
            {
                var result = await _iarticleModel.GetBy(condition);
                return BusinessResult<ArticleDTO>.Success(result, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<ArticleDTO>.Issue(null, General.OperationIssue, ex);
            }
        }

        public async Task<BusinessResult<ArticleDTO>> GetById(int id)
        {
            try
            {
                var result = await _iarticleModel.GetById(id);
                return BusinessResult<ArticleDTO>.Success(result, General.OperationSucsess);
            }
            catch (Exception ex)
            {
                return BusinessResult<ArticleDTO>.Issue(null, General.OperationIssue, ex);
            }
        }
    }
}
