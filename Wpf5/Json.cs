using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf5
{
    internal class Json
    {
        private static string pathJsonFile = Path.Combine(Directory.GetCurrentDirectory() + "\\..\\..\\..\\JsonFiles\\Days.json");
        public static void Serialize(List<ModelDay> list)
        {
            File.WriteAllText(pathJsonFile, JsonConvert.SerializeObject(list));
        }
        public static List<ModelDay> Deserialize()
        {
            return JsonConvert.DeserializeObject<List<ModelDay>>(File.ReadAllText(pathJsonFile)) ?? new List<ModelDay>();
        }
    }
}
