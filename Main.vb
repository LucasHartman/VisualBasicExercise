Imports System

Module Main
    Sub Main()

        Console.WriteLine("Hello World!")

        Dim obj1 As Object
        obj1 = New BMIClass()
        Console.WriteLine("Your BMI: " + obj1.BMI(180, 78))

        Dim obj2 As Object
        obj2 = New ExpressionMatterClass()
        Console.WriteLine("ExpressionMatter: " + obj2.ExpressionMatter(5, 1, 3).ToString())

        Dim obj3 As Object
        obj3 = New RowWeightsClass()
        Dim t1 As Integer = obj3.RowWeights({100, 51, 50, 100})(0)
        Dim t2 As Integer = obj3.RowWeights({100, 51, 50, 100})(1)
        Console.WriteLine("RowWeights: " + t1.ToString() + " " + t2.ToString())

        Dim obj4 As Object
        obj4 = New DoubletonClass()
        Console.WriteLine("Doubleton: " + obj4.Doubleton(10).ToString())



        ' -----------------------------------------------------------------------
        Dim Res As Object
        Res = New Recepies()

        Console.WriteLine("Formatting: " + Res.Formatting(300.1234).ToString())
        'Converters
        Console.WriteLine("Array -> String: " + Res.ArrayToString(1, 2, 3, 4))
        Console.WriteLine("Array -> Array: " + Res.ArrayToArray(1, 2, 3, 4)(0).ToString())
        Console.WriteLine("Array -> HashSet: " + Res.ArrayToHashSet(2, 1, 2, 2)(1).ToString())
        Console.WriteLine("String -> Character Array: " + Res.StringToCharArray("Fish")(0))
        Console.WriteLine("Integer -> Array: " + Res.IntegerToArray("1234")(0))
        'Loops
        Console.WriteLine("For Loop: " + Res.ForLoop())
        Console.WriteLine("Do While Loop: " + Res.DoWhileLoop())







        Console.ReadLine()
    End Sub
End Module