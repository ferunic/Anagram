using System;
using System.Linq;
using Xunit;

namespace AnagramService.Tests
{
    public class AnagramServiceTests
    {
        [Fact]
        public void toggled_strings_should_be_anagram(){
            var testOrdbok = new string[]{"ab","ba"};
            var anagramEngine = new AnagramService(testOrdbok,"testfile");
            var result = anagramEngine.IsAnagram(testOrdbok[0],testOrdbok[1]);
            Assert.True(result);
        }
        [Fact]
        public void complex_strings_should_be_anagram(){
            var testOrdbok = new string[]{"abbaaabcvju","cuavabbaajb"};
            var anagramEngine = new AnagramService(testOrdbok,"testfile");
            var result = anagramEngine.IsAnagram(testOrdbok[0],testOrdbok[1]);
            Assert.True(result);
        }
        [Fact]
        public void strings_different_size_should_not_be_anagram(){
            var testOrdbok = new string[]{"abnnmn","bannmmn"};
            var anagramEngine = new AnagramService(testOrdbok,"testfile");
            var result = anagramEngine.IsAnagram(testOrdbok[0],testOrdbok[1]);
            Assert.False(result);
        }
        [Fact]
        public void strings_should_not_be_anagram(){
            var testOrdbok = new string[]{"aa","ba"};
            var anagramEngine = new AnagramService(testOrdbok,"testfile");
            var result = anagramEngine.IsAnagram(testOrdbok[0],testOrdbok[1]);
            Assert.False(result);
        }
        [Fact]
        public void same_strings_should_not_be_anagram(){
            var testOrdbok = new string[]{"abbabghgak","abbabghgak"};
            var anagramEngine = new AnagramService(testOrdbok,"testfile");
            var result = anagramEngine.IsAnagram(testOrdbok[0],testOrdbok[1]);
            Assert.False(result);
        }
        [Fact]
        public void strings_nordic_chars_should_be_anagram(){
            var testOrdbok = new string[]{"æøååøæ","ææååøø"};
            var anagramEngine = new AnagramService(testOrdbok,"testfile");
            var result = anagramEngine.IsAnagram(testOrdbok[0],testOrdbok[1]);
            Assert.True(result);
        }
        [Fact]
        public void real_words_should_be_anagram(){
            var testOrdbok = new string[]{"trepar","reptar"};
            var anagramEngine = new AnagramService(testOrdbok,"testfile");
            var result = anagramEngine.IsAnagram(testOrdbok[0],testOrdbok[1]);
            Assert.True(result);
        }
        [Fact]
        public void list_words_with_anagram_should_return_result(){
            var testOrdbok = new string[]{"trepar","reptar","rancio","presos","parter","sorpes"};
            var anagramEngine = new AnagramService(testOrdbok,"testfile");
            var result = anagramEngine.GenerateAnagramRows(testOrdbok.ToList());
            Assert.True(result.Count > 0);
        }


    }
}
