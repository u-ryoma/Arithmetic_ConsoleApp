Imports System.Diagnostics.Eventing.Reader

Imports Microsoft.VisualBasic.ApplicationServices

Module Module1

    Sub Main()

        'Dim Name As String
        'Dim Age As Integer



        'Console.WriteLine("Enter Your Name: ")
        'Name = Console.ReadLine()
        'Console.WriteLine("Enter your age: ")
        'Age = Console.ReadLine()
        'Console.WriteLine("Enter your ")

        'Console.WriteLine("Hello " + Name + " " + CStr(Age) + " Years Old")

        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim userAct As String
        Dim result As Integer
        Dim optr As String


        Console.WriteLine("Enter First Number: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter Second Number: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Enter Third Number: ")
        num3 = Console.ReadLine()

        Console.WriteLine("The number you pick are: " + CStr(num1) + "," + CStr(num2) + "," + CStr(num3))

        Console.WriteLine("Do you want to calculate the number you enter?")
        userAct = Console.ReadLine()


        If (userAct = "Yes") Then
            Console.WriteLine("What operator you want to use : 1 - Addition, 2 - Subtraction, 3 - Multiply, 4 - Division")
            optr = Console.ReadLine()
        Else
            Console.WriteLine("Thank You!")
            Environment.Exit(0)
        End If

        Select Case optr
            Case "1"
                result = num1 + num2 + num3
                Console.WriteLine("The sum of number you pick is " + CStr(result))
                Environment.Exit(0)
            Case "2"
                result = num1 - num2 - num3
                Console.WriteLine("The difference of number you pick is " + CStr(result))
                Environment.Exit(0)
            Case "3"
                result = num1 * num2 * num3
                Console.WriteLine("The product of number you pick is " + CStr(result))
                Environment.Exit(0)
            Case "4"
                result = num1 / num2 / num3
                Console.WriteLine("The quotient of number you pick is " + CStr(result))
                Environment.Exit(0)

        End Select


















    End Sub

End Module
