using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCapcha
{
    public class ClassCapcha
    {
        public string captchaText { get; }

        public List<char> letters = new List<char>();

        private string EngAlph = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890";

        private Random rnd = new Random();

        public ClassCapcha(int length)
        {
            for (int i = 0; i < length; i++)
            {
                letters.Add(EngAlph[rnd.Next(EngAlph.Length)]);
                captchaText = String.Join("", letters);
            }
        }
    }
}
