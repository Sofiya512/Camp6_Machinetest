using Camp6._1_Machinetest.Models;
using Camp6._1_Machinetest.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camp6._1_Machinetest.Repository
{
    public interface ICustomerRepository
    {
        Task<List<CustomerTbl>> GetAllCustomerTbl();

        Task<int> AddCustomer(CustomerTbl customer);

        Task UpdateCustomer(CustomerTbl customer);

        //Find an customer - Get customer by id

        Task<CustomerTbl> GetCustomerById(int? id);

        //Delete an customer
        Task<int> DeleteCustomer(int? id);

        Task<List<CustomerDetailsViewModel>> GetViewModelCustomer();
    }

}

