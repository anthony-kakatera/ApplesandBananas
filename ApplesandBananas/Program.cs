namespace ApplesBananas {

    public class ApplesandBananas {


        public static void Main(string[] args) {
            //get verse from console
            Console.WriteLine("Provide a verse");
            string verse = Console.ReadLine();

            //get vowel to swap out and set default to "a"
            Console.WriteLine("Provide a vowel to substitute");
            
            //grabbing user input
            string vowel = Console.ReadLine();
            
            //check if user provided vowel
            if (vowel.ToCharArray().Length == 0) { vowel = "a"; }


            //calling method used to substitute vowels
            string reshapedWords = substituteWithVowel(verse, vowel);

            Console.WriteLine(reshapedWords);

            Console.ReadLine();
        }

        public static string substituteWithVowel(string verse, string vowel)
        {
            //split the string by space
            string[] words = verse.Split(' ');
            //replace the first character
            words[words.Length - 1] = applesandBananas(words[words.Length - 1], vowel);
            words[words.Length - 3] = applesandBananas(words[words.Length - 3], vowel);

            //printing out
            return string.Join(" ", words);
        }

        public static string applesandBananas(string fruit, string vowel)
        {
            //vowels array
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //to array
            char[] chars = fruit.ToCharArray();
            //loop through array
            for (int i = 0; i < chars.Length; i++) {
                for (int r = 0; r < vowels.Length; r++)
                {
                    //search for vowel but avoid the last vowel for the plural sound
                    if (vowels[r].Equals(chars[i]))
                    {
                        //swap out with vowel
                        chars[i] = char.Parse(vowel);
                    }
                    else if (Char.ToUpper(vowels[r]).Equals(chars[i])) {
                        //swap out with vowel
                        chars[i] = Char.ToUpper(char.Parse(vowel));
                    }
                }
            }
            //return reconstructed string 
            return new string(chars);
        }
    }
}
