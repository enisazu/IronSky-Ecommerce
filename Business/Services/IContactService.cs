﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IContactService
    {
        List<Contact> List();
        void Add(Contact contact);
    }
}
