using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CellphoneStore.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }

        public string Address { get; set; }
    }
}