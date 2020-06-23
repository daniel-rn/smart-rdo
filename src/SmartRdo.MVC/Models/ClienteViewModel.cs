using System;
using System.ComponentModel.DataAnnotations;

namespace SmartRdo.MVC.Models
{
    public class ClienteViewModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
