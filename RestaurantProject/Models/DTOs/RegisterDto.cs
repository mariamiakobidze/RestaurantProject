using Microsoft.AspNetCore.Mvc;
using RestaurantProject.Controllers;
using System.ComponentModel.DataAnnotations;

namespace RestaurantProject.Models.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Person Name can't be blank")]
        public string PersonName { get; set; }

        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage = "Email should be proper email address format")]
        [Remote(action: nameof(AccountController.IsEmailAlreadyRegistered), controller: nameof(AccountController), ErrorMessage = "Email is already in use")]
        public string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber can't be blank")]
        [Phone(ErrorMessage = "PhoneNumber should be proper phoneNumber address format")]
        [Remote(action: "IsPhoneNumberAlreadyRegistered", controller: nameof(AccountController), ErrorMessage = "PhoneNumber is already in use")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password can't be blank")]
        [Compare(nameof(Password), ErrorMessage = "Password and Confirm password do not match")]
        public string ConfirmPassword { get; set; }
    }


}
