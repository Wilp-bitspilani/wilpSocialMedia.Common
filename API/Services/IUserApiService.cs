using WilpSocialMedia.Common.API.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace WilpSocialMedia.Common.API.Services
{
    public interface IUserApiService
    {
        AccountUserDto Detail(Guid IdUser);
        List<AccountUserDto> GetUsers(List<Guid> IdUser);
        bool UserExist(Guid IdUser);
    }
}
