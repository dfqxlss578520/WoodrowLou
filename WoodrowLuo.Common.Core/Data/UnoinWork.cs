using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WoodrowLuo.Common.Core.Data
{
    public class UnoinWork : IUnionWork
    {
        IDbContext _db;
        TransactionScope _tran;

        public UnoinWork(IDbContext db)
        {
            _db = db;
        }
        public IDbContext DbContext
        {
            get
            {
                return _db;
            }
        }

        public TransactionScope tan
        {
            get
            {
                if (_tran == null)
                {
                    new TransactionScope();
                }
                return _tran;
            }
        }

        public void Dispose()
        {
            if (_tran != null)
            {
                try
                {
                    _tran.Dispose();
                }
                finally
                {

                }
            }
        }
    }
}
