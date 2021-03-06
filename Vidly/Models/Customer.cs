﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public bool IsSubscribedToNewsletter { get; set; }
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}