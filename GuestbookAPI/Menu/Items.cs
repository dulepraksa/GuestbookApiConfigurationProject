using System.Collections.Generic;

namespace GuestbookAPI.Menu
{
    public class Items
    {
        public string Label { get; set; }
        public string Value { get; set; }
        public List<Items> Subitems { get;}
    }
}