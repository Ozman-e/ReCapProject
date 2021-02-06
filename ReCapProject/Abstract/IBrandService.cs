﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Updated(Brand brand);
        void Delete(Brand brand);
        List<Brand> GetAll();
        Brand GetByBrandId(string id);
    }

}
