// See https://aka.ms/new-console-template for more information

using DependencyA;
using DependencyB;
using DependencyC;
using TestApp;

Console.WriteLine("Hello, World!");

new ThisIsClassFromDependencyA().ThisIsMethodFromDependencyA();

new ThisIsClassFromDependencyB().ThisIsMethodFromDependencyB();

new ThisIsClassFromDependencyC().ThisIsMethodFromDependencyC();

var result = new ValidatorTest().Validate(new IAmAModel("Hello", 20));
Console.WriteLine(" Result " + result.IsValid);

result = new ValidatorTest().Validate(new IAmAModel("Hello", 5));
Console.WriteLine(" Result " + result.IsValid);
