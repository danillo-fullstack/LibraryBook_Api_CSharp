using LibraryBook.Communication.Requests;
using LibraryBook.Communication.Responses;

namespace LibraryBook.Application.UseCase.Books.Register;

public static class RegisterBooksUseCase
{
    public static ResponseRegisteredBookJson Execute(RequestRegisterBookJson request)
    {
        return new ResponseRegisteredBookJson()
        {
            Title = request.Title,
        };
    }
}