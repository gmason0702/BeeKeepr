using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BeeKeepr.Data
{
    public enum NoteType { FieldNote, Reminder }
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        [Display(Name ="Note Date")]
        public DateTime NoteDate { get; set; }

        [Display(Name ="Note")]
        [MaxLength(1000, ErrorMessage = "Please enter a shorter note")]
        public string NoteContent { get; set; }
        public virtual Hive Hive { get; set; }
        public virtual Queen Queen { get; set; }
    }
}
