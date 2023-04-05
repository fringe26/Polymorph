using System;

namespace Polymorph
{
    public class NoteContact : IContactService
    {
        private Contact[] _myContact;
        public Contact[] MyContact => _myContact;
        

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
