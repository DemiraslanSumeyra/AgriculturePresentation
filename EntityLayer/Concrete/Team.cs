using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public int PersonName{ get; set; }
        public int Title { get; set; }
        public int ImageURL { get; set; }
        public int FacebookURL { get; set; }
        public int InstagramURL { get; set; }
        public int WebsiteURL  { get; set; }
        public int TwitterURL { get; set; }
    }
}
