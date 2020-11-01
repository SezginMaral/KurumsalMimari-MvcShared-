using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Bll.Abstract
{
   public interface IBookService//Burda servisin yapacagı işler yazılır  eklemeler yapılabilir
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetByAuthorId(int id);

        void Add(Book book);

        void Delete(Book book);
        void Update(Book book);


       // List<Book> GetAll(bool yayindami); bunun gibi isyenilen ne varsa bu sekilde yapılablir
    }
}
