using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace HumansApis.Models.Domain
{
    public class humans
    {

        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }

        public string Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }


    }
}
