using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BettingWebbApp.Domain.Entities
{
    public class Betting
    {
       
        public int BettingId { get; set; }

        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Odd is required")]
        public int Odd { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage ="Please enter a positive amount")]
        public decimal Amount { get; set; }

        [Required]
        public string Description { get; set; }

        [Required(ErrorMessage ="Category is required")]
        public string Category { get; set; }

        [Required]
        public DateTime Kickoff { get; set; }
    }
}
