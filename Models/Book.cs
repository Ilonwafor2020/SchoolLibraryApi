using System.Text.Json.Serialization;

namespace SchoolLibraryApi.Models
{
    public class Book
{
    public int BookID { get; set; }
    public required string Title { get; set; }
    public int PublisherID { get; set; }
    [JsonIgnore]
    public Publisher? Publisher { get; set; }
    public int CategoryID { get; set; }
    [JsonIgnore]
    public Category? Category { get; set; }
}
}