//Write a text file - Version 2
Using System;
Using System.IO;
Using System.Text;
Namespace readwriteapp
{
    Class Class1
    {
        [STAThread]
        Static void Main(String[] args)
        {
            Int64 x;
            Try
            {
                //Open the File
                StreamWriter sw = New StreamWriter("C:/Users/Full Stack Developer/Downloads/Phito/journal/Journal.txt", True, Encoding.ASCII);
               
               ////////////////////////////////////////////////////////////
                DateTime dateTime = dateTime.UtcNow.Date;
                String stopWriting = "stop";
                String journal = "";
                StringComparison comp = StringComparison.OrdinalIgnoreCase;
                Boolean check = journal.Contains(stopWriting, comp);
                Console.WriteLine("To start to write in Captain's journal type start and stop to end writing");
                String startWriting = Console.ReadLine();

                If (startWriting == "start")
                {
                sw.WriteLine("Captain's log");
                sw.WriteLine("Stardate " + dateTime.ToString("dd/MM/yyyy"));
                journal = Console.ReadLine();


                If (check){
                sw.WriteLine("Jean-Luc Picard");
                sw.Close();
                }else {
                For (x = 1; x > 0; x++)
                {
                sw.WriteLine("Line" + x + journal);
                }
                }

                sw.WriteLine("Jean-Luc Picard");
                sw.Close();
                } else if(startWriting == "stop"){
                    sw.Close();
                }

                ////////////////////////////////////////////////////
            
            }
            Catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
