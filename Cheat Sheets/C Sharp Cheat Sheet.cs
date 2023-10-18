
/// IF ELSE

int myNumber = 10;

if (myNumber < 5)
{
    Console.WriteLine("...");
}
else if (myNumber > 15)
{
    Console.WriteLine("...");
}
else
{
    Console.WriteLine("...");
}


/// FOR

for (statement 1; statement 2; statement 3) 
{
  // code block to be executed
}



/// FOR EACH

foreach (type variableName in arrayName) 
{
  // code block to be executed
}








/// WHILE

while (condition) 
{
  // code block to be executed
}




/// DO WHILE

do 
{
  // code block to be executed
}
while (condition);




/// SWITCH

switch(expression) 
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default:
    // code block
    break;
}






/// ARRAY

int[] numbers = new int[3] { 1, 2, 3 };
Console.WriteLine(numbers[0]); // Output: 1
Console.WriteLine(numbers[1]); // Output: 2
Console.WriteLine(numbers[2]); // Output: 3

string[] cars = new string[4];
string[] cars = new string[4] {"a", "b", "c", "d"};
string[] cars = new string[] {"a", "b", "c", "d"};
string[] cars = {"a", "b", "c", "d"};





// length
string[] cars = {"a", "b", "c", "d"};
Console.WriteLine(cars.Length);



// multidimensional
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

for (int i = 0; i < numbers.GetLength(0); i++) 
{ 
  for (int j = 0; j < numbers.GetLength(1); j++) 
  { 
    Console.WriteLine(numbers[i, j]); 
  } 
}  







/// LIST

List<string> names = new List<string>();
names.Add("a");
names.Add("b");
names.Add("c");
Console.WriteLine(names[1]); 
names.Remove("c");
Console.WriteLine(names.Count); 


/// DICTIONARY

Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Add("a", 25);
ages.Add("b", 30);
ages.Add("c", 35);
Console.WriteLine(ages["Bob"]); 
ages.Remove("c");
Console.WriteLine(ages.Count);




/// HASHSET

HashSet<int> numbers = new HashSet<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(3); 
Console.WriteLine(numbers.Count); 
numbers.Remove(2);
Console.WriteLine(numbers.Count); 

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 2, 3, 6, 7, 1 };

        HashSet<int> uniqueNumbers = new HashSet<int>();
        foreach (int number in numbers)
        {
            uniqueNumbers.Add(number);
        }

        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }
    }
}




/// QUEUE

Queue<dataType> queueName = new Queue<dataType>();
Queue<int> queue1 = new Queue<int>();
Queue<string> queue2 = new Queue<string>();


// enqueue

Queue<int> numbers = new Queue<int>();

numbers.Enqueue(50);
numbers.Enqueue(23);

// print elements of the queue 
foreach (int item in numbers)
{
    Console.WriteLine(item);
}



// dequeue

Queue<string> colors = new Queue<string>();

colors.Enqueue("Red");
colors.Enqueue("Blue");
var removedElement = colors.Dequeue();
Console.WriteLine("Removed Element: " + removedElement);


// peek

Queue<string> planet = new Queue<string>();
planet.Enqueue("Earth");
planet.Enqueue("Jupiter");
Console.WriteLine("Element at beginning of queue: " + planet.Peek());


// contains

Queue<string> planet = new Queue<string>();

planet.Enqueue("Earth");
planet.Enqueue("Jupiter");

Console.WriteLine(planet.Contains("Mars"));
Console.WriteLine(planet.Contains("Jupiter"));






/// STACK

// push

Stack my_stack = new Stack();
// Adding elements in the Stack
// Using Push method
my_stack.Push("g");


// pop

Stack my_stack = new Stack();
my_stack.Push("g");
Console.WriteLine("Total elements present in"+
" my_stack: {0}", my_stack.Count);
                                    
my_stack.Pop();

Console.WriteLine("Total elements present in "+
                    "my_stack: {0}", my_stack.Count);                           
my_stack.Clear();


// peek

Stack my_stack = new Stack();
my_stack.Push("g");
Console.WriteLine("Total elements present in"+
" my_stack: {0}", my_stack.Count);
Console.WriteLine("Topmost element of my_stack "+
"is: {0}",my_stack.Peek());




// contains
Stack my_stack = new Stack();
my_stack.Push("gfg");
if (my_stack.Contains("gfg") == true) {
        Console.WriteLine("Found");
    }
    else {
        Console.WriteLine("Not found");
    }









/// LINKED LIST: addLast, Remove, RemoveFirst, RemoveLast


using System;
using System.Collections.Generic;
 
class GFG {
 
  static public void Main()
  {

    LinkedList<String> my_list = new LinkedList<String>();

    my_list.AddLast("z");
    my_list.AddLast("s");
    my_list.AddLast("r");
    my_list.AddLast("n");
    my_list.AddLast("p");
    my_list.AddLast("z");

    Console.WriteLine("Best students of XYZ "+
                      "university initially:");

    foreach(string str in my_list)
    {
        Console.WriteLine(str);
    }

    Console.WriteLine("Best students of XYZ"+
                      " university in 2000:");

    my_list.Remove(my_list.First);

    foreach(string str in my_list)
    {
        Console.WriteLine(str);
    }

    Console.WriteLine("Best students of XYZ"+
                      " university in 2001:");

    my_list.Remove("Rohit");

    foreach(string str in my_list)
    {
        Console.WriteLine(str);
    }
    
    Console.WriteLine("Best students of XYZ"+
                      " university in 2002:");

    my_list.RemoveFirst();

    foreach(string str in my_list)
    {
        Console.WriteLine(str);
    }

    // After using RemoveLast() method
    Console.WriteLine("Best students of XYZ"+
                      " university in 2003:");

    my_list.RemoveLast();

    foreach(string str in my_list)
    {
        Console.WriteLine(str);
    }

    // After using Clear() method
    my_list.Clear();
    Console.WriteLine("Number of students: {0}",
                                  my_list.Count);
}
}







/// TRY-CATCH-FINALLY

try
{
    // Code that might throw an exception
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}
finally
{
    // Code that should always be run
}




/// SORTING

// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
}




/// MIN, MAX, SUM
using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
    }
  }
}










