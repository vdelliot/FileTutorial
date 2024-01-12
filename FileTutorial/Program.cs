class Program {
    public static void Main(string[] args) {
        //define filepath to mydocuments
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/test.txt";
        StreamWriter sw;

        //check if file exists
        if (File.Exists(docPath)) {
            //if yes create stream to add text
            sw = File.AppendText(docPath);
        } else {
            //else create new file stream
            sw = File.CreateText(docPath);
        }
        string input = Console.ReadLine();

        //Write to file
        sw.WriteLine(input);

        //close stream to save changes
        sw.Close();


        //Create stream to read file
        StreamReader sr = File.OpenText(docPath);
        
        string docLine;
        //read all lines in file
        while((docLine = sr.ReadLine()) != null) {
            Console.WriteLine(docLine);
        }

        sr.Close();
    }
}