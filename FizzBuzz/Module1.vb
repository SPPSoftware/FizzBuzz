Module Module1

    Sub Main()

        'Kysy aloitus ja lopetusluvut
        Console.WriteLine("Welcome to FizzBuzz!")
        Console.Write("Anna aloitusluku: ")
        Dim lower As Integer = Console.ReadLine()

        Console.Write("Anna viimeinen luku: ")
        Dim upper As Integer = Console.ReadLine()
        Console.WriteLine("-------------------------")

        'Looppaa aloituksesta lopetukseen
        For i As Integer = lower To upper
            Dim result As String = ""

            'Tarkista numero
            If (lower Mod 5 = 0) Then result = "Fizz"

            If (lower Mod 3 = 0) Then result = "Buzz"

            If (lower Mod 3 = 0 And lower Mod 5 = 0) Then result = "FizzBuzz"

            If (result.Length = 0) Then result = lower.ToString

            'Tulosta oikea numero
            Console.WriteLine(result)
            lower += 1
        Next

        Console.ReadLine()
    End Sub

End Module