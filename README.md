# FactorialExtensionMethodCsharp
Factorial with Extension Method, using C# Language

In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n.

Example of implementation:

Int64[] arr = new Int64[] {
  1,2,3,4,5,10,15,20,21,21,22,25,50,70,100,450,1000,5000
};
foreach (double i in arr)
{
    Console.Out.WriteLine(String.Format("{0}! => {1}", i, i.Factorial().ToString()));
}
