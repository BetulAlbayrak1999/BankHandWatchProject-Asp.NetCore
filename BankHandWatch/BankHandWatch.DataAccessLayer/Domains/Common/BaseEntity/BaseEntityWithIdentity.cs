﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity
{
    public abstract class BaseEntityWithIdentity : IdentityUser, IBaseEntity
    {
        public BaseEntityWithIdentity()
        {
            CreatedDate = DateTime.Now;
            LastModifiedDate = DateTime.Now;
            IsActive = false;
        }
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }*/
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime? UnActiveDate { get; set; }
        public bool IsActive { get; set; }
    }
}
