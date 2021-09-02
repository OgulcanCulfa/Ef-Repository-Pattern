using EfDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfDemo.Entity.Concrete
{
    public class Example: IEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
