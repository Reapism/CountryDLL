using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace CountryData {

    #region Currency class.

    /// <summary>
    /// A class containing information about the
    /// code, name, and symbol of a particular currency.
    /// <para>Author: Anthony Jaghab (c), all rights reserved.</para>
    /// </summary>

    [DataContract]
    public class Currency {

        #region Currency class member fields.

        private string code;
        private string name;
        private string symbol;

        #endregion

        #region Properties of the Currency class.

        /// <summary>
        /// Property for the code of this currency instance.
        /// </summary>

        [DataMember(Name = "code")]
        public string Code {
            get { if (this.code == null) return ""; else return this.code; }
            set {
                if (value != null) { this.code = value; } // if value is null, don't set!
            }
        }

        /// <summary>
        /// Property for the name of this currency instance.
        /// </summary>

        [DataMember(Name = "name")]
        public string Name {
            get { if (this.name == null) return ""; else return this.name; }
            set {
                if (value != null) { this.name = value; } // if value is null, don't set!
            }
        }

        /// <summary>
        /// Property for the symbol of this currency instance.
        /// </summary>

        [DataMember(Name = "symbol")]
        public string Symbol {
            get { if (this.symbol == null) return ""; else return this.symbol; }
            set {
                if (value != null) { this.symbol = value; } // if value is null, don't set!
            }
        }

        #endregion


        #region Constructors and methods.

        /// <summary>
        /// Default constructor to instantiate member fields.
        /// </summary>

        public Currency() {
            this.code = "N/A";
            this.name = "N/A";
            this.symbol = "N/A";
        }

        /// <summary>
        /// Attempts to serialize a Currency type. 
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
                ser = new DataContractJsonSerializer(typeof(Currency));
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
        /// Attempts to serialize a Currency type. 
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
                ser = new DataContractSerializer(typeof(Currency));
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
        /// Attempts to deserialize a serialized Currency type and passes it out.
        /// 
        /// <para>Internally catches an Exception, in that case,
        /// writes to console the exception, returns false, and
        /// type = null</para>
        /// </summary>
        /// <param name="path">Path to deserialize object.</param>
        /// <param name="type">Sets the calling argument to type.</param>

        public static bool DeserializeJSON(string path, out Currency type) {
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
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Currency));
                type = (Currency)ser.ReadObject(ms);
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

        public static bool DeserializeXML(string path, out Currency type) {
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
                DataContractSerializer ser = new DataContractSerializer(typeof(Currency));
                type = (Currency)ser.ReadObject(ms);
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
        /// Returns a string containing information about
        /// the currency code, name and symbol.
        /// </summary>
        /// <returns>Information on all the member variables
        /// current values.</returns>

        public override string ToString() =>
            $"Currency name: {this.name}\nSymbol: {this.symbol}\nCode:{this.code}\n";

    }
    #endregion
    #endregion
}
