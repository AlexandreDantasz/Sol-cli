using System.IO;
using System.Text;

public class Program 
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            // adicione o caminho o absoluto ou relativo do template na string a seguir:
            string pathToTemplate = "C:\\Users\\alexa\\dev\\sol.cli\\template.cpp";
            using (FileStream fs = File.OpenRead(pathToTemplate))
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
            }
        }
    }
}