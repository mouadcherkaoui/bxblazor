using NLayersApp.Persistence.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendApi.Models
{
    public class Member: IAuditable, ISoftDelete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
