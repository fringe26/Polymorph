using System;

namespace Polymorph
{
    public class PhoneContact : IContactService
    {
        private Contact[] _phoneContacts;
        public Contact[] MyContact => _phoneContacts;

        public void Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Edit(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Remove(Contact contact)
        {
            throw new NotImplementedException();
        }
    }

}
