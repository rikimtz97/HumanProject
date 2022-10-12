using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumansApis.Models.DTO
{
    public class HumansDTO
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public string Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

    }
}
