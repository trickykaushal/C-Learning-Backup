using System;
namespace Learning
{
    class Learning
    {
        public static void Main()
        {
            Customer[] cus = new Customer[3];
            cus[0] = new Customer
            {
                Gender = Gender.Male,
                Name = "Kaushal"
            }; 
            cus[1] = new Customer
            {
                Gender = Gender.Female,
                Name = "Manoj"
            };
            cus[2] = new Customer
            {
                Gender = Gender.Unknown,
                Name = "Ranjeet"
            };
            foreach (Customer customer in cus)
            {
                Console.WriteLine("Name={0} and Gender={1}",customer.Name,customer.Gender);


            }

        }
        public string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Male:return "Male";
                case Gender.Female:return "Female";
                case Gender.Unknown:return "Unknown";
                default: return "Unknown Data Type";
                
            }
        }
    }
    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
    public class Customer
    {
        private Gender gender;
        private String _Name;
        public Gender Gender { get => gender; set => gender = value; }
        public string Name { get => _Name; set => _Name = value; }

    }
}