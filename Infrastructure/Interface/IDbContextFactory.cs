using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WilpSocialMedia.Common.Infrastructure.Interface
{
    public interface IDbContextFactory
    {
        IDbConnection GetDbConnection(string connectionString);
        string GetConnectionString(string connectionDb);
    }
}
