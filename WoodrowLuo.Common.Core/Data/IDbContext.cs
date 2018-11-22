using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodrowLuo.Common.Core.Data
{
    public interface IDbContext
    {
        DbContext GetDB { get; }
    }
}
