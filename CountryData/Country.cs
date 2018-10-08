
using System.Runtime.Serialization;
/// Country Data Class Library: 
/// The Country Class.
///
/// Author: Anthony Jaghab (c), all rights reserved.
namespace CountryData {

    #region Country class

    /// <summary>
    /// A class containing information about a country.
    /// </summary>

    public class Country {



        private string capital;
        private Currency currency;
        private Language language;
        private int population;
        private string region;
        private string subregion;

        #region Properties

        /// <summary>
        /// The capital of the country.
        /// </summary>

        [DataMember(Name = "capital")]
        public string Capital { get => this.capital; set { if (value != null) this.capital = value; } }

        /// <summary>
        /// The currency of the country.
        /// </summary>

        [DataMember(Name = "currency")]
        public Currency Currency { get => this.currency; set { if (value != null) this.currency = value; } }

        /// <summary>
        /// The language of the country.
        /// </summary>

        [DataMember(Name = "language")]
        public Language Language { get => this.language; set { if (value != null) this.language = value; } }

        /// <summary>
        /// The population of the country.
        /// </summary>

        [DataMember(Name = "population")]
        public int Population { get => this.population; set { if (value > 0) { this.population = value; } } }

        /// <summary>
        /// The region of the country.
        /// </summary>

        [DataMember(Name = "region")]
        public string Region { get => this.region; set { if (value != null) this.region = value; } }

        /// <summary>
        /// The subregion of the country.
        /// </summary>

        [DataMember(Name = "subregion")]
        public string Subregion { get => this.subregion; set { if (value != null) this.subregion = value; } }

        #endregion

        #region Constructors and methods.

        /// <summary>
        /// Default constructor 
        /// </summary>

        public Country() {
            this.capital = "Washington, D.C";
            this.currency = new Currency {
                Code = "USD",
                Name = "U.S Dollar",
                Symbol = "$"
            };

            this.language = new Language {
                ISO639_1 = "en",
                ISO639_2 = "eng",
                Name = "English",
                NativeName = "English"
            };
            this.population = 350000000;
            this.region = "Americas";
            this.subregion = "North America";
        }

        /// <summary>
        /// Displays all properties of the Country class.
        /// </summary>
        /// <returns></returns>

        public override string ToString() => $"The capital of this country instance is {this.Capital}." +
            $"{this.Currency.ToString()}" +
            $"{this.Language.ToString()}" +
            $"Population is {this.Population}." +
            $"The region is {this.Region} and the subregion is {this.Subregion}.";


        #endregion
    }

    #endregion
}
