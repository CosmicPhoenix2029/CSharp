//defining arrays:
int[] integerArray = { 1, 2, 3, 4, 5 };
double[] doubleArray = { 1.1, 1.2, 1.3, 1.4, 1.5 };
string[] stringArray = { "word", "anotherWord" };
char[] charArray = { 'a', 'b', 'c' };


//if you plan on initializing the array outside of the declaration, you must use the new keyword:
int[] intArray;
intArray = new int[] { 1, 2, 3, 4, 5 };

//get the array length:
int intArrayLength = intArray.Length;

//Accessing Array Items:
//array indexes start at 0
int fifthInt = intArray[4];
//as this is the last item in the array, we can also do:
int lastItem = intArray[intArray.Length - 1];

//editing the content of an array:
//Once an array is created its size is fixed, however its possible to change the values inside the array:
int[] example = new int[3];
example[0] = 2;
example[1] = 3;
example[2] = 1;

//built in Methods:

//SORT --sorts an array into ascending for numerical arrays, or alphabetically for string/char arrays
Array.Sort(example);

//REVERSE --reverses the order of array elements
Array.Reverse(example);

//INDEXOF -- takes an array and a value and returns its array position if it exists within the array
//if a value exists more than once, it will return the index of the first one in the array
int position = Array.IndexOf(example, 3);
Console.WriteLine($"The number 3 is in array position: {position}");

//FIND - searches a specified array for the provided search criteria (its best to use a lamda expression to define the search criteria)
//returns the first item that meets the search criteria
int number = Array.Find(integerArray, num => num == 5);
Console.WriteLine(number);

//further built in methods can be found here:
//https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-7.0

