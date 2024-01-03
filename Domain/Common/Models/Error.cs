namespace Domain.Common.Models;

public class Error
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new("Error.NullValue", "The specified result value is null");

    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }

    public string Code { get; }
    public string Message { get; }

    public static implicit operator string(Error error) => error.Code;

    public static bool operator ==(Error a, Error b)
    {
        if (a is null && b is null)
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.Code == b.Code;
    }

    public static bool operator !=(Error a, Error b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return GetHashCode() * 41;
    }

    public bool Equals(Error other)
    {
        return Code == other.Code;
    }

    public override bool Equals(object obj)
    {
        if (obj is not Error)
        {
            return false;
        }

        return Equals((Error)obj);
    }
}
