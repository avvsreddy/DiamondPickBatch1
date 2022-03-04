using System;
using System.Collections.Generic;

namespace IDE.LanguagesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDE ide = new IDE();
            //ide.Languages.Add(new LangCSharp());
            ide.Languages.Add(new LangJava());
            ide.Languages.Add(new LangC());
            ide.Languages.Add(new LangVB());
            ide.WorkWithLanguages();

        }
    }

    class IDE
    {
        public List<ILanguage> Languages = new List<ILanguage>();

        public void WorkWithLanguages()
        {
            foreach (ILanguage language in Languages)
            {
                Console.WriteLine(language.GetName());
                Console.WriteLine(language.GetUnit());
                Console.WriteLine(language.GetParadigm());
            }
        }
    }

    interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();
    }


    abstract class OOLanguage : ILanguage
    {
        abstract public string GetName();


        public string GetParadigm()
        {
            return "OOP";
        }

        public string GetUnit()
        {
            return "Class";
        }
    }

    class LangVB : OOLanguage
    {
        public override string GetName()
        {
            return "VB";
        }


    }

    class LangCSharp : OOLanguage
    {
        public override string GetName()
        {
            return "C Sharp";
        }

    }

    class LangJava : OOLanguage
    {
        public override string GetName()
        {
            return "Java";
        }

    }

    class LangC : ILanguage
    {
        public string GetName()
        {
            return "C Lang";
        }
        public string GetUnit()
        {
            return "Function";
        }
        public string GetParadigm()
        {
            return "Procedural";
        }
    }



}
