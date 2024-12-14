using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_DataAdapter_DataTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataTable Sports = new DataTable("Sports");

                DataColumn ID = new DataColumn("ID");
                ID.Caption = "ID";
                ID.DataType = System.Type.GetType("System.Int32");   // Method-1: To declear the data type.
                ID.AllowDBNull = false;
                ID.AutoIncrement = true;
                ID.AutoIncrementSeed = 1;
                ID.AutoIncrementStep = 2;
                Sports.Columns.Add(ID);

                DataColumn Name = new DataColumn("Name");
                Name.Caption = "Name";
                Name.DataType = typeof(String);            // Method-2: To declear the data type.
                Name.AllowDBNull = false;
                Name.MaxLength = 50;            // Given a limitation for name string.
                Sports.Columns.Add(Name);

                DataColumn PLR_Count = new DataColumn("PLR_Count");
                //PLR_Count.Caption = "PLR_Count";
                PLR_Count.DataType = typeof(int);
                Name.AllowDBNull = false;
                Sports.Columns.Add(PLR_Count);

                Sports.PrimaryKey = new DataColumn[] { ID };
                DataRow row1 = Sports.NewRow();

                //row1["ID"] = 1;
                row1["Name"] = "Cricket";
                row1["PLR_Count"] = 11;
                Sports.Rows.Add(row1);

                Sports.Rows.Add(null, "Kho-Kho", 10);
                Sports.Rows.Add(null, "Kabbadi", 7);

                foreach (DataRow Row in Sports.Rows)
                {
                    Console.WriteLine(Row["ID"] + " " + Row["Name"] + " " + Row["PLR_Count"]);
                }





            }

            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Console.ReadLine();
        }
    }
}
