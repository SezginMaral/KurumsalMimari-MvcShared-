using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Book: IEntity
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int AuthorID { get; set; }
        public decimal Price { get; set; }


    }
}
