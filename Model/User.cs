namespace dotnet03_web_blazor.Model;

using System.ComponentModel.DataAnnotations;

public class User
{
    [Required(ErrorMessage = "Full name is required.")]
    [MinLength(3, ErrorMessage = "Full name must be at least 3 characters long.")]
    public string Fullname { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
    public string PhoneNumber { get; set; }

    public string Address { get; set; }

    [Required(ErrorMessage = "Message is required.")]
    [MinLength(10, ErrorMessage = "Message must be at least 10 characters long.")]
    public string Message { get; set; }

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
    public bool Agree { get; set; }

    [Required(ErrorMessage = "Service is required.")]
    [NotChooseValidator(ErrorMessage = "Vui lòng chọn một dịch vụ hợp lệ")]
    public string Service { get; set; }

    public class NotChooseValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is string str && !string.IsNullOrWhiteSpace(str) && str != "Choose...";
        }
    }
}
