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
