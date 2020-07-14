using DevProject.Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace DevProject.Entities.Concrete
{
    public class AppRole : IdentityRole<int>, IEntity
    {

    }
}
