Module Module1

    Sub Main()

        Dim Gate As String
        Dim InputA As Boolean
        Dim InputB As Boolean
        Dim Output As Boolean

        Do
            Console.Write("Enter logic gate: ")
            Gate = Console.ReadLine().ToUpper
            Console.Write("Enter first input: ")
            InputA = Console.ReadLine()
            Console.Write("Enter second input: ")
            InputB = Console.ReadLine()

            Select Case Gate
                Case "AND"
                    Output = InputA And InputB

                Case "NAND"
                    Output = Not (InputA And InputB)

                Case "OR"
                    Output = InputA Or InputB

                Case "NOR"
                    Output = Not (InputA Or InputB)

                Case "XOR"
                    Output = InputA Xor InputB

            End Select

            Console.WriteLine("The output is " & Output)
            Console.WriteLine()

        Loop


    End Sub

End Module
