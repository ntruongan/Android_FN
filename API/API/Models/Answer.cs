//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public int ClassID { get; set; }
        public int ModuleID { get; set; }
        public string TraineeID { get; set; }
        public int QuestionID { get; set; }
        public Nullable<int> Value { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Module Module { get; set; }
        public virtual Question Question { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
