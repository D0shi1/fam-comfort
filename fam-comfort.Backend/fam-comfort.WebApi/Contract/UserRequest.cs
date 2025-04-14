using System.ComponentModel.DataAnnotations;

namespace fam_comfort.WebApi.Contract;

public record UserRequest(
    [Required] string Username,
    [Required] string Password);