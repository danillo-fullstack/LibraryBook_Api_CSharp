namespace LibraryBook.Exception.ExceptionsBase;

public class ErrorOnValidationException(List<string> errorMessages) : LibraryBookException
{
    public List<string> ErrorMessages { get; set; } = errorMessages;
}