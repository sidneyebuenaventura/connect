using EfVueMantle;

namespace DidacticVerse.Models;

[EfVueSource(typeof(AccountModel))]
public class AccountDetailDTO: DataTransferObjectBase
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? EmailAddress { get; set; }
    public bool ConfirmAge { get; set; }
    public bool TermsConditions { get; set; }
}
