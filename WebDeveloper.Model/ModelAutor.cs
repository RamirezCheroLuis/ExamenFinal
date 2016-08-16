using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{

    [Table("Autor")]
    public partial class ModelAutor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AutorId { get; set; }


        [Column("AutorNombre")]
        [StringLength(50)]
        public string AutorNombre { get; set; }

        [Column("AutorApellido")]
        [StringLength(50)]
        public string AutorApellido { get; set; }


        [Column("AutorCiudad")]
        [StringLength(50)]
        public string AutorCiudad { get; set; }

        [Column("AutorSexo")]
        [StringLength(10)]
        public string AutorSexo { get; set; }

        [Column("AutorSalario")]
        public int  AutorSalario { get; set; }

        
        public virtual ModelLibroAutor ModeloAutor { get; set; }
    }
}
