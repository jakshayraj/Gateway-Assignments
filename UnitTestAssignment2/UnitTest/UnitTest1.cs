using System;
using UnitTestAssignment2;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ConvertUpper1()
        {
            string a = "test";
            string result = a.ConvertUpper();
            Assert.Equal("TEST", result);
        }
        [Fact]
        public void ConvertUpper2()
        {
            string a = "test";
            string result = a.ConvertUpper();
            Assert.NotEqual("Test", result);
        }
        [Fact]
        public void ConvertLower1()
        {
            string a = "TEST";
            string result = a.ConvertLower();
            Assert.Equal("test", result);
        }
        [Fact]
        public void ConvertLower2()
        {
            string a = "TEST";
            string result = a.ConvertLower();
            Assert.NotEqual("Test", result);
        }
        [Fact]
        public void ConvertTitleCase1()
        {
            string a = "test cases";
            string result = a.ConvertTitleCase();
            Assert.Equal("Test Cases", result);
        }
        [Fact]
        public void ConvertTitleCase2()
        {
            string a = "test cases";
            string result = a.ConvertTitleCase();
            Assert.NotEqual("TEST Cases", result);
        }
        [Fact]
        public void IsLower1()
        {
            string a = "test";
            bool result = a.IsLower();
            Assert.True(result);
        }
        [Fact]
        public void IsLower2()
        {
            string a = "Test";
            bool result = a.IsLower();
            Assert.False(result);
        }
        [Fact]
        public void IsUpper1()
        {
            string a = "TEST";
            bool result = a.IsUpper();
            Assert.True(result);
        }
        [Fact]
        public void IsUpper2()
        {
            string a = "TESt";
            bool result = a.IsUpper();
            Assert.False(result);
        }
        [Fact]
        public void ConvertCapitalize1()
        {
            string a = "test cases";
            string result = a.ConvertCapitalize();
            Assert.Equal("Test cases", result);
        }
        [Fact]
        public void ConvertCapitalize2()
        {
            string a = "test cases";
            string result = a.ConvertCapitalize();
            Assert.NotEqual("Test Cases", result);
        }
        [Fact]
        public void WordCount1()
        {
            string a = "test cases";
            int result = a.WordCount();
            Assert.Equal(2, result);
        }
        [Fact]
        public void WordCount2()
        {
            string a = "test cases";
            int result = a.WordCount();
            Assert.NotEqual(1, result);
        }
        [Fact]
        public void RemoveLastCharacter1()
        {
            string a = "test";
            string result = a.RemoveLastCharacter();
            Assert.Equal("tes", result);
        }
        [Fact]
        public void RemoveLastCharacter2()
        {
            string a = "test";
            string result = a.RemoveLastCharacter();
            Assert.NotEqual("test", result);
        }
        [Fact]
        public void ValidNumeric1()
        {
            string a = "123";
            bool result = a.ValidNumeric();
            Assert.True(result);
        }
        [Fact]
        public void ValidNumeric2()
        {
            string a = "123a";
            bool result = a.ValidNumeric();
            Assert.False(result);
        }
        [Fact]
        public void StringToNumber1()
        {
            string a = "123";
            int? result = a.StringToNumber();
            Assert.Equal(123, result);
        }
        [Fact]
        public void StringToNumber2()
        {
            string a = "123a";
            int? result = a.StringToNumber();
            Assert.Null(result);
        }
    }
}
