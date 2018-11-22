using System;
using System.Data.Entity;

namespace WoodrowLuo.Common.Core.Data
{
    public class CommonContext:IDbContext
    {
        DbContext _db;
        public CommonContext(DbContext db)
        {
            _db = db;
        }

        public DbContext GetDB
        {
            get
            {
              return _db;
            }
        }
    }
}
 