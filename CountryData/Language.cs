using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace CountryData {

    #region Language class.

    /// <summary>
    /// A class containing information about a language.
    /// <para>Author: Anthony Jaghab (c), all rights reserved.</para>
    /// </summary>

    [DataContract]
    public class Language {

        #region Language class member fields.

        private string name;
        private string nativeName;
        private string iso639_1;
        private string iso639_2;

        #endregion

        #region Properties of the Language class.

        /// <summary>
        /// Property for the name of this language instance.
        /// </summary>

        [DataMember(Name = "name")]
        public string Name {
            get { if (this.name == null) return ""; else return this.name; }
            set { if (value != null) this.name = value; }
        }

        /// <summary>
        /// Property for the native name of this language instance.
        /// </summary>

        [DataMember(Name = "nativeName")]
        public string NativeName {
            get { if (this.nativeName == null) return ""; else return this.nativeName; }
            set { if (value != null) this.nativeName = value; }
        }

        /// <summary>
        /// Property for the ISO639-1 of this language instance.
        /// A language code from the  International Organization 
        /// for Standardization to classifylanguages.
        /// </summary>

        [DataMember(Name = "iso639_1")]
        public string ISO639_1 {
            get { if (this.iso639_1 == null) return ""; else return this.iso639_1; }
            set { if (value != null) this.iso639_1 = value; }
        }

        /// <summary>
        /// Property for the ISO639-2 of this language instance.
        /// A language code from the  International Organization
        /// for Standardization to classify languages.
        /// </summary>

        [DataMember(Name = "iso639_2")]
        public string ISO639_2 {
            get { if (this.iso639_2 == null) return ""; else return this.iso639_2; }
            set { if (value != null) this.iso639_2 = value; }
        }

        #endregion

        #region Constructors and Methods

        /// <summary>
        /// Default constructor to instantiate member fields.
        /// </summary>

        public Language() {
            this.name = "N/A";
            this.nativeName = "N/A";
            this.iso639_1 = "N/A";
            this.iso639_2 = "N/A";
        }

        /// <summary>
        /// Attempts to serialize a Language type. 
        /// 
        /// <para>Internally catches an Exception, in that case,
        /// writes to console the exception, and returns false</para>
        /// </summary>
        /// <param name="path">Path to serialized object.</param>
        /// <param name="type">Type to Serialize</param>

        public bool SerializeJSON(string path) {
            StreamWriter sw;
            MemoryStream ms;
            DataContractJsonSerializer ser;
            byte[] data;
            string utf8String;

            try {
                ser = new DataContractJsonSerializer(typeof(Language));
                ms = new MemoryStream();
                ser.WriteObject(ms, this);
                data = ms.ToArray();
                utf8String = System.Text.Encoding.UTF8.GetString(data, 0, data.Length);
                sw = new StreamWriter(path, false, System.Text.Encoding.UTF8);
                sw.Write(utf8String);
            } catch (Exception e) {
                Console.WriteLine("\nException found:" + e.ToString());
                return false;
            }

            ms.Close();
            sw.Close();
            return true;
        }

        /// <summary>
        /// Attempts to serialize a Language type. 
        /// 
        /// <para>Internally catches an Exception, in that case,
        /// writes to console the exception, and returns false</para>
        /// </summary>
        /// <param name="path">Path to serialized object.</param>
        /// <param name="type">Type to Serialize</param>

        public bool SerializeXML(string path) {
            StreamWriter sw;
            MemoryStream ms;
            DataContractSerializer ser;
            byte[] data;
            string utf8String;

            try {
                ser = new DataContractSerializer(typeof(Language));
                ms = new MemoryStream();
                ser.WriteObject(ms, this);
                data = ms.ToArray();
                utf8String = System.Text.Encoding.UTF8.GetString(data, 0, data.Length);
                sw = new StreamWriter(path, false, System.Text.Encoding.UTF8);
                sw.Write(utf8String);
            } catch (Exception e) {
                Console.WriteLine("\nException found:" + e.ToString());
                return false;
            }

            ms.Close();
            sw.Close();
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

        public static bool DeserializeJSON(string path, out Language type) {
            FileStream reader;
            StreamReader sr;
            byte[] bArr;
            MemoryStream ms;
            string utf8Str;

            try {
                reader = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(reader, System.Text.Encoding.UTF8);
                utf8Str = sr.ReadToEnd();
                bArr = System.Text.Encoding.UTF8.GetBytes(utf8Str);
                ms = new MemoryStream(bArr);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Language));
                type = (Language)ser.ReadObject(ms);
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

        public static bool DeserializeXML(string path, out Language type) {
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
                DataContractSerializer ser = new DataContractSerializer(typeof(Language));
                type = (Language)ser.ReadObject(ms);
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
        /// Returns a string containing information on all the properties
        /// of this language.
        /// </summary>
        /// <returns>Information on all the member variables
        /// current values.</returns>

        public override string ToString() => $"Language name: {this.name}\n" +
            $"Native name: {this.nativeName}\niso639-1: " +
            $"{this.iso639_1}\n iso639-2: {this.iso639_2}" +
            $"\n";

        #endregion
    }

    #endregion
}
