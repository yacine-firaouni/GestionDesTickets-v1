using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionDesTickets.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {

        [Required]
        [Display(Name = "Nom d'utilisateur")]
        public string User { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [Display(Name = "Se Souvenir de moi?")]
        public bool RememberMe { get; set; }
    }
    public class EditProfileViewModel
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Nom d'Utilisateur")]
        public string UserName { get; set; }

        [Display(Name = "Photo")]
        public string Photo { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} mot de passe doit Contenir au minimum {2} Caractères", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe actuel")]
        public string CurrentPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} mot de passe doit Contenir au minimum {2} Caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de Passe")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Vérification du mot de passe")]
        [Compare("NewPassword", ErrorMessage = "Les mot de passe ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Societe")]
        public string Societe { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }

        [Required]
        [Display(Name = "Nom d'Utilisateur")]
        public string UserName { get; set; }


        [Display(Name = "Photo")]
        public string Photo { get; set; }

        [Required]
        [Display(Name = "Sexe")]
        public string Sexe { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} mot de passe doit Contenir au minimum {2} Caractères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de Passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Vérification du mot de passe")]
        [Compare("Password", ErrorMessage = "Les mot de passe ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
