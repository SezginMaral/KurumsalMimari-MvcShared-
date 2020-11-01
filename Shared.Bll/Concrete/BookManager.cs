using Entities.Concrete;
using Shared.Bll.Abstract;
using Shared.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Bll.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;// DataAccsess layera baglanmak için new yerine kullanıldı


        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public void Add(Book book)
        {
           //// if (_bookDal.getList(x => x.Name == book.Name == null))//örnek iş kodları
           // {
               _bookDal.Add(book);
           // }
           // else
           //     throw new Exception("kitap listede zaten ekli");
          

        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return null; _bookDal.getList();
        }

        public List<Book> GetByAuthorId(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book book)   
        {
            _bookDal.Update(book);
        }
    }
}
 