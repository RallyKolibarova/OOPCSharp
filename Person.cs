using System;
using System.Collections.Generic;

namespace DefineClassPerson
{
	public class Person
	{

		private string name;
		private int age;

		public string Name 
		{
			get{ return this.name; }

			set{ this.name = value; }
		}

		public int Age
		{
			get{ return this.age; }

			set{ this.age = value; }
		}


		public Person()
		{
			this.Age = 1;
		}

		public Person(int age):this()
		{
			this.Name = "No name";
		}

		public Person(string name, int age)
		{
			
			this.Name = name;
			this.Age = age;


		}


		public override string ToString ()
		{
			return $"Name \n {Name} \n Age \n {Age}";
		}

	}
}
