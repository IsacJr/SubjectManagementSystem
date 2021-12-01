using System.Collections.Generic;
using SubjectManagementSystem.Domain;

namespace SubjectManagementSystem.Service
{
    public interface IReportService
    {
        Report GetOne(int id);
        IEnumerable<Report> GetAll();
        Report Insert(Report report);
        Report Update(Report report);  
        Report Delete(int id); 
    }
}