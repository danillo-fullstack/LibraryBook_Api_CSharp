using LibraryBook.Communication.Enums;

namespace LibraryBook.Communication.Requests;

public class RequestRegisterBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public GenreType Genre { get; set; }
    public string? UrlImage { get; set; }
    public int TotalStar { get; set; }
    public BookStatusType Status { get; set; }
    public string? Comment  { get; set; } 
}