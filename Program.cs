// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 10;

int[] myArray = {10, 20, 30};

// Creating a new empty list called yyList
// myList can only store ints
List<int> myList = new List<int>();

// Another list created with an initializer list.
// This list stores strings
List<string> listOfStrings = new List<string>() {"red", "green", "yellow"};

// Loop through the list using an foreach loop
// string element represents each item in the list - a string
// foreach can only read the contents of a list, it cannot modify them
foreach (string element in listOfStrings)
{
    Console.WriteLine(element);
}

// A for loop can also be used. It can also modify a string
for (int i = 0; i < listOfStrings.Count; i++)
{
    Console.WriteLine(listOfStrings[i]);
    listOfStrings[i] = "purple"; // Example of modifying the list
}

// Add or Remove elements in a string with the .Add() and .Remove() methods
listOfStrings.Add("blue");
listOfStrings.Remove("green");

// Here we use .Contains() to check if a specific element is in a list or not
// .Contains() returns true if the element is in the list, otherwise false
if (listOfStrings.Contains("red"))
{
    Console.WriteLine("red is in your list!");
}
else
{
    Console.WriteLine("red is NOT in your list!");
}

// .Clear() will empty a list
listOfStrings.Clear();

// .Count is a property that will return the number of items or elements in the list
Console.WriteLine($"list of strings contains {listOfStrings.Count} elements");