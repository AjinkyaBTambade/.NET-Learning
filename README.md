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


# .NET Collection Framework

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

************************************************************************************************


# Simple .NET Web API

This guide provides step-by-step instructions on how to create a simple Web API using .NET, and explains why it is used, its advantages, and common use cases.

## Why Use .NET for Web APIs?

.NET is a popular framework for building web applications and APIs. Here are some reasons why it's commonly used:

1. **Cross-Platform**: .NET Core allows you to build and run applications on Windows, macOS, and Linux.
2. **Performance**: .NET Core is known for its high performance and efficiency.
3. **Scalability**: It is suitable for both small and large applications, providing the ability to scale as needed.
4. **Security**: .NET includes built-in security features to protect your applications.
5. **Rich Ecosystem**: It has a large ecosystem of libraries and tools, making development faster and easier.

## Advantages of .NET Web APIs

- **Consistency**: Provides a consistent programming model and tools across various types of applications.
- **Integration**: Seamlessly integrates with other Microsoft services and tools, such as Azure and Visual Studio.
- **Community Support**: Strong community and extensive documentation available for developers.
- **Open Source**: .NET Core is open source, which means it is continuously improved by the community.

## Common Use Cases

- **Microservices**: Building small, modular services that can be deployed and scaled independently.
- **RESTful APIs**: Creating RESTful APIs for web, mobile, and other applications to consume.
- **Backend Services**: Developing backend services for web applications, mobile apps, and IoT devices.
- **Cloud-Based Applications**: Building cloud-native applications that can take advantage of cloud services.



# Simple .NET Web API with Razor Pages

This guide provides step-by-step instructions on how to create a simple Web API using .NET with Razor Pages. It also explains why these technologies are used, their advantages, and common use cases.


## Why Use .NET Web API with Razor Pages?

.NET Web API and Razor Pages are popular for building web applications due to several reasons:

1. **Separation of Concerns**: Web APIs can handle the data layer, while Razor Pages handle the presentation layer.
2. **Cross-Platform**: .NET Core allows you to build and run applications on Windows, macOS, and Linux.
3. **Performance**: Known for its high performance and efficiency.
4. **Scalability**: Suitable for both small and large applications, providing the ability to scale as needed.
5. **Security**: Includes built-in security features to protect your applications.
6. **Rich Ecosystem**: A large ecosystem of libraries and tools, making development faster and easier.

## Advantages of .NET Web API with Razor Pages

- **Consistency**: Provides a consistent programming model and tools across various types of applications.
- **Integration**: Seamlessly integrates with other Microsoft services and tools, such as Azure and Visual Studio.
- **Community Support**: Strong community and extensive documentation available for developers.
- **Open Source**: .NET Core is open source, which means it is continuously improved by the community.

## Common Use Cases

- **Dynamic Web Applications**: Building dynamic web applications with server-side rendering.
- **RESTful APIs**: Creating RESTful APIs for web, mobile, and other applications to consume.
- **Backend Services**: Developing backend services for web applications, mobile apps, and IoT devices.
- **Cloud-Based Applications**: Building cloud-native applications that can take advantage of cloud services.




## MVC

MVC (Model-View-Controller) is a pattern in software design commonly used to implement user interfaces, data, and controlling logic. It emphasizes a separation between the software's business logic and display. This  <b>Separation Of Concern </b> provides for a better division of labor and improved maintenance. Some other design patterns are based on MVC, such as MVVM (Model-View-Viewmodel), MVP (Model-View-Presenter), and MVW (Model-View-Whatever).

### Model

The model manages the behavior and data of the application domain, responds to requests for information about its state (usually from the view), and responds to instructions to change state (usually from the controller). It maintains the state and notified observers/subscribers of change in information.

```
namespace EStoreWebApp.Models;
public class Product
{
    public int ProductId{get; set;}
    public string Title{ get; set;}
    public string Category{get; set;}
    public string Description{get; set;}
    public string PaymentTerm{get; set;}
    public string Delivery {get; set;}
    public string ImageURL{get;set;}
    public float UnitPrice{get;set;}
    public int Balance{get;set;}
}
```

The Model represents and handles the data your application needs to run, especially as an in-memory, partial and local representation of the data that lives in your database(s) / data store(s). All the methods you need to create, read, update, and delete (i.e. CRUD) this data should be in your Model, thereby allowing your application access to those methods.

Some also place API methods, especially those that interface with your database(s) here as well. Doing so makes sense, but it’s not the only way to go about it. I actually prefer to conceptualize and incorporate these in the Controller, for reasons I’ll explain later.

The bottom line is that the Model captures and contains the data your application currently needs, in memory, to be able to display what it needs to output. It does not contain your entire database, only as much as it needs right now.

The Model receives and contains the data it needs from your database’s file storage (i.e. an SSD) to local memory (i.e. RAM) in order to rapidly render these on the page.

When you’re scrolling down your feed on Facebook, for example, the Model is being updated with more data from the database, probably several steps ahead of your scroll, to ensure a seamless transition. But each scroll most likely makes yet again another API call to the database, to add one (or more) tidbits of data to the Model, ready to be displayed on your next scroll.


### Controller

The controller interprets the mouse and keyboard inputs from the user, informing the model and/or the view to change as appropriate.

```
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using BLL;
namespace EStoreWebApp.Controllers;
public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;
    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(){  
        return View();
    }
    public IActionResult Details(int id){
        CatalogManager manager=new CatalogManager();
        Product product=manager.GetProduct(id);
        this.ViewData["product"]=product;
        return View();
    }
}
```
Finally, the Controller is the brains of the application, where most of the business logic lives. The Controller is the middleman that pulls data from the Model, and sends it to the View to be rendered on the page.

In the other direction, the Controller receives UI events from the View, processes them, and sends data to the Model if necessary (e.g. to add data from the user input to the Model).

In our increasingly cloud-based and microservices-oriented applications, we also need to understand where to place asynchronous API calls. In my mental model, I prefer to think of the Model as exclusively representing the state of the application in-the-moment. This is especially useful when thinking of front-end libraries like React, where each component’s state represents the data as it exists in-the-moment. This state can easily and quickly change, thereby necessitating a re-render of the View.

That’s part of the reason why it conceptually and usually makes more sense to incorporate API calls in the Controller, especially because their asynchronous nature means it will be at least a while before we receive the response and can update both the Model and the View. There are definitely applications, however, where encapsulating API calls in the Model is a better way to go.

The bottom line is that these aren’t always rigid demarcation lines, and the details of your MVC implementation might vary depending on the needs of your application, and even perhaps on the structure of your organization and teams responsible for the maintenance of your application.

### View

The view manages the display of information and also facilitates interaction with user.

```
<!--details.cshtml razor view file -->
@using EStoreWebApp.Models;
@{
    ViewData["Title"] = "Details Page";
}

<div>
    <h2>Product Details</h2>
    @{
        BOL.Product theProduct=ViewData["product"] as Product;
        <p> Id: @theProduct.ProductId</p>
        <p> Title:  <b> <u></u>@theProduct.Title</b></p>
        <p> Description: @theProduct.Description</p>
        <p> Unit Price: @theProduct.UnitPrice</p>
        <p> Stock Available: @theProduct.Balance</p>
    }
</div>
```

The View is the part of the application that your user sees and interacts with. For front-end applications, it’s the DOM. For an API or other server-side microservice, we might think of the View as the output of the system, i.e. the response from the server.

The common theme is that the View mainly represents the output from the system. For a fullstack system, where the user also triggers UI events and enters data, however, the View also includes those interfaces that capture inputs or events from the user.

These might include and incorporate, for example,<input/> and <button></button> elements from a <form></form>,or generally elements that can be clicked on.

### Advantages of MVC architecture

- <b>Simplicity</b> - First of all, having those three separate concepts adds a certain level of simplicity to your application, clearly delineating where each method should be placed, according to the separation of concerns principle. The pattern does away with complex inheritance structures that might involve six or more classes and / or otherwise relies on multiple and varied relationships between all these different classes.
- <b>Flexibility</b> - The MVC pattern is also flexible and can accommodate any feature that might need to be added later on. It has room for growth within its basic structure.
- <b>Reusability</b> - Finally, because it is a familiar pattern that many developers are already used to, and because of its flexibility, it’s a pattern that can be used over and over again, so it can be applied to any application or business need. It also means applications that follow this pattern are easier to maintain in the long run.

Design patterns are helpful because they provide us with a blueprint for an architectural framework that has worked before, and would probably also work again. But each pattern’s usefulness and applicability of course varies and depends on your system’s particular use case and business needs. Although MVC was originally designed in the 1970s as a desktop computing framework for the Smalltalk language, it has evolved to be incorporated in many web frameworks for Java,.NET, Python, and Ruby.

