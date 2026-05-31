using System;
using System.Data;
using System.Linq;

public class Example
{
    public static void Main()
    {







        DataTable EmployeesDataTable = new DataTable("EmployeesDataTable");
        EmployeesDataTable.Columns.Add("ID", typeof(int)); 
        EmployeesDataTable.Columns.Add("Name", typeof(string)); 
        EmployeesDataTable.Columns.Add("Country", typeof(string));
        EmployeesDataTable.Columns.Add("Salary", typeof(Double));
        EmployeesDataTable.Columns.Add("Date", typeof(DateTime));


        EmployeesDataTable.Rows.Add(1, "Muhammed", "Jordan", 5000, DateTime.Now);
        EmployeesDataTable.Rows.Add(2, "Ali Maher", "Eygpt", 500, DateTime.Now);
        EmployeesDataTable.Rows.Add(3, "Lina Kamal", "Jordan", 2000, DateTime.Now);
        EmployeesDataTable.Rows.Add(4, "Fadi Jamal", "Syria", 400, DateTime.Now);
        EmployeesDataTable.Rows.Add(5, "Omar Mahmoud", "Syria", 1000, DateTime.Now);





        Console.WriteLine("\n Employees List: \n");
        foreach (DataRow RecordRow in EmployeesDataTable.Rows)
        {

            Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4}\t",
                RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

        }


        DataTable DepartmentsDataTable = new DataTable("DepartmentsDataTable");
        DepartmentsDataTable.Columns.Add("DepartmentID", typeof(int));
        DepartmentsDataTable.Columns.Add("Name", typeof(string));


        DepartmentsDataTable.Rows.Add(1, "Marketing");
        DepartmentsDataTable.Rows.Add(2, "IT");
        DepartmentsDataTable.Rows.Add(3, "HR");


        Console.WriteLine("\n Departments List:");

        foreach(DataRow RecordRow in DepartmentsDataTable.Rows)
        {
            Console.WriteLine("DepartmentID: {0}\t Name : {1} ", RecordRow["DepartmentID"], RecordRow["Name"]);

        }


        DataSet dataSet1 = new DataSet();

        dataSet1.Tables.Add(EmployeesDataTable);
        dataSet1.Tables.Add(DepartmentsDataTable);

        Console.WriteLine("\n Printing Employees Data From the Dataset\n");
        foreach(DataRow RecordRow in dataSet1.Tables["EmployeesDataTable"].Rows)
        {
            Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4}\t",
                RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

        }


        foreach (DataRow RecordRow in dataSet1.Tables["DepartmentsDataTable"].Rows)


        {
            Console.WriteLine("DepartmentID: {0}\t Name : {1} ", RecordRow["DepartmentID"], RecordRow["Name"]);

        }



        Console.ReadKey();

    }
}
