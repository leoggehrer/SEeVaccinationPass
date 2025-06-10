namespace eVaccinationPass.Logic.Entities 
{
    /// <summary>
    /// Repräsentiert eine Impfung im eVaccinationPass-System.
    /// </summary>
    [Table("Vaccinations")]
    public partial class Vaccination : EntityObject
    {
        /// <summary>
        /// Datum der Impfung.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Verabreichter Impfstoff.
        /// </summary>
        [MaxLength(512)]
        public string Vaccine { get; set; } = string.Empty;

        /// <summary>
        /// Sozialversicherungsnummer (SVNR) des Patienten.
        /// </summary>
        [MaxLength(10)]
        public string SocialNumber { get; set; } = string.Empty;

        /// <summary>
        /// Vorname des Patienten.
        /// </summary>
        [MaxLength(64)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Nachname des Patienten.
        /// </summary>
        [MaxLength(64)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Name des Arztes, der die Impfung durchgeführt hat.
        /// </summary>
        [MaxLength(64)]
        public string Doctor { get; set; } = string.Empty;

        /// <summary>
        /// Zusätzliche Anmerkungen zur Impfung.
        /// </summary>
        [MaxLength(1024)]
        public string? Note { get; set; }

        // Navigation properties können hier bei Bedarf ergänzt werden
    }
}