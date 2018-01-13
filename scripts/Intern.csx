
string a = "Hello, world!";
string b = "Hello, world!";

Console.WriteLine(a == b);
Console.WriteLine(Object.ReferenceEquals(a, b));


var list = new List<string>();
foreach (var i in Enumerable.Range(0, 100))
{
    list.Add(String.Intern($"Message {i}"));
}

var m0 = "Message 0";
Console.WriteLine(Object.ReferenceEquals(m0, list[0]));