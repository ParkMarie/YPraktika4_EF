//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PraktikaEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderInfo
    {
        public int ID_OrderInfo { get; set; }
        public int Order_ID { get; set; }
        public int Book_ID { get; set; }
        public int Kol_Vo { get; set; }
    
        public virtual Books Books { private get; set; }
        public virtual Orders Orders { private get; set; }
    }
}