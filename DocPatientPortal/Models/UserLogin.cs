﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DocPatientPortal.Models
{
    [Table("userlogin")]
    public class UserLogin
    {
        [Key]
        public int uid { get; set; }


        [Required]
        public string username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string role { get; set; }
        public string status { get; set; }


        //creating the constructor
        
    }
}
