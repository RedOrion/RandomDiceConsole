Module Module1


    Sub Main()
        Randomize()
    End Sub

    Sub Randomize()
        Dim lowerbound As Integer = 0
        Dim upperbound As Integer = 100
        Dim sixsideddie As Integer = CInt(Int((6 * Rnd()) + 1))
        Dim zeroandonehundred As Integer = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Console.WriteLine("Six Sided Die")
        Console.WriteLine(sixsideddie)
        Console.WriteLine("Value Between 0 and 100")
        Console.WriteLine(zeroandonehundred)
        Console.ReadKey()
    End Sub

End Module