//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacion.CapaData.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Especie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Especie()
        {
            this.SecuenciaDeNucleotidos = new HashSet<SecuenciaDeNucleotidos>();
        }
    
        public int idEspecie { get; set; }
        public int idGenero { get; set; }
        public int idFamilia { get; set; }
        public int idOrden { get; set; }
        public int idClase { get; set; }
        public int idFilo { get; set; }
        public int idReino { get; set; }
        public int idDominio { get; set; }
        public string epitetoEspecifico { get; set; }
    
        public virtual Genero Genero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecuenciaDeNucleotidos> SecuenciaDeNucleotidos { get; set; }
    }
}
