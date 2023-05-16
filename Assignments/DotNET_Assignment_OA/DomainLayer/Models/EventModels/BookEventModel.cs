using System.ComponentModel.DataAnnotations;
using System;
using DomainLayer.OtherFiles;

namespace DomainLayer.Models
{
    public class BookEventModel
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the title of your book event.")]
        public string Title { get; set; }


        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter the date of your book event.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "Please enter the start time of your book event.")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }

        [Display(Name = "Location")]
        [Required(ErrorMessage = "Please enter the location of your book event.")]
        public string Location { get; set; }

        [Required]
        public EventType Type { get; set; }

        [Display(Name = "Duration In Hours")]
        [Range(0, 8)]
        public int Duration { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(500)]
        [Display(Name = "Other Details")]
        public string OtherDetails { get; set; }

        [Display(Name = "Invite Others")]
        public string InviteByEmail { get; set; }

        public int Count { get; set; }
        public string CreatedBy { get; set; }

        public string CommentAdded { get; set; }

    }
}
