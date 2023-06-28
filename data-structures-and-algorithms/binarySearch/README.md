# challange code(3) :Binary Search
this is a simple code that will take an a array and key and checks if the key is in the array it will return the element with the key 
but if it is not in the array it will return -1 the array should be sorted .this code is wrote to achive a big o of O(n) i which the n is the leangth of the array
and the space comlexity is also the same.
## code:
```c#
namespace data_structures_and_algorithms
{
   public class Program
  
    {
        static void Main()
        {

            int[] array = { 1, 2, 3, 4, 5 };
            int key = 4;
            Console.WriteLine(BinarySearch(array, key));

        }
   

        public static int BinarySearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                    return mid + 1;
                if (array[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }


            return -1;
        }




    }
}

```

## tests:
```c#
using data_structures_and_algorithms;

namespace TestReserve
{
  
        public class UnitTest1
        {
        [Fact]
        public void Test1()
        {
            
int[] array = { 1, 2, 3, 4, 5 };
            int key = 10;
            int result = Program.BinarySearch(array, key);
            Assert.Equal(-1, result);
        }

  [Fact]
 public void Test2()
        {
            
int[] array = { 1, 2, 3, 4, 5 };
            int key = 4;
            int result = Program.BinarySearch(array, key);
            Assert.Equal(4, result);

        }
      }
    }


```
## this is the whiteboard for the problem :
 ![whiteboard](white.png)
 
 ## in this whiteboard you will find the steps of soliving this problem domain and also the code for this method also the test will be down below :
  ![test](bintestandres.png)
