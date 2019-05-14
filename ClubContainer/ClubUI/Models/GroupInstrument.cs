using System;
using System.Collections.Generic;

namespace ClubUI.Models
{
    public partial class GroupInstrument
    {
        public int GroupInstumentId { get; set; }
        public int GroupId { get; set; }
        public string InstrumentCode { get; set; }

        public Groups Group { get; set; }
        public Instrument InstrumentCodeNavigation { get; set; }
    }
}
