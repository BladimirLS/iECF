//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iECF.Recepcion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class XZ
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> FechaHoraFirma { get; set; }
        public Nullable<int> IdECFInformacionReferencia { get; set; }
        public Nullable<bool> PaginacionSpecified { get; set; }
        public Nullable<bool> DescuentosORecargosSpecified { get; set; }
        public Nullable<bool> SubtotalesSpecified { get; set; }
    }
}
