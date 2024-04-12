

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class BaseEntity{

    [Key, Column("id")]
    public Guid Id {get; set;} = Guid.NewGuid();
}