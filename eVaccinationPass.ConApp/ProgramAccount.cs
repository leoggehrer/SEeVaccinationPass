#if ACCOUNT_ON
namespace eVaccinationPass.ConApp
{
    partial class Program
    {
        /// <summary>
        /// Gets or sets the SA user.
        /// </summary>
        private static string SAUser => "SysAdmin";
        /// <summary>
        /// Gets or sets the system administrator email address.
        /// </summary>
        private static string SAEmail => "SysAdmin@gmx.at";
        /// <summary>
        /// Gets the password for Sa account.
        /// </summary>
        private static string SAPwd => "1234SysAdmin";

        /// <summary>
        /// The username of the AppAdmin user.
        /// </summary>
        /// <value>The value is fixed as "AppAdmin".</value>
        private static string AAUser => "AppAdmin";
        /// <summary>
        /// Gets the email address for the AppAdmin eVaccinationPass.
        /// </summary>
        private static string AAEmail => "AppAdmin@gmx.at";
        /// <summary>
        /// Gets or sets the password for the AaPwd.
        /// </summary>
        private static string AAPwd => "1234AppAdmin";
        /// <summary>
        /// Gets the value "AppAdmin" representing the AA role.
        /// </summary>
        private static string AARole => "AppAdmin";

        /// <summary>
        /// Gets the AppUser property.
        /// </summary>
        private static string VOUser => "VaccinationOffice";
        /// <summary>
        /// Represents the email address used by the application.
        /// </summary>
        private static string VOEmail => "VaccinationOffice@gmx.at";

        /// <summary>
        /// Gets or sets the application password.
        /// </summary>
        private static string VOPwd => "1234VaccinationOffice";
        /// <summary>
        /// Gets the application role.
        /// </summary>
        private static string VORole => "VaccinationOffice";

        /// <summary>
        /// Gets the AppUser property.
        /// </summary>
        private static string EXUser => "Executive";
        /// <summary>
        /// Represents the email address used by the application.
        /// </summary>
        private static string EXEmail => "Executive@gmx.at";

        /// <summary>
        /// Gets or sets the application password.
        /// </summary>
        private static string EXPwd => "1234Executive";
        /// <summary>
        /// Gets the application role.
        /// </summary>
        private static string EXRole => "Executive";

        static partial void CreateAccounts()
        {
            Task.Run(async () =>
            {
                await Logic.AccountAccess.InitAppAccessAsync(SAUser, SAEmail, SAPwd);
                await AddAppAccessAsync(SAEmail, SAPwd, AAUser, AAEmail, AAPwd, 30, AARole);
                await AddAppAccessAsync(SAEmail, SAPwd, VOUser, VOEmail, VOPwd, 35, VORole);
                await AddAppAccessAsync(SAEmail, SAPwd, EXUser, EXEmail, EXPwd, 35, EXRole);
                await AddAppAccessAsync(SAEmail, SAPwd, "g.gehrer", "   g.gehrer@htl-leonding.ac.at ", VOPwd, 35, VORole);
            }).Wait();
        }

        /// <summary>
        /// Adds application access for a user.
        /// </summary>
        /// <param name="loginEmail">The email of the user logging in.</param>
        /// <param name="loginPwd">The password of the user logging in.</param>
        /// <param name="user">The username of the user being granted access.</param>
        /// <param name="email">The email of the user being granted access.</param>
        /// <param name="pwd">The password of the user being granted access.</param>
        /// <param name="timeOutInMinutes">The timeout duration in minutes for the access.</param>
        /// <param name="roles">A string array representing the roles for the user.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        private static async Task AddAppAccessAsync(string loginEmail, string loginPwd, string user, string email, string pwd, int timeOutInMinutes, params string[] roles)
        {
            var login = await Logic.AccountAccess.LoginAsync(loginEmail, loginPwd, string.Empty);

            await Logic.AccountAccess.AddAppAccessAsync(login!.SessionToken, user, email, pwd, timeOutInMinutes, roles);
            await Logic.AccountAccess.LogoutAsync(login!.SessionToken);
        }
    }
}
#endif
