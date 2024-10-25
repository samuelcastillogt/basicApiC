using Microsoft.AspNetCore.Mvc;
using AllCards.Models;
namespace Cards.Controllers{
    [Route("cards")]
    [ApiController]
    public class Cards : ControllerBase{
        [HttpGet("all")]
        public dynamic get(){
            return "Hola";
        }
        [HttpGet("id/{id}")]
        public dynamic getById(string id){
            var result = new CardsClass { Id = id, Name = "ojo" };
            return result;
        }
    }
}