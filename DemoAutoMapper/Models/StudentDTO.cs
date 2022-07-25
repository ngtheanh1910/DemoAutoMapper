using DemoAutoMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAutoMapper
{
    public class StudentDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string CurrentCity { get; set; }
        public AddressDTO Address { get; set; }
    }
}
