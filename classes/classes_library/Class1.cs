using System;

namespace classes_library
{
    public class Worker
    {
        public string PassNum = "00000000";
        public Profile profile;

        public void ComeToWork ()
        {
            Console.WriteLine("I have already coming!");
        }

        public static void GetAwayFromWork()
        {
            Console.WriteLine("I have already been going home!");
        }

    }

    public class Profile
    {
        public string name;
        public string surname;
        public int age;
        public char sex;
        public string university;
        public int salary;


        public void ShowData()
        {
            Console.WriteLine("Name: {0} \n" +
                              "Surname: {1} \n" +
                              "Age: {2} \n" +
                              "Sex: {3} \n" +
                              "University: {4} \n" +
                              "Salary: {5} \n", name, surname,
                              age.ToString(), sex, university, salary.ToString());
        }

    }
}
