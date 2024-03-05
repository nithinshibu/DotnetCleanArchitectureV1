using Movies.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Entities
{
    //Here we are inheriting the Entity class since we need to have this basic audit related stuff needed to be injected from the entity itself.

    //Here the ID will be substituted by the TId itself and that will be the Movie Id
    public class Movie :Entity
    {
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public string ReleaseYear { get; set; }
    }
}
