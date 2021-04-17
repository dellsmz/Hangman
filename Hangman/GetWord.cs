using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    static class GetWord
    {
        // Choses a word from the list given
        public static string WordGetter()
        {
            string unsortedwords = "master,bucket,legend,method,middle,exceed,punish,monkey,timber,course,borrow,strain,sphere,agency,answer,fossil";
            List<string> sortedwords = unsortedwords.Split(',').ToList();

            int index = new Random().Next(sortedwords.Count);
            string secretWord = sortedwords[index];

            return secretWord;
        }
    }
}

