using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BeeKeepr.Data
{
    public enum Color
    {
        [Description("Year ending in 1 or 6")] White,
        [Description("Year ending in 2 or 7")] Yellow,
        [Description("Year ending in 3 or 8")] Red,
        [Description("Year ending in 4 or 9")] Green,
        [Description("Year ending in 5 or 0")] Blue
    }
    public class Queen
    {
        [Key]
        public int QueenId { get; set; }
        [Display(Name ="Current Hive")]
        public int CurrentHiveId { get; set; }

        [Display(Name = "Original Hive")]
        public int OriginalHiveId { get; set; }
        public int Age { get; set; }
        public Color Color { get; set; }

        [ForeignKey(nameof(Hives))]
        public int? HiveId { get; set; }
        public virtual Hive Hives { get; set; }

        [ForeignKey(nameof(Notes))]
        public int? NoteId { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
