// using System;
// // Step No 1
// using System.Data;
// using System.Data.SqlClient;

// namespace ADODemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Step 2
//             // Create Connection Object
//             string connectionString =  "data source=LAPTOP-53S2KQS8;initial catalog=PracticeDb1;integrated security=true";
//             // SqlConnection connection= new   SqlConnection();
//             // connection.ConnectionString= connectionString;
//             SqlConnection connection = new SqlConnection(connectionString);
//             // Step 3: 
//             // SqlCommand command = new SqlCommand();
//             // command.CommandText ="Select * from batch";
//             // command.Connection = connection;

//             SqlCommand command = new    SqlCommand("Select * from Employee", connection);
//             connection.Open();
//             SqlDataReader reader = command.ExecuteReader();
//             if(reader.HasRows)
//             {
//                 while(reader.Read())
//                 {
//                     // Console.WriteLine(reader[0] + " " + reader[1]);
//                     // Console.WriteLine(reader["id"] + " " + reader["name"]);
                    
//                     for(int i=0;i<reader.FieldCount ;i++)
//                     Console.Write(reader[i] + " ");
//                     Console.WriteLine();
//                 }
//                 }
            
//             else 
//             {
//                 Console.WriteLine("There are no records");
//             }
//             reader.Close();
//             connection.Close();
//             // Unmanaged Code
//             reader.Dispose();
//             command.Dispose();
//             connection.Dispose();

 
//     }
// }
