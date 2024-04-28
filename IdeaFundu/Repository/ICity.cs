﻿using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICity:IGeneric<City>
    {
        List<GetCitiesVM> GetCitiesByStateId(Int64 stateID);
    }
}
