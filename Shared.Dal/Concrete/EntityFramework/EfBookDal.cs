using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Shared.Dal.Abstract;
using Shared.Dal.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Dal.Concrete.EntityFramework
{
  public  class EfBookDal: EfEntityRepositoryBase<Book, BookStoreContext>,IBookDal
    {
    }
}
