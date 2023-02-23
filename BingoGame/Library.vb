Module Library

    Private Sub Test()
        Console.WriteLine("hello from the library!")
    End Sub

    ''' <summary>
    ''' Returns a random integer from 0 to 
    ''' the max value argument inclusive
    ''' </summary>
    ''' <param name="max"></param>
    ''' <returns>a random integer</returns>
    Public Function RandomNumber(max As Integer) As Integer
        Dim _randomNumber As Integer
        ' Dim max As Integer = 10
        Randomize(Date.Now.Millisecond)
        _randomNumber = CInt(Math.Floor(Rnd() * (max + 1)))
        Return _randomNumber
    End Function

End Module
