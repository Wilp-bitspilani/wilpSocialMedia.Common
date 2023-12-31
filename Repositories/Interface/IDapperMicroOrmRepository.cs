﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WilpSocialMedia.Common.Repositories.Interface
{
    public interface IDapperMicroOrmRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FromSql(string query = null, object param = null);
        void FromSqlWithoutReturn(string query = null, object param = null);
    }
}
