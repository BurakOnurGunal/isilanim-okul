
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DataAccessLayer
{

using System;
    using System.Collections.Generic;
    
public partial class Schools
{

    public int SchoolId { get; set; }

    public string SchoolName { get; set; }

    public string DepartmentName { get; set; }

    public string StartYear { get; set; }

    public string StartEnd { get; set; }

    public Nullable<int> cv_id { get; set; }



    public virtual Cvs Cvs { get; set; }

}

}
