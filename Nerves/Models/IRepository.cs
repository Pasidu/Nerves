using System.Collections.Generic;

namespace Nerves.Models
{
    public interface IRepository
    {
        void OrganizationSave(Organization org);

        List<Organization> OrganizationGetAll();

        Organization OrganizationGetById(int id);
    }
}
    
