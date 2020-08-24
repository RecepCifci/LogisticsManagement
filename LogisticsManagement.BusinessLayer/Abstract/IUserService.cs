using LogisticsManagement.Core.Results;
using LogisticsManagement.Entities.Concrete;
using LogisticsManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticsManagement.BusinessLayer.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetById(int Id);
        IDataResult<List<User>> GetList();
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IResult Authenticate(LoginDto loginDto);
    }
}
