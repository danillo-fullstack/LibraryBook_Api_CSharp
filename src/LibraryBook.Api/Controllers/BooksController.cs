using LibraryBook.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LibraryBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterBookJson request)
        {
            return Created();
        }
    }
}
