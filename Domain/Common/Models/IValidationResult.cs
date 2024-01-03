namespace Domain.Common.Models;

public interface IValidationResult
{
    public static readonly Error ValidationError = new("Validation Error", "Validation failed");

    Error[] Errors { get; }
}
