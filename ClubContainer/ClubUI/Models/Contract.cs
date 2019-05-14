using System;
using System.Collections.Generic;

namespace ClubUI.Models
{
    public partial class Contract
    {
        public int ContractId { get; set; }
        public DateTime StartDate { get; set; }
        public int GroupId { get; set; }
        public int ClubId { get; set; }
        public double PricePerPerformace { get; set; }
        public int NumberOfPerformances { get; set; }
        public double TotalPrice { get; set; }

        public Club Club { get; set; }
        public Groups Group { get; set; }
    }
}
