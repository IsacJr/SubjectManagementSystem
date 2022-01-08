using System.Collections.Generic;
using System.Threading.Tasks;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IReportService
    {
        Task<Report> GetOne(int id);
        Task<IEnumerable<Report>> GetAll(FilterValue filter);
        Task<Report> Insert(Report report);
        Task<Report> Update(Report report);  
        Task<Report> Delete(int id); 
    }
}