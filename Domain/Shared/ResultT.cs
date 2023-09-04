namespace Domain.Shared;

public class Result<TValue> : Result
{
    public Result(bool isSucceeded, Error error) : base(isSucceeded, error)
    {
    }

    public TValue Value { get; set; }
}

