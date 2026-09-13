# Code-Generator
A simple C# console-based Bot Generator that creates rule-based and dictionary-based bots in C# and Python. Built as a personal learning project focused on C#, dictionaries, methods, loops, conditions, file I/O, and code generation. This is v1.0, with Educational Bot and Command Mode planned for future versions.

# Features

**The program can create two types of bots:**

_Rule-based Bot_
_Dictionary-based Bot_

**Each type can be generated in:**

Python
C#

This gives the user four possible bot generators:

Rule-based Python Bot
Dictionary-based Python Bot
Rule-based C# Bot
Dictionary-based C# Bot
# How It Works

When the program starts, it asks the user to choose a bot type:

choose type of your bot. (dict or rule-based) or enter exit:
Rule-based Bot

Enter:

# rule-based

Then choose:

python

or:

C#

The program generates the corresponding source-code file.

# Dictionary-based Bot

Enter:

dict

Then choose:

python

or:

C#

The program generates the corresponding source-code file.

# Generated Files

The program can create these files:

RulePythonBot.py
DictPythonBot.py
RuleCsharpBot.cs
DictCsharpBot.cs

The files are created using C# File.WriteAllText().

If a file with the same name already exists, its contents will be replaced.

# Exit

Enter:

exit

to close the program.

You can also enter exit when the program is asking for the bot language.

# Technologies
C#
.NET
Python
Console Application
Methods
Loops
Conditions
Dictionary
File I/O
Code Generation
Project Structure

Version 1.0 intentionally uses a simple structure and consists of a single C# source file.

BotGenerator/
→ BotGenerator.cs
→ README.md
Purpose

This project was created as a personal programming project to practice C# and learn how a program can generate source code for other programming languages.

The project will be developed gradually in future versions.

# Roadmap
v1.0 → Basic Bot Generator |
v2.0 → Educational Bot |
v3.0 → Command Mode

Future versions may add more commands and capabilities.

# Version

Current Version: v1.0
