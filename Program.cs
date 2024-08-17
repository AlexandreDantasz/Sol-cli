using System.IO;
using System.Text;

public class Program 
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            // adicione o caminho o absoluto ou relativo do template na string a seguir:
            string templatePath = "";
            using (FileStream fs = File.OpenRead(templatePath))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readlen;
                string text = "";
                while ((readlen = fs.Read(b, 0, b.Length)) > 0)
                {
                    text += temp.GetString(b, 0, readlen);
                }

                using (FileStream fs2 = File.Create($"./{args[0]}.cpp"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(text);
                    fs2.Write(info, 0, info.Length);
                }

                using (FileStream fs3 = File.Create($"./Makefile"))
                {
                    string makefileText = $"exec: main\n\t./main.exe\nmain:\n\tg++ {args[0]}.cpp -o main.exe";
                    byte[] info = new UTF8Encoding(true).GetBytes(makefileText);
                    fs3.Write(info, 0, info.Length);
                }
            }
        }
    }
}