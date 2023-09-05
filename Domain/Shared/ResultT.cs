namespace Domain.Shared;

public class Result<TValue> : Result
{
    public Result(bool isSucceeded, Error error) : base(isSucceeded, error)
    {
    }

    public Result(bool isSucceeded,TValue value) : base(isSucceeded)
    {
        Value = value;
    }

    public TValue Value { get; set; }

    public static Result<TValue> Success(TValue value)
    {
        return new Result<TValue>(true, value);
    }
}

