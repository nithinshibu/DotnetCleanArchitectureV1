using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Entities.Base
{
    //This interface will accept the ID which we are supplying from the Entity.
    public interface IEntityBase<TId>
    {
        TId Id { get; }    
    }
}
