
using System.Linq;

namespace SQLSkaner.IKeyWord
{
    class Floats : IKeyWords
    {

        public bool IsFullMatch(string input)
        {
            string[] splitInput = input.Split('.');

            if (splitInput.Length != 2)
                return false;

            foreach (string s in splitInput) 
                if ((s == null) || (!s.All(char.IsDigit)))
                    return false;

              return true;
        }

        public bool IsPartialMatch(string input)
        {
            return false;
        }

        public string KeyWordName()
        {
            return "Float";
        }

        public string WrapToHtml(string elementToBeWrapped)
        {
            return "<font style=\"color: Blue\">" + elementToBeWrapped + "</font>";
        }
    }
}
