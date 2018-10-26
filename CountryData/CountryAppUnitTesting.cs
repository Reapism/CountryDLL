using System;

namespace CountryData {

    #region CountryAppUnitTesting class.

    /// <summary>
    /// Runs a test on all the country properties and
    /// its class properties Currency and Language.
    /// 
    /// <para>Updates to add a currency and language
    /// to the new Lists added. Checks first index to.</para>
    /// 
    /// Author: Anthony Jaghab (c), all rights reserved.
    /// </summary>

    public class CountryAppUnitTesting {

        #region Methods.

        /// <summary>
        /// Performs a unit test for all of the
        /// Country classes properties.
        /// </summary>

        public void UnitTestCountry() {

            string capital = "Test";
            string curCode = "code";
            string curName = "name";
            string curSymb = "symb";

            Currency cur = new Currency {
                Code = curCode,
                Name = curName,
                Symbol = curSymb
            };

            string lanISO1 = "zz";
            string lanISO2 = "zxz";
            string lanName = "Zork";
            string lanNatName = "Skork";

            Language l = new Language {
                ISO639_1 = lanISO1,
                ISO639_2 = lanISO2,
                Name = lanName,
                NativeName = lanNatName
            };

            int population = 10000;
            string region = "region";
            string subregion = region + region.Substring(0, 1);

            Country c = new Country {
                Capital = capital,
                Population = population,
                Region = region,
                Subregion = subregion
            };

            c.Currencies.Add(cur);
            c.Languages.Add(l);

            Console.WriteLine("\n**********************");
            Console.WriteLine("Unit Testing: Country");
            Console.WriteLine("************************");

            Console.Write("\nCountry captial property: ");
            Console.WriteLine((c.Capital == capital) ? "Pass" : "Fail");

            Console.Write("\nCountry Currency code property: ");
            Console.WriteLine((c.Currencies[0].Code == curCode) ? "Pass" : "Fail");
            Console.Write("\nCountry Currency name property: ");
            Console.WriteLine((c.Currencies[0].Name == curName) ? "Pass" : "Fail");
            Console.Write("\nCountry Currency symbol property: ");
            Console.WriteLine((c.Currencies[0].Symbol == curSymb) ? "Pass" : "Fail");

            Console.Write("\nCountry Language ISO639_1 property: ");
            Console.WriteLine((c.Languages[0].ISO639_1 == lanISO1) ? "Pass" : "Fail");
            Console.Write("\nCountry Language ISO639_2 property: ");
            Console.WriteLine((c.Languages[0].ISO639_2 == lanISO2) ? "Pass" : "Fail");
            Console.Write("\nCountry Language Name property: ");
            Console.WriteLine((c.Languages[0].Name == lanName) ? "Pass" : "Fail");
            Console.Write("\nCountry Language NativeName property: ");
            Console.WriteLine((c.Languages[0].NativeName == lanNatName) ? "Pass" : "Fail");

            Console.Write("\nCountry population property: ");
            Console.WriteLine((c.Population == population) ? "Pass" : "Fail");

            Console.Write("\nCountry region property: ");
            Console.WriteLine((c.Region == region) ? "Pass" : "Fail");

            Console.Write("\nCountry subregion property: ");
            Console.WriteLine((c.Subregion == subregion) ? "Pass" : "Fail");

            Console.WriteLine("**********************");
        }

        /// <summary>
        /// Runs a test on all the currency properties.
        /// </summary>

        public void UnitTestCurrency() {

            Currency c = new Currency();

            string code = "z123";
            string name = "anthony";
            string symbol = "z";

            c.Code = code;
            c.Name = name;
            c.Symbol = symbol;

            Console.WriteLine("\n**********************");
            Console.WriteLine("Unit Testing: Currency");
            Console.WriteLine("**********************");

            Console.Write("\nCurrency code property: ");
            Console.WriteLine((c.Code == code) ? "Pass" : "Fail");

            Console.Write("\nCurrency name property: ");
            Console.WriteLine((c.Name == name) ? "Pass" : "Fail");

            Console.Write("\nCurrency symbol property: ");
            Console.WriteLine((c.Symbol == symbol) ? "Pass" : "Fail");

            Console.WriteLine("**********************");
        }

        /// <summary>
        /// Runs a test on all the language properties.
        /// </summary>

        public void UnitTestLanguage() {

            Language l = new Language();

            string iso639_1 = "b1";
            string iso639_2 = "b8";
            string name = "anthony";
            string nativeName = "Anthonyy";

            l.ISO639_1 = iso639_1;
            l.ISO639_2 = iso639_2;
            l.Name = name;
            l.NativeName = nativeName;

            Console.WriteLine("\n**********************");
            Console.WriteLine("Unit Testing: Language");
            Console.WriteLine("**********************");

            Console.Write("\nLanguage ISO639_1 property: ");
            Console.WriteLine((l.ISO639_1 == iso639_1) ? "Pass" : "Fail");

            Console.Write("\nLanguage ISO639_2 property: ");
            Console.WriteLine((l.ISO639_2 == iso639_2) ? "Pass" : "Fail");

            Console.Write("\nLanguage Name property: ");
            Console.WriteLine((l.Name == name) ? "Pass" : "Fail");

            Console.Write("\nLanguage NativeName property: ");
            Console.WriteLine((l.NativeName == nativeName) ? "Pass" : "Fail");

            Console.WriteLine("**********************");
        }

        #endregion
    }

    #endregion
}
