using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using BankHandWatch.DataAccessLayer.Domains.SysDomains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Location : BaseEntityNoIdentity
    {
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; }


        public int RegionId { get; set; }
        [ForeignKey(nameof(RegionId))]
        public Region Region { get; set; }


        public int BranchId { get; set; }

        [ForeignKey(nameof(BranchId))]
        public Branch Branch { get; set; }


        public string Street { get; set; }


        public string PostalCode { get; set; }

        public ICollection<Person> Persons { get; set; }
    }
}
