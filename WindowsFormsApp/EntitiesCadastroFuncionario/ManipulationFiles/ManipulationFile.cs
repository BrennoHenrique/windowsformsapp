using System.IO;
using System.Collections.Generic;

namespace WindowsFormsApp.Entities.ManipulationFiles
{
    public class ManipulationFile
    {
        public static string LocationFile()
        {
            string locationFile = Directory.GetCurrentDirectory();
            locationFile = locationFile.Replace("\\bin\\Debug", "\\DATABASE\\data.txt");

            return locationFile;
        }

        public static List<string> LinesFile()
        {
            string line;
            List<string> lines = new List<string>();

            StreamReader reader = new StreamReader(ManipulationFile.LocationFile());

            while ((line = reader.ReadLine()) != null)
                lines.Add(line);

            reader.Close();

            return lines;
        }

        public static void AddInFile(Funcionario funcionario)
        {
            StreamWriter writer = File.AppendText(LocationFile());

            try
            {
                writer.WriteLine($"{funcionario.nome}|{funcionario.cpf}|{funcionario.Cargo}|{funcionario.salarioBruto}|" +
                                 $"{funcionario.desconto}|{funcionario.adicional}");
            }
            finally { writer.Close(); }
        }

        public static void RemoveInFile(string cpf)
        {
            List<string> lines = LinesFile();

            StreamWriter writer = new StreamWriter(LocationFile());
            writer.Write("");
            writer.Close();

            StreamWriter writerInFile = File.AppendText(LocationFile());

            for (int contador = 0; contador < lines.Count; contador++)
            {
                string[] elements = lines[contador].Split('|');

                if (elements[1] != cpf)
                    writerInFile.WriteLine($"{lines[contador]}");
            }
            writerInFile.Close();
        }
    }
}
