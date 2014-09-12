Module Module1


    Sub Main()
        RandomizeSixSidedDie()
        RandomizeZeroAndOneHundred()
        RandomizeEighteenSidedDie()
        Console.ReadKey()
    End Sub

    Sub RandomizeSixSidedDie()
        Dim sixsideddie As Integer = CInt(Int((6 * Rnd()) + 1))
        Console.WriteLine("Six Sided Die")
        Console.WriteLine(sixsideddie)
    End Sub

    Sub RandomizeEighteenSidedDie()
        Dim eighteensideddie As Integer = CInt(Int((18 * Rnd()) + 1))
        Console.WriteLine("Eighteen Sided Die")
        Console.WriteLine(eighteensideddie)
    End Sub

    
    Sub RandomizeZeroAndOneHundred()
        Dim lowerbound As Integer = 0
        Dim upperbound As Integer = 100
        Dim zeroandonehundred As Integer = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Console.WriteLine("Value Between 0 and 100")
        Console.WriteLine(zeroandonehundred)
    End Sub

End Module
