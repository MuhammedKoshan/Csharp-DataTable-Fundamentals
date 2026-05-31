using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataTable EmployeesDataTable = new DataTable();
            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(Double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));



            EmployeesDataTable.Rows.Add(1, "Muhammed", "Syria", 502.24, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Hasan", "Jordan", 2402, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "KOKO", "Jordan", 521, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "MOMO", "Jordan", 282, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Muaz", "Italy", 1254, DateTime.Now);


            Console.WriteLine("\n Emplployess List:\n");

            foreach(DataRow RecordRow in EmployeesDataTable.Rows)
            {
                Console.WriteLine("ID: {0}\t Name : {1}\t Country: {2}\t Salary: {3}\t Date {4} ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            }



            int EmployeesCount = 0;
            double TotalSalaries = 0;
            double AverageSalaries = 0;
            double MinSalary = 0;
            double MaxSalary = 0;


            EmployeesCount = EmployeesDataTable.Rows.Count;
            TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", string.Empty));
            AverageSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", string.Empty));
            MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", string.Empty));
            MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", string.Empty));


            Console.WriteLine("\nCount of Employees = " + EmployeesCount);
            Console.WriteLine("Total Employee Salaries = " + TotalSalaries);
            Console.WriteLine("Average Employee Salaries = " + AverageSalaries);
            Console.WriteLine("Minimum Salary = " + MinSalary);
            Console.WriteLine("Maximum Salary = " + MaxSalary);




            int ResultCount = 0;

            DataRow[] ResultRows;

            ResultRows = EmployeesDataTable.Select("Country='Jordan'");


            Console.WriteLine("\n\nFilter \"Jordan\" Employees\n");



            foreach (DataRow RecordRow in ResultRows)
            {
                Console.WriteLine("ID: {0}\t Name : {1}\t Country: {2}\t Salary: {3}\t Date {4} ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            }

            ResultCount = ResultRows.Count();
            TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "Country='Jordan'"));
            AverageSalaries = Convert.ToDouble(EmployeesDataTable.Compute("Avg(Salary)", "Country='Jordan'"));
            MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "Country='Jordan'"));
            MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "Country='Jordan'"));



            Console.WriteLine("\nCount of Employees = " + ResultCount);
            Console.WriteLine("Total Employee Salaries = " + TotalSalaries);
            Console.WriteLine("Average Employee Salaries = " + AverageSalaries);
            Console.WriteLine("Minimum Salary = " + MinSalary);
            Console.WriteLine("Maximum Salary = " + MaxSalary);



            ResultRows = EmployeesDataTable.Select("Country='Jordan' or Country='Italy'");

            Console.WriteLine("\n\nFilter \"Jordan\" Or \"Italy\" Employees\n");


            foreach (DataRow RecordRow in ResultRows)
            {
                Console.WriteLine("ID: {0}\t Name : {1}\t Country: {2}\t Salary: {3}\t Date {4} ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            }


            ResultCount = ResultRows.Count();
            TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "Country='Jordan' or Country='Italy'"));
            AverageSalaries = Convert.ToDouble(EmployeesDataTable.Compute("Avg(Salary)", "Country='Jordan' or Country='Italy'"));
            MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "Country='Jordan' or Country='Italy'"));
            MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "Country='Jordan' or Country='Italy'"));


            Console.WriteLine("\nCount of Employees = " + ResultCount);
            Console.WriteLine("Total Employee Salaries = " + TotalSalaries);
            Console.WriteLine("Average Employee Salaries = " + AverageSalaries);
            Console.WriteLine("Minimum Salary = " + MinSalary);
            Console.WriteLine("Maximum Salary = " + MaxSalary);


            ResultRows = EmployeesDataTable.Select("ID =1");
            Console.WriteLine("ID = 1 ");



            foreach (DataRow RecordRow in ResultRows)
            {
                Console.WriteLine("ID: {0}\t Name : {1}\t Country: {2}\t Salary: {3}\t Date {4} ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            }


            ResultCount = ResultRows.Count();
            TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "ID =1 "));
            AverageSalaries = Convert.ToDouble(EmployeesDataTable.Compute("Avg(Salary)", "ID =1 "));
            MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "ID =1 "));
            MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "ID =1 "));


            Console.WriteLine("\nCount of Employees = " + ResultCount);
            Console.WriteLine("Total Employee Salaries = " + TotalSalaries);
            Console.WriteLine("Average Employee Salaries = " + AverageSalaries);
            Console.WriteLine("Minimum Salary = " + MinSalary);
            Console.WriteLine("Maximum Salary = " + MaxSalary);

        }
    }
}
