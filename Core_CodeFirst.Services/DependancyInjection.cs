using Core_CodeFirst.Data.Models;
using Core_CodeFirst.Services.IServices;

namespace Core_CodeFirst.Services
{
    public class DependancyInjection : ITransient, IScoped, ISingoleton
    {

        Guid id;
        public DependancyInjection()
        {
            id = Guid.NewGuid();
        }

        public Guid GetOperationID()
        {
            return id;
        }
    }
}