using System;
using System.Collections.Generic;

namespace ClubUI.Models
{
    public partial class Club
    {
        public Club()
        {
            Contract = new HashSet<Contract>();
        }

        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string StyleCode { get; set; }

        public Style StyleCodeNavigation { get; set; }
        public ICollection<Contract> Contract { get; set; }
    }
}
