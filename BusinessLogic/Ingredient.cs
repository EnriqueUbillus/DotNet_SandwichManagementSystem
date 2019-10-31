using System;
using System.Collections.Generic;
using System.Text;


namespace SMS.BusinessLogic
{
    public class Ingredient
    {
        public string NameEnglish { get; set; }
        public string NameFrench { get; set; }
        public string NameDutch { get; set; }
        public bool Allergene { get; set; }

        public string GetIngredientName(Language lang)
        {
            //condition ? consequent (true) : alternative (false)
            var name = lang == Language.English ? NameEnglish : (lang == Language.French ? NameFrench : NameDutch);
            return name + (Allergene ? "*" : "");
        }
    }
}
