using BookStore.Data;
using BookStore.Interfaces;
using BookStore.Models;

namespace BookStore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookStoreDbContext _bookStoreDbContext;

        public UserRepository(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }

        public async Task CreateUser(User user)
        {
            _bookStoreDbContext.Users.Add(user);
            await _bookStoreDbContext.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var user = await _bookStoreDbContext.Users.FindAsync(id);
            _bookStoreDbContext.Users.Remove(user);
            await _bookStoreDbContext.SaveChangesAsync();
        }

        public async Task<User> GetUserByFirstName(string firstname)
        {
          return await  _bookStoreDbContext.Users.FindAsync(firstname);
        }

        public async Task<User> GetUserByID(int id)
        {
           return await _bookStoreDbContext.Users.FindAsync(id);
        }

        public async Task UpdateUser(User user)
        {
            _bookStoreDbContext.Users.Update(user);
            await _bookStoreDbContext.SaveChangesAsync();
        }
    }
}
