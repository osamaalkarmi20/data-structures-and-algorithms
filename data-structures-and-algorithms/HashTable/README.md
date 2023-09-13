# challenge (30) : Hash Tables
## explanation
 the code demonstrates the Implemintationn for the Hash Tables.


 ![white](white.jpg)

## Step by step explanation:
Hashtable Initialization:
In the constructor Hashtable(), an array is initialized to store key-value pairs. The size of this array is not explicitly specified in the code but is assumed to be a predefined constant Hashtable.Size.
Setting a Key-Value Pair (Set Method):
When you call hashtable.Set("key", "value"), it performs the following steps:
Computes the hash code for the "key" using the Hash method.
Maps the hash code to an index in the array (the modulus operation is often used for this purpose).
Inserts the key-value pair into the array at the determined index.
If there is a collision (another key hashes to the same index), the code handles it by chaining, which means creating a linked list of key-value pairs at that index.
Retrieving a Value by Key (Get Method):
When you call hashtable.Get("key"), it performs the following steps:
Computes the hash code for the "key" using the Hash method.
Maps the hash code to an index in the array.
Searches the linked list (if it exists at that index) for the given "key" and returns the associated value.
Getting a List of Unique Keys (Keys Method):
When you call hashtable.Keys(), it performs the following steps:
Iterates through the entire array.
For each index in the array, if a linked list exists, it iterates through the linked list to extract all unique keys.
Hashing a Key (Hash Method):
The Hashtable class has a Hash method that computes a hash code for a given key. The specifics of this hash function are not provided in the code snippet, but it should produce consistent hash codes for the same key and distribute them evenly across the range of possible indices in the array.
![Run](run.png)
## code:
```c#
using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    class Program
    {
        public static void Main()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Set("name", "John");
            hashtable.Set("age", 30);
            hashtable.Set("city", "New York");

            Console.WriteLine("Name: " + hashtable.Get("name"));
            Console.WriteLine("Age: " + hashtable.Get("age"));
            Console.WriteLine("Has city: " + hashtable.Has("city"));
            Console.WriteLine("Has country: " + hashtable.Has("country"));

            List<string> keys = hashtable.Keys();
            Console.WriteLine("Keys: " + string.Join(", ", keys));
        }
    }

    public class KeyValue
    {
        public string Key { get; set; }
        public object Value { get; set; }
    }

    public class Hashtable
    {
        public const int Size = 100;
        public List<List<KeyValue>> table;

        public Hashtable()
        {
            table = new List<List<KeyValue>>(Size);
            for (int i = 0; i < Size; i++)
            {
                table.Add(new List<KeyValue>());
            }
        }

        public int CalculateHash(string key)
        {
            int hash = 0;
            foreach (char c in key)
            {
                hash += c;
            }
            return hash % Size;
        }

        public void Set(string key, object value)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var kvp in bucket)
            {
                if (kvp.Key == key)
                {
                    kvp.Value = value;
                    return;
                }
            }

            bucket.Add(new KeyValue { Key = key, Value = value });
        }

        public object Get(string key)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var kvp in bucket)
            {
                if (kvp.Key == key)
                {
                    return kvp.Value;
                }
            }

            return null;
        }

        public bool Has(string key)
        {
            int index = CalculateHash(key);
            List<KeyValue> bucket = table[index];

            foreach (var kvp in bucket)
            {
                if (kvp.Key == key)
                {
                    return true;
                }
            }

            return false;
        }

        public List<string> Keys()
        {
            List<string> keys = new List<string>();

            foreach (var bucket in table)
            {
                foreach (var kvp in bucket)
                {
                    keys.Add(kvp.Key);
                }
            }

            return keys;
        }

   
    }
}
```

![test](test.png)
## test:
```c#
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
```
