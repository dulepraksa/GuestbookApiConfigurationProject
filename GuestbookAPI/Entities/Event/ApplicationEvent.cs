using GuestbookAPI.Models.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuestbookAPI.Models.Event
{
    /// <summary>
    /// Event entitet koji ce da postoji, ima tip i userId koji ga je kreirao
    /// </summary>
    public class ApplicationEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public ApplicationType Type { get; set; }
    }
}
