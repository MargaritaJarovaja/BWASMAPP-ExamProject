using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWASMAPP.Shared.Models
{
    public class Annons
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Discription { get; set; }
        public decimal Price { get; set; }
        public string? UserId { get; set; }
        public string? Contact { get; set; }
        public byte[]? Image { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
