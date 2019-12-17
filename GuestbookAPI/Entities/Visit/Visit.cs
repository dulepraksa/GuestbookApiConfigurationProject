using GuestbookAPI.Models.Guest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace GuestbookAPI.Entities.Visit
{
    [DataContract]
    public class Visit
    {
        /// <summary>
        /// Id posete u bazi.
        /// </summary>
        [DataMember(Name = "Id")]
        public Guid Id { get; set; }

        /// <summary>
        /// Vreme i datum dolska posetioca firme.
        /// </summary>
        [Required]
        [DataMember(Name = "Arrived at", Order = 2)]
        public DateTime ArrivedAt { get; set; }

        /// <summary>
        /// Vreme i datum odlaska posetioca firme.
        /// </summary>
        [DataMember(Name = "Left at", Order = 3)]
        public DateTime LeftAt { get; set; }

        /// <summary>
        /// Datum kad je kreirana poseta.
        /// </summary>
        [Timestamp]
        [DataMember(Name = "Created at", Order = 4)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Ime i prezime gosta koji je posetio firmu.
        /// </summary>
        [DataMember(Name = "Guest")]
        public Guest Guest { get; set; }
    }
}
