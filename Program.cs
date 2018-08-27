using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfAndSwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the game\n Please Enter your character: ");
            char a = char.Parse(Console.ReadLine());

            CheckVowel checkVowel = new CheckVowel();
            Console.WriteLine(checkVowel.isVowel(a));

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            VowelSwitch vowelSwitch = new VowelSwitch();
            vowelSwitch.isVowel(a);


            Console.ReadLine();

        }
    }



    class CheckVowel
    {
        public string isVowel(char a)
        {
            Console.WriteLine("This response is from IfElse(Nested If) Statements");

            char ch = a;
            String message = "";
            if (ch == 'A' || ch == 'a')
            {
                message = (ch + " is Vowel and Pronunced as [ei]");
            }
            else if (ch == 'E' || ch == 'e')
            {
                message = (ch + " is Vowel and Pronunced as [i:]");
            }
            else if (ch == 'I' || ch == 'i')
            {
                message = (ch + " is Vowel and Pronunced as [ai]");
            }
            else if (ch == 'O' || ch == 'o')
            {
                message = (ch + " is Vowel and Pronunced as [ou]");
            }
            else if (ch == 'U' || ch == 'u')
            {
                message = (ch + " is Vowel and Pronunced as [ju:]");
            }
            else
            {
                message = (ch + " is Consonant");
            }
            return message;
        }
    }

    class VowelSwitch
    {
        public void isVowel(char a)
        {
            Console.WriteLine("This response is from Switch cases");
            char val = a;
            switch (val)
            {
                case 'a':
                case 'A':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("{0}is a vowel", val);
                    break;
                default:
                    Console.WriteLine("{0} is not a vowel, This must be a Consonant", val);
                    break;
            }
        }
    }
}
