using LibraryBook.Communication.Enums;

namespace LibraryBook.Communication.Responses;

public class ResponseRegisteredBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public GenreType Genre { get; set; }
}