using System;
using System.IO;

//----------------------------------------------
void CreateRulePython()
{
    Console.WriteLine("your rule-based python bot is created");

    string RulePythonCode =  @"def bot(message):
    if message == ""hello"":
        return ""Hello! How are you?""
    elif message == ""bye"":
        return ""Goodbye!""
    elif message == ""name"":
        return ""I am a rule-based bot.""
    else:
        return ""I don't understand.""

while True:
    message = input(""You: "")

    if message == ""exit"":
        break

    print(""Bot:"", bot(message))
    ";

    File.WriteAllText("RulePythonBot.py", RulePythonCode);
}
//----------------------------------------------------
void CreateDictPython()
{
    Console.WriteLine("your dict python bot is created");

    string DictPythonCode = @"responses = {
    ""hello"": ""Hello! How are you?"",
    ""bye"": ""Goodbye!"",
    ""name"": ""I am a dictionary-based bot.""
    }

while True:
    message = input(""You: "")

    if message == ""exit"":
        break

    print(""Bot:"", responses.get(message, ""I don't understand.""))";

    File.WriteAllText("DictPythonBot.py", DictPythonCode);
}
//-------------------------------------------------
void CreateRuleCsharp()
{
    Console.WriteLine("your rule-based Csharp bot is created");

    string RuleCsharpCode = @"using System;

while (true)
{
    Console.Write(""You: "");
    string? message = Console.ReadLine();

    if (message == ""exit"")
        break;

    if (message == ""hello"")
        Console.WriteLine(""Bot: Hello! How are you?"");
    else if (message == ""bye"")
        Console.WriteLine(""Bot: Goodbye!"");
    else if (message == ""name"")
        Console.WriteLine(""Bot: I am a rule-based bot."");
    else
        Console.WriteLine(""Bot: I don't understand."");
}";

    File.WriteAllText("RuleCsharpBot.cs", RuleCsharpCode);
}
//--------------------------------------------------------
void CreateDictCsharp()
{
    Console.WriteLine("your dict Csharp bot is created");

    string DictCsharpCode = @"using System;
using System.Collections.Generic;

Dictionary<string, string> responses = new()
{
    [""hello""] = ""Hello! How are you?"",
    [""bye""] = ""Goodbye!"",
    [""name""] = ""I am a dictionary-based bot.""
};

while (true)
{
    Console.Write(""You: "");
    string? message = Console.ReadLine();

    if (message == ""exit"")
        break;

    if (responses.TryGetValue(message ?? """", out string? response))
        Console.WriteLine(""Bot: "" + response);
    else
        Console.WriteLine(""Bot: I don't understand."");
}";

    File.WriteAllText("DictCsharpBot.cs", DictCsharpCode);
}
//----------------------------------------------------------

while (true)
{
    Console.Write("choose type of your bot. (dict or rule-based) or enter exit: ");
    string? user = Console.ReadLine();

    if (user == "rule-based")
    {
        Console.Write("choose language of your bot to create (python or C#) or enter (exit): ");
        string? language = Console.ReadLine();

        if (language == "python")
        {
            CreateRulePython();
        }
        else if (language == "C#")
        {
            CreateRuleCsharp();
        }
        else if (language == "exit")
        {
            break;
        }
        else
        {
            Console.WriteLine("please choose valid selection");
        }
    }
    else if (user == "dict")
    {
        Console.Write("choose language of your bot to create (python or C#) or enter exit: ");
        string? language = Console.ReadLine();

        if (language == "python")
        {
            CreateDictPython();
        }
        else if (language == "C#")
        {
            CreateDictCsharp();
        }
        else if (language == "exit")
        {
            break;
        }
        else
        {
            Console.WriteLine("please choose valid selection");
        }
    }
    else if (user == "exit")
    {
        break;
    }
    else
    {
        Console.WriteLine("please choose valid selection");
    }
}