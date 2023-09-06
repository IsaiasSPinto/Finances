namespace Domain.Shared;

public class Result
{
    public Result(bool isSucceeded)
    {
        IsSuccess = isSucceeded;
    }

    public Result(bool isSucceeded, Error error)
    {
        IsSuccess = isSucceeded;
        Message = error.Message;
    }
    public bool IsSuccess { get; set; }
    public string Message { get; set; }

    public static Result Success()
    {
        return new Result(true);
    }

    public static Result Failure(Error error)
    {
        return new Result(false, error);
    }

}

