﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.DataLayer.Entities.Developers.Factories
{
    public interface IDeveloperFactory
    {
        Developer Create(string name);
    }
}
