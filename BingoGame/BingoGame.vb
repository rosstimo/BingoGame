'Tim Rossiter
'RCET0265
'Spring 2023
'Bingo Game Console Program
Option Strict On
Option Explicit On
Option Compare Text


Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Common

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
        Display(bingoGrid)
    End Sub
    ''' <summary>
    ''' Returns a random integer from 0 to the max value argument
    ''' </summary>
    ''' <param name="max"></param>
    ''' <returns>a random integer</returns>
    Private Function RandomNumber(max As Integer) As Integer
        Dim _randomNumber As Integer
        ' Dim max As Integer = 10
        Randomize()
        _randomNumber = CInt(Math.Floor(Rnd() * (max + 1)))
        Return _randomNumber
    End Function

    Private Sub Display(theArray As Boolean(,))
        'ball value logic
        'add 1 to row index
        'then add the column index times 15
        Dim temp$
        For row = 0 To 14
            For column = 0 To 4
                temp = BallLabel(column, row) & " |"
                Console.Write(temp.PadLeft(5))
            Next
            Console.WriteLine()
        Next

    End Sub
    Private Function BallLabel(column%, row%) As String
        Return "XX"
    End Function

End Module
