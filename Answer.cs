//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Questionnaire2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public Answer()
        {
            this.Responses = new HashSet<Respons>();
        }
    
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public string QTypeName { get; set; }
        public bool selectedValue { get; set; }
    
        public virtual QType QType { get; set; }
        public virtual ICollection<Respons> Responses { get; set; }
    }
}
