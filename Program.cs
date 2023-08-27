namespace ConsoleApp5
{

    public class Homework
    {
        public void Program1()
        {
            int count = 0;

            string sentence = "    the fruits  :   are:apples:strawberries,melons";


            string[] strings2 = sentence.Split(' ',',',':');
            foreach (string words in strings2)
            {

                if (String.IsNullOrEmpty(words))
                { count--; }
                count++;
                Console.WriteLine(words);
            }
            Console.WriteLine("Total number of words " + count);
            Console.WriteLine("==============================================================================================================");

        }

        //public void Program2()
        //{


        //    string word = "Mister  ,,,nn";
        //    int count1 = 0;
        //    int count2 = 0;

        //    string[] consonants1 = word.Split('i', 'u', 'a', 'o', 'e', 'I', 'U', 'A', 'O', 'E',',');
        //    string consonants2 = String.Join(',', consonants1);

        //    Console.WriteLine(consonants2+"|");
        //    foreach (char consonant in consonants2)
        //    {
        //        if (!Char.IsLetter(consonant))
        //        { count1++; }    
        //    }
        //    foreach (char vowel in word)
        //    {
        //        if (!Char.IsLetter(vowel))
        //        { count2++; }
        //    }
        //    int vowels = word.Length - count2-(consonants2.Length - count1);
        //    Console.WriteLine($"The number of vowels is  {vowels }  ");
        //    Console.WriteLine($"The number  of consonants is {consonants2.Length-count1 }" );
        //    Console.WriteLine("==================================================================================================================");
        //}

        public void Program2()

        {
            string word1 = "Miste  rJames";
            int count1 = 0;
            
            int count2 = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] == 'i' || word1[i] == 'u' || word1[i] == 'a' || word1[i] == 'o'
                    || word1[i] == 'e' || word1[i] == 'I' || word1[i] == 'U' || word1[i] == 'A' || word1[i] == 'O' || word1[i] == 'E')
                {
                    count1++;
                }
                else if(!Char.IsLetter(word1[i]) )
                { continue; }   
                else { count2++; }


            }
            Console.WriteLine($"Amount of vowels {count1}");
            Console.WriteLine($"Amount of consonants {count2}");
            Console.WriteLine("======================================================================================================================================");
        }


        public void Program3() 
        {
            string word = "Jhonson";
            string empty = "";
            for(int i=word.Length-1;i>=0; i-- )
            {
                Console.WriteLine(word[i]);
                empty = empty + char.ToUpper(word[i]);
            }
        
        Console.WriteLine(empty);
            Console.WriteLine("=============================================================================================================");
        
        
        }



    }

        public class Program
        {
            static void Main(string[] args)

            {
                Homework homework = new Homework();
            homework.Program1();
            homework.Program2();
            homework.Program3();
            }
        
    
    }
}