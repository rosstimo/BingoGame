'Tim Rossiter
'RCET0265
'Spring 2023
'Bingo Game Console Program
Option Strict On
Option Explicit On
Option Compare Text


Imports System

Module BingoGame
    Sub Main(args As String())
        'Bingo game has 75 balls
        'each letter has a specific range
        'B = 1 to 15
        'I = 16 to 30
        'N = 31 to 45
        'G = 46 to 60
        'O = 61 to 75

        Dim bingoGrid(4, 14) As Boolean

    End Sub
    ''' <summary>
    ''' Returns a random integer from 0 to the max value argument
    ''' </summary>
    ''' <param name="max"></param>
    ''' <returns>a random integer</returns>
    Function RandomNumber(max As Integer) As Integer
        Dim _randomNumber As Integer
        ' Dim max As Integer = 10
        Randomize()
        _randomNumber = CInt(Math.Floor(Rnd() * (max + 1)))
        Return _randomNumber
    End Function
End Module
