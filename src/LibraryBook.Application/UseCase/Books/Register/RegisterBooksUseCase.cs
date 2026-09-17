using LibraryBook.Communication.Requests;
using LibraryBook.Communication.Responses;
using LibraryBook.Exception.ExceptionsBase;

namespace LibraryBook.Application.UseCase.Books.Register;

public static class RegisterBooksUseCase
{
    public static ResponseRegisteredBookJson Execute(RequestRegisterBookJson request)
    {
        Validate(request);
        return new ResponseRegisteredBookJson()
        {
            Title = request.Title,
            Author = request.Author,
            Genre = request.Genre,
        };
    }

    private static void Validate(RequestRegisterBookJson request)
    {
        var validator = new RegisterBookValidator();
        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(error => error.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorMessages);
        }
    }
}