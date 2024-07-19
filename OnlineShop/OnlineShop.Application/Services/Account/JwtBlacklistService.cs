using Microsoft.IdentityModel.Tokens;
using OnlineShop.Application.Contracts.JWT;
using OnlineShop.Application.Dtos.JWT;
using OnlineShop.RepositoryDesignPatern.Frameworks.Abstracts;
using OnlineShopDomain.Aggregates.JWT;
using PublicTools.Resources;
using ResponseFramework;
using System.Net;

namespace OnlineShop.Application.Services.Account
{
    public class JwtBlacklistService : IAppJwtBlacklistService
    {
        private readonly IRepository<BlackListToken, Guid> _tokenRepository;

        public JwtBlacklistService(IRepository<BlackListToken, Guid> tokenRepository)
        {
            _tokenRepository = tokenRepository;
        }

        //private readonly HashSet<string> _blacklist = new HashSet<string>();

        //public void AddToBlacklist(string token)
        //{
        //    _blacklist.Add(token);
        //}

        //public bool IsInBlacklist(string token)
        //{
        //    return _blacklist.Contains(token);
        //}
        #region [- NotImplemented -]
        public Task<IResponse<object>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task<IResponse<object>> PutAsync(PutBlacklistTokensAppDto model)
        {
            throw new NotImplementedException();
        }
        public Task<IResponse<GetBlacklistTokensAppDto>> FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion

        public async Task<IResponse<object>> DeleteAsync(DeleteBlacklistTokensAppDto model)
        {
            if (!model.Token.IsNullOrEmpty())
            {

                var token = new BlackListToken()
                {
                    Id = model.Id,
                    ExpireDate = DateTime.UtcNow,
                    Token = model.Token
                };
                await _tokenRepository.DeleteAsync(token);
                await SaveChanges();
                return new Response<object>(MessageResource.Info_SuccessfullProcess);
            }
            return new Response<object>(MessageResource.Error_FailProcess);
        }
        public async Task<IResponse<object>> PostAsync(PostBlacklistTokensAppDto model)
        {
            if (!model.Token.IsNullOrEmpty())
            {

                var token = new BlackListToken()
                {
                    ExpireDate = DateTime.UtcNow,
                    Token = model.Token
                };
                var result = await _tokenRepository.InsertAsync(token);
                return new Response<object>(true, MessageResource.Info_SuccessfullProcess, string.Empty, result, HttpStatusCode.OK);
            }
            return new Response<object>(MessageResource.Error_FailProcess);
        }
        public async Task SaveChanges()
        {
            await _tokenRepository.SaveChanges();
        }
        public async Task<bool> IsInBlacklist(string token)
        {
            var blacklistTokens = await GetAsync();
            var result = blacklistTokens.Result;
            foreach (var item in result)
            {
                if (item.Token==token) return true; 
            }
            return false;

        }
        public async Task<IResponse<List<GetBlacklistTokensAppDto>>> GetAsync()
        {
            var blaklisttokens = await _tokenRepository.Select();
            var finalList = blaklisttokens.Result.Select(x => new GetBlacklistTokensAppDto()
            {
                Id = x.Id,
                ExpireDate= x.ExpireDate,
                Token = x.Token
            }).ToList();
            return new Response<List<GetBlacklistTokensAppDto>>(finalList);
        }
    }
}
