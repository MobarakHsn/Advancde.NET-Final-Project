//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public string status_sale { get; set; }
        public string status_purchase { get; set; }
        public string product_description { get; set; }
        public string warehouse_name { get; set; }
        public Nullable<double> stock { get; set; }
        public string nature { get; set; }
        public string weight { get; set; }
        public string weight_unit { get; set; }
        public string dimention { get; set; }
        public string dimention_unit { get; set; }
        public Nullable<double> selling_price { get; set; }
        public string tax { get; set; }
        public string product_image { get; set; }
        public string product_condition { get; set; }
        public string date_added { get; set; }
        public string last_updated { get; set; }
    }
}
