using System.Text.Json.Serialization;

namespace SchoolLibraryApi.Models
{
    
  public class Librarian
 {
    public int LibrarianID { get; set; }
    public required string Name { get; set; }
    [JsonIgnore]
    public List<Borrowing>? Borrowings { get; set; }
 }
}