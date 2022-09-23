using System.Collections.Generic;
using System.Threading.Tasks;
using xamarinIOSTask.Domain.Entity;
namespace xamarinIOSTask.Domain.Interfaces
{
    public interface DoctorsServices
    {
        Task<List<Doctor>> GetDoctorsAcceptInsurance();
    }
}
