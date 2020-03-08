using NLayersApp.Persistence.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BackendApi.Models
{
    public class TestModel : IAuditable, ISoftDelete
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
