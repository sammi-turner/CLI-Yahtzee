# CSharp-Cli-Yahtzee

A solitaire, command line version of [Yahtzee](https://en.wikipedia.org/wiki/Yahtzee) created with C Sharp 9 and .NET 5.

## Top Level Statements in C# 9

The lack of any explicitly defined namespace, 'Main' method or 'Program class' in this project probably looks wrong to those familiar with earlier versions of C Sharp. [This article](https://www.claudiobernasconi.ch/2020/12/03/csharp-9-top-level-statements/) helps to explain what is going on.

## Building A Standalone Executable from this project in Visual Studio 2019

1. Amend the default csproj file for your .NET 5 console app so that it matches the one in this repo.
2. Amend the settings in Visual Studio as shown in 'dotnet-settings.png'.
3. Click 'publish'.
