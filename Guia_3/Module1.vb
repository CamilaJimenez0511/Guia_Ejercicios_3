Module Module1

    Sub Main()
        Dim menu As Integer
        Console.WriteLine("Seleccione el punto del ejercicio que quiere ejecutar")
        Console.WriteLine("Punto 1")
        Console.WriteLine("Punto 2")
        Console.WriteLine("Punto 3")
        Console.WriteLine("Punto 4")
        Console.WriteLine("Punto 5")
        Console.WriteLine("Punto 6")
        Console.WriteLine("Punto 7")
        Console.WriteLine("Punto 8")
        Console.WriteLine("Punto 9")
        Console.WriteLine("Punto 10")
        Console.WriteLine("Punto 11")
        Console.WriteLine("Punto 12")

        menu = Console.ReadLine()
        Select Case menu
            Case 1
                PrimerPunto()
            Case 2
                SegundoPunto()
            Case 3
                TercerPunto()
            Case 4
                CuartoPunto()
            Case 5
                QuintoPunto()
            Case 6
                SextoPunto()
            Case 7
                SeptimoPunto()
            Case 8
                OctavoPunto()
            Case 9
                NovenoPunto()
            Case 10
                DecimoPunto()
            Case 11
                OnceavoPunto()
            Case 12
                DoceavoPunto()
            Case Else
                Console.WriteLine("Digite una opción valida")

        End Select

    End Sub

    Sub PrimerPunto()

        Console.WriteLine("Determinar si un número es positivo y par.")

        Dim num1 As Integer
        Console.WriteLine("Digite un número")
        num1 = Console.ReadLine

        If (num1 Mod 2 = 0) Then
            Console.WriteLine("El número es par")
        Else
            Console.WriteLine("El número es impar")
        End If

        If (num1 < 0) Then
            Console.WriteLine("El número es negativo")
        Else
            Console.WriteLine("El número es positivo")
        End If
    End Sub

    Sub SegundoPunto()

        Console.WriteLine("Calcular el cubo de un número entero ingresado por el usuario solo sí, 
                           el número es múltiplo de 3 y 5.")

        Dim num As Integer
        Dim resultado As Integer
        Console.WriteLine("Digite un número")
        num = Console.ReadLine

        If (num Mod 3 = 0 Or num Mod 5 = 0) Then

            resultado = num * num * num
            Console.WriteLine("El cubo del número es {0}", resultado)
        Else
            Console.WriteLine("No se puede calcular el cubo del número porque no es multiplo de 3 ni de 5")
        End If

    End Sub

    Sub TercerPunto()

        Console.WriteLine("Calcular el cuadrado de un número entero ingresado por el usuario solo sí,
                           el número es múltiplo de 4 y 16.")

        Dim num As Integer
        Dim resultado As Integer
        Console.WriteLine("Digite un número")
        num = Console.ReadLine

        If (num Mod 4 = 0 Or num Mod 16 = 0) Then

            resultado = num * num
            Console.WriteLine("El cuadrado del número es {0}", resultado)
        Else
            Console.WriteLine("No se puede calcular el cuadrado del número porque no es multiplo de 4 ni de 16")
        End If
    End Sub

    Sub CuartoPunto()

        Console.WriteLine("Realizar un algoritmo que permita dar una ponderación cualitativa, según una nota
                          cuantitativa:
                          Rango: 0 y 40: Pésimo, Aplazado sin oportunidad
                          Rango: 41 y 45: Deficiente, Aplazado a reparación
                          Rango: 46 y 50: Bajo, Aplazado repetir examen
                          Rango 51 y 60: Regular, No aplazado – Remedial
                          Rango 61 y 70: Bien
                          Rango 71 y 80: Muy Bien
                          Rango 81 y 100: Excelente")

        Dim nota As Integer
        Console.WriteLine("Digite su nota cuantitativa")
        nota = Console.ReadLine

        If (nota >= 0 And nota <= 40) Then
            Console.WriteLine("Pésimo, aplazado sin oportunidad")
        ElseIf (nota >= 41 And nota <= 45) Then
            Console.WriteLine("Deficiente, aplazado a reparación")
        ElseIf (nota >= 46 And nota <= 50) Then
            Console.WriteLine("Bajo, Aplazado repetir examen")
        ElseIf (nota >= 51 And nota <= 60) Then
            Console.WriteLine("Regular, No aplazado - Remedial")
        ElseIf (nota >= 61 And nota <= 70) Then
            Console.WriteLine("Bien")
        ElseIf (nota >= 71 And nota <= 80) Then
            Console.WriteLine("Muy bien")
        ElseIf (nota >= 81 And nota <= 100) Then
            Console.WriteLine("Excelente")
        End If

    End Sub

    Sub QuintoPunto()
        Console.WriteLine("Calcular el pago por galones de gasolina de una estación de servicio, según el tipo de gasolina:
                           Gasolina Premium Extra: 1 litro: 5.000 pesos
                           Gasolina Premium: 1 litro: 3.900 pesos
                           Gasolina Corriente: 1 litro 3.200 pesos
                           Se debe mostrar la cantidad de gasolina expresada en galones y litros, 
                           el cliente pide en galones. ")
        Dim galones As Double
        Dim cantidad As Double
        Dim precio As Double
        Dim tipo As String
        Const tipo1 As String = "Premium Extra"
        Const tipo2 As String = "Premium"
        Const tipo3 As String = "Corriente"
        Console.WriteLine("Seleccione el tipo de gasolina que desea")
        Console.WriteLine(tipo1)
        Console.WriteLine(tipo2)
        Console.WriteLine(tipo3)
        tipo = Console.ReadLine()
        Console.WriteLine("Inserte la cantidad de galones")
        galones = Console.ReadLine()
        cantidad = galones * 3.7854
        If (tipo.ToLower = tipo1.ToLower And galones > 0) Then
            precio = cantidad * 5000
            Console.WriteLine("Usted pidio {0} galones de gasolina {1} lo que equivale a {2} Litros", galones, tipo1, cantidad)
            Console.WriteLine("El valor de la gasolina es de {0}", precio)
        ElseIf (tipo.ToLower = tipo2.ToLower And galones > 0) Then
            precio = cantidad * 3900
            Console.WriteLine("Usted pidio {0} galones de gasolina {1} lo que equivale a {2} Litros", galones, tipo2, cantidad)
            Console.WriteLine("El valor de la gasolina es de {0}", precio)
        ElseIf (tipo.ToLower = tipo3.ToLower And galones > 0) Then
            precio = cantidad * 3200
            Console.WriteLine("Usted pidio {0} galones de gasolina {1} lo que equivale a {2} Litros", galones, tipo3, cantidad)
            Console.WriteLine("El valor de la gasolina es de {0}", precio)
        Else
            Console.WriteLine("No se encontro el tipo de gasolina o la cantidad de galones es negativa")
        End If
    End Sub
    Sub SextoPunto()

        Console.WriteLine("Calcular el monto a pagar por el servicio de internet según el nivel del cliente y la cantidad de MB:
                           Cada MB tiene un precio de:
                           Nivel 1: 5000 mil pesos
                           Nivel 2: 7000 mil pesos
                           Nivel 3: 9000 mil pesos
                           Nivel 4: 15000 mil pesos
                           Nivel 5: 22000 mil pesos
                           Nivel 6: 30000 mil pesos
                           Todos los demás niveles 35000 mil pesos")

        Dim nivel As Integer
        Dim cantidad As Integer
        Dim total As Integer

        Dim valor1 As Integer = 5000
        Dim valor2 As Integer = 7000
        Dim valor3 As Integer = 9000
        Dim valor4 As Integer = 15000
        Dim valor5 As Integer = 22000
        Dim valor6 As Integer = 30000
        Dim valor7 As Integer = 35000
        Console.WriteLine("Digite el nivel de internet para verificar su precio")
        nivel = Console.ReadLine
        Console.WriteLine("Digite la cantidad de MB")
        cantidad = Console.ReadLine

        If (nivel = 1 And nivel > 0) Then
            total = cantidad * valor1
            Console.WriteLine("El valor es de {0}", total)
        ElseIf (nivel = 2 And nivel > 0) Then
            total = cantidad * valor2
            Console.WriteLine("El valor es de {0}", total)
        ElseIf (nivel = 3 And nivel > 0) Then
            total = cantidad * valor3
            Console.WriteLine("El valor es de {0}", total)
        ElseIf (nivel = 4 And nivel > 0) Then
            total = cantidad * valor4
            Console.WriteLine("El valor es de {0}", total)
        ElseIf (nivel = 5 And nivel > 0) Then
            total = cantidad * valor5
            Console.WriteLine("El valor es de {0}", total)
        ElseIf (nivel = 6 And nivel > 0) Then
            total = cantidad * valor6
            Console.WriteLine("El valor es de {0}", total)
        Else
            total = cantidad * valor7
            Console.WriteLine("El valor es de {0}", total)

        End If
    End Sub


    Sub SeptimoPunto()

        Console.WriteLine("Calcular el sueldo a pagar de un trabajador dado que se debe 
                           ingresar la cantidad de horas trabajadas y el valor de la hora en pesos.")

        Dim horas As Double
        Dim valorP As Double
        Dim total As Double
        Console.WriteLine("Digite la cantidad de horas que trabajo")
        horas = Console.ReadLine()
        Console.WriteLine("Digite el valor de la hora en pesos")
        valorP = Console.ReadLine()
        total = horas * valorP
        Console.WriteLine("El valor a pagar es: {0}", total)
    End Sub

    Sub OctavoPunto()

        Console.WriteLine("Calcular el interés a pagar por un dinero, colocado a generar interés diario. 
                           Se debe ingresar la cantidad de dinero, los días que
                           lleva generando interés y el interés. Se debe imprimir el interés y
                           la cantidad de dinero más el interés.")

        Dim dinero As Double
        Dim cantidad As Integer
        Dim interes As Double
        Dim pago As Double
        Console.WriteLine("Ingrese la cantidad de dinero")
        dinero = Console.ReadLine()
        Console.WriteLine("Ingrese la cantidad de días")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese la tase de interés")
        interes = Console.ReadLine()
        If (dinero > 0 And cantidad > 0 And interes > 0) Then
            pago = (dinero * cantidad) * (interes / 100)
            Console.WriteLine("La cantidad de dinero a generar interes es {0}", dinero)
            Console.WriteLine("La cantidad de días son {0} y la tasa de interes es {1}", cantidad, interes)
            Console.WriteLine("El interes a pagar es {0}", pago)
        End If

    End Sub
    Sub NovenoPunto()

        Console.WriteLine("Leer dos números enteros y determinar ¿cuál de los dos es positivo?")

        Dim num1 As Integer
        Dim num2 As Integer
        Console.WriteLine("Digite su primer número")
        num1 = Console.ReadLine
        Console.WriteLine("Digite su segundo número")
        num2 = Console.ReadLine


        If (num1 > 0 And num2 > 0) Then
            Console.WriteLine("Los dos números son positivos")

        ElseIf (num1 > 0) Then
            Console.WriteLine("El primer número es positivo")
        Else
            Console.WriteLine("El segundo número es positivo")

        End If
    End Sub
    Sub DecimoPunto()

        Console.WriteLine("Realizar un pseudocódigo que sume 3 números e imprima la suma.")

        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim resultado As Double

        Console.WriteLine("Digite su primer número")
        num1 = Console.ReadLine
        Console.WriteLine("Digite su segundo número")
        num2 = Console.ReadLine
        Console.WriteLine("Digite su tercer número")
        num3 = Console.ReadLine

        resultado = num1 + num2 + num3

        Console.WriteLine("El resultado se la suma es {0}", resultado)
    End Sub

    Sub OnceavoPunto()

        Console.WriteLine("Realizar un pseudocódigo que sume 3 números impares e imprima la suma.")

        Dim num As Double
        Dim resultado As Double
        For i As Integer = 0 To 2 Step 1
            Console.WriteLine("Digite el numero {0}", (i + 1))
            num = Console.ReadLine()
            If (num Mod 2 <> 0) Then
                resultado += num
            Else
                Console.WriteLine("El numero no puede ser par")
                i -= 1
            End If
        Next
        Console.WriteLine("La suma es: {0}", resultado)

    End Sub

    Sub DoceavoPunto()

        Console.WriteLine("Dado una compra realizada calcular: el iva e imprimir: 
                          la compra sin iva, el iva en pesos y el monto con el iva. 
                          Tomar en cuenta que el iva es el 19%.")

        Dim VCompra As Double
        Dim iva As Double = 0.19
        Dim total As Double

        Console.WriteLine("Digite el valor de su compra")
        VCompra = Console.ReadLine

        total = VCompra * iva

        Console.WriteLine("El aumento del IVA es de {0}", total)
        Console.WriteLine("El valor de su compra con IVA es de {0}", total + VCompra)
        Console.WriteLine("El valor de su compra sin IVA es de {0}", VCompra)

    End Sub

End Module
