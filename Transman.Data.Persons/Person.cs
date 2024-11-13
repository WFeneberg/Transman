using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transman.Data.Persons;

public class Person
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long PersonId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
    
    public DateTime CreateDateTime { get; set; }

    // public string Title { get; set; }
    //
    // public string AcademicTitle { get; set; }
    //
    // public string Street { get; set; }
    //
    // public string AddressAdditionalLine { get; set; }
    //
    // public string PostBox { get; set; }
    //
    // public string PostBoxPostalCode { get; set; }
    //
    // public string PostalCode { get; set; }
    //
    // public string Country { get; set; }
    //
    // public string State { get; set; }
    //
    // public string City { get; set; }
    //
    // public bool SendPostbox { get; set; }
    //
    // public DateTime ModifyDateTime { get; set; }
    //
    // public string CreateModifyUser { get; set; }
    //
    // public bool Inactive { get; set; }
    //
    // public DateTime? InactiveDateTime { get; set; }
    //
    // public bool PublishAddressChange { get; set; }
    //
    // public string FullName => LastName + " " + FirstName;

}