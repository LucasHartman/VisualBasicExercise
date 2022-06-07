Imports System.Collections.Generic

Public Class DoubletonClass

    Function Doubleton(ByVal num As Integer) As Integer
        ' Doubleton consist out of 2 idetical digits
        ' Find the first Doubleton numer after the input
        ' 1234 returns 1311

        Dim iterate As Boolean = True
        Do While iterate

            'addup
            num += 1

            'Digits to HasSet
            Dim hash As HashSet(Of Char) = New HashSet(Of Char)(num.ToString)

            'HasSet to Array.
            Dim arr() As Char = hash.ToArray()

            'Break if Found
            If arr.Length = 2 Then
                iterate = False
            End If
        Loop

        Return num
    End Function


    Function BestDoubleton(ByVal num As Integer) As Integer
        While True
            num += 1
            If num.ToString().Distinct().ToArray().Count = 2 Then Exit While
        End While
        Return num
    End Function

End Class
