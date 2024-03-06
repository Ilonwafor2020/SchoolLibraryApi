using System.Text.Json.Serialization;

namespace SchoolLibraryApi.Models
{
   public class Category
  {
    public int CategoryID { get; set; }
    public required string Name { get; set; }
    [JsonIgnore]
    public List<Book>? Books { get; set; }
  }

}