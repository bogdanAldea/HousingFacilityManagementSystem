﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Options
{
    public class JwtSettings
    {
        public string SigningKey { get; set; }
        public string Issuer { get; set; }
        public string[] Audiences { get; set; }
    }
}
