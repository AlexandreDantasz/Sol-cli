using System.IO;
using System.Text;

public class Program 
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            using (FileStream fs = File.Create($"./{args[0]}.cpp"))
            {   
                string text = "#include <bits/stdc++.h>\n\nusing namespace std;\n\nint main()\n{\n\tios_base::sync_with_stdio(false);\n\tcin.tie(NULL);\n\treturn 0;\n}\n";
                byte[] info = new UTF8Encoding(true).GetBytes(text);
                fs.Write(info, 0, info.Length);
            }
        }
    }
}