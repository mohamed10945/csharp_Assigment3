
readme_content = """
# Utility and Cache Classes Overview

This document provides a description of two assignments involving generic programming in C#. The focus is on developing utility functions for arrays and a caching mechanism using generics.

---

## **Assignment 1: Utility Class `ArrayUtils`**

The first assignment revolves around creating a utility class called `ArrayUtils` with two generic methods that operate on arrays:

### **1. `ReverseArray<T>(T[] array)`**
- **Description**: This method takes a generic array as input and reverses the order of its elements. It handles arrays of any type, such as integers, strings, or custom objects, without needing to modify the core logic for each type.
  
### **2. `FindMax<T>(T[] array)`**
- **Description**: This method returns the maximum element from a generic array. It works with any type that implements the `IComparable<T>` interface, which allows for comparing elements to find the maximum. If an array is empty or null, an appropriate error is raised.

---

## **Assignment 2: Generic Cache Class `Cache<TKey, TValue>`**

The second assignment is to build a generic cache system using the least recently used (LRU) eviction policy. This cache system supports basic cache operations while automatically managing memory limits by evicting old items when necessary.

### **Key Features:**

### **1. Add Method**
- **Description**: Adds a key-value pair to the cache. If the key already exists, it updates the associated value and marks the key as the most recently used. If the cache has reached its maximum size, the least recently used item is removed before adding the new item.

### **2. Retrieve (Get) Method**
- **Description**: Retrieves a value based on its key. Accessing a cached item moves it to the most recently used position to ensure that it won’t be evicted in the near future.

### **3. Remove Method**
- **Description**: Removes an item from the cache by its key. If the key doesn't exist, no action is taken. This method helps manage the cache manually when needed.


---

## **General Notes:**

- Both assignments make extensive use of C# generics, allowing the functionality to be reused across different data types while maintaining type safety.
- In Assignment 1, the utility methods work with arrays of any type, and in Assignment 2, the cache can store any combination of key-value pairs.
- Error handling is included in both assignments, such as managing null or empty arrays and handling cases where an item is not found in the cache.

This approach encourages clean, reusable code that adheres to the principles of generic programming, enabling flexibility and scalability across different use cases.
"""
