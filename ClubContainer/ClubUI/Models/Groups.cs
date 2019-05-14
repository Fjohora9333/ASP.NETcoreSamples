using System;
using System.Collections.Generic;

namespace ClubUI.Models
{
    public partial class Groups
    {
        public Groups()
        {
            Contract = new HashSet<Contract>();
            GroupInstrument = new HashSet<GroupInstrument>();
        }

        public int GroupId { get; set; }
        public short Size { get; set; }
        public string Name { get; set; }
        public string StyleCode { get; set; }

        public Style StyleCodeNavigation { get; set; }
        public ICollection<Contract> Contract { get; set; }
        public ICollection<GroupInstrument> GroupInstrument { get; set; }
    }
}
