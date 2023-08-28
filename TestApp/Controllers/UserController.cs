using Business.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelProject;
using ModelProject.Models;

namespace TestApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly dbContext _dbContext;
        // using this line dont need to create object in methods every time
        public UserInfoCrud CrudInfo { get; set; }
        public UserController(dbContext dbContext)
        {
            this._dbContext = dbContext;
            this.CrudInfo = new UserInfoCrud(_dbContext);
        }

        [HttpGet]
        public IActionResult Get()
        {
            // UserInfoCrud userInfo = new UserInfoCrud(_dbContext);
            // userInfo._dbContext = _dbContext;
            var data = CrudInfo.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(UserInfo userInfo)
        {
            if (userInfo == null)
            {
                return BadRequest();
            }
            var data = CrudInfo.Save(userInfo);
            return Ok(data);
        }
        [HttpPatch]
        public IActionResult patch(UserInfo userInfo)
        {
            var data = CrudInfo.patch(userInfo.Id, userInfo.Mobile);
            if(data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpGet]
        public IActionResult GetByID(int id)
        {
            var data = CrudInfo.Get(id);
            return Ok(data);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var data = CrudInfo.Delete(id);
            return Ok(data);
        }
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            var data = CrudInfo.DeleteAll();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult SaveAll(List<UserInfo> data)
        {
            if (data == null)
            {
                return BadRequest();
            }
            var UaerData = CrudInfo.SaveAll(data);
            return Ok(UaerData);
        }
    }
}
