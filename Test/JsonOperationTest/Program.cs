using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace JsonOperationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = @"..\..\.\connection.json";
            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonFilePath))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);
                    string url = o["url"].ToString();
                    string user_id = o["user_id"].ToString();
                    string password = o["password"].ToString();
                }
            }
        }
    }
}
