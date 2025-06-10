#if GENERATEDCODE_ON
using eVaccinationPass.Logic.Contracts;

namespace eVaccinationPass.Logic.Entities
{
    partial class Vaccination : IValidatableEntity
    {
        public void Validate(IContext context, EntityState entityState)
        {
            if (ChechSocialNumber(SocialNumber) == false)
            {
                throw new Modules.Exceptions.BusinessRuleException($"Invalid {SocialNumber}.");
            }
        }

        private bool ChechSocialNumber(string socialNumber)
        {
            if (socialNumber.Length != 10 || !socialNumber.All(char.IsDigit)) return false;

            int[] weights = { 3, 7, 9, 0, 5, 8, 4, 2, 1, 6 };
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                int digit = socialNumber[i] - '0';

                sum += digit * weights[i];
            }
            return sum % 11 != 10;
        }
    }
}
#endif