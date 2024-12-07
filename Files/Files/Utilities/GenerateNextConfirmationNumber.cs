using Files.DAL;

namespace Files.Utilities
{
    public class GenerateNextConfirmationNumber
    {
        public static int GetNextConfirmationNumber(AppDbContext context)
        {
            const int START_NUMBER = 21936; // Starting number for confirmation numbers

            int maxConfirmationNumber = context.Reservations.Any()
                ? context.Reservations.Max(r => r.ConfirmationNumber)
                : START_NUMBER - 1;

            // Ensure no duplicates and always increment
            return maxConfirmationNumber + 1;
        }
    }
}

