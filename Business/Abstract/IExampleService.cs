using EfDemo.Core.Utilities.Results;
using EfDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfDemo.Business.Abstract
{
    public interface IExampleService
    {
        Task<IDataResult<List<Example>>> GetAll();
        Task<IDataResult<Example>> Get(int id);
        Task<IResult> Add(Example example);
        Task<IResult> Update(Example example);
        Task<IResult> Delete(Example example);
    }
}
