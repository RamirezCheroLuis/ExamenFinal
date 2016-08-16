using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model.DTO
{
    public class AutorModelView
    {
        public int AutorId { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Resource))]
        public string AutorNombre { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "LastName", ResourceType = typeof(Resources.Resource))]
        public string AutorApellido { get; set; }


        [Required]
        [StringLength(50)]
        
        public string AutorCiudad { get; set; }

        [Required]
        [StringLength(50)]
        
        public string AutorSexo { get; set; }


        [Required]
        [StringLength(50)]
        
        public int AutorSalario { get; set; }
        


    }
}
