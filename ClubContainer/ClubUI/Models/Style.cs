using System;
using System.Collections.Generic;

namespace ClubUI.Models
{
    public partial class Style
    {
        public Style()
        {
            Club = new HashSet<Club>();
            Groups = new HashSet<Groups>();
        }

        public string StyleCode { get; set; }
        public string Name { get; set; }

        public ICollection<Club> Club { get; set; }
        public ICollection<Groups> Groups { get; set; }
    }
}
