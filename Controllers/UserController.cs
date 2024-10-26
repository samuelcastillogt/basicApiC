using Microsoft.AspNetCore.Mvc;
using UserModel.Models;

namespace User.Controllers{
    [Route("users")]
    [ApiController]
    public class User : ControllerBase{
        [HttpGet("all")]
        public dynamic getAll(){
            var users = new UserClass {Id = 1, Name = "Jual"};
            return users;
        }
        [HttpGet("byid/{id}")]
        public dynamic getById(string id){
            return id;
        }
        [HttpPost("login")]
        public dynamic login(UserClass data){
            // var requestBody = await Request.Body.ReadAsStringAsync();
            return data.Name;
        }
    }
}