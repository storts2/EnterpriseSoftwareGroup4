// Made By Nabeel

using Group4API.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Group4API.Repositories
{
    public interface IFieldReportRepo
    {
        IEnumerable<FieldReport> GetReport();

        FieldReport GetReportByDate(Date date);

        FieldReport AddNewReport(FieldReport report);

    }
}
