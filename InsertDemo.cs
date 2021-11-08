// using System;
// // Step 1: 
// using System.Data.SqlClient;

//  class Program{
//     static void Main()
//     {
//     //Step 2:
//  SqlConnection connection = new  SqlConnection("data source=LAPTOP-53S2KQS8;initial catalog=practicedb1;integrated security=true");
// // Step 3: 
// SqlCommand command = new  SqlCommand("Insert into Employee(id, name, address, salary) values (102,'Ajay','Delhi',12000)", connection);
// connection.Open();
// int res = command.ExecuteNonQuery();
// if(res>0)
// Console.WriteLine("Record is inserted");
// connection.Close();
// command.Dispose();
// connection.Dispose();
//     }
//  }