using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Classes.Database.Enums
{
    public enum UserTypes
    {
        Administrator,
        Personnel,
        Intern,
        Customer
    }
    public enum CustomerTypes
    {
        Person,
        Company
    }
    public enum CompanyTypes
    {
        Anonim,
        Limited,
        Personal
    }

    public enum FormGoal
    {
        Add,
        Update,
        Delete
    }
}
