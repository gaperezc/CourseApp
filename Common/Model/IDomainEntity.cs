namespace Common.Model
{
    public interface IDomainEntity
    {
        Guid Id { get; }
        string  code { get; }
        string Description { get; } 

    }
}
