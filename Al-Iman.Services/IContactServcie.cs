using Al_Iman.Utilities;
using Al_Iman.ViewModels;
using System;

namespace Al_Iman.Services
{
    public interface IContactService
    {
        PagedResult<ContactViewModel> GetAll(int pageNumber, int pageSize);

        ContactViewModel GetContactById(int contactId);

        void UpdateContact(ContactViewModel contact);

        void InsertContact(ContactViewModel contact);

        void DeleteContact(int id);
    }
}
