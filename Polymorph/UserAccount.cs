namespace Polymorph
{
    public class UserAccount
    {
        public const double PI = 3.14;
        
        private readonly IContactService _contactService;

        public UserAccount(IContactService noteContact)
        {
            _contactService = noteContact;
            string[] names = new string[10];

            Program.Main(names);
           
        }

      
    }

}
