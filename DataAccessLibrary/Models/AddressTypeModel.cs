namespace DataAccessLibrary.Models;

public class AddressTypeModel
{
    public AddressTypeModel() { }

    public AddressTypeModel(string addressTypeName)
    {
        AddressTypeName = addressTypeName;
    }

    public int AddressTypeId { get; set;}

    public string AddressTypeName { get; set; }

    public ICollection<AddressModel> Addresses { get; set; }
}
