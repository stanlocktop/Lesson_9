using System;

class User
{
    public string Login { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"����: {Login}");
        Console.WriteLine($"��'�: {FirstName}");
        Console.WriteLine($"�������: {LastName}");
        Console.WriteLine($"³�: {Age}");
        Console.WriteLine($"���� ���������� ������: {RegistrationDate}");
    }
}