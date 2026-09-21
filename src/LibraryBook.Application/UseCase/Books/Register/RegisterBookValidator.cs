using FluentValidation;
using LibraryBook.Communication.Requests;
using LibraryBook.Exception;

namespace LibraryBook.Application.UseCase.Books.Register;

public class RegisterBookValidator : AbstractValidator<RequestRegisterBookJson>
{
    public RegisterBookValidator()
    {
        RuleFor(books => books.Title)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage(ResourcesErrorMessages.TITLE_REQUIRED)
            .Length(2,120).WithMessage(ResourcesErrorMessages.TITLE_MUST_BE_BETWEEN_2_AND_120_CARACTERES);

        RuleFor(books => books.Author)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage(ResourcesErrorMessages.AUTHOR_REQUIRED)
            .Length(2,120).WithMessage(ResourcesErrorMessages.AUTHOR_MUST_BE_BETWEEN_2_AND_120_CARACTERES);
        
        RuleFor(books => books.Genre).IsInEnum().WithMessage(ResourcesErrorMessages.GENRE_INVALID);
        RuleFor(books => books.Status).IsInEnum().WithMessage(ResourcesErrorMessages.STATUS_INVALID);
        
    }
}