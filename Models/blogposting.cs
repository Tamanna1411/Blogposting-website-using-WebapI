//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class blogposting
    {
        [Required(ErrorMessage ="this field to continue")]
        public int ID { get; set; }
        [Required(ErrorMessage = "this field to continue")]
        public string Title { get; set; }
        [Required(ErrorMessage = "this field to continue")]
        public string Tags { get; set; }
        [Required(ErrorMessage = "this field to continue")]
        public string Content { get; set; }
    }
}