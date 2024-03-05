using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Entities.Base
{
    //Entity is an abstract class 
    //It should be deriving from the EntityBase
    //Inside the EntityBase we will be deriving how it needs to be , like the ID needs to be substituted.
    //Because if we are working with SQL server or MongoDB , in case of SQL server the ID can be substituted with INT and in Mongo we can use String.
    public abstract class Entity : EntityBase<int>
    {
    }
}
