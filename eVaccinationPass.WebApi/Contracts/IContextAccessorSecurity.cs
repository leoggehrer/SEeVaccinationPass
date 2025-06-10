//@CodeCopy
#if ACCOUNT_ON
namespace eVaccinationPass.WebApi.Contracts
{
    partial interface IContextAccessor
    {
        string SessionToken { set; }
    }
}
#endif
