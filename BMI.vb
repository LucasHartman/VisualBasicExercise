Public Class BMIClass

    Public Function BMI(ByVal height As Single, ByVal weight As Single)
        'Calculate BMI 
        BMI = Format((weight) / (height ^ 2), "0.00")
    End Function

End Class
