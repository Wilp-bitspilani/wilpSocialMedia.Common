using WilpSocialMedia.Common.API.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace WilpSocialMedia.Common.API.Interface
{
    public interface IUrlApiFactory
    {
        string GetUrl(ServiceType serviceType);
        string GetUrl(string serviceType);
    }
}
