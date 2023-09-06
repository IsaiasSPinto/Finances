namespace Domain.Shared;

public class Error
{
    public Error(string name, string message)
    {
        Name = name;
        Message = message;
    }

    public string Name { get; }
    public string Message { get; }
}
