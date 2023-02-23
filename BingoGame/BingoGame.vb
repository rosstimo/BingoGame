'Tim Rossiter
'RCET0265
'Spring 2023
'Bingo Game Console Program
Option Strict On
Option Explicit On
Option Compare Text


Imports System
'TODO
'add separate interface for console and WinForm app
'game play should work for either
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
        For i = 1 To 10
            ConsoleDisplay(bingoGrid)
            DrawNextBall(bingoGrid)
            '  Console.Read()

        Next

        ' Library.Test()
        'Library.RandomNumber(10)
    End Sub

    'start game play
    Sub Play()

    End Sub


    'Draw random ball and update tracking array
    Private Sub DrawNextBall(ByRef theArray As Boolean(,))
        Dim row%, column%

        Do
            row = Library.RandomNumber(14)
            column = Library.RandomNumber(4)
        Loop While theArray(column, row)

        theArray(column, row) = True

    End Sub
    Private Sub ConsoleDisplay(theArray As Boolean(,))
        Dim temp$
        Dim header = New String() {"B", "I", "N", "G", "O"}
        Dim columnWidth As Integer = 5
        Console.Clear()  'start fresh
        'build and display column header
        For i = 0 To 4
            temp = header(i) & " |"
            temp = temp.PadLeft(columnWidth)
            Console.Write(temp)
        Next
        Console.WriteLine()
        'header separator
        Console.WriteLine(StrDup(columnWidth * 5, "-"))
        'display contents of array
        'ball label shown only if ball has been drawn
        For row = 0 To 14
            For column = 0 To 4
                temp = ""
                If theArray(column, row) Then
                    temp = BallLabel(column, row)
                End If
                temp &= " |"
                Console.Write(temp.PadLeft(columnWidth))
            Next
            Console.WriteLine()
        Next

    End Sub
    Private Function BallLabel(column%, row%) As String
        'ball value logic
        'add 1 to row index
        'then add the column index times 15
        Return CStr((column * 15) + (row + 1))
    End Function

End Module
