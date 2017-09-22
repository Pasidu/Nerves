using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nerves.Models
{
    public class Repository : IRepository
    {
        static List<Organization> orgList = new List<Organization>();
        public Repository()
        {
           
        }

        public void OrganizationSave(Organization org) {
            orgList.Add(org);
        }

        public List<Organization> OrganizationGetAll()
        {
            return orgList;
        }

        public Organization OrganizationGetById(int id) {
            return orgList.FirstOrDefault<Organization>(x => x.Id == id);
        }
    }
}