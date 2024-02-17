using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Fintech.Models
{
  public class User
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id {get; set;} = Guid.NewGuid().ToString().Replace("-","");

    public string FirstName {get; set;} = null!;

    public string LastName {get; set;} = null!;
  }
}
