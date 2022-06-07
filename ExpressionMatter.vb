Imports System.Collections.Generic

Public Class ExpressionMatterClass

    Public Function ExpressionMatter(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        'all +
        Dim op11 As Integer = a + b + c
        Dim op12 As Integer = (a + b) + c
        Dim op13 As Integer = a + (b + c)

        'Dim op14 As Integer = b + c + a
        'Dim op15 As Integer = (b + c) + a
        'Dim op16 As Integer = b + (c + a)

        'Dim op17 As Integer = c + a + b
        'Dim op18 As Integer = (c + a) + b
        'Dim op19 As Integer = c + (a + b)

        'all *
        Dim op21 As Integer = a * b * c
        Dim op22 As Integer = (a * b) * c
        Dim op23 As Integer = a * (b * c)

        'Dim op24 As Integer = b * c * a
        'Dim op25 As Integer = (b * c) * a
        'Dim op26 As Integer = b * (c * a)

        'Dim op27 As Integer = c * a * b
        'Dim op28 As Integer = (c * a) * b
        'Dim op29 As Integer = c * (a * b)

        '+ *
        Dim op31 As Integer = a + b * c
        Dim op32 As Integer = (a + b) * c
        Dim op33 As Integer = a + (b * c)

        'Dim op34 As Integer = b + c * a
        'Dim op35 As Integer = (b + c) * a
        'Dim op36 As Integer = b + (c * a)

        'Dim op37 As Integer = c + a * b
        'Dim op38 As Integer = (c + a) * b
        'Dim op39 As Integer = c + (a * b)

        '* +
        Dim op41 As Integer = a * b + c
        Dim op42 As Integer = (a * b) + c
        Dim op43 As Integer = a * (b + c)

        'Dim op44 As Integer = b * c + a
        'Dim op45 As Integer = (b * c) + a
        'Dim op46 As Integer = b * (c + a)

        'Dim op47 As Integer = c * a + b
        'Dim op48 As Integer = (c * a) + b
        'Dim op49 As Integer = c * (a + b)

        Dim arr() As Integer = {
            op11, op12, op13,
            op21, op22, op23,
            op31, op32, op33,
            op41, op42, op43}

        Return arr.Max()
    End Function

    Public Function ExpressionMatterWinner(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Return (New Integer() {
            a * (b + c),
            a * b * c,
            a + b * c,
            a + b + c,
            (a + b) * c,
            (a * b) + c
        }).Max()
    End Function


End Class
