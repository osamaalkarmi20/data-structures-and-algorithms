
using data_structures_and_algorithms;
using Microsoft.VisualStudio.TestPlatform.TestHost;



namespace TestReserve
{

        public class UnitTest1
        {
            [Fact]
            public void Add_ShouldAddKeyAndValue()
            {
                var customHashTable = new CustomHashTable<string, int>(100);
                customHashTable.Add("Key1", 42);

                Assert.True(customHashTable.ContainsKey("Key1"));
                Assert.True(customHashTable.TryGetValue("Key1", out int value));
                Assert.Equal(42, value);
            }

            [Fact]
            public void Add_ShouldUpdateExistingKey()
            {
                var customHashTable = new CustomHashTable<string, int>(100);
                customHashTable.Add("Key1", 42);

                customHashTable.Add("Key1", 24);

                Assert.True(customHashTable.ContainsKey("Key1"));
                Assert.True(customHashTable.TryGetValue("Key1", out int value));
                Assert.Equal(24, value);
            }

            [Fact]
            public void GetHash_ShouldReturnNonNegativeHash()
            {
                var customHashTable = new CustomHashTable<string, int>(100);
                int hash = customHashTable.GetHash("TestKey");

                Assert.True(hash >= 0);
            }

            [Fact]
            public void TryGetValue_ShouldReturnTrueAndCorrectValueForExistingKey()
            {
                var customHashTable = new CustomHashTable<string, int>(100);
                customHashTable.Add("Key1", 42);

                bool result = customHashTable.TryGetValue("Key1", out int value);

                Assert.True(result);
                Assert.Equal(42, value);
            }

            [Fact]
            public void TryGetValue_ShouldReturnFalseForNonExistingKey()
            {
                var customHashTable = new CustomHashTable<string, int>(100);

                bool result = customHashTable.TryGetValue("NonExistentKey", out int value);

                Assert.False(result);
            }

            [Fact]
            public void ContainsKey_ShouldReturnTrueForExistingKey()
            {
                var customHashTable = new CustomHashTable<string, int>(100);
                customHashTable.Add("Key1", 42);

                bool result = customHashTable.ContainsKey("Key1");

                Assert.True(result);
            }

            [Fact]
            public void ContainsKey_ShouldReturnFalseForNonExistingKey()
            {
                var customHashTable = new CustomHashTable<string, int>(100);

                bool result = customHashTable.ContainsKey("NonExistentKey");

                Assert.False(result);
            }

            [Fact]
            public void FindFirstRepeatedWord_ShouldReturnFirstRepeatedWord()
            {
                var customHashTable = new CustomHashTable<string, int>(100);
                string input = "This is a test. This is only a test.";

                string repeatedWord = customHashTable.FindFirstRepeatedWord(input);

                Assert.Equal("This", repeatedWord);
            }

            [Fact]
            public void FindFirstRepeatedWord_ShouldReturnNullForNoRepeatedWords()
            {
                var customHashTable = new CustomHashTable<string, int>(100);
                string input = "No repeated words in this sentence.";

                string repeatedWord = customHashTable.FindFirstRepeatedWord(input);

                Assert.Null(repeatedWord);
            }

            [Fact]
            public void Keys_ShouldReturnAllKeys()
            {
                var customHashTable = new CustomHashTable<string, int>(100);
                customHashTable.Add("Key1", 42);
                customHashTable.Add("Key2", 24);

                var keys = customHashTable.Keys();

                Assert.Contains("Key1", keys);
                Assert.Contains("Key2", keys);
            }

        }
    }

