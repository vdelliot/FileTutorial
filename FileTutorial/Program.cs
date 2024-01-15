<<<<<<< HEAD
﻿using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;
=======
﻿using System.Text.Json;
>>>>>>> 1c7802f803caf8e5756c9250d9d518ab7cbdbc44

class Program {
    public static void Main(string[] args) {
        //define filepath to mydocuments
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/test.json";
        StreamWriter sw;

        /*
        //check if file exists
        /*
        if (File.Exists(docPath)) {
            //if yes create stream to add text
            sw = File.AppendText(docPath);
        } else {
            //else create new file stream    
        }
        */
<<<<<<< HEAD
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
=======
        sw = File.CreateText(docPath);
        List<ClassRoom> rooms = new List<ClassRoom>();
        ClassRoom room = new ClassRoom("T2", 20);
        rooms.Add(room);
        room = new ClassRoom("T1", 32); 
        rooms.Add(room);
        room = new ClassRoom("T3", 16); 
        rooms.Add(room);
        JsonSerializerOptions option = new JsonSerializerOptions();
        option.WriteIndented = true;
        string json = JsonSerializer.Serialize(rooms, option);
        //string input = Console.ReadLine();
>>>>>>> 1c7802f803caf8e5756c9250d9d518ab7cbdbc44


        string json = JsonSerializer.Serialize(rooms , );
        //Write to file
        sw.WriteLine(json);

        //close stream to save changes
        sw.Close();


        //Create stream to read file
<<<<<<< HEAD
        

=======
        StreamReader sr = File.OpenText(docPath);
        /*
>>>>>>> 1c7802f803caf8e5756c9250d9d518ab7cbdbc44
        string docLine;
        //read all lines in file
        while ((docLine = sr.ReadLine()) != null) {
            Console.WriteLine(docLine);
        }
        */
        string saveData = sr.ReadToEnd();
        List<ClassRoom> temp = JsonSerializer.Deserialize<List<ClassRoom>>(saveData);
        for(int i = 0; i < temp.Count; i++) {
            Console.WriteLine(temp[i].Name + " " + temp[i].NrSeats);
        }

        //Console.WriteLine(saveData);
        sr.Close();
    }

    class ClassRoom {
        public string Name { get; set; }
        public int NrSeats { get; set; }

        public ClassRoom(string name,int nrSeats) {
            Name = name;
            NrSeats = nrSeats;
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
