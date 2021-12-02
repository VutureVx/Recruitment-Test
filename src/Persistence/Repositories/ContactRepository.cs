using Vuture.Persistence.Repositories.Interfaces;

namespace Vuture.Persistence.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDbContext _context;

        public ContactRepository(ContactDbContext context)
        {
        }

        void IContactRepository.SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Contact GetContactById(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteContactById(int Id)
        {
            throw new NotImplementedException();
        }

        public Contact CreateContact(Contact Contact)
        {
            throw new NotImplementedException();
        }

        public Contact UpdateContact(Contact Contact)
        {
            throw new NotImplementedException();
        }
    }
}