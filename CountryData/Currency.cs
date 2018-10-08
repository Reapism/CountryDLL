/// Country Data Class Library: 
/// The Currency Class.
///
/// Author: Anthony Jaghab (c), all rights reserved.

using System.Runtime.Serialization;

namespace CountryData {

    #region Currency class.

    /// <summary>
    /// A class containing information about the
    /// code, name, and symbol of a particular currency.
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
            get => this.code;
            set {
                if (value != null) { this.code = value; } // if value is null, don't set!
            }
        }

        /// <summary>
        /// Property for the name of this currency instance.
        /// </summary>

        [DataMember(Name = "name")]
        public string Name {
            get => this.name;
            set {
                if (value != null) { this.name = value; } // if value is null, don't set!
            }
        }

        /// <summary>
        /// Property for the symbol of this currency instance.
        /// </summary>

        [DataMember(Name = "symbol")]
        public string Symbol {
            get => this.symbol;
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
            this.code = "USD";
            this.name = "United States dollar";
            this.symbol = "$";
        }

        /// <summary>
        /// Returns a string containing information about
        /// the currency code, name and symbol.
        /// </summary>
        /// <returns>Information on all the member variables
        /// current values.</returns>

        public override string ToString() =>
            $"The {this.name} ({this.symbol}) code is {this.code}";

    }
    #endregion
    #endregion
}
