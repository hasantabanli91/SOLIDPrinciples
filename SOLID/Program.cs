// Solid Principles are very popular design principles in the object-oriented programming world and
// developers try to use these principles in their code with the intention of adding flexibility and maintainability to the code i.e. to write better software.
// They are very important for flexible, reliable & robust software development.

using SOLID;

Console.WriteLine("");
Console.WriteLine("    Solid Principles");
Console.WriteLine("");
Console.WriteLine("    1 - Single Responsibility");
Console.WriteLine("        > Its means each software module or a class should have one and only one reason to change");
SingleResponsibility singleResponsibility = new SingleResponsibility();
singleResponsibility.SingleResponseInCafe();