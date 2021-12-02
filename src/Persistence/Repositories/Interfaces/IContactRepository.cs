namespace Vuture.Persistence.Repositories.Interfaces
{
    public interface IContactRepository
    {
        void SaveChanges();
        Contact GetContactById(int Id);
        void DeleteContactById(int Id);
        Contact CreateContact(Contact Contact);
        Contact UpdateContact(Contact Contact);
    }
}