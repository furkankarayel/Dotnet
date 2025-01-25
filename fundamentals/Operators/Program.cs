Console.WriteLine("Arithmetic operators");

Console.WriteLine();

Console.WriteLine("  Increment and decrement");

int a = 12;
int b = a++;
Console.WriteLine($"  a: {a}, b: {b}");
int c = 25;
int d = --c;
Console.WriteLine($"  c: {c}, d: {d}");

Console.WriteLine();

Console.WriteLine("  Plus, minus, multiplication, division");

int e = 5 + 9;
int f = 18 - 6;
int g = 7 * 3;
int h = 30 / 5;

Console.WriteLine($"  e: {e}, f: {f}, g: {g}, h: {h}");

int i = 4 + 24 / 3;
int j = (4 + 24) / 3;

Console.WriteLine($"  i: {i}, j: {j}");


Console.WriteLine("Comparison operators");

int k = 22;
int l = 19;

Console.WriteLine(k > l);  // True
Console.WriteLine(k < l);  // False
Console.WriteLine(k >= l); // True
Console.WriteLine(k <= l); // False
Console.WriteLine();

Console.WriteLine("Boolean logical operators");

bool isRegistered = true;

Console.WriteLine($"isRegistered: {isRegistered}"); // True
Console.WriteLine($"isRegistered NOT: {!isRegistered}"); // False

bool isWednesday = false;
bool isWeekend = true;

Console.WriteLine(isWednesday && isWeekend); // False
Console.WriteLine(isWednesday || isWeekend); // True

Console.WriteLine();

Console.WriteLine("Equality operators");

string myName = "Alice";
string myCountry = "Canada";
int myLuckyNumber = 7;

Console.WriteLine(myLuckyNumber != 10);  // True
Console.WriteLine(myLuckyNumber == 7);   // True
Console.WriteLine(myName == myCountry);  // False