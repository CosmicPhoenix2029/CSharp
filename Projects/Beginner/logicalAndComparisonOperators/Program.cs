//***comparison operators***


//Equals == (returns true of the value on LHS is equal to the RHS)
bool isEqual = 3 < 24;
Console.WriteLine(isEqual);

//not equals != (returns true if LHS is not equal to RHS)
bool notEqual = 4 + 4 < 1;
Console.WriteLine(notEqual);

//Less than < (returns true if LHS is less than RHS)
bool lessThan = 5 < 6;
Console.WriteLine(lessThan);

//greater than > (returns true if LHS is greater than RHS)
bool greaterThan = 10 > 5;
Console.WriteLine(greaterThan);

//less than or equal to <= (returns true if LHS is less than, or equal to RHS)
bool lessThanOrEqual = 11 <= 12;
Console.WriteLine(lessThanOrEqual);

//greater than or equal to >= (returns true if LHS is greater than, or equal to RHS)
bool greaterThanOrEqual = 14 >= 15;
Console.WriteLine(greaterThanOrEqual);


//***Logical Operators***


//AND && (returns true if both LHS and LHS return true)
bool andExample = ((9 < 10) && (20 > 19));
Console.WriteLine(andExample);

//OR || (returns true if either LHS or RHS return true)
bool orExample = ((9 > 8) || (8 > 9));
Console.WriteLine(orExample);

//NOT ! (returns the opposite value as to what it is comparing)
bool notExample = !(1 < 3);
Console.WriteLine(notExample);


//***Ternary operator (?)
string colour = "blue";
//condition to evaluate ()| if condition is true, result will be "blue", if false result will be "NOT blue"   
string result = (colour == "blue") ? "blue" : "NOT blue";
