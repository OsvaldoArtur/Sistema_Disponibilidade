//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GesDisponibilidade
{
    using System;
    using System.Collections.Generic;
    
    public partial class Viatura_tb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Viatura_tb()
        {
            this.SaidaViatura_tb = new HashSet<SaidaViatura_tb>();
            this.Abastecimento_tb = new HashSet<Abastecimento_tb>();
        }
    
        public int idViaturas { get; set; }
        public string ModeloViatura { get; set; }
        public string AnoFabrico { get; set; }
        public string Matricula { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> DataRegistro { get; set; }
        public Nullable<int> RegistradoPor { get; set; }
        public Nullable<int> ActualizadoPor { get; set; }
        public Nullable<int> idMarca { get; set; }
        public Nullable<int> idFluido { get; set; }
        public string KmCadastro { get; set; }
        public string DestinoUso { get; set; }
        public byte[] Foto { get; set; }
        public string EstadoViatura { get; set; }
    
        public virtual Fluidos_tb Fluidos_tb { get; set; }
        public virtual Marca_tb Marca_tb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaidaViatura_tb> SaidaViatura_tb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abastecimento_tb> Abastecimento_tb { get; set; }
    }
}