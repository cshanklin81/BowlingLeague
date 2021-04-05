using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Models.ViewModels
{
    public class PageNumberingInfo
    {
        public int NumItemsPerPage { get; set; }
        public int CurrentPageNum { get; set; }
        public int TotalNumItems { get; set; }
        //Calculates the num of pages
        public int NumPages => (int)(Math.Ceiling((decimal) TotalNumItems / NumItemsPerPage));
    }
}
