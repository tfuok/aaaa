namespace dotnet03_web_blazor.Model;

using System.ComponentModel.DataAnnotations;

public class CourseUser
{
    [Required(ErrorMessage = "Full name is required")]
    [MinLength(3, ErrorMessage = "Full name must be at least 3 characters")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10–12 digits")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "You must select a course")]
    public string SelectedCourse { get; set; }

    [Required(ErrorMessage = "Please select a study mode")]
    public bool IsOnline { get; set; } //true onl false ofline

    [Required(ErrorMessage = "Please select a start date")]
    [DataType(DataType.Date)]
    public DateTime? StartDate { get; set; }

    public string Notes { get; set; }

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to terms and conditions")]
    public bool AgreeTerms { get; set; }
}