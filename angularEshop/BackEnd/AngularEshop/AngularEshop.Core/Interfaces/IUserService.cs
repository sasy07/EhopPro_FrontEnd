using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Account;

namespace AngularEshop.Core.Interfaces
{
    public interface IUserService:IDisposable
    {
        Task<List<User>> GetAllUsers();
    }
}