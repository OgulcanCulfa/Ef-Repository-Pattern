using EfDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfDemo.Repository.Abstract
{
    public interface IExampleRepository: IEntityRepository<Example>
    {
    }
}
