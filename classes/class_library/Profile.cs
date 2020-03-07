using System;
using System.Collections.Generic;
using System.Text;




namespace classes_library
{
    public class Profile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public string University { get; set; }
        public int Salary { get; set; }


        public override string ToString()
        {
            return String.Format("Name: {0} \n" +
                              "Surname: {1} \n" +
                              "Age: {2} \n" +
                              "Sex: {3} \n" +
                              "University: {4} \n" +
                              "Salary: {5} \n", Name, Surname,
                              Age.ToString(), Sex, University, Salary.ToString());
        }


    }
}
