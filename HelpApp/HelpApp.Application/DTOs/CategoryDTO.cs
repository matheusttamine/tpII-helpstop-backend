using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Invalid name, too short, minimum 3 characters")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
