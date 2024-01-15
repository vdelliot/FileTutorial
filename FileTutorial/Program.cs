using System.Text.Json;

class Program {
    public static void Main(string[] args) {
        //define filepath to mydocuments
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/test.json";
        StreamWriter sw;

        //check if file exists
        /*
        if (File.Exists(docPath)) {
            //if yes create stream to add text
            sw = File.AppendText(docPath);
        } else {
            //else create new file stream
            sw = File.CreateText(docPath);
        }
        */
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

        //Write to file
        sw.WriteLine(json);

        //close stream to save changes
        sw.Close();


        //Create stream to read file
        StreamReader sr = File.OpenText(docPath);
        /*
        string docLine;
        //read all lines in file
        while((docLine = sr.ReadLine()) != null) {
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
}