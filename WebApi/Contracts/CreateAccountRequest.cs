namespace WebApi.Contracts;

public record CreateAccountRequest(
    string Name,
    decimal Budget);
