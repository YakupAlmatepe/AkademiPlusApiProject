﻿using AkademiPlusAp.EntityLayer.Concrete;
using AkademiPlusApi.DataAccessLayer.Abstract;
using AkademiPlusApi.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusApi.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
    }
}
