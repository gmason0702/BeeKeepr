using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BeeKeepr.Data
{
    public enum Status { Winter, SpringBrood, Swarm, Flow, FallPrep }

    public class Hive
    {
        [Key]
        public int HiveId { get; set; }

        [Display(Name ="Origin Date")]
        public DateTime OriginDate { get; set; }

        [Display(Name ="# of Deeps")]
        public int NumberOfDeeps { get; set; }

        [Display(Name ="Has hive swarmed?")]
        public bool HasSwarmed { get; set; }
        public Status Status { get; set; }
        public virtual Queen Queen { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
