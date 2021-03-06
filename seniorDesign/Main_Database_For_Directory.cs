//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace seniorDesign
{
    using System;
    using System.Collections.Generic;
    
    public partial class Main_Database_For_Directory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Main_Database_For_Directory()
        {
            this.Comment_Table = new HashSet<Comment_Table>();
        }
    
        public string Organization { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string ServicesOffered { get; set; }
        public string TypeOfOrganization { get; set; }
        public Nullable<bool> InformationSource { get; set; }
        public Nullable<bool> ApprovedForDirectory { get; set; }
        public Nullable<bool> Verified { get; set; }
        public string Fax { get; set; }
        public string Facebook { get; set; }
        public string Google { get; set; }
        public string Youtube { get; set; }
        public string Instagram { get; set; }
        public string Pinterest { get; set; }
        public string CharityNavigator { get; set; }
        public string Linkedin { get; set; }
        public string Vimeo { get; set; }
        public string Guidestar { get; set; }
        public string Twitter { get; set; }
        public int OrgID { get; set; }
        public bool EditedOrg { get; set; }
        public Nullable<bool> OriginalOrg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment_Table> Comment_Table { get; set; }
    }
}
