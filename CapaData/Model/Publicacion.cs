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
    
    public partial class Publicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publicacion()
        {
            this.Autor = new HashSet<Autor>();
            this.SecuenciaDeNucleotidos = new HashSet<SecuenciaDeNucleotidos>();
        }
    
        public int idPublicacion { get; set; }
        public string tituloPublicacion { get; set; }
        public System.DateTime fechaPub { get; set; }
        public int idRevistaCientif { get; set; }
    
        public virtual Publicacion_Archivo Publicacion_Archivo { get; set; }
        public virtual Revista_Cientifica Revista_Cientifica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autor> Autor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecuenciaDeNucleotidos> SecuenciaDeNucleotidos { get; set; }
    }
}
