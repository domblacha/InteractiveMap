using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveMap.Models
{
    public class CreateMarkerDto
    {
        [Required, MaxLength(255)]
        public string PointName { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        [Required]
        public int Latitude { get; set; }
        [Required]
        public int Longitude { get; set; }
        public int UserId { get; set; }
    }
}
