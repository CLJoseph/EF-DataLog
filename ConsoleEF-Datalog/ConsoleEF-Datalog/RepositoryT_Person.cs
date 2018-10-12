using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreRepositoryDatalog
{
    
    public interface IRepositoryPerson : IRepository<T_Person>
    {
    }

    public class RepositoryTPerson : Repository<T_Person>, IRepositoryPerson
    {
        private new ApplicationDbContext _Context;
        public RepositoryTPerson(ApplicationDbContext Context) : base(Context)
        {
            _Context = Context;
        }
    }

}
