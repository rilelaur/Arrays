Module ArraysExample

    Sub Main()
        ArrayExample()
        ArrayMultidimensional()
        ArrayItteration()
        Console.Read()
    End Sub

    Sub ArrayExample()
        'container for multiple items of the same type
        Dim names(5) As String

        names(0) = "Bob"
        names(1) = "Joe"
        names(2) = "Phil"
        names(3) = "Phillis"
        names(4) = "Ryan"

        Randomize()

        Console.WriteLine(names(Rnd()) & vbCrLf)
    End Sub

    Sub ArrayMultidimensional()
        Dim people(5, 1) As String

        people(0, 0) = "Billy"
        people(1, 0) = "Jean"
        people(2, 0) = "Joel"
        people(3, 0) = "Margaret"
        people(4, 0) = "Thatcher"

        people(0, 1) = "A"
        people(1, 1) = "B"
        people(2, 1) = "A+"
        people(3, 1) = "C-"
        people(4, 1) = "D"

        Console.WriteLine(people(0, 0) & vbCrLf)
    End Sub

    Sub ArrayItteration()
        Dim people(5, 1) As String
        Dim firstname As Integer = 0
        Dim grade As Integer = 1

        people(0, firstname) = "Billy"
        people(1, firstname) = "Jean"
        people(2, firstname) = "Joel"
        people(3, firstname) = "Margaret"
        people(4, firstname) = "Thatcher"

        people(0, grade) = "A"
        people(1, grade) = "B"
        people(2, grade) = "A+"
        people(3, grade) = "C-"
        people(4, grade) = "D"

        For i As Integer = 0 To 5
            Console.WriteLine(people(i, firstname) & " " & people(i, grade))
        Next

        'Or try this

        For i = LBound(people) To UBound(people)
            Console.WriteLine($"{people(i, 0)} {people(i, 1)}")
        Next
    End Sub

End Module
