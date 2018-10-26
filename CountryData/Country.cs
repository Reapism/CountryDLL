using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace CountryData {

    #region Country class

    /// <summary>
    /// A class containing information about a country.
    /// 
    /// Author: Anthony Jaghab (c), all rights reserved.
    /// </summary>
    [DataContract]
    public class Country {

        #region Instance members

        private string capital;
        private List<Currency> currencyList;
        private List<Language> languageList;
        private string name;
        private int population;
        private string region;
        private string subregion;

        #endregion

        #region Properties

        /// <summary>
        /// The capital of the country.
        /// </summary>

        [DataMember(Name = "capital")]
        public string Capital {
            get { if (this.capital == null) return ""; else return this.capital; }
            set { if (value != null) this.capital = value; }
        }

        /// <summary>
        /// The Country of the country.
        /// </summary>

        [DataMember(Name = "currencies")]
        public List<Currency> Currencies {
            get => this.currencyList;
            set { if (value != null) this.currencyList = value; }
        }

        /// <summary>
        /// The language of the country.
        /// </summary>

        [DataMember(Name = "languages")]
        public List<Language> Languages {
            get => this.languageList;
            set { if (value != null) this.languageList = value; }
        }

        /// <summary>
        /// The name of a country.
        /// </summary>

        [DataMember(Name = "name")]
        public string Name {
            get { if (this.name == null) return ""; else return this.name; }
            set { if (value != null) this.name = value; }
        }

        /// <summary>
        /// The population of the country.
        /// </summary>

        [DataMember(Name = "population")]
        public int Population {
            get => this.population;
            set { if (value > 0) { this.population = value; } }
        }

        /// <summary>
        /// The region of the country.
        /// </summary>

        [DataMember(Name = "region")]
        public string Region {
            get { if (this.region == null) return ""; else return this.region; }
            set { if (value != null) this.region = value; }
        }

        /// <summary>
        /// The subregion of the country.
        /// </summary>

        [DataMember(Name = "subregion")]
        public string Subregion {
            get { if (this.subregion == null) return ""; else return this.subregion; }
            set { if (value != null) this.subregion = value; }
        }

        #endregion

        #region Constructors and methods.

        /// <summary>
        /// Default constructor 
        /// </summary>

        public Country() {
            this.Capital = "Washington, D.C";
            this.Currencies = new List<Currency>();
            this.Languages = new List<Language>();
            this.Name = "United States of America";
            this.Population = 350000000;
            this.Region = "Americas";
            this.Subregion = "North America";
        }

        /// <summary>
        /// Attempts to serialize a Country type. 
        /// 
        /// <para>Internally catches an Exception, in that case,
        /// writes to console the exception, and returns false</para>
        /// </summary>
        /// <param name="path">Path to serialized object.</param>

        public static bool SerializeJSON(string path, List<Country> list) {
            StreamWriter sw;
            MemoryStream ms;
            DataContractJsonSerializer ser;
            byte[] data;
            string utf8String;

            try {
                ser = new DataContractJsonSerializer(typeof(List<Country>));
                ms = new MemoryStream();
                ser.WriteObject(ms, list);
                data = ms.ToArray();
                utf8String = System.Text.Encoding.UTF8.GetString(data, 0, data.Length);
                sw = new StreamWriter(path, true, System.Text.Encoding.UTF8);
                sw.Write(utf8String);
            } catch (Exception e) {
                Console.WriteLine("\nException found:\n\n" + e.ToString());
                return false;
            }

            ms.Close();
            sw.Close();
            return true;
        }

        /// <summary>
        /// Attempts to serialize a Country type. 
        /// 
        /// <para>Internally catches an Exception, in that case,
        /// writes to console the exception, and returns false</para>
        /// </summary>
        /// <param name="path">Path to serialized object.</param>

        public static bool SerializeXML(string path, List<Country> list) {
            StreamWriter sw;
            MemoryStream ms;
            DataContractSerializer ser;
            byte[] data;
            string utf8String;

            try {
                ser = new DataContractSerializer(typeof(List<Country>));
                ms = new MemoryStream();
                ser.WriteObject(ms, list);
                data = ms.ToArray();
                utf8String = System.Text.Encoding.UTF8.GetString(data, 0, data.Length);
                sw = new StreamWriter(path, false, System.Text.Encoding.UTF8);
                sw.Write(utf8String);
            } catch (Exception e) {
                Console.WriteLine("\nException found:\n\n" + e.ToString());
                return false;
            }

            ms.Close();
            sw.Close();
            return true;
        }

        /// <summary>
        /// Attempts to deserialize a serialized Country type and passes it out.
        /// 
        /// <para>Internally catches an Exception, in that case,
        /// writes to console the exception, returns false, and
        /// type = null</para>
        /// </summary>
        /// <param name="path">Path to deserialize object.</param>
        /// <param name="type">Sets the calling argument to type.</param>

        public static bool DeserializeJSON(string path, out List<Country> type) {
            FileStream reader;
            StreamReader sr;
            byte[] bArr;
            MemoryStream ms;
            string utf8Str;

            try {
                reader = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(reader, System.Text.Encoding.UTF8);
                utf8Str = sr.ReadToEnd();
                bArr = System.Text.Encoding.Unicode.GetBytes(utf8Str);
                ms = new MemoryStream(bArr);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Country>));
                type = (List<Country>)ser.ReadObject(ms);
            } catch (Exception e) {
                Console.WriteLine("\nException found:" + e.ToString());
                type = null;
                return false;
            }

            reader.Close();
            sr.Close();
            ms.Close();

            return true;
        }

        /// <summary>
        /// Attempts to deserialize a serialized Language type and passes it out.
        /// 
        /// <para>Internally catches an Exception, in that case,
        /// writes to console the exception, returns false, and
        /// type = null</para>
        /// </summary>
        /// <param name="path">Path to deserialize object.</param>
        /// <param name="type">Sets the calling argument to type.</param>

        public static bool DeserializeXML(string path, out List<Country> type) {
            FileStream reader;
            StreamReader sr;
            byte[] bArr;
            MemoryStream ms;
            string utf8Str;

            try {
                reader = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(reader, System.Text.Encoding.UTF8);
                utf8Str = sr.ReadToEnd();
                bArr = System.Text.Encoding.Unicode.GetBytes(utf8Str);
                ms = new MemoryStream(bArr);
                DataContractSerializer ser = new DataContractSerializer(typeof(List<Country>));
                type = (List<Country>)ser.ReadObject(ms);
            } catch (Exception e) {
                Console.WriteLine("\nException found:" + e.ToString());
                type = null;
                return false;
            }

            reader.Close();
            sr.Close();
            ms.Close();

            return true;
        }

        /// <summary>
        /// Displays all properties of the Country class.
        /// </summary>
        /// <returns></returns>

        public override string ToString() {
            string s = $"\nName: {this.Name}\nCapital: {this.Capital}\n";

            foreach (Currency c in this.Currencies) { s += c.ToString(); }
            foreach (Language l in this.Languages) { s += l.ToString(); }

            s += $"Population: {this.Population}\n" +
            $"Region: {this.Region}\nSubregion {this.Subregion}\n";
            return s;
        }

        #endregion
    }

    #endregion
}
