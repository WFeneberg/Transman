using System;

namespace Transman.Person;

internal sealed class Person
{
    public Guid Id { get; init; }

    public string FirstName { get; init; }

    public string LastName { get; init; }
    
    public DateTime CreateDateTime { get; init; }

    public string Title { get; set; }

    public string AcademicTitle { get; set; }

    public string Street { get; set; }

    public string AddressAdditionalLine { get; set; }

    public string PostBox { get; set; }

    public string PostBoxPostalCode { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }

    public string State { get; set; }

    public string City { get; set; }

    public bool SendPostbox { get; set; }

    public DateTime ModifyDateTime { get; set; }

    public string CreateModifyUser { get; set; }

    public bool Inactive { get; set; }

    public DateTime? InactiveDateTime { get; set; }

    public bool PublishAddressChange { get; set; }
    
    public string FullName => LastName + " " + FirstName;

    private Person(Guid id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        CreateDateTime = DateTime.Now;
    }
    
    internal static Person Register(string firstName, string lastName) =>
        new(Guid.NewGuid(), firstName, lastName);

}