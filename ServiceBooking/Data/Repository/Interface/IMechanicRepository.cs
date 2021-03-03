﻿using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IMechanicRepository
    {
        MechanicViewModel GetMechanic(int? Id);
        IEnumerable<MechanicViewModel> GetAllMechanic();
        string CreateMechanic(MechanicViewModel model);
        string UpdateMechanic(MechanicViewModel model);
        string DeleteMechanic(int? Id);
    }
}
