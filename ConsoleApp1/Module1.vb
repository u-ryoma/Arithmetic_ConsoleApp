Imports System.Diagnostics.Eventing.Reader

Imports Microsoft.VisualBasic.ApplicationServices

Module Module1

    Sub Main()

        

        Dim num1 As Integer
        Dim num2 As Integer
        Dim input as String
        Dim userAct As String
        Dim result As Double
        Dim optr As String


        Console.WriteLine("Enter First Number: ")
        input = Console.ReadLine()
        if not Integer.TryParse(input,num1) Then
            Console.WriteLine("Invalid input, Please enter a 'NUMBER' ")
            Environment.exit(0)
            end if
        Console.WriteLine("Enter Second Number: ")
        input = Console.ReadLine()
        if not Integer.Tryparse(input,num2) then
                Console.WriteLine("Invalid input, Please enter a 'NUMBER' ")
             Environment.exit(0)
            end if
    
        Console.WriteLine("Do you want to calculate the number you enter?")
        userAct = Console.ReadLine()


        If (userAct.ToLower() = "yes") Then
            Console.WriteLine("What operator you want to use : 1 - Addition, 2 - Subtraction, 3 - Multiply, 4 - Division")
            optr = Console.ReadLine()
        Else
            Console.WriteLine("Thank You!")
            Environment.Exit(0)
        End If

        Select Case optr
            Case "1"
                result = num1 + num2 
                Console.WriteLine("The sum of number you pick is " + CStr(result))
                Environment.Exit(0)
            Case "2"
                result = num1 - num2 
                Console.WriteLine("The difference of number you pick is " + CStr(result))
                Environment.Exit(0)
            Case "3"
                result = num1 * num2 
                Console.WriteLine("The product of number you pick is " + CStr(result))
                Environment.Exit(0)
            Case "4"
                if num1 = 0 or num2 = 0  Then
                        Console.Writeline("You can't divide a number by 0")
                Else
                result = num1 / num2 
                Console.WriteLine("The quotient of number you pick is " + CStr(result))
                Environment.Exit(0)
            End if

            case else 
                    Console.Writeline("Invalid, Please choose from 1,2,3 or 4 ")

        End Select


















    End Sub

End Module
