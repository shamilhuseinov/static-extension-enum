using System;
namespace test
{
	public class User
	{
        public string NAME { get; set; }
		public string SURNAME { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }
        private string pin;
        public string  PIN
        {
            get
            {
                return pin;
                
            }
            set
            {
                if (value.ChechkPIN()==true)
                {
                    pin = value;
                }
            }
        }

        public string GetDetails()
        {
            return $"{NAME}, {SURNAME}, {RegistrationMonth}, {PIN}";
        }

        public User(string Name, string Surname, RegistrationMonth registrationMonth, string pin)
        {
            NAME = Name;
            SURNAME = Surname;
            PIN = pin;
            RegistrationMonth = registrationMonth;
        }
    }
    public enum RegistrationMonth
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}

