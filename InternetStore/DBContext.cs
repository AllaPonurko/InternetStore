﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace InternetStore
{
     public class MyDBContext:DbContext
    {
        public MyDBContext():base("DBConnectionString")
        {
             
        }
    }
}
