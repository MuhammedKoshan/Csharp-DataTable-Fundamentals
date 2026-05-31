using System;
using System.Data;
using System.Linq;

public class Example
{
    public static void Main()
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

        DataView EmployeesDataView1 = EmployeesDataTable.DefaultView;

        Console.WriteLine("\nEmployees List From Data View:\n");



        EmployeesDataView1.RowFilter = "Country='Jordan' or Country= 'Eygpt'"
;


        for (int i=0; i<EmployeesDataView1.Count; i++)
        {

            Console.WriteLine("{0}, {1}, {2}, {3}", EmployeesDataView1[i][0], EmployeesDataView1[i][1],
                EmployeesDataView1[i][2], EmployeesDataView1[i][3]);


        }










        Console.ReadKey();

    }
}
