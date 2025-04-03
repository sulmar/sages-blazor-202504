using BlazorServerApp.Models;
using FluentValidation;

namespace BlazorServerApp.Validators;

// dotnet add package FluentValidation
public class CustomerValidator : AbstractValidator<Customer>
{
	public CustomerValidator()
	{
		RuleFor(p=>p.Name).NotEmpty().MinimumLength(3).MaximumLength(20);
		RuleFor(p => p.City).NotEmpty();
		RuleFor(p => p.Description).Matches("^[A-Z]ello$");
		RuleFor(p => p.Balance).InclusiveBetween(0, 1000);
		RuleFor(p => p.ConfirmPassword).Equal(nameof(Customer.Password));
	}
}
