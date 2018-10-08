namespace CountryData {

    #region Currency zzzz

    public class Currency {

        #region Currency member variables

        private string code;
        private string name;
        private string symbol;

        #endregion

        public Currency() {
            this.code = string.Empty;
            this.name = string.Empty;
            this.symbol = string.Empty;
        }

        #region Properties of the Currency class.

        /// <summary>
        /// Represents the code for this currency instance.
        /// </summary>

        public string Code {
            get => this.code;
            set {
                if (value != null) { this.code = value; } // if value is null, don't set!
            }
        }

        /// <summary>
        /// Represents the name for this currency instance.
        /// </summary>

        public string Name {
            get => this.name;
            set {
                if (value != null) { this.name = value; } // if value is null, don't set!
            }
        }

        /// <summary>
        /// Represents the symbol for this currency instance.
        /// </summary>

        public string Symbol {
            get => this.symbol;
            set {
                if (value != null) { this.symbol = value; } // if value is null, don't set!
            }
        }

        #endregion

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
}
