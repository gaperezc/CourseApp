namespace Common.Model
{
    internal interface IEventProvider
    {
        IEnumerable<IDomainEvent> GetUnCommittedDomainEvents();

        void MarkDomainEventsAsCommitted();


    }
}
