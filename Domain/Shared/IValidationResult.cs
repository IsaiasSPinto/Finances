namespace Domain.Shared;

public interface IValidationResult
{
    public static readonly Error ValidationError = new("Validation Error", "Validation failed");

    Error[] Errors { get; }
}
