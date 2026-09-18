using EBlumbit.Models;
using EBlumbit.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EBlumbit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(UserService userService) : ControllerBase
    {
        private readonly UserService _userService = userService;

        [HttpGet]
        public async Task<ActionResult<ICollection<Users>>> GetAllUsers()
        {
            return Ok(_userService.GetAllUsers().Result.ToList());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUserById(int id)
        {
            return Ok(_userService.GetUserById(id).Result);
        }

        [HttpPost]
        public async Task<ActionResult<Users>> CreateUser([FromBody] Users user)
        {
            return Created("", _userService.CreateUser(user).Result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] Users user)
        {
            await _userService.UpdateUser(user);
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userService.DeleteUser(id);
            return NoContent();
        }
        
        [HttpPatch("{id}")]
        public async Task<IActionResult> LogicalDeleteUser(int id)
        {
            await _userService.LogicalDeleteUsuario(id);
            return NoContent();
        }
    }
}
