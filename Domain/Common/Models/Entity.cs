namespace Domain.Common.Models;

public abstract class Entity<TKey> : IEquatable<Entity<TKey>>
{
    public TKey Id { get; set; }

    protected Entity(TKey id)
    {
        Id = id;
    }

    protected Entity()
    {
    }

    public override bool Equals(object? obj)
    {
        return obj is Entity<TKey> entity && Id.Equals(entity.Id);
    }
    public static bool operator ==(Entity<TKey>? left, Entity<TKey>? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Entity<TKey>? left, Entity<TKey>? right)
    {
        return !(left == right);
    }

    public bool Equals(Entity<TKey>? other)
    {
        return Equals((object?)other);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

}
