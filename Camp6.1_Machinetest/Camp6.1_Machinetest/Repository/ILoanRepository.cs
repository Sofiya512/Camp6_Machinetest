using Camp6._1_Machinetest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camp6._1_Machinetest.Repository
{
    public interface ILoanRepository
    {
        Task<List<LoanDetailsTbl>> GetAllLoanDetails();

        Task<int> AddDetails(LoanDetailsTbl loanDetails);

        Task UpdateDetails(LoanDetailsTbl loanDetails);

        //Find an Details - Get Details by id

        Task<LoanDetailsTbl> GetDetailsById(int? id);

        //Delete an Details
        Task<int> DeleteDetails(int? id);

    }
}
