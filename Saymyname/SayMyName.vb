'Malachi Marlow
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/MalachiMarlow/SayMyName.git

Option Explicit On
Module SayMyName

    Sub Main()
        Dim userInput As String

        Console.WriteLine("What is your name?") 'Ask your name

        userInput = Console.ReadLine() 'Reads user input on next line
        Console.WriteLine("Hello! " & userInput) 'greets previous input

    End Sub

End Module
