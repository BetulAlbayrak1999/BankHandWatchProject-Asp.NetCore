using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Customer: Person
    {
        public string Password { get; set; }

        public int WatchId { get; set; }

        [ForeignKey(nameof(WatchId))]
        public Watch Watch { get; set; }


        public int AccountId { get; set; }

        [ForeignKey(nameof(AccountId))]
        public Account Account { get; set; }
    }
}
