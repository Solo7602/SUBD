using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE.TABLES
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [ForeignKey("HotelId")]
        public int idHotel { get; set; }
        public virtual List<Hotel> Hotels { get; set; }
    }
}
