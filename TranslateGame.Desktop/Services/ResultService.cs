using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranslateGame.Desktop.Interfaces;
using TranslateGame.Desktop.Interfaces.Services;
using TranslateGame.Desktop.Repositories;
using TranslateGame.Desktop.ViewModels;

namespace TranslateGame.Desktop.Services
{
    public class ResultService : IResultService
    {
        private readonly IResultRepository _resultRepository;
        private readonly IUserRepository _userRepository;

        public ResultService()
        {
            this._resultRepository = new ResultRepositroy();
            this._userRepository = new UserRepository();
        }

        public async Task<IEnumerable<ResultViewModel>> GetRatings()
        {
            ICollection<ResultViewModel> result = new List<ResultViewModel>();

            foreach (var user in this._userRepository.GetAll())
            {
                result.Add(await GetUserRating(user.Id));
            }

            return result.OrderByDescending(r => r.HardAvg).ThenByDescending(r => r.MediumAvg).ThenByDescending(r => r.EasyAvg);
        }

        public async Task<ResultViewModel> GetUserRating(Guid userId)
        {
            var result = new ResultViewModel();

            var results = _resultRepository.GetAll().Where(r => r.UserId == userId);

            result.EasyAvg = results.Where(r => r.Level == Enums.TestLevel.Easy)
                .Sum(p => p.Percentage) / results.Where(r => r.Level == Enums.TestLevel.Easy).Count();

            result.MediumAvg = results.Where(r => r.Level == Enums.TestLevel.Medium)
                .Sum(p => p.Percentage) / results.Where(r => r.Level == Enums.TestLevel.Medium).Count();

            result.HardAvg = results.Where(r => r.Level == Enums.TestLevel.Hard)
                .Sum(p => p.Percentage) / results.Where(r => r.Level == Enums.TestLevel.Hard).Count();

            result.Name = _userRepository.Get(userId).Username;

            return result;
        }
    }
}
