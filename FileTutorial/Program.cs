class Program {
    public static void Main(string[] args) {
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/test.txt";
        StreamWriter sw;

        if (File.Exists(docPath)) {
            sw = File.AppendText(docPath);
        } else {
            sw = File.CreateText(docPath);
        }
        string input = Console.ReadLine();

        sw.WriteLine(input);

        sw.Close();

        StreamReader sr = File.OpenText(docPath);
        string docLine;
        while((docLine = sr.ReadLine()) != null) {
            Console.WriteLine(docLine);
        }
    }
}