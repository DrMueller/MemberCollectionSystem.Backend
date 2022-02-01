using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mmu.MemberCollectionSystem.Areas.MemberAddresses.Dtos
{
    public class MemberAddressDto
    {
        public long Id { get; set; }
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
    }
}
