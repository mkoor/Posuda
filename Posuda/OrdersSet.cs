//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Posuda
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersSet
    {
        public int Id { get; set; }
        public Nullable<int> idProduct { get; set; }
        public Nullable<int> idPoint { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> Count { get; set; }
    
        public virtual PointsSet PointsSet { get; set; }
        public virtual ProductsSet ProductsSet { get; set; }
        public virtual Users Users { get; set; }
    }
}
