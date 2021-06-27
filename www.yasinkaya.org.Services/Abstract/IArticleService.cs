﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Entities.Dtos;
using www.yasinkaya.org.Shared.Utilities.Result.Abstract;

namespace www.yasinkaya.org.Services.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> GetAsync(int articleId);

        Task<IDataResult<ArticleUpdateDto>> GetArticleUpdateDtoAsync(int articleId);

        Task<IDataResult<ArticleListDto>> GetAllAsync();

        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAsync();

        Task<IDataResult<ArticleListDto>> GetAllByDeletedAsync();

        Task<IDataResult<ArticleListDto>> GetAllByNonDeleteAndActiveAsync();

        Task<IDataResult<ArticleListDto>> GetAllByCategoryAsync(int categoryId);

        Task<IResult> AddAsync(ArticleAddDto articleAddDto, string createdByName,int userId);

        Task<IResult> UpdateAsync(ArticleUpdateDto articleUpdateDto, string modifiedByName);

        Task<IResult> DeleteAsync(int articleId, string modifiedByName);

        Task<IResult> HardDeleteAsync(int articleId);

        Task<IResult> UndoDeleteAsync(int articleId, string modifiedByName);

        Task<IDataResult<int>> CountAsync();

        Task<IDataResult<int>> CountByNonDeletedAsync();

        Task<IDataResult<ArticleListDto>> GetAllByViewCountAsync(bool isAscending, int? takeSize);
    }
}
