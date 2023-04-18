﻿using Core.DataAccess;
using System;

namespace Entities
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public bool IsAdmin { get; set; }

    }
}
