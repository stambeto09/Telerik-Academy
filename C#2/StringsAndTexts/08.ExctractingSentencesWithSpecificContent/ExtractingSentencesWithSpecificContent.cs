using System;
    class ExtractingSentencesWithSpecificContent
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string currentSentence = null;
            for (int index = 0; index < text.Length; index++)
            {
                
                if (text[index]!='.')
                {
                    currentSentence += text[index];
                }
                else
                {
                    string[] words=currentSentence.Split(' ');
                    for (int i = 0;i< words.Length; i++)
                    {
                        if (words[i]=="in")
                        {
                            Console.WriteLine(currentSentence); 
                        }
                       
                    }
                    currentSentence = null;
                }
            }

        }
    }

