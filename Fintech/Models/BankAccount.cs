using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fintech.Models
{
  public class BankAccount
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id {get;set;} = Guid.NewGuid().ToString().Replace("-","");

    [Column(TypeName = "decimal(6,2)")]
    public decimal Balance {get; set;}
    public User Owner {get; set;} = null!;
  }
}
