using LibraryBook.Application.UseCase.Books.Register;
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
            var result = RegisterBooksUseCase.Execute(request);
            return Created(string.Empty, result);
        }
    }
}
