using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TranslateGame.Desktop.ViewModels;

namespace TranslateGame.Desktop.Interfaces.Services
{
    public interface IResultService
    {
        Task<ResultViewModel> GetUserRating(Guid userId);
        Task<IEnumerable<ResultViewModel>> GetRatings();
    }
}
