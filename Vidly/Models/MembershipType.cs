using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public byte Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }


//        private string _name;
//
//        public string Name
//        {
//            get
//            {
//                if (Id == 1)
//                {
//                    _name = "Pay as you go";
//                }
//                else if (Id == 2)
//                {
//                    _name = "Monthly";
//                }
//                else if (Id == 3)
//                {
//                    _name = "Quarterly";
//                }
//                else if (Id == 4)
//                {
//                    _name = "Yearly";
//                }
//                return _name;
//            }
//
//            set => _name = value;
//        }

    }
}