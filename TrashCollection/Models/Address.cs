﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollection.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string StreetAddress { get; set; }
        public string CityState { get; set; }
        public int Zip { get; set; }


    }
}
