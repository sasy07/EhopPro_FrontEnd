using System.Collections.Generic;
using System.Threading.Tasks;
using AngularEshop.Core.Interfaces;
using AngularEshop.DataLayer.Entities.Account;
using AngularEshop.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace AngularEshop.Core.Implementations
{
    public class UserService : IUserService
    {
        #region Constractor

        private IGenericRepository<User> userRepository;

        public UserService(IGenericRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        #endregion

        #region User

        public async Task<List<User>> GetAllUsers()
        {
            return await userRepository.GetEntitiesQuery().ToListAsync();
        }

        #endregion
        
        #region Dispose

        public void Dispose()
        {
            this.userRepository?.Dispose();
        }

        #endregion
    }
}