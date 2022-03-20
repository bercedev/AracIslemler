using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace __
{
    public class Araç
    {
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
    }

    public class Araçlar
    {
        public string Author { get; set; }
        public List<Araç> Araclar { get; set; } // ÖĞELERİ LİSTE OLARAK SAKLAYAN KISIM 
    }
    internal class Json
    {

        public string Parse(string JsonVeri /* Stringe çevrilmiş Json verisi*/, string istenilenveri, bool v2 = true)
        { // Sadece okumak için kullan
            string cikti;
            JObject json = JObject.Parse(JsonVeri);
            if (v2)
            {
                //                     /* |-> ÖĞELERİ LİSTE OLARAK SAKLAYAN KISMIN ADI*/
                cikti = json["Araclar" /* | */][istenilenveri].ToString();
            }
            else cikti = json[istenilenveri].ToString();
            return cikti;
        }


        internal static Araçlar Read(string jsonVerisi)
        {
            Araçlar account = JsonConvert.DeserializeObject<Araçlar>(jsonVerisi);

            //foreach (var ogrenci in account.Ogrenciler)
            //{
            //    System.Console.WriteLine(ogrenci.ToString());
            //}
            return account;
        }
        internal static string Create(Araçlar jsons)
        {
            string json = JsonConvert.SerializeObject(jsons,Formatting.Indented);
            return json;
        }








        internal static List<Araçlar> Untext(string json)
        {
            //string json = @"[{""Name"":""John"",""LastName"":""Doe""},{""Name"":""Anna"",""LastName"":""Smith""},{""Name"":""Peter"",""LastName"":""Jones""}]";
            dynamic liste = (List<Araçlar>)JsonConvert.DeserializeObject(json, typeof(List<Araçlar>));
            return liste.ToList();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
