namespace Common.Model
{
    // un raiz de agregado por la cual se gestionan y administran otras relaciones entidades anidadas.
    public abstract class AggregateRoot : IEventProvider
    {
        private readonly List<IDomainEvent> _domainEvents;
        protected AggregateRoot() 
        { 
            _domainEvents = new List<IDomainEvent>();
        }

        public IEnumerable<IDomainEvent> GetUnCommittedDomainEvents()
        {
            return _domainEvents;
        }

        public void MarkDomainEventsAsCommitted()
        {
            _domainEvents.Clear();
        }

        protected void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}
