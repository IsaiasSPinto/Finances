namespace Domain.Shared;

public class Result 
{
    public Result(bool isSucceeded)
    {
        Success = isSucceeded;
    }

    public Result(bool isSucceeded,Error error)
    {
        Success = isSucceeded;
        Message = error.Message;
    }
    public bool Success { get; set; }
    public string Message { get; set; } 
}

