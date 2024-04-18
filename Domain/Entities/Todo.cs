using System.ComponentModel.DataAnnotations;

namespace Clean.Domain.Entities;

public class Todo: BaseEntity{

    [Required]
    public required string Title {get; set;}

    public bool IsCompleted {get; set;} = false;

    [Required]
    public required Guid User {get; set;}

}