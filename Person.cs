using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Goliath
{
    internal abstract class Person
    {
        private string _name;
        private string _language;
        private string _nation;

        public Person(string name, string language, string nation)
        {
            this._name = name;
            this._language = language;
            this._nation = nation;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetLanguage()
        {
            return _language;
        }

        public string GetNation()
        {
            return _nation;
        }

        public abstract void Speak(string phrase);
    }
}
