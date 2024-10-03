
// var myAge = 33;

/*
int myAge2 = 33;
System.Console.WriteLine(myAge);
System.Console.WriteLine(myAge2);
*/

// liczby całkowite
int myAge = 120;
int newAge = myAge + 5;
Console.WriteLine(newAge);
myAge = int.MaxValue;
Console.WriteLine(myAge);
int myVar = int.MinValue;
Console.WriteLine(myVar);
uint myVar2 = uint.MaxValue;
Console.WriteLine(myVar2);

long myVarLong = long.MaxValue;
Console.WriteLine(myVarLong);
myVarLong = long.MinValue;
Console.WriteLine(myVarLong);
ulong myVarULong = ulong.MaxValue;
Console.WriteLine(myVarULong);
myVarULong = ulong.MinValue;
Console.WriteLine(myVarULong);
Console.WriteLine();

// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
Console.WriteLine(myNumber);
double myNumber2 = double.MaxValue;
Console.WriteLine(myNumber2);
decimal myNumber3 = decimal.MaxValue;
Console.WriteLine(myNumber3);
myNumber3 = decimal.MinValue;
Console.WriteLine(myNumber3);
Console.WriteLine();

// zmienne tekstowe
string name = "Adam";
string surname = "Kamizelich";
string result = name + surname;
Console.WriteLine(result);
string oneAsText = "1";
int oneAsOne = 1;
result = oneAsText + oneAsOne;
Console.WriteLine(result);
result = oneAsOne + oneAsText;
Console.WriteLine(result);
Console.WriteLine();

// zmienne znakowe
char letter = 'A';
Console.WriteLine(letter);
Console.WriteLine();

// zmienne logiczne
bool isActive = true;
Console.WriteLine(isActive);
isActive = false;
Console.WriteLine(isActive);
var isValid = 5 > 6;
Console.WriteLine(isValid);
