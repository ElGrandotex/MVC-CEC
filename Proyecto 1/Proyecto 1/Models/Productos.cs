namespace Proyecto_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos
    {
        public int id { get; set; }

        public int CategoriaId { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public decimal Valor { get; set; }

        public bool Activo { get; set; }

        public virtual Categorias Categorias { get; set; }
    }
}
