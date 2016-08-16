using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    [Table("LibroAutor")]
    public partial class ModelLibroAutor
    {
        public ModelLibroAutor()
        {
            Libro = new HashSet<ModelLibro>();
            Autor = new HashSet<ModelAutor>();
           
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }
        

        public virtual ICollection<ModelLibro> Libro { get; set; }

        public virtual ICollection<ModelAutor> Autor { get; set; }

        
 
    }
}
