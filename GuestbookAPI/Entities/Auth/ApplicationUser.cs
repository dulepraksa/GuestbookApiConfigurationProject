﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GuestbookAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName="NVARCHAR(50)")]
        public string FullName { get; set; }
    }
}
