using System;
using System.Collections.Generic;

namespace EmployeeOfTheMonth
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("How many employees will be registered? ");
      int nEmployees = int.Parse(Console.ReadLine());

      List<Employee> list = new List<Employee>();

      for (int i = 1; i <= nEmployees; i++)
      {
        Console.WriteLine($"\nEmployee #{i}");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Salary: £");
        double salary = double.Parse(Console.ReadLine());
        int id = i;
        list.Add(new Employee(id, name, salary));
      }

      Console.Write("\nEnter the employee id that will have salary increased: ");
      int selectId = int.Parse(Console.ReadLine());

      Employee emp = list.Find(x => x.Id == selectId);
      if (emp != null)
      {
        Console.Write("Enter the percentage: ");
        int percentage = int.Parse(Console.ReadLine());
        emp.IncreaseSalary(percentage);
      }
      else
      {
        Console.WriteLine("Employee doesn't exist.");
      }

      Console.WriteLine("\nUpdated List of employees:");

      foreach (Employee detail in list)
      {
        Console.WriteLine(detail);
      }
    }
  }
}
