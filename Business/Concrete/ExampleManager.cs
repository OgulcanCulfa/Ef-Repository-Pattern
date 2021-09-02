using EfDemo.Business.Abstract;
using EfDemo.Core.Utilities.Results;
using EfDemo.Entity.Concrete;
using EfDemo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfDemo.Business.Concrete
{
    public class ExampleManager: IExampleService
    {
        private readonly IExampleRepository _exampleRepository;
        public ExampleManager(IExampleRepository exampleRepository)
        {
            this._exampleRepository = exampleRepository;
        }

        public async Task<IResult> Add(Example example)
        {
            await _exampleRepository.Add(example);
            return new Result(true, "Example added.");
        }

        public async Task<IResult> Delete(Example example)
        {
            await _exampleRepository.Delete(example);
            return new Result(true, "Example deleted.");
        }

        public async Task<IDataResult<Example>> Get(int exampleId)
        {
            return new DataResult<Example>(await _exampleRepository.Get(id => id.Id == exampleId), true);
        }

        public async Task<IDataResult<List<Example>>> GetAll()
        {
           return new DataResult<List<Example>>(await _exampleRepository.GetAll(), true);
           
        }

        public async Task<IResult> Update(Example example)
        {
            await _exampleRepository.Update(example);
            return new Result(true, "Example updated.");
        }
    }
}
