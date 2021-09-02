using EfDemo.Entity.Concrete;
using EfDemo.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EfDemo.Repository.Concrete.EntityFramework
{
    public class EfExampleDal : EfEntityRepositoryBase<Example,ExampleContext>, IExampleRepository
    {

    }
}
