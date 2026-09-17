using FluentValidation;
using LibraryBook.Communication.Requests;

namespace LibraryBook.Application.UseCase.Books.Register;

public class RegisterBookValidator : AbstractValidator<RequestRegisterBookJson>
{
    public RegisterBookValidator()
    {
        RuleFor(books => books.Title)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("Title is required")
            .Length(2,120).WithMessage("Title must be between 2 and 120 characters");

        RuleFor(books => books.Author)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("Author is required")
            .Length(2,120).WithMessage("Author must be between 2 and 120 characters");
        
        RuleFor(books => books.Genre).IsInEnum().WithMessage("Genre is invalid");
        RuleFor(books => books.Status).IsInEnum().WithMessage("Status is invalid");
        
    }
}