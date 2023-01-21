# Solid-Design-Principles
Open Closed Principle and Liskov substitution principle with .Net

In software engineering, SOLID design principles intend to make object-oriented designs more understandable, flexible, and maintainable.There are many articles on SOLID design principles but i have found it difficult to get concise and clear information on Open closed principle and Liskov substitution  of SOLID.
Below is the attempt to cover these both principles.

Open closed principle
Definition- open–closed principle (OCP) states "software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification"

3 Ways to achieve open closed principle:
1. Inheritance - with using virtual override keywords
2. Dependency Injection - 
3. Extension Methods- for eg. Linq functionlity is an example of open closed principle

Inheritance and dependency injection both are applied similarly to achieve open closed principle. So below shared is an example with dependency injection.

Use case- 
We have created 2 projects 
1. OpenClosedPrinciple-Before without open closed principle implementation
2. OpenClosedPrinciple with open closed principle implementation

We want to implement sort based on customer type. We have 3 customer types to begin with and later we want to add diamond customer type and its corresponding diamondSort implementation.
Note 3 comments added in the each project to add the new diamond implementation.


Liskov Substitution Principle
Definition- Liskov Substitution Principle (LSP) states that objects of a superclass should be replaceable with objects of its subclasses without breaking the application. 
This primary purpose of this principle is to help achieve open closed principle. The only extra thing to be taken care of is when there is code smell while doing the same as mentioned below.

![liskov](https://user-images.githubusercontent.com/116249623/213861664-3e918916-241f-49ec-96d6-42b63a1257d3.JPG)

In order to avoid the same, its important to make sure that we dont let any class implement interface which doesnt naturally align the same.
Its possible in the beginning this natural alignment is not clear and later it becomes clear and then the code is refactored




