using System;
using System.Collections.Generic;

namespace ClubUI.Models
{
    public partial class Instrument
    {
        public Instrument()
        {
            GroupInstrument = new HashSet<GroupInstrument>();
        }

        public string InstrumentCode { get; set; }
        public string Name { get; set; }

        public ICollection<GroupInstrument> GroupInstrument { get; set; }
    }
}
