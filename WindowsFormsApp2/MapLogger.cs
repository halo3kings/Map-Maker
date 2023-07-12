using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;


public class MapLogger
{
    private string[] Information = new string[128];
    private string Location;
    private int NumberOfLines = 0;
    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    public MapLogger()
    {

    }
    public void SetInformation(int line, string information)
    {
        Information[line] = information;
    }
    public int GetNumberOfLines()
    {
        return NumberOfLines;
    }
    public void OutputDocument()
    {

        using (StreamWriter sw = new StreamWriter(Path.Combine(path, "Test")))
        {
            foreach (string information in Information)
                sw.WriteLine(information);
        }
    }

}

