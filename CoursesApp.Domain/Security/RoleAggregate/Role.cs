using Common.Model;

namespace CoursesApp.Domain.Security.RoleAggregate
{
    public class Role: IDomainEntity
    {
        public Role() 
        { 
        
        }

        public static Role CreateNew(string code, string name, string description)
        {
            return new Role
            {
                Id = Guid.NewGuid(),
                code = code,
                Name = name,
                Description = description,
                status = RoleStatus.Active
            };
        }

        public Guid Id { get; private set; }
        public string code { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public RoleStatus status { get; private set; }


    }
}
