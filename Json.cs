using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;

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

    public class Out /*: __.Araçlar*/
    {
        public string Plaka { get; set; }
        public double Tutar { get; set; }
        public string Date { get; set; }
    }

    public class Outs
    {
        public string Author { get; set; }
        public List<Out> OutList { get; set; } // ÖĞELERİ LİSTE OLARAK SAKLAYAN KISIM 
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


        internal static Araçlar ReadAndReturnAraclar(string jsonVerisi)
        {
            Araçlar account = JsonConvert.DeserializeObject<Araçlar>(jsonVerisi);

            //foreach (var ogrenci in account.Ogrenciler)
            //{
            //    System.Console.WriteLine(ogrenci.ToString());
            //}
            return account;
        }

        internal static Outs ReadAndReturnOuts(string jsonVerisi)
        {
            Outs account = JsonConvert.DeserializeObject<Outs>(jsonVerisi);

            //foreach (var ogrenci in account.Ogrenciler)
            //{
            //    System.Console.WriteLine(ogrenci.ToString());
            //}
            return account;
        }

        internal static object Read(string jsonVerisi)
        {
            object account = JsonConvert.DeserializeObject(jsonVerisi);

            //foreach (var ogrenci in account.Ogrenciler)
            //{
            //    System.Console.WriteLine(ogrenci.ToString());
            //}
            return account;
        }

        internal static string Create(object jsons)
        {
            string json = JsonConvert.SerializeObject(jsons, Formatting.Indented);
            return json;
        }

        public static bool IsList(object o)
        {
            if (o == null) return false;
            return o is IList
                && o.GetType().IsGenericType
                && o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
        }
        public class AllSteps
        {
            public AllSteps(/*string ApplicationSpath,string jsonFile,string jsonFileListAdı, object jsonaEklenecekClass*/)
            {
                //if (!jsonFile.StartsWith("\\\\")) jsonFile = "\\\\" + jsonFile;
                SetJsonFileLocation();
            }

            void SetJsonFileLocation()
            {
                JsonFileLocation = StartupPath + JsonFileName;
            }
            //protected string GetJsonListName()
            //{
            //    JsonFileLocation = StartupPath + JsonFileName;
            //    string filetxt = File.ReadAllText(JsonFileLocation);
            //    ars = Json.Read(filetxt);
            //    int a = 1;
            //    foreach (var item in ars.GetType().GetProperties())
            //    {

            //        if (a == 2 /*Json.IsList(item)*/)
            //        {
            //            JsonFileListAdı = item.Name;
            //        }
            //        a++;
            //    }
            //    return JsonFileListAdı;
            //}


            /*
             * 
             *  EXAMPLE USAGE
             *  
             *  
             *  
            Json.AllSteps JAllSteps = new Json.AllSteps()
            {
                JsonFileName = Admin.araclarjsonkonum,
                StartupPath = Application.StartupPath,
                JsonaEklenecekClass = new Araç
                {
                    Marka = marka.Text,
                    Model = model.Text,
                    Plaka = plaka.Text,
                    Renk = renk.Text
                }
            };

            JAllSteps.RunAndAddArac or .RunAndAddOut();
            * 
            * 
            *  EXAMPLE USAGE
            *  
            *  
            */

            public string StartupPath;
            public string JsonFileName;
            object ars;
            protected string JsonFileLocation;
            //string JsonFileListAdı = "null";
            public object JsonaEklenecekClass;
            internal void RunAndAddArac()
            {
                /*
                 EXAMPLE USAGE

            Json.AllSteps JAllSteps = new Json.AllSteps()
            {
                JsonFileName = Admin.hareketjsonkonum,
                StartupPath = Application.StartupPath,
                JsonaEklenecekClass = @out
            };

            JAllSteps.RunAndAddOut();


                 EXAMPLE USAGE
                 */
                //System.Windows.Forms.MessageBox.Show(GetJsonListName());
                //JsonFileListAdı = GetJsonListName();
                SetJsonFileLocation();
                string filetxt = File.ReadAllText(JsonFileLocation);
                ars = ReadAndReturnAraclar(filetxt);
                Araçlar js = (Araçlar)ars;
                js.Author = "Mustafa Disbudak";
                if (js.Araclar == null)
                {
                    js.Araclar = new List<Araç>();
                }
                js.Araclar.Add(
                (Araç)JsonaEklenecekClass
                );

                File.WriteAllText(
                    JsonFileLocation,
                    Create(js)
                );
            }

            internal void RunAndAddOut()
            {
                //System.Windows.Forms.MessageBox.Show(GetJsonListName());
                //JsonFileListAdı = GetJsonListName();
                SetJsonFileLocation();
                string filetxt = File.ReadAllText(JsonFileLocation);
                ars = ReadAndReturnOuts(filetxt);
                Outs js = (Outs)ars;
                js.Author = "Mustafa Disbudak";
                if (js.OutList == null)
                {
                    js.OutList = new List<Out>();
                }
                js.OutList.Add(
                (Out)JsonaEklenecekClass
                );

                File.WriteAllText(
                    JsonFileLocation,
                    Create(js)
                );
            }
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
