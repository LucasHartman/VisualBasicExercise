Imports System
Imports System.Collections.Generic


Public Class Recepies

    Public Function Formatting(ByVal x As Single)
        'Number of Digits
        Return Format(x, "0.00")
    End Function

#Region "Convert Type ////////////////////////////////////////////////////////"

    Public Function ArrayToString(ByVal ParamArray arr() As Integer) As String
        ' Convert: Array -> String
        Return String.Join(" ", arr)
    End Function


    Public Function ArrayToArray(ByVal ParamArray arr() As Integer) As Object
        'Convert: Array -> Array
        Dim getIndex As Integer = array.IndexOf(arr, 2)
        Return arr
    End Function

    Public Function ArrayToHashSet(ByVal ParamArray arr() As Integer) As Object
        'Convert: Array -> HashSet
        Dim hash As HashSet(Of Integer) = New HashSet(Of Integer)
        'Add Value
        hash.Add(1)
        'Get Length
        Dim len As Integer = hash.Count
        'Contain?
        Dim getVal As Integer = hash.Contains(2)
        'HashSet -> Array
        hash.CopyTo(arr)
        Dim newArr() As Integer = hash.ToArray()
        Return arr
    End Function

    Public Function StringToCharArray(ByVal str As String) As Object
        'String -> Character Array
        Dim charArray() As Char = str.ToCharArray
        'Character Array -> String
        Dim newString As String = String.Join("", charArray)
        Return charArray
    End Function

    Public Function IntegerToArray(ByVal num As Integer) As Object
        'Integer -> Destinct Array
        Return num.ToString().Distinct().ToArray()
    End Function

#End Region

#Region "Loop ////////////////////////////////////////////////////////"

    Public Function ForLoop()
        Dim arr(10) As Integer
        Dim counter As Integer
        'For Loop
        For counter = 1 To 10
            'Add to Array
            arr(counter) = counter
            ' Exit Loop
            If counter >= 6 Then
                Exit For
            End If
        Next
        Return String.Join(" ", arr) ' 0 1 2 3 4 5 6 0 0 0 0
    End Function

    Public Function DoWhileLoop()
        'Do While Loop
        Dim arr(10) As Integer
        Dim counter As Integer
        Do While counter <= 10
            arr(counter) = counter
            counter += 1
        Loop
        Return String.Join(" ", arr) ' 0 1 2 3 4 5 6 7 8 9 10
    End Function

#End Region

#Region "Lambda ////////////////////////////////////////////////////////"

    Public Function Lambda() As Integer

        'Lambda Increment by 1
        Dim increment = Function(x) x + 1
        Dim init1 = increment(5)

        'Lambda WriteLine
        Dim write = Sub(x) Console.WriteLine(x)
        write("Hello World")

    End Function










#End Region
End Class
