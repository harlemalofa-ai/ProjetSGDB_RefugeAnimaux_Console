namespace RefugeAnimaux.coucheAccesBD
{
    public static class ConfigurationConnexion
    {
        public static string ObtenirChaineConnexion()
        {
            string? chaineComplete = Environment.GetEnvironmentVariable("REFUGE_ANIMAUX_DB");

            if (!string.IsNullOrWhiteSpace(chaineComplete))
            {
                return chaineComplete;
            }

            string host = Environment.GetEnvironmentVariable("REFUGE_DB_HOST") ?? "localhost";
            string database = Environment.GetEnvironmentVariable("REFUGE_DB_NAME") ?? "refuge_animaux";
            string username = Environment.GetEnvironmentVariable("REFUGE_DB_USER") ?? "postgres";
            string? password = Environment.GetEnvironmentVariable("REFUGE_DB_PASSWORD");

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new InvalidOperationException(
                    "La variable d'environnement REFUGE_DB_PASSWORD doit être définie avant de lancer l'application."
                );
            }

            return
                $"Host={host};" +
                $"Database={database};" +
                $"Username={username};" +
                $"Password={password}";
        }
    }
}
