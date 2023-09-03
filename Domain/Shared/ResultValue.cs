namespace Domain.Shared;

public class ResultValue<T>
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public T Value { get; set; }
}
