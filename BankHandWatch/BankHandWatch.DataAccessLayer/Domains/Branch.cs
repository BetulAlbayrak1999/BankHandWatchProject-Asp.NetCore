using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Branch : BaseEntityNoIdentity
    {
        public int BankId { get; set; }

        [ForeignKey(nameof(BankId))]
        public Bank Bank { get; set; }

        public int LocationId { get; set; }

        [ForeignKey(nameof(LocationId))]
        public Location Location { get; set; }

        public ICollection<Person> People { get; set; }

    }
}
