using System;
using System.Data.SqlClient;
 class Program
 {
   static void Main()
   {
     char choice='y';
     while(choice=='y')
     {
     Console.WriteLine("1. Insert Record");
     Console.WriteLine("2. Search Record");
     Console.WriteLine("3. Edit Record");
     Console.WriteLine("4. Delete Record");
     Console.WriteLine("5. List of Employees");
     int ch;
     Console.WriteLine("Enter your choice");
     ch = Byte.Parse(Console.ReadLine());
  switch (ch)
  {
    case 1 :   {
              //  Console.WriteLine("Enter ID");
              //  int id = Byte.Parse(Console.ReadLine());
              //  Console.WriteLine("Enter Name");
              //  string name = Console.ReadLine();
              //  Console.WriteLine("Enter Address");
              //  string address = Console.ReadLine();
              //  Console.WriteLine("Enter Salary");
              //  int salary = Int32.Parse(Console.ReadLine());
          
               InsertRecord();
               break;
                }
                case 2: { GetEmployeeById();
                break;
                }
                 case 3 :   {
              //  Console.WriteLine("Enter ID for which to edit record");
              //  int id = Byte.Parse(Console.ReadLine());
              //  Console.WriteLine("Enter Name");
               
              //  string address = Console.ReadLine();
              //  Console.WriteLine("Enter Salary");
              //  int salary = Int32.Parse(Console.ReadLine());
          
               EditRecord();
               break;
                }
                    case 4 :   {
              //  Console.WriteLine("Enter ID for which to edit record");
              //  int id = Byte.Parse(Console.ReadLine());
              //  Console.WriteLine("Enter Name");
               
              //  string address = Console.ReadLine();
              //  Console.WriteLine("Enter Salary");
              //  int salary = Int32.Parse(Console.ReadLine());
          
               DeleteRecord();
               break;
                }
                case 5:
                {
                  GetEmployees();
                  break;
                }

   }
   Console.WriteLine("Do you want to repeat any task");
   choice = Char.Parse(Console.ReadLine());
  }
 }

   static void InsertRecord()
   {SqlConnection connection = new  SqlConnection("data source=LAPTOP-53S2KQS8;initial catalog=practicedb1;integrated security=true");

    SqlCommand command = new  SqlCommand("Insert into Employee(id, name, address, salary) values (104,'Harpreet','Delhi',9000)", connection);
    connection.Open();
    int res = command.ExecuteNonQuery();
    if(res>0)
        Console.WriteLine("Record is inserted");
        connection.Close();
        command.Dispose();
        connection.Dispose();
      
   }

    static void EditRecord()
   {SqlConnection connection = new  SqlConnection("data source=LAPTOP-53S2KQS8;initial catalog=practicedb1;integrated security=true");

    SqlCommand command = new  SqlCommand("update Employee set address = 'N Delhi' , salary = 10000 where id=101", connection);
    connection.Open();
    int res = command.ExecuteNonQuery();
    if(res>0)
        Console.WriteLine("Record is updated");
        connection.Close();
        command.Dispose();
        connection.Dispose();
      
   }
 
  static void DeleteRecord()
   {SqlConnection connection = new  SqlConnection("data source=LAPTOP-53S2KQS8;initial catalog=practicedb1;integrated security=true");

    SqlCommand command = new  SqlCommand("delete Employee where id=100", connection);
    connection.Open();
    int res = command.ExecuteNonQuery();
    if(res>0)
        Console.WriteLine("Record is deleted");
        connection.Close();
        command.Dispose();
        connection.Dispose();
      
   }
   static void GetEmployeeById()
   {SqlConnection connection = new  SqlConnection("data source=LAPTOP-53S2KQS8;initial catalog=practicedb1;integrated security=true");

     SqlCommand command = new    SqlCommand("Select * from Employee where id=101", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
              reader.Read();
                
                     
                    for(int i=0;i<reader.FieldCount ;i++)
                    Console.Write(reader[i] + " ");
                    Console.WriteLine();
                }
            
            else 
            {
                Console.WriteLine("There are no records");
            }
            reader.Close();
            connection.Close();
            // Unmanaged Code
            reader.Dispose();
            command.Dispose();
            connection.Dispose();
      
   }
static void GetEmployees()
   {SqlConnection connection = new  SqlConnection("data source=LAPTOP-53S2KQS8;initial catalog=practicedb1;integrated security=true");

     SqlCommand command = new    SqlCommand("Select * from Employee", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
              while(reader.Read())
              {
                
                     
                    for(int i=0;i<reader.FieldCount ;i++)
                    Console.Write(reader[i] + " ");
                    Console.WriteLine();
                }
            }
            else 
            {
                Console.WriteLine("There are no records");
            }
            reader.Close();
            connection.Close();
            // Unmanaged Code
            reader.Dispose();
            command.Dispose();
            connection.Dispose();
      
   }

 }