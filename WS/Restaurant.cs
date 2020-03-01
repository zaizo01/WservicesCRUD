namespace WS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Restaurant")]
    public partial class Restaurant
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Nombre { get; set; }

        [StringLength(40)]
        public string Direccion { get; set; }

        [StringLength(15)]
        public string RNC { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        [StringLength(30)]
        public string Persona_Encargada { get; set; }

        public int? Cantidad_Emplados { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_Creacion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_Modificacion { get; set; }

        [StringLength(20)]
        public string Tipo_Comida { get; set; }

        [Column(TypeName = "money")]
        public decimal? Ventas_Mensuales_Promedio { get; set; }

        [StringLength(40)]
        public string GuidReg { get; set; }
    }
}
