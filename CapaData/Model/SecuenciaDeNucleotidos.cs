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
    
    public partial class SecuenciaDeNucleotidos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecuenciaDeNucleotidos()
        {
            this.Autor = new HashSet<Autor>();
            this.Gen = new HashSet<Gen>();
            this.Gen1 = new HashSet<Gen>();
            this.Publicacion = new HashSet<Publicacion>();
        }
    
        public int idSecNucleot { get; set; }
        public string secuencia { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public int idMetodoSec { get; set; }
        public string anotaciones { get; set; }
        public int idOrganela { get; set; }
        public Nullable<int> nroCromosoma { get; set; }
        public int idConformacion { get; set; }
        public int idEspecie { get; set; }
        public int idGenero { get; set; }
        public int idFamilia { get; set; }
        public int idOrden { get; set; }
        public int idClase { get; set; }
        public int idFilo { get; set; }
        public int idReino { get; set; }
        public int idDominio { get; set; }
    
        public virtual Conformacion Conformacion { get; set; }
        public virtual Especie Especie { get; set; }
        public virtual MetodoDeSecuenciacion MetodoDeSecuenciacion { get; set; }
        public virtual Organela Organela { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autor> Autor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gen> Gen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gen> Gen1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Publicacion> Publicacion { get; set; }
    }
}
