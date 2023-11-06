using System;
using System.Collections.Generic;
using System.Text;

namespace WilpSocialMedia.Common.API.DTO
{
    public class AccountUserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
