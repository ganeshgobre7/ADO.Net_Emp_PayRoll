using System;

namespace EmpPayRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE EMPLOYEE PAY ROLL PROGRAM!");
            EmployeeRepo employeeRepo = new EmployeeRepo();
            employeeRepo.DBconnection();
        }
    }
}
