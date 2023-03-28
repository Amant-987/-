/*
Sample Input
["eat", "tea", "tan", "ate", "nat", "bat"]
Sample Output
[ ["ate", "eat", "tea"], ["nat", "tan"], ["bat"] ]
Т.е. сгруппировать слова по " общим буквам ".
*/
Console.Clear();
       const String words = @"C:\Users\aleks\Documents\Learning_IT\Learn_C_Sharp\C-sharp-1\C_Sharp\Testing_Skill\words.txt";
       const String anagram = @"C:\Users\aleks\Documents\Learning_IT\Learn_C_Sharp\C-sharp-1\C_Sharp\Testing_Skill\anagrams.txt";
       static bool CheckAnagr(String sl1, String sl2)
        {
            Byte length_sl1;
            Byte length_sl2;
            length_sl1 = (Byte)sl1.Length;
            length_sl2 = (Byte)sl2.Length;
           
           if (length_sl1 != length_sl2) return false;
 
           Int16 summ_Unicode_sl1 = 0;
           Int16 summ_Unicode_sl2 = 0;
 
               for (Byte N_letter = 0; N_letter < length_sl1; N_letter++) {
                   summ_Unicode_sl1 += (Int16)sl1[N_letter];
                   summ_Unicode_sl2 += (Int16)sl2[N_letter];
               }
 
           if (summ_Unicode_sl1 == summ_Unicode_sl2) return true;
           return false;   
        }
        static void WriteInFile(String Write_anagr)
       {
           StreamWriter writer = new System.IO.StreamWriter(anagram, true, Encoding.UTF8);
           writer.WriteLine(Write_anagr);
           writer.Close();
       }
        static void Main()
        {
            Int16 size_of_file = (Int16)System.IO.File.ReadAllLines(words).Length;
            String[] mass_words = new String[size_of_file];
            Int16 IndeX = 0;//индекс для foreach
            String nextWord = "";
            String anagr_word = "";
            
            foreach (String Next_str in File.ReadLines(words))
            {
                mass_words[IndeX] = Next_str; IndeX++;
            }
            
            for (Int16 N_slov = 0; N_slov < size_of_file; N_slov++)
            {
                if (mass_words[N_slov] == "") continue;
 
                nextWord = mass_words[N_slov];
                anagr_word += nextWord;
                mass_words[N_slov] = "";
                IndeX = 0;
                foreach (String Next_str in mass_words)
                {
                    if (Next_str == "") { IndeX++; continue; }
                    if (CheckAnagr(nextWord, Next_str))
                            {
                                anagr_word = anagr_word + " " + Next_str;
                                mass_words[IndeX] = "";
                            }
                            IndeX++;
                }
                WriteInFile(anagr_word);
                anagr_word = "";
                
            }
        }