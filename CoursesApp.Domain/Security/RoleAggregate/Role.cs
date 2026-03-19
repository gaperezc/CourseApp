using Common.Model;
using CoursesApp.Domain.Security.RoleAggregate.Events;

namespace CoursesApp.Domain.Security.RoleAggregate
{
    public class Role: AggregateRoot, IDomainEntity
    {
        public Role() 
        { 
            Users = new List<User>();
        }

        public static Role CreateNew(string code, string name, string description)
        {
            return new Role
            {
                Id = Guid.NewGuid(),
                code = code,
                Name = name,
                Description = description,
                status = RoleStatus.Active,
                Users = new List<User>()
            };
        }

        public Guid Id { get; private set; }
        public string code { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public RoleStatus status { get; private set; }

        public List<User> Users { get; private set; }


        public void ChangeUserFirstName(Guid id, string firstName)
        {
            if (Users == null || Users.Count <= 0)
            {
                return;
            }

            User user = Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
            {
                return;
            }

            bool changed = user.ChangeFirstName(firstName);

            if (changed)
            {
                   AddDomainEvent(new UserFirstNameChangedDomainEvent(id, firstName));
            }
        }


     }

 }

