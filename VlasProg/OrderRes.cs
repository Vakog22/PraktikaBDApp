//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VlasProg
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderRes
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsDone { get; set; }
        public int IDResource { get; set; }
        public int Quantity { get; set; }
        public int IDSupplier { get; set; }
    
        public virtual Resource Resource { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}