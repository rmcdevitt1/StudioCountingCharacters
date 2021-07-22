using System;
using System.Collections.Generic;

namespace StudioCountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] charactersInString = myString.ToCharArray();


            //loop thru character array
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            for (int i = 0; i < charactersInString.Length; i++)
            {
                //store and update character count
                

                //add character to dictionary
                if (charDictionary.ContainsKey(charactersInString[i]))
                {
                    charDictionary[charactersInString[i]] += 1;
                }
                else
                {
                    charDictionary.Add(charactersInString[i], 1);
                }
            }

                
                foreach (KeyValuePair<char, int> character in charDictionary)
                {
                    Console.WriteLine(character.Key + " (" + character.Value + ")");
                    
                }

            //print results
        }
    }
}
