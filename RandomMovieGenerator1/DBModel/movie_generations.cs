//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RandomMovieGenerator1.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class movie_generations
    {
        public int id { get; set; }
        public int movieID { get; set; }
        public string title { get; set; }
        public Nullable<int> release { get; set; }
        public string image { get; set; }
        public System.DateTime Date { get; set; }
    }
}
