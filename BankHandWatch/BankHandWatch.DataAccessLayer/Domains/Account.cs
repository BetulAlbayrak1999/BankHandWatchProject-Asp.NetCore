using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Account: BaseEntityWithIdentity
    {
        public string Iban { get; set; }
        public string AccountNo { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        public string AccountType { get; set; }

        public int CurrentBalance { get; set; }


        public int WatchId { get; set; }

        [ForeignKey(nameof(WatchId))]
        public Watch Watch { get; set; }
    }
}
