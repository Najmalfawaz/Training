using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn= new SqlConnection())
            {
                
                conn.ConnectionString = "Server=P-05;Database=Student_management;user id=sa;password=@6T$qL#n3W{}.@;Trusted_Connection=False;";
                conn.Open ();


                /*INSERTION COMMAND*/

                /* SqlCommand insertCommand = new SqlCommand("INSERT INTO STUDENT(STUD_NAME,ROLL_NO,DISTRICT)VALUES(@0,@1,@2)", conn);

                 insertCommand.Parameters.Add(new SqlParameter("0","Sreelakshmi"));
                 insertCommand.Parameters.Add(new SqlParameter("1", 5));
                 insertCommand.Parameters.Add(new SqlParameter("2", "Calicut"));

                 Console.WriteLine("Commands Executed" + insertCommand.ExecuteNonQuery());
                 Console.WriteLine("Done!");
                 Console.ReadLine();
                 Console.Clear();
                 */

                /*SELECTION COMMAND*/

                /*
                SqlCommand selectCommand = new SqlCommand("SELECT *FROM STUDENT", conn);
                selectCommand.Parameters.Add(new SqlParameter("0", 1));

                using(SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    Console.WriteLine("ID\t STUD__NAME\t ROLL_NO\t DISTRICT");
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}\t {1}\t {2}\t {3}\t",
                            reader[0], reader[1], reader[2], reader[3]));
                    }
                }
                Console.WriteLine("Data Displayed!");
                Console.ReadLine();
                Console.Clear();*/



                /* FOR LOOP*/


                /*
                string name;
                int RollNo;
                String District;
                int n;
                Console.WriteLine("No. of data: ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                { 
                Console.WriteLine("Enter the Name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter the Roll_no");
                RollNo=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the District");
                District = Console.ReadLine();

                SqlCommand insertCommand = new SqlCommand("INSERT INTO STUDENT(STUD_NAME,ROLL_NO,DISTRICT)VALUES(@0,@1,@2)", conn);
                insertCommand.Parameters.Add(new SqlParameter("0", name));
                insertCommand.Parameters.Add(new SqlParameter("1", RollNo));
                insertCommand.Parameters.Add(new SqlParameter("2", District));

                Console.WriteLine("Commands Executed" + insertCommand.ExecuteNonQuery());
                Console.ReadLine();
                
                }*/

                /*INSERTION STORED PROCEDURE*/

                /*string name;
                int RollNo;
                String District;
                int n;
                Console.WriteLine("No. of data: ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter the Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the Roll_no");
                    RollNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the District");
                    District = Console.ReadLine();

                    SqlCommand insertCommand = new SqlCommand();
                    insertCommand.Connection = conn;
                    insertCommand.CommandType = CommandType.StoredProcedure;
                    insertCommand.CommandText = "Insertdetails";
                    insertCommand.Parameters.Add(new SqlParameter("@STUD_NAME",name));
                    insertCommand.Parameters.Add(new SqlParameter("@ROLL_NO",RollNo));
                    insertCommand.Parameters.Add(new SqlParameter("@District",District));
                    Console.WriteLine("INSERTION DONE!" + insertCommand.ExecuteNonQuery());
                    Console.ReadLine();
                }
                */

                /*SELECTION COMMAND*/
                /*string name;
                Console.WriteLine("Enter the Name:");
                name = Console.ReadLine();
                SqlCommand selectCommand = new SqlCommand();
                selectCommand.Connection = conn;
                selectCommand.CommandType = CommandType.StoredProcedure;
                selectCommand.CommandText = "Selecttable";
                selectCommand.Parameters.Add(new SqlParameter("@STUD_NAME", name));

                using(SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    Console.WriteLine("ID\t STUD__NAME\t ROLL_NO\t DISTRICT");
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}\t {1}\t \t{2}\t \t{3}\t",
                            reader[0], reader[1], reader[2], reader[3]));
                    }
                }
                Console.WriteLine("Data Displayed!");*/

                /*UPDATE COMMAND*/

                //string name;
                //int id;
                //Console.WriteLine("Enter the Name:");
                //name = Console.ReadLine();
                //Console.WriteLine("Enter id:");
                //id = Convert.ToInt32(Console.ReadLine());
                //SqlCommand updateCommand = new SqlCommand();
                //updateCommand.Connection = conn;
                //updateCommand.CommandType = CommandType.StoredProcedure;
                //updateCommand.CommandText = "Updatetable";
                //updateCommand.Parameters.Add(new SqlParameter("@NAME", name));
                //updateCommand.Parameters.Add(new SqlParameter("@ID", id));
                //Console.WriteLine("UPDATE DONE!" + updateCommand.ExecuteNonQuery());
                //Console.ReadLine();

                /*DELETE COMMAND*/
               
                
                int id;
                Console.WriteLine("Enter id:");
                id = Convert.ToInt32(Console.ReadLine());
                SqlCommand deleteCommand = new SqlCommand();
                deleteCommand.Connection = conn;
                deleteCommand.CommandType = CommandType.StoredProcedure;
                deleteCommand.CommandText = "Deletetable";
                deleteCommand.Parameters.Add(new SqlParameter("@ID", id));
                Console.WriteLine("FIELD DELETED" + deleteCommand.ExecuteNonQuery());
                Console.ReadLine();

                conn.Close();
            }

        }
    }
}
