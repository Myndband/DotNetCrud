using ModelProject;
using ModelProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
{
    public class UserInfoCrud
    {
        public dbContext _dbContext { get; set; }
        public UserInfoCrud(dbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public List<UserInfo> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public UserInfo Get(int id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.Id == id);

        }

        public UserInfo Save(UserInfo userInfo)
        {
            if (userInfo.Id <= 0)
            {
                _dbContext.Users.Add(userInfo);
            }
            else
            {
                _dbContext.Users.Update(userInfo);
            }
            _dbContext.SaveChanges();
            return userInfo;
        }
        public UserInfo patch(long id, int mobile)
        {

            var userInfo = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            if (userInfo == null)
            {
                return null;
            }
            userInfo.Mobile = mobile;
            _dbContext.Users.Update(userInfo);
            _dbContext.SaveChanges();
            return userInfo;
        }
        public List<UserInfo> SaveAll(List<UserInfo> UserDetails)
        {
            foreach (UserInfo userInfo in UserDetails)
            {
                if (userInfo.Id <= 0)
                {
                    _dbContext.Users.Add(userInfo);
                }
                else
                {
                    _dbContext.Users.Update(userInfo);
                }
            }
            _dbContext.SaveChanges();
            return UserDetails;
        }

        public string Delete(int id)
        {
            var userInfo = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            if (userInfo is null)
            {
                return "Id Does Not Exists";
            }
            _dbContext.Users.Remove(userInfo);
            _dbContext.SaveChanges();
            return "Data Deeted Succesfully";
        }
        public string DeleteAll()
        {
            var userInfo = _dbContext.Users.ToList();
            if (userInfo is null)
            {
                return "Data Does Not Exists";
            }
            foreach (UserInfo data in userInfo)
            {
                _dbContext.Users.Remove(data);
            }
            _dbContext.SaveChanges();
            return "All Data Deeted Succesfully";
        }
    }
}
