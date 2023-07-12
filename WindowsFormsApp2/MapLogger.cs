using System;
using System.IO;
using System.Text;


public class MapLogger
{
    public MapLogger()
    {

        string path = @"C:\Users\austi\Desktop";
        StreamWriter sw = new StreamWriter(path);

        sw.WriteLine("Test");
        sw.WriteLine("Checking");
        sw.Close();
    }
}

