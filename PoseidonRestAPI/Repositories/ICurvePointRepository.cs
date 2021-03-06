﻿using PoseidonRestAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PoseidonRestAPI.Repositories
{
    public interface ICurvePointRepository: IGenericRepository<CurvePoint>
    {
        void Update(int Id, CurvePoint entity);
    }
}