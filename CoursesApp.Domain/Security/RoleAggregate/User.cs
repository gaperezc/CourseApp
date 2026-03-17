using Common.Model;

namespace CoursesApp.Domain.Security.RoleAggregate
{
    public class User : IDomainEntity
    {

        public static User CreateNew(Guid roleId, string code, string firstName, string lastName, string address, string description)
        {
            User entity = new User
            {
                Id = Guid.NewGuid(),
                RoleId = roleId,
                code = code,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Description = description,
                status = UserStatus.Active
            };

            return entity;
        }

        public Guid Id { get; private set; }

        public Guid RoleId { get; private set; }

        public string code { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Address { get; private set; }

        public UserStatus status { get; private set; }
        
        public string Description { get; private set; }

        public virtual Role Role { get; private set; }




        internal bool ChangeFirstName(Guid id, string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name cannot be null or empty.", nameof(firstName));

            if (FirstName != firstName)
            {
                FirstName = firstName;
                return true;
            }

            return false;
        }

    }
}
