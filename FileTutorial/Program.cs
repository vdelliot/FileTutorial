using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;

class Program {
    public static void Main(string[] args) {
        //define filepath to mydocuments
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/test.json";
        StreamWriter sw;

        /*
        //check if file exists
        if (File.Exists(docPath)) {
            //if yes create stream to add text
            sw = File.AppendText(docPath);
        } else {
            //else create new file stream    
        }
        */
        string SaveData = sr.ReadToEnd();
        List<Classroom> temp = JsonSerializer.Deserialize<List><Classroom>(SaveData);
        for (int i = 0; i < temp.Count; i++) {
            Console.WriteLine(temp.Name + " " + temp.NrSeats);
        }
        
        Console.WriteLine(SaveData);
        StreamReader sr = File.OpenText(docPath);
        sw = File.CreateText(docPath);
        Console.WriteLine(sr.ReadToEnd());
        string input = Console.ReadLine();
        Classroom room = new Classroom("T2", 20);
        
        List<Classroom> rooms = new List<Classroom>();
        
        room = new Classroom("T2", 20);
        rooms.Add(room);
        room = new Classroom("T3", 15);
        rooms.Add(room);
        room = new Classroom("T1", 40);
        rooms.Add(room);
        room = new Classroom("T4", 40);


        string json = JsonSerializer.Serialize(rooms , );
        //Write to file
        sw.WriteLine(input);

        //close stream to save changes
        sw.Close();


        //Create stream to read file
        

        string docLine;
        //read all lines in file
        while ((docLine = sr.ReadLine()) != null) {
            Console.WriteLine(docLine);
        }
    }
    class Classroom
    {
        public string Name { get; set; }
        public int NrSeats { get; set; }

        public Classroom(string name, int nrSeats)
        {
            Name = name;
            NrSeats = nrSeats;
        } 
    }
}
