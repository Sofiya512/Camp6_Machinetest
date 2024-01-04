using Camp6._1_Machinetest.Models;

namespace Camp6._1_Machinetest.Repository
{
    public interface ILoginRepository
    {
        public LoginTbl ValidataeUser(string un, string pwd);

    }
}
