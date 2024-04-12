using System.ComponentModel.DataAnnotations;

namespace Clean.Domain.Entities;
public class User : BaseEntity{

    [Required]
    public required string Email {get; set;}

    [Required]
    public required string FirstName {get; set;}

    [Required]
    public required string LastName {get; set;}

    [Required]
    public required string Password {get; set;}

    [Required]
    public required string Role {get; set;}

    public string? RefreshToken {get; set;}

}