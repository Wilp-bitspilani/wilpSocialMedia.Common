using System;
using System.Collections.Generic;
using System.Text;

namespace WilpSocialMedia.Common.Repositories.Interface
{
    public interface ITransactionAble
    {        
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        void DisposeTransaction();
    }
}
