namespace Polymorph
{
    public interface IContactService
    {
        public Contact[] MyContact { get; }
        void Add(Contact contact);
        void Edit(Contact contact);
        void Remove(Contact contact);
 
    }

}
