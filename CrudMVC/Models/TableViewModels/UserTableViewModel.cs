﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudMVC.Models.TableViewModels
{
    public class UserTableViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public int Edad { get; set; }
    }
}