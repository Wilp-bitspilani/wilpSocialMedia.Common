using AutoMapper;
using WilpSocialMedia.Common.API.DTO;
using WilpSocialMedia.Common.API.Enum;
using WilpSocialMedia.Common.API.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WilpSocialMedia.Common.API.Services
{
    public class UserApiService : IUserApiService
    {
        private readonly IUrlApiFactory _urlApiFactory;
        private readonly IMapper _mapper;
        public UserApiService(IUrlApiFactory urlApiFactory, IMapper mapper)
        {
            _urlApiFactory = urlApiFactory;
            _mapper = mapper;
        }

        public AccountUserDto Detail(Guid IdUser)
        {
            try
            {
                var resspond = new HTTPWebRequestUtilities<AccountUserDto>(_urlApiFactory.GetUrl(ServiceType.User))
                            .GetSingle($"User/{IdUser}");

                return resspond;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AccountUserDto> GetUsers(List<Guid> IdUser)
        {
            try
            {
                var data = new HTTPWebRequestUtilities<AccountUserDto>(_urlApiFactory.GetUrl(ServiceType.User))
                             .Post($"Users", IdUser);

                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool UserExist(Guid IdUser)
        {
            try
            {
                var exist = new HTTPWebRequestUtilities<AccountUserDto>(_urlApiFactory.GetUrl(ServiceType.User))
                             .GetSingle($"User/{IdUser}");

                return exist != null ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
