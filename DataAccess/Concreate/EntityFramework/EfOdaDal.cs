using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework.Contexts;
using Entity.Concreate.Entities;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfOdaDal:EfEntityRepositoryBase<Oda,PansiyonContext>,IOdaDal
    {
        
    }
}