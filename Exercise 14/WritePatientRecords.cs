using System;
using static System.Console;
using System.IO;
class WritePatientRecords
{
    static void Main()
    {
        string id = "0";
        string patientName;
        double balance;
        FileStream outFile = new FileStream("Patients.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);
        while (id != "999")
        {
            Write("Enter patient ID number or 999 to quit >> ");
            id = ReadLine();
            WriteLine("Enter last name >> ");
            patientName = ReadLine();
            Write("Enter balance >> ");
            balance = Convert.ToDouble(ReadLine());
            writer.WriteLine(id + "," + patientName + "," + balance);
        }
        writer.Close();
        outFile.Close();
    }
}
