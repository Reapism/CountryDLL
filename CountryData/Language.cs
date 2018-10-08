/// Country Data Class Library: 
/// The Language Class.
///
/// Author: Anthony Jaghab (c), all rights reserved.

using System.Runtime.Serialization;

namespace CountryData {

    #region Language class.

    /// <summary>
    /// A class containing information about a language.
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

        [DataMember(Name="name")]
        public string Name {
            get => this.name;
            set { if (value != null) this.name = value; }
        }

        /// <summary>
        /// Property for the native name of this language instance.
        /// </summary>
        [DataMember(Name = "nativeName")]
        public string NativeName {
            get => this.nativeName;
            set { if (value != null) this.nativeName = value; }
        }

        /// <summary>
        /// Property for the ISO639-1 of this language instance.
        /// A language code from the  International Organization 
        /// for Standardization to classifylanguages.
        /// </summary>
        

        [DataMember(Name = "iso639_1")]
        public string ISO639_1 {
            get => this.iso639_1;
            set { if (value != null) this.iso639_1 = value; }
        }

        /// <summary>
        /// Property for the ISO639-2 of this language instance.
        /// A language code from the  International Organization
        /// for Standardization to classify languages.
        /// </summary>

        [DataMember(Name = "iso639_2")]
        public string ISO639_2 {
            get => this.iso639_2;
            set { if (value != null) this.iso639_2 = value; }
        }

        #endregion

        #region Constructors and Methods

        /// <summary>
        /// Default constructor to instantiate member fields.
        /// </summary>

        public Language() {
            this.name = "English";
            this.nativeName = "English";
            this.iso639_1 = "en";
            this.iso639_2 = "eng";
        }

        /// <summary>
        /// Returns a string containing information on all the properties
        /// of this language.
        /// </summary>
        /// <returns>Information on all the member variables
        /// current values.</returns>

        public override string ToString() => $"The name of this languge is {this.name}" +
            $" with a native name \"{this.nativeName}\". International Organization for " +
            $"Standardization codes are iso639-1: {this.iso639_1} and iso639-2: {this.iso639_2}";
    }
    #endregion
    #endregion
}
