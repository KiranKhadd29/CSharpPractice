// Declare variable
string name;
string surname = "Khadd";

//Assign value to variable
name = "kiran";

//Print varibale
Console.WriteLine(name);

//Override value
//name = "kiran khadd";

//Console.WriteLine(name);

//Interpolation
Console.WriteLine($"my name is {name}");

//Concatination
Console.WriteLine("my name is" + name);

//String formatting 
Console.WriteLine("my name is {0} {1}", name, surname);

// Escape charactores 

Console.WriteLine("I am a \"Escape\" charactor \n and \t lets backslash add \\");




Console.WriteLine("Enter Something");
string userInput = Console.ReadLine();
Console.WriteLine("You entered: " + userInput);
Console.ReadKey();