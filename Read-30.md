# Hashtable (Hash Table)

A **hashtable**, often referred to as a **hash table**, is a versatile data structure designed for efficient storage and retrieval of information using key-value pairs. It can be visualized as a specialized container with compartments, each uniquely labeled (key) and containing a piece of data (value).

## Hashing

At the core of hashtables lies **hashing**, a fundamental concept. This process can be likened to a magical spell that takes a key (which can be a string or any data) and converts it into a numerical value. This numeric code acts as a map, precisely guiding us to the location of the associated data within the hashtable.

### Buckets

Imagine the hashtable as an array, with each slot in the array serving as a **bucket**. These buckets can potentially house multiple key-value pairs if there's a **collision**, which occurs when different keys result in the same numeric value after hashing.

### Collisions

Collisions are akin to two guests trying to occupy the same seat at a dinner party. They happen when different keys produce identical numeric values during hashing. Handling collisions is essential, and various strategies are employed to address them.

## Hashtable Functionality

Hashtables offer several essential functionalities:

- **Preserving Unique Values**: Hashtables excel at storing unique values. It's important to note that while keys must be unique, values can be repeated.

- **Dictionary-Like**: Hashtables function much like a dictionary where you can swiftly look up a word (key) and find its definition (value).

- **Library Catalog**: Think of a hashtable as a catalog in a library. Each book title (key) corresponds to a precise location on the shelf (value).

## Structure

### Hashing

Hashing is the procedure of transforming a key into a numeric form. It's crucial that hashing remains consistent, meaning the same key consistently results in the same numeric code. There should be no element of randomness.

### Creating a Hash

To create a hashtable, you usually start with an array, often of a predetermined size (e.g., 1024). Then, you employ a hashing algorithm to convert keys into numeric indices within this array. A simple algorithm might entail adding or multiplying ASCII values and using modulo to fit within the array size.

### Dealing with Collisions

Collisions take place when multiple keys land at the same array index. Picture two books accidentally ending up on the same library shelf. Managing these collisions is essential, and various techniques are utilized to address them.

## Hashtable Operations

Hashtables support several key operations:

- `set()`: This operation involves adding a key-value pair to the hashtable.

- `get()`: It allows for swift retrieval of the value linked to a specific key.

- `has()`: This function permits you to check if a particular key exists within the hashtable.

- `keys()`: It provides you with a list of all the keys present in the hashtable.

- `hash()`: This function acts as the enchantment that turns keys into numeric indices.

In summary, hashtables stand as an efficient means of storing and retrieving key-value pairs. Through hashing, they make data retrieval exceptionally fast, boasting an average time complexity of O(1). Collisions are skillfully managed to ensure data integrity, rendering hashtables a powerful tool in the realm of computer science.
