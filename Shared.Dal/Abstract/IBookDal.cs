using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Dal.Abstract
{
   public interface IBookDal: IEntityRepository<Book>
    {
    }
}
