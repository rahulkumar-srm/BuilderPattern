using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class User
    {
        private readonly string firstName;
        private readonly string lastName;
		private readonly int age;
		private readonly string phone;
		private readonly string address;

		private User(UserBuilder builder)
		{
			firstName = builder.FirstName;
			lastName = builder.LastName;
			age = builder.Age;
			phone = builder.Phone;
			address = builder.Address;
		}

		public string GetFirstName()
        {
			return firstName;
        }

		public string GetLastName()
		{
			return lastName;
		}

		public int GetAge()
		{
			return age;
		}
		public string GetPhone()
		{
			return phone;
		}
		public string GetAddress()
		{
			return address;
		}

		public class UserBuilder
		{
			public string FirstName { get; private set; }
			public string LastName { get; private set; }
			public int Age { get; private set; }
			public string Phone { get; private set; }
			public string Address { get; private set; }

			public UserBuilder(string firstName, string lastName)
			{
				FirstName = firstName;
				LastName = lastName;
			}
			public UserBuilder SetAge(int age)
			{
				Age = age;
				return this;
			}
			public UserBuilder SetPhone(string phone)
			{
				Phone = phone;
				return this;
			}
			public UserBuilder SetAddress(string address)
			{
				Address = address;
				return this;
			}
			public User Build()
			{
				User user = new User(this);
				return user;
			}
		}
	}
}
