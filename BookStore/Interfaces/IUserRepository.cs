using BookStore.Models;

namespace BookStore.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByID(int id);
        Task<User> GetUserByFirstName(string firstname);
        Task CreateUser(User user);
        Task UpdateUser (User user);
        Task DeleteUser (int id);
    }
}
