using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Watch : BaseEntityNoIdentity
    {
        public string Color { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        public int AccountId { get; set; }

        [ForeignKey(nameof(AccountId))]
        public Account Account { get; set; }

        public DateTime ExpireTime { get; set; }
    }
}
