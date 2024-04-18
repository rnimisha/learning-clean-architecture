

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.Domain.Entities;
public class BaseEntity{

    public BaseEntity()
    {
        Id = Guid.NewGuid();
    }

    [Key, Column("id")]
    public Guid Id {get; set;} = Guid.NewGuid();
}