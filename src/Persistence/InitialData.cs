namespace Vuture.Persistence
{
    public static class InitialData
    {
        public static void PopulateDb(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<ContactDbContext>() ?? throw new InvalidOperationException();
            if (context != null && !context.Contacts.Any())
            {
                Console.WriteLine("Populating the database...");
                context.Contacts.AddRange(
                    new Contact
                    {
                        FirstName = "Charly",
                        LastName = "Webster",
                        Title = "Head of Engineering",
                        EmailAddress = "charly.webster@vutu.re",
                        Company = "Vuture"
                    },
                    new Contact
                    {
                        FirstName = "Simon",
                        LastName = "Humphries",
                        Title = "Engineering Team Lead",
                        EmailAddress = "simon.humphries@vutu.re",
                        Company = "Vuture"
                    },
                    new Contact
                    {
                        FirstName = "Tufan",
                        LastName = "Unal",
                        Title = "CTO/Founder",
                        EmailAddress = "tufan.unal@vutu.re",
                        Company = "Vuture"
                    },
                    new Contact
                    {
                        FirstName = "Tom",
                        LastName = "Janofsky",
                        Title = "Group CTO",
                        EmailAddress = "tjanofsky@campaignmonitor.com",
                        Company = "CM Group"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}