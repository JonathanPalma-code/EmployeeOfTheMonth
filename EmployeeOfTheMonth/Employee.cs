﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOfTheMonth
{
  class Employee
  {
    public int Id { get; private set; }
    public string Name { get; set; }
    public double Salary { get; private set; }

    public Employee(int id, string name, double salary)
    {
      Id = id;
      Name = name;
      Salary = salary;
    }
    public void IncreaseSalary(double percentage)
    {
      Salary += Salary * percentage / 100;
    }

    public override string ToString() => $"{Id}, " +
             $"{Name}, " +
             $"£{Salary.ToString("f2")}";
  }
}