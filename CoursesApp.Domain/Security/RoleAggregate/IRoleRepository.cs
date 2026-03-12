using Common.Model;

namespace CoursesApp.Domain.Security.RoleAggregate
{
    internal interface IRoleRepository: IRepository<Role>
    {
            List<Role> GetByStatus(RoleStatus status);

            void addUser(Role user);

           Role GetUserById(Guid id);

           Role GetUserByCode(string code);
    }
}
