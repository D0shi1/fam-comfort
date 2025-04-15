using System.ComponentModel.DataAnnotations;

namespace fam_comfort.Application.ViewModels;

public record UserRequest(
    [Required] string Username,
    [Required] string Password);