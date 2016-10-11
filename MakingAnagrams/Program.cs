using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().Trim();
            string b = Console.ReadLine().Trim();

            int[] alphabets = new int[26];
            foreach (char c in a) {
                alphabets[c - 'a']++;
            }

            foreach (char c in b)
            {
                alphabets[c - 'a']--;
            }

            int count = 0;
            for (int i = 0; i < 26; i++)
            {
                if (alphabets[i] == 0) continue;
                if (alphabets[i] < 0) count += (-alphabets[i]);
                else count += alphabets[i];
            }

            Console.WriteLine(count);
        }
    }
}
