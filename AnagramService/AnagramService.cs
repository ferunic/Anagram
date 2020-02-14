using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnagramService
{
    public class AnagramService
    {
        private string[] _ordbok;
        private int MaxLength;
        private string _outputFile;
        private List<string> anagrams = new List<string>();
        public AnagramService(string[] ordbok, string outputFile)
        {
            _ordbok = ordbok;
            _outputFile = outputFile;
        }

        public void FindAnagrams()
        {
            MaxLength = _ordbok.Max(x => x.Length);
            for (int i = MaxLength; i >= 2; i--)
            {
                var subListe = _ordbok.Where(x => x.Length == i).ToList();
                if (subListe.Count > 1)
                {
                    var anagramRader = GenerateAnagramRows(subListe);
                    foreach (var rad in anagramRader)
                    {
                        anagrams.Add(rad);
                    }
                }
            }
            
        }
        public void CreateAnagramFile()
        {
            FindAnagrams();
            using (StreamWriter writer = new StreamWriter(_outputFile, false, Encoding.GetEncoding(28591)))
            {
                foreach (var anagramrad in anagrams)
                {
                    writer.WriteLineAsync(anagramrad);
                }
            }
        }

        public List<string> GenerateAnagramRows(List<string> subListe)
        {
            var result = new List<string>();
            var hjelpeListe = subListe.ToList();
            foreach (var item in subListe)
            {
                var anarad = string.Empty;
                hjelpeListe.Remove(item);
                foreach (var item2 in hjelpeListe)
                {
                    if (IsAnagram(item, item2))
                    {
                            anarad += item2 + " ";
                    }
                }

                if (anarad != String.Empty)
                {
                    if (result.FirstOrDefault(x => x.Contains(item)) == null)
                    {
                        anarad += item;
                        result.Add(anarad);
                    }
                }
            }
            return result;
        }
        public bool IsAnagram(string a, string b)
        {
            if (a == b) // same ord, ikke anagram
            {
                return false;
            }
            var arr1 = a.ToCharArray();
            var arr2 = b.ToCharArray().ToList();
            foreach (var c in arr1)
            {
                if (arr2.Contains(c))
                {
                    arr2.Remove(c);
                }
            }

            return arr2.Count == 0;
        }
    }
}
