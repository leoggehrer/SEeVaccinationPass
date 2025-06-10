//@CodeCopy
namespace eVaccinationPass.Common.Contracts
{
    public partial interface ISettings
    {
        string? this[string key] { get; }
    }
}
