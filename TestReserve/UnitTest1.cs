using data_structures_and_algorithms;
using Microsoft.VisualStudio.TestPlatform.TestHost;



namespace TestReserve
{

    public class HashtableTests
    {
        [Fact]
        public void SettingKeyValueShouldRetrieveValue()
        {
         
            Hashtable hashtable = new Hashtable();

            
            hashtable.Set("name", "John");

            Assert.Equal("John", hashtable.Get("name"));
        }

        [Fact]
        public void RetrieveNonExistentKeyShouldReturnNull()
        {
         
            Hashtable hashtable = new Hashtable();

            object result = hashtable.Get("nonexistent");

     
            Assert.Null(result);
        }

        [Fact]
        public void RetrieveKeysShouldReturnUniqueKeys()
        {
            
            Hashtable hashtable = new Hashtable();
            hashtable.Set("name", "John");
            hashtable.Set("age", 30);
            hashtable.Set("city", "New York");

            
            List<string> keys = hashtable.Keys();

            
            Assert.Contains("name", keys);
            Assert.Contains("age", keys);
            Assert.Contains("city", keys);
            Assert.Equal(3, keys.Count);
        }

        [Fact]
        public void HandleCollisionWithinHashtable()
        {
           
            Hashtable hashtable = new Hashtable();

            
            hashtable.Set("name", "John");
            hashtable.Set("eman", "Jane");

            
            Assert.Equal("John", hashtable.Get("name"));
            Assert.Equal("Jane", hashtable.Get("eman"));
        }

        [Fact]
        public void HashKeyToInRangeValue()
        {
            
            Hashtable hashtable = new Hashtable();

            
            int hash = hashtable.CalculateHash("name");

            
            Assert.InRange(hash, 0, Hashtable.Size - 1);
        }
    }
}