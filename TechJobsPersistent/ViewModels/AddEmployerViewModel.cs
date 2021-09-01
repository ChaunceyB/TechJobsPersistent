using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Every job must have a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Every job must have a name.")]
        public string Location { get; set; }
     
    }
}
