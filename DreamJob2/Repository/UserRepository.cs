using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DreamJob2.DBContexts;
using DreamJob2.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamJob2.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DreamJobContext _dbContext;
        public UserRepository(DreamJobContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteUser(int id)
        {
            var user = _dbContext.User.Find(id);
            _dbContext.User.Remove(user);
            Save();
        }
        public User GetUserById(int id)
        {
            return _dbContext.User.Find(id);
        }
        public IEnumerable<User> GetUsers()
        {
            return _dbContext.User.ToList();
        }

        public void InsertUser(User user)
        {
            _dbContext.Add(user);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            Save();
        }

     
    }
}
