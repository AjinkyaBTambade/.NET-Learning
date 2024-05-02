# What Is .NET?
.NET is an open-source platform for building desktop, web, and mobile applications that can run natively on any operating system. The .NET system includes tools, libraries, and languages that support modern, scalable, and high-performance software development. An active developer community maintains and supports the .NET platform.

 In simple terms, the .NET platform is a software that can do these tasks:

- Translate .NET programming language code into instructions that a computing device can process.
- Provide utilities for efficient software development. For example, it can find the current time or print text on the screen.
- Define a set of data types to store information like text, numbers, and dates on the computer.


## What is a .NET implementation?

Various implementations of .NET allow .NET code to execute on different operating systems like Linux, macOS, Windows, iOS, Android, and many others.

### .NET Framework 
.NET Framework is the original .NET implementation. It supports running websites, services, desktop apps, and more on Windows. Microsoft released .NET Framework in the early 1990s.

### .NET Core
Microsoft launched .NET Core in late 2014 to enable cross-platform support for .NET developers. The company released the newest version of the .NET Core, .NET 5.0, in November 2020 and renamed it .NET .NET Core is open-source on GitHub. Latest stable version of .NET is 7.0.


## Why choose .NET?

### Ease of development
Developers like to use .NET because it includes many tools that make their work easier. For example, using the Visual Studio suite, developers can write code faster, collaborate efficiently, and test and fix their code efficiently.  The ability to reuse code between implementations reduces the cost of development.

### High-performing applications
.NET applications provide faster response times and require less computing power. They have strong built in security measures and efficiently perform server-side tasks like database access. 

### Community support
.NET is open source, which means that anyone can get access to use, read, and modify it freely. An active community of developers maintains and improves the .NET software. The .NET Foundation is an independent nonprofit organization established to support the .NET community. It provides learning resources, open-source .NET projects, and various events for .NET developers.

## What are the components of .NET architecture?
.NET has a modular and optimized architecture. Users can choose different components to meet their software development requirements.

These are the three main .NET components:

- .NET languages
- Application model frameworks
- .NET runtime 

Developers use .NET programming languages and application model frameworks to create their .NET applications. The .NET runtime then executes and runs them.

## What are .NET programming languages?

C# (pronounced C sharp), F# (pronounced F sharp), and Visual Basic are the three Microsoft-supported languages for NET development. Different companies and developers have also created other languages that work with the .NET platform.

### C#
C# is a simple, modern, and object-oriented programming language. With syntax similar to the C family of languages, C# is familiar to C, C++, Java, and JavaScript programmers.

### Visual Basic
Visual Basic is an object-oriented programming language developed by Microsoft. Using Visual Basic makes it fast and easy to create type-safe .NET apps. Type safety is the extent to which a programming language discourages or prevents logical coding errors.

### Common Language Infrastructure (CLI) languages
Languages like ClojureCLR, Eiffel, IronPython, PowerBuilder, and many others also work on the .NET platform. This is because .NET implements the Common Language Infrastructure (CLI). You can think of CLI as a template for creating .NET-compatible languages.


## What is .NET runtime?

The .NET runtime, also called Common Language Runtime (CLR), compiles and executes .NET programs on different operating systems.

## Just-in-time compilation
The CLR compiles code as the developer writes it. During compilation, CLR translates the code into Common Intermediate Language (CIL). For example, code written in C# has English-like syntax and words. .NET compiles or translates this code into CIL. CIL code looks different because it is a lower-level machine code language.

## Execution
.NET runtime manages the execution of CIL code. CIL is cross-platform compatible, and any operating system can process it. Cross-platform compatibility refers to an application’s ability to run on multiple different operating systems with minimal modifications. For example, an application in C# can run on Windows, Linux, or macOS without any code modifications. Such an application is called a cross-platform application.

## What are .NET application model frameworks?

The application model frameworks are a collection of developer tools and libraries that support fast and efficient .NET project development. Different frameworks exist for different types of applications, such as those listed below.

### Web applications
The ASP.NET framework extends the .NET developer platform specifically for building web-based applications. It supports web technologies such as REST APIS, HTML, CSS, and JavaScript. It provides a built-in user database with multi-factor and external authentication. ASP.NET supports industry-standard authentication protocols with a built-in security mechanism to protect your .NET apps from cyberattacks.

### Mobile applications
You can use Xamarin/Mono to run .NET apps on all the major mobile operating systems, including iOS and Android. Xamarin includes Xamarin.Forms, an open-source mobile user interface framework. .NET developers use Xamarin.forms to create a consistent user experience across mobile platforms. All .NET apps can look the same, even on different mobile devices.

### Desktop applications
You can use Xamarin for desktop application development. Additionally, Universal Windows Platform extends .NET Windows 10 application development. Windows Presentation Foundation and Windows Forms are other frameworks for user interface design on Windows.

### Other applications
With ML.NET, you can develop and integrate custom machine learning models into your .NET applications. You can use .NET IoT Libraries to develop applications on sensors and other smart devices. For any solutions not available in the frameworks, you can find many specific function libraries on the public NuGet repository. You can use Nuget to create, share, and use many .NET libraries for almost any purpose.


# NET Collection Framework

A collection is a set of related objects. Unlike arrays, a collection can grow and shrink dynamically as the number of objects added or deleted. A collection is a class, so you must declare a new collection before you can add elements to that collection.

Many applications need the creation and management of groups of linked items. Items may be grouped in two ways: by generating arrays of objects or collections of objects. In terms of Data Structures, collections mimic the Array Data Structures; the main difference is that, unlike arrays, collections do not require a minimum size to be specified.

C# collections are made to more effectively organize, store, and modify comparable data. Adding, deleting, discovering, and inserting data into the collection are all examples of data manipulation. These classes support stacks, queues, lists, and hash tables. Most collection classes implement the same interfaces.


### Arrays

Like other programming languages, array in C# is a group of similar types of elements that have contiguous memory location. In C#, array is an object of base type System.Array. In C#, array index starts from 0. We can store only fixed set of elements in C# array.

#### Advantages of Arrays
- Code Optimization (less code)
- Random Access
- Easy to traverse data
- Easy to manipulate data
- Easy to sort data etc.



#### C# Array Types
There are 3 types of arrays in C# programming:
- Single Dimensional Array
- Multidimensional Array


## Generic Collections

Generic collections in C# are data structures that can hold a collection of elements of any data type, providing type safety and performance benefits. They are part of the System.Collections.Generic namespace in the .NET Framework and provide several types of collections, each with its own characteristics and use cases. Here are some common types of generic collections:

**List<T>:**
Represents a strongly-typed list of objects.
Allows dynamic resizing, adding, and removing elements.
Implemented as a resizable array.
Provides indexed access to elements.

**Dictionary<TKey, TValue>:**
Represents a collection of key-value pairs where each key is unique.
Provides fast lookup by key.
Implemented as a hash table.
Useful for storing mappings or associations between keys and values.

**HashSet<T>:**
Represents a set of unique elements.
Does not allow duplicate elements.
Implemented using a hash table.
Provides operations for set operations such as union, intersection, and difference.

**Queue<T>:**
Represents a first-in, first-out (FIFO) collection of objects.
Allows adding elements at the end (enqueue) and removing elements from the beginning (dequeue).
Implemented using a linked list or array.

**Stack<T>:**
Represents a last-in, first-out (LIFO) collection of objects.
Allows adding elements at the top (push) and removing elements from the top (pop).
Implemented using a linked list or array.

**LinkedList<T>:**
Represents a doubly linked list of elements.
Allows fast insertion and deletion of elements at any position.
Suitable for scenarios where frequent insertion or removal of elements in the middle of the list is required.

**SortedSet<T>:**
Represents a sorted collection of unique elements.
Automatically maintains elements in sorted order.
Implemented using a red-black tree.

**SortedDictionary<TKey, TValue>:**
Represents a collection of key-value pairs sorted by keys.
Provides fast lookup, insertion, and removal of elements based on key values.
Implemented using a red-black tree.