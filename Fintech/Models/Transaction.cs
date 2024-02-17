
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fintech.Models
{
  public class Transaction
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id {get;set;} = Guid.NewGuid().ToString().Replace("-","");


    public BankAccount Source {get; set;} = null!;

    public BankAccount Destination {get; set;} = null!;

    public DateTime CreatedAt {get; set;} = DateTime.Now;
  }
}
