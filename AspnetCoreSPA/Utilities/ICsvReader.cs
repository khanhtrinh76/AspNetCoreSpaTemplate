using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AspnetCoreSPATemplate.Utilities
{
    public interface ICsvReader
    {
        IEnumerable<T> ProcessFile<T>(string filePath);
    }

    public class CsvReader : ICsvReader
    {
        private const string _delimiter = ",";
        public IEnumerable<T> ProcessFile<T>(string filePath)
        {
            var lines = new List<string[]>();

            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    line = line.Trim();
                    string[] fields = line.Split(_delimiter.ToCharArray()).ToList().Where(x => (!string.IsNullOrWhiteSpace(x))).ToArray();
                    lines.Add(fields);
                }
            }

            List<T> list = new List<T>();

            for (int row = 1; row < lines.Count; row++)
            {
                string[] values = lines[row];
                T t = Activator.CreateInstance<T>();
                var properties = t.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                var index = 0;
                foreach (var prop in properties)
                {
                    if (!prop.CanWrite || !prop.CanRead) { continue; }
                    prop.SetValue(t, Convert.ChangeType(values[index], prop.PropertyType), null);
                    index++;
                }

                list.Add(t);
            }

            return list;

        }
    }
}
