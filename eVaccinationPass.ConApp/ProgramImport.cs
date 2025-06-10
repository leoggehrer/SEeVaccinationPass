#if GENERATEDCODE_ON

namespace eVaccinationPass.ConApp
{
    partial class Program
    {
        static partial void ImportData()
        {
            var idx = 0;
            var context = CreateContext();
            var filePath = Path.Combine("data", "vaccinations_dataset.csv");
            var lines = File.ReadAllLines(filePath);
            var entities = lines.Skip(1)
                                .Select(l => l.Split(';'))
                                .Select(p => new Logic.Entities.Vaccination
                                {
                                    Date = DateTime.Parse(p[0]),
                                    Vaccine = p[1],
                                    SocialNumber = p[2],
                                    FirstName = p[3],
                                    LastName = p[4],
                                    Doctor = p[5],
                                    Note = p[6]

                                }).ToArray();

            foreach (var entity in entities)
            {
                try
                {
                    idx++;
                    context.VaccinationSet.Add(entity);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    context.RejectChanges();
                    Console.WriteLine($"Error in line {idx}: {ex.Message}");
                }

            }
        }
    }
}
#endif