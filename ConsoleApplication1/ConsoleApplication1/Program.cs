using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {

                
        static string stpHandler(string para)
        {
            string[] stopWordsList = new string[] {

                                                              "a",
                                                              "about",
                                                              "above",
                                                              "across",
                                                              "afore",
                                                              "aforesaid",
                                                              "after",
                                                              "again",
                                                              "against",
                                                              "ago",
                                                              "all",
                                                              "almost",
                                                              "alone",
                                                              "along",
                                                              "alongside",
                                                              "already",
                                                              "also",
                                                              "although",
                                                              "always",
                                                              "am",
                                                              "amid",
                                                              "amidst",
                                                              "among",
                                                              "amongst",
                                                              "an",
                                                              "and",
                                                              
                                                              "another",
                                                              "any",
                                                              "anybody",
                                                              "anyone",
                                                              "anything",
                                                              "are",
                                                              "aren't",
                                                              "around",
                                                              "as",
                                                              
                                                              
                                                              "at",
                                                              
                                                              "away",
                                                              
                                                              "back",
                                                              
                                                              "barring",
                                                              "be",
                                                              "because",
                                                              "been",
                                                              "before",
                                                              "behind",
                                                              "being",
                                                              "below",
                                                              "beneath",
                                                              "beside",
                                                              "besides",
                                                              "best",
                                                              "better",
                                                              "between",
                                                             
                                                              "beyond",
                                                              "both",
                                                              "but",
                                                              "by",
                                                              
                                                              "can",
                                                              "cannot",
                                                              "can't",
                                                              "certain",
                                                             
                                                              "close",
                                                              "concerning",
                                                              "considering",
                                                              
                                                              "could",
                                                              "couldn't",
                                                              "couldst",
                                                              
                                                              "dare",
                                                              "dared",
                                                              "daren't",
                                                              "dares",
                                                              "daring",
                                                              "despite",
                                                              "did",
                                                              "didn't",
                                                              "different",
                                                              "directly",
                                                              "do",
                                                              "does",
                                                              "doesn't",
                                                              "doing",
                                                              "done",
                                                              "don't",
                                                              
                                                              "doth",
                                                              "down",
                                                              "during",
                                                              "durst",
                                                              
                                                              "each",
                                                              "early",
                                                              "either",
                                                              
                                                              "english",
                                                              "enough",
                                                              
                                                              "even",
                                                              "ever",
                                                              "every",
                                                              "everybody",
                                                              "everyone",
                                                              "everything",
                                                              "except",
                                                              "excepting",
                                                              
                                                              "failing",
                                                              "far",
                                                              "few",
                                                              "first",
                                                              "five",
                                                              "following",
                                                              "for",
                                                              "four",
                                                              "from",
                                                          
                                                              "gonna",
                                                              "gotta",
                                                            
                                                              "had",
                                                              "hadn't",
                                                              "hard",
                                                              "has",
                                                              "hasn't",
                                                              "hast",
                                                              "hath",
                                                              "have",
                                                              "haven't",
                                                              "having",
                                                              "he",
                                                              "he'd",
                                                              "he'll",
                                                              "her",
                                                              "here",
                                                              "here's",
                                                              "hers",
                                                              "herself",
                                                              "he's",
                                                              "high",
                                                              "him",
                                                              "himself",
                                                              "his",
                                                              "home",
                                                              "how",
                                                              "howbeit",
                                                              "however",
                                                              "how's",
                                                             
                                                              "id",
                                                              "if",
                                                              "ill",
                                                              "i'm",
                                                              "immediately",
                                                              "important",
                                                              "in",
                                                              "inside",
                                                              "instantly",
                                                              "into",
                                                              "is",
                                                              "isn't",
                                                              "it",
                                                              "it'll",
                                                              "it's",
                                                              "its",
                                                              "itself",
                                                              "i've",
                                                             
                                                              "just",
                                                            
                                                             
                                                              "large",
                                                              "last",
                                                              "later",
                                                              "least",
                                                              "left",
                                                              "less",
                                                              "lest",
                                                              "let's",
                                                              "like",
                                                              "likewise",
                                                              "little",
                                                              "living",
                                                              "long",
                                                             
                                                              "many",
                                                              "may",
                                                              "mayn't",
                                                              "me",
                                                              "mid",
                                                              "midst",
                                                              "might",
                                                              "mightn't",
                                                              "mine",
                                                              "minus",
                                                              "more",
                                                              "most",
                                                              "much",
                                                              "must",
                                                              "mustn't",
                                                              "my",
                                                              "myself",
                                                            
                                                              "near",
                                                              "'neath",
                                                              "need",
                                                              "needed",
                                                              "needing",
                                                              "needn't",
                                                              "needs",
                                                              "neither",
                                                              "never",
                                                              "nevertheless",
                                                              "new",
                                                              "next",
                                                              "nigh",
                                                              "nigher",
                                                              "nighest",
                                                         
                                                              "no",
                                                              "no-one",
                                                              "nobody",
                                                              "none",
                                                              "nor",
                                                              "not",
                                                              "nothing",
                                                              "notwithstanding",
                                                              "now",
                                                             
                                                              "of",
                                                              "off",
                                                              "often",
                                                              "on",
                                                              "once",
                                                              "one",
                                                              "oneself",
                                                              "only",
                                                              "onto",
                                                              "open",
                                                              "or",
                                                              "other",
                                                              "otherwise",
                                                              "ought",
                                                              "oughtn't",
                                                              "our",
                                                              "ours",
                                                              "ourselves",
                                                              "out",
                                                              "outside",
                                                              "over",
                                                              "own",
                                                             
                                                              "past",
                                                              "pending",
                                                              "per",
                                                              "perhaps",
                                                              "plus",
                                                              "possible",
                                                              "present",
                                                              "probably",
                                                              "provided",
                                                              "providing",
                                                              "public",
                                                              
                                                              "qua",
                                                              "quite",
                                                           
                                                              "rather",
                                                              
                                                              "real",
                                                              "really",
                                                              "respecting",
                                                              "right",
                                                              "round",
                                                              
                                                              "same",
                                                             
                                                              "save",
                                                              "saving",
                                                              "second",
                                                              "several",
                                                              "shall",
                                                              "shalt",
                                                              "shan't",
                                                              "she",
                                                              "shed",
                                                              "shell",
                                                              "she's",
                                                              "short",
                                                              "should",
                                                              "shouldn't",
                                                              "since",
                                                              "six",
                                                              "small",
                                                              "so",
                                                              "some",
                                                              "somebody",
                                                              "someone",
                                                              "something",
                                                              "sometimes",
                                                              "soon",
                                                              "special",
                                                              "still",
                                                              "such",
                                                              
                                                              "supposing",
                                                              "sure",
                                                             
                                                              "than",
                                                              "that",
                                                              "that'd",
                                                              "that'll",
                                                              "that's",
                                                              "the",
                                                              "thee",
                                                              "their",
                                                              "theirs",
                                                              "their's",
                                                              "them",
                                                              "themselves",
                                                              "then",
                                                              "there",
                                                              "there's",
                                                              "these",
                                                              "they",
                                                              "they'd",
                                                              "they'll",
                                                              "they're",
                                                              "they've",
                                                              "thine",
                                                              "this",
                                                            
                                                              "those",
                                                              "thou",
                                                              "though",
                                                              "three",
                                                              "thro'",
                                                              "through",
                                                              "throughout",
                                                              "thru",
                                                              "thyself",
                                                              "till",
                                                              "to",
                                                              "too",
                                                              "today",
                                                              "together",
                                                              "too",
                                                              "touching",
                                                              "toward",
                                                              "towards",
                                                              "true",
                                                              "'twas",
                                                              "'tween",
                                                              "'twere",
                                                              "'twill",
                                                              "'twixt",
                                                              "two",
                                                              "'twould",
                                                       
                                                              "under",
                                                              "underneath",
                                                              "unless",
                                                              "unlike",
                                                              "until",
                                                              "unto",
                                                              "up",
                                                              "upon",
                                                              "us",
                                                              "used",
                                                              "usually",
                                                           
                                                              "versus",
                                                              "very",
                                                              "via",
                                                              "vice",
                                                              "vis-a-vis",
                                                          
                                                              "wanna",
                                                              "wanting",
                                                              "was",
                                                              "wasn't",
                                                              "way",
                                                              "we",
                                                              "we'd",
                                                              "well",
                                                              "were",
                                                              "weren't",
                                                              "wert",
                                                              "we've",
                                                              "what",
                                                              "whatever",
                                                              "what'll",
                                                              "what's",
                                                              "when",
                                                              "whencesoever",
                                                              "whenever",
                                                              "when's",
                                                              "whereas",
                                                              "where's",
                                                              "whether",
                                                              "which",
                                                              "whichever",
                                                              "whichsoever",
                                                              "while",
                                                              "whilst",
                                                              "who",
                                                              "who'd",
                                                              "whoever",
                                                              "whole",
                                                              "who'll",
                                                              "whom",
                                                              "whore",
                                                              "who's",
                                                              "whose",
                                                              "whoso",
                                                              "whosoever",
                                                              "will",
                                                              "with",
                                                              "within",
                                                              "without",
                                                              "wont",
                                                              "would",
                                                              "wouldn't",
                                                              "wouldst",
                                                           
                                                              "yet",
                                                              "you",
                                                              "you'd",
                                                              "you'll",
                                                              "your",
                                                              "you're",
                                                              "yours",
                                                              "yourself",
                                                              "yourselves",
                                                              "you've",
                                                            
        };
        for (int i = 0; i < stopWordsList.Length; i++)
        {
            int index;
                string wordToRemove = " " + stopWordsList[i] + " ";
            while((index = para.IndexOf(wordToRemove)) != -1)
            {
                para = para.Remove(index , stopWordsList[i].Length+1);
            }
    }


            return para;
        }
        static string textSummarizer(string para)
        {
            int i;
            string[] unaltered = Regex.Split(para, @"(?<=[\.!\?])+");
            para = stpHandler(para);
            string[] sentences = Regex.Split(para, @"(?<=[\.!\?])\s+");
            double[] sf_2 = new double[sentences.Length];
            double[] sf_8 = new double[sentences.Length];
            double[] sf_3 = new double[sentences.Length];
            double[] total = new double[sentences.Length];
            sentenceFeature3(sentences,sf_3,para);
            sentenceFeature2(sentences, sf_2);
            sentenceFeature8(sentences, sf_8);
            for (i = 0; i < sentences.Length; i++)
            {
                total[i] = sf_2[i] + sf_3[i] + sf_8[i];
            }
            for (i = 0; i < sentences.Length; i++)
            {
                Debug.WriteLine("sentence feature 2 " + sf_2[i] + "sentence feature 3 " + sf_3[i] + "sentence feature 8 " + sf_8[i]);
                Debug.WriteLine(total[i]);
            }
            int maxInd = 0, lineDispCount = 5;
            string result=" ";
            while (lineDispCount-- > 0)
            {
                for (i = 0; i < sentences.Length; i++)
                {
                    if (total[maxInd] < total[i])
                    {
                        maxInd = i;
                    }

                }
                result += unaltered[maxInd];
                total[maxInd] = 0;
            }
            return result;
        }

        static void sentenceFeature2(string[] sentences , double[] sf_2 )
        {
            int maxIndex = 0;
            int i = 0;
            foreach (string sentence in sentences)
            {
                sf_2[i] = sentence.Length;
                if (sentence.Length > sf_2[maxIndex])
                {
                    maxIndex = i;
                }
                i++;
            }

            double maxLength = sf_2[maxIndex];
            for (i = 0; i < sf_2.Length; i++)
            {
                sf_2[i] /= maxLength;
            }
        }
        static void sentenceFeature8(string[] sentences, double[] sf_8)
        {
            int i = 0;
            foreach (string sentence in sentences)
            {
                double digCount = 0;
                foreach (char c in sentence)
                {
                    if (char.IsDigit(c))
                    {
                        digCount++;
                    }
                }
                sf_8[i] = digCount / sentence.Length;
                i++;
            }

        }

        static void sentenceFeature3(string[] sentences, double[] sf_3,string para)
        {
            int i = 0;
            double max = 0;
            foreach (string sentence in sentences)
            {
            
                //var fixedInput = Regex.Replace(sentence, "[^a-zA-Z0-9% _]", string.Empty);
                var splitted = sentence.Split(' ');
                sf_3[i] = 0;
                for (int start = 0; start < splitted.Length; start++)
                {
                    string word = splitted[start];
                    int sentFreq = 0;
                    int termFreq = 0;


                    foreach (Match match in Regex.Matches(para, word))
                    {
                        termFreq++;
                    }
                    foreach (string line in sentences)
                    {
                        if (line.IndexOf(word) != -1)
                        {
                            sentFreq++;
                        }
                    }
                    if (sentFreq != 0)
                        sf_3[i] += termFreq * (Math.Log(sentences.Length / sentFreq));

                }
                if (sf_3[i] > max)
                {
                    max = sf_3[i];
                }
                i++;
            }
            for (i = 0; i < sentences.Length; i++)
            {
                sf_3[i] = sf_3[i] / max;
            }

        }


        static void Main(string[] args)
        {
            string para = "An increasingly important task in the current era of information overload, text summarization has become an important and timely tool for helping and interpreting the large volumes of text available in documents. The goal of text summarization is to present the most important information in a shorter version of the original text while keeping its main content and helps the user to quickly understand large volumes of information. Text summarization addresses both the problem of selecting the most important sections of text and the problem of generating coherent summaries.This process is significantly different from that of human based text summarization since human can capture and relate deep meanings and themes of text documents while automation of such a skill is very difficult to implement. Automatic text summarization researchers since Luhn work [1], they are trying to solve or at least relieve that problem by proposing techniques for generating summaries. The summaries serve as quick guide to interesting information, providing a short form for each document in the document set; reading summary makes decision about reading the whole document or not, it also serves as time saver.A number of researchers have proposed techniques for automatic text summarization which can be classified into two categories: extraction and abstraction.Extraction summary is a selection of sentences or phrases from the original text with the highest score and put it together to a new shorter text without changing the source text.Abstraction summary method uses linguistic methods to examine and interpret the text.Most of the current automated text summarization system use extraction method to produce summary.Automatic text summarization works best on well - structured documents, such as news, reports, articles and scientific papers. The first step in summarization by extraction is the identification of important features such as sentence length, sentence location[11], term frequency[6], number of words occurring in title[5], number of proper nouns[14] and number of numerical data[13].In our approach, we utilize a feature fusion technique to discover which features out of the available ones are most useful. In this paper, we propose text summarization based on fuzzy logic method to extract important sentences as a summary.The rest of this paper is organized as follows. Section II presents the summarization approach.Section III describes preprocessing and the important features.Section IV and V describes our proposed, followed by experimental design, experimental results and evaluation.Finally, we conclude and suggest future work that can be carried out in Section VI.";
            string result = textSummarizer(para);
            Debug.WriteLine(result);
                      

        }
    }
}


