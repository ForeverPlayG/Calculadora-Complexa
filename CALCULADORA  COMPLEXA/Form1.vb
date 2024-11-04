Imports System.Diagnostics.Eventing.Reader
Imports System.Math
Imports System.Threading
' A MODIFICAR: Quando for feita a FR, vai aparecer outro visor a mostrai x2=  FEITO
'              Botão de cancelar nas combinações que crasha    
'              corrigir Aparecer escrito no txtbox o que estou a escrever na trignometria, raiz , raiz de indice X, log e  calc comb
'              Botão para apagar o ultimo caracter escrito FEITO 
'              Personalização 
'              :D
Public Class Form1
    Dim eae, op As Byte
    Dim n1, n2 As Long
    Dim isRadians As Boolean = False



    Private Sub tecla(i As Byte)
        If eae = 0 Then
            TxtBox.Text = i
            eae = 1
        Else
            TxtBox.Text = TxtBox.Text & i
        End If
    End Sub

    Private Sub TxtBox_TextChanged(sender As Object, e As EventArgs) Handles TxtBox.TextChanged
        eae = 0
    End Sub


    Private Sub Btt1_Click(sender As Object, e As EventArgs) Handles Btt1.Click
        tecla(1)
    End Sub

    Private Sub Btt2_Click(sender As Object, e As EventArgs) Handles Btt2.Click
        tecla(2)
    End Sub

    Private Sub Btt3_Click(sender As Object, e As EventArgs) Handles Btt3.Click
        tecla(3)
    End Sub

    Private Sub Btt4_Click(sender As Object, e As EventArgs) Handles Btt4.Click
        tecla(4)
    End Sub

    Private Sub Btt5_Click(sender As Object, e As EventArgs) Handles Btt5.Click
        tecla(5)
    End Sub

    Private Sub Btt6_Click(sender As Object, e As EventArgs) Handles Btt6.Click
        tecla(6)
    End Sub

    Private Sub Btt7_Click(sender As Object, e As EventArgs) Handles Btt7.Click
        tecla(7)
    End Sub

    Private Sub Btt8_Click(sender As Object, e As EventArgs) Handles Btt8.Click
        tecla(8)
    End Sub

    Private Sub Btt9_Click(sender As Object, e As EventArgs) Handles Btt9.Click
        tecla(9)
    End Sub

    Private Sub Btt0_Click(sender As Object, e As EventArgs) Handles Btt0.Click
        tecla(0)
    End Sub

    Private Sub BttC_Click(sender As Object, e As EventArgs) Handles BttC.Click
        eae = 0
        TxtBox.Text = "0"
        BttGRAUS.BackColor = SystemColors.Control
        BttRAD.BackColor = SystemColors.Control
    End Sub

    Private Sub BttPONTO_Click(sender As Object, e As EventArgs) Handles BttPONTO.Click
        If Not TxtBox.Text.Contains(".") Then
            TxtBox.Text = TxtBox.Text & "."
        End If
    End Sub

    Private Sub BttIGUAL_Click(sender As Object, e As EventArgs) Handles BttIGUAL.Click
        n2 = Val(TxtBox.Text)
        Select Case op
            Case 1
                TxtBox.Text = Str(n1 + n2)
            Case 2
                TxtBox.Text = Str(n1 - n2)
            Case 3
                TxtBox.Text = Str(n1 * n2)
            Case 4
                TxtBox.Text = Str(n1 / n2)
            Case 5
                TxtBox.Text = Str(n1 ^ n2)
            Case 6
                TxtBox.Text = Str(If(isRadians, Sin(n1), Sin(n1 * PI / 180)))
            Case 7
                TxtBox.Text = Str(If(isRadians, Cos(n1), Cos(n1 * PI / 180)))
            Case 8
                TxtBox.Text = Str(If(isRadians, Tan(n1), Tan(n1 * PI / 180)))

            Case 9
                TxtBox.Text = Str(If(isRadians, Asin(n1), Asin(n1) * 180 / PI))
            Case 10
                TxtBox.Text = Str(If(isRadians, Acos(n1), Acos(n1) * 180 / PI))
            Case 11
                TxtBox.Text = Str(If(isRadians, Atan(n1), Atan(n1) * 180 / PI))
            Case 13
                TxtBox.Text = Str(Log10(n1))
        End Select
        eae = 0
    End Sub
    '-------------------------------------------------------------------------------------------------------
    Private Sub BttMAIS_Click(sender As Object, e As EventArgs) Handles BttMAIS.Click
        op = 1
        eae = 0
        n1 = Val(TxtBox.Text)
        TxtBox.Text &= " + " & n2
    End Sub

    Private Sub BttMENOS_Click(sender As Object, e As EventArgs) Handles BttMENOS.Click
        op = 2
        eae = 0
        n1 = Val(TxtBox.Text)
        TxtBox.Text &= " - " & n2
    End Sub

    Private Sub BttVEZES_Click(sender As Object, e As EventArgs) Handles BttVEZES.Click
        op = 3
        eae = 0
        n1 = Val(TxtBox.Text)
        TxtBox.Text &= " X " & n2

    End Sub

    Private Sub BttDIVIDIR_Click(sender As Object, e As EventArgs) Handles BttDIVIDIR.Click
        op = 4
        eae = 0
        n1 = Val(TxtBox.Text)
        TxtBox.Text &= " : " & n2

    End Sub

    '-------------------------------------------------------------------------------------------------------


    Private Sub BttSQR_Click(sender As Object, e As EventArgs) Handles BttSQR.Click
        n1 = Val(TxtBox.Text)
        'TxtBox.Text = Str(Sqrt(n1))
        eae = 0
        TxtBox.Text &= "√" & n1 & "=" & Str(Sqrt(n1))

    End Sub

    Private Sub BttPI_Click(sender As Object, e As EventArgs) Handles BttPI.Click
        TxtBox.Text = Str(PI)
        eae = 0
    End Sub

    Private Sub BttELEVADO_Click(sender As Object, e As EventArgs) Handles BttELEVADO.Click
        op = 5
        eae = 0
        n1 = Val(TxtBox.Text)
    End Sub


    '-------------------------------------------------------------------------------------------------------

    ' trignometria
    Private Sub BttSIN_Click(sender As Object, e As EventArgs) Handles BttSIN.Click
        n1 = Val(TxtBox.Text)
        TxtBox.Text = "SIN(" & n1 & If(isRadians, " rad", "°") & ")"
        op = 6
    End Sub

    Private Sub BttCOS_Click(sender As Object, e As EventArgs) Handles BttCOS.Click
        n1 = Val(TxtBox.Text)
        TxtBox.Text = "COS(" & n1 & If(isRadians, " rad", "°") & ")"
        op = 7
    End Sub

    Private Sub BttTAN_Click(sender As Object, e As EventArgs) Handles BttTAN.Click
        n1 = Val(TxtBox.Text)
        TxtBox.Text = "TAN(" & n1 & If(isRadians, " rad", "°") & ")"
        op = 8
    End Sub


    Private Sub BttSIN1_Click(sender As Object, e As EventArgs) Handles BttSIN1.Click
        n1 = Val(TxtBox.Text)
        TxtBox.Text = "SIN⁻¹(" & n1 & If(isRadians, " rad", "°") & ")"
        op = 9
    End Sub

    Private Sub BttCOS1_Click(sender As Object, e As EventArgs) Handles BttCOS1.Click
        n1 = Val(TxtBox.Text)
        TxtBox.Text = "COS⁻¹(" & n1 & If(isRadians, " rad", "°") & ")"
        op = 10
    End Sub

    Private Sub BttTAN1_Click(sender As Object, e As EventArgs) Handles BttTAN1.Click
        n1 = Val(TxtBox.Text)
        TxtBox.Text = "TAN⁻¹(" & n1 & If(isRadians, " rad", "°") & ")"
        op = 11
    End Sub


    ' Alternar radianos e graus
    Private Sub BttRAD_Click(sender As Object, e As EventArgs) Handles BttRAD.Click
        isRadians = True
        BttGRAUS.BackColor = SystemColors.Control
        BttRAD.BackColor = Color.White
    End Sub

    Private Sub BttGRAUS_Click(sender As Object, e As EventArgs) Handles BttGRAUS.Click
        isRadians = False
        BttGRAUS.BackColor = Color.White
        BttRAD.BackColor = SystemColors.Control
    End Sub


    '---------------------------------------------------------------------------------------------------------------



    Private Sub BttLOG_Click(sender As Object, e As EventArgs) Handles BttLOG.Click
        n1 = Val(TxtBox.Text)
        op = 13
        eae = 0
        'TxtBox.Text &= "Log" & n1 & "=" & op = 13
    End Sub




    Private Sub BttAPAGAR_Click(sender As Object, e As EventArgs) Handles BttAPAGAR.Click
        If TxtBox.Text.Length > 0 Then
            ' Remove o último caractere
            TxtBox.Text = TxtBox.Text.Substring(0, TxtBox.Text.Length - 1)
        End If
        If TxtBox.Text.Length = 0 Then
            eae = 0
            TxtBox.Text = "0"
        End If
    End Sub


    '-------------------------------------------------------------------------------------------------------

    'calculo combinatorio
    Private Function Fatorial(x As Double) As Double
        If x = 0 Then
            Return 1
        End If
        Return x * Fatorial(x - 1)
    End Function

    Private Sub BttFATORIAL_Click(sender As Object, e As EventArgs) Handles BttFATORIAL.Click
        n1 = Val(TxtBox.Text)

        If n1 < 0 Or n1 <> Int(n1) Then
            MsgBox("Fatorial tem que ser um número positivo e inteiro", vbCritical, "Fatorial")
            Exit Sub
        End If

        Dim result As Double = 1

        For i As Integer = 1 To n1
            result *= i
        Next

        TxtBox.Text = Str(result)
        eae = 0

    End Sub

    Private Sub BttPERMUTACOES_Click(sender As Object, e As EventArgs) Handles BttPERMUTACOES.Click
        n1 = Val(TxtBox.Text)
        Dim n As Double = InputBox("Valor de c:")

        If n > n1 Then
            MsgBox("Erro de Sintaxe, p não pode ser > n ", vbCritical, "Permutação ")

            Exit Sub
            Threading.Thread.Sleep(500)

            BttC_Click(sender, e)


        End If
        ' TxtBox.Text = Str(Fatorial(n1) / Fatorial(n1 - n)) ' nPr

        TxtBox.Text &= n1 & "P" & n & "=" & Str(Fatorial(n1) / Fatorial(n1 - n)) 'nPc
        eae = 0


    End Sub

    Private Sub BttCONTAGENS_Click(sender As Object, e As EventArgs) Handles BttCONTAGENS.Click
        n1 = Val(TxtBox.Text)
        Dim n As Double = InputBox("Valor de p:")

        If n > n1 Then
            MsgBox("Erro de Sintaxe, p não pode ser > n ", vbCritical, "Permutação ")

            Exit Sub
            Threading.Thread.Sleep(500)

            BttC_Click(sender, e)

        End If

        'TxtBox.Text = Str(Fatorial(n1) / (Fatorial(n) * Fatorial(n1 - n))) ' nCr

        TxtBox.Text &= n1 & "C" & n & "=" & Str(Fatorial(n1) / (Fatorial(n) * Fatorial(n1 - n))) 'nCp
        eae = 0

        If n > n1 Then
            TxtBox.Text = "Erro de Sintaxe, p não pode ser > n "

            '  Module Module1
            'Sub Main()
            '    Console.WriteLine(":D")
            '   Thread.Sleep(5000) ' 5000 milissegundos (5 segundos)
            '  Console.WriteLine("XD")
            'End Sub
            'End Module

            ' BttC.Click()


        End If
        '-------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub BttSQRELE_Click(sender As Object, e As EventArgs) Handles BttSQRELE.Click ' numero^(1/n)
        n1 = Val(TxtBox.Text)
        Dim n As Double = InputBox("Valor de x:")

        ' TxtBox.Text = Str(n1 ^ (1 / n))
        TxtBox.Text &= "^" & n & "√" & n1 & "=" & Str(n1 ^ (1 / n))
        eae = 0

    End Sub
    Private Sub BttFR_Click(sender As Object, e As EventArgs) Handles BttFR.Click ' Formula rosolvente 



        Dim input As String = InputBox("Escreve a, b e c separados por vírgula:", "Fórmula Resolvente")

        Dim vals() As String = input.Split(","c)


        If vals.Length <> 3 Then
            MsgBox("Escreve os 3 valores separados por vírgulas.", vbCritical, "Fórmula resolvente")
            Exit Sub
        End If

        Dim a As Double = Val(vals(0).Trim())
        Dim b As Double = Val(vals(1).Trim())
        Dim c As Double = Val(vals(2).Trim())

        ' conteudo = conteudo da rais
        Dim conteudo As Double = (b ^ 2) - (4 * a * c)

        If conteudo < 0 Then
            MsgBox("A equação não tem raízes reais.", vbCritical, "Fórmula Resolvente")
        Else

            Dim x1 As Double = (-b + Sqrt(conteudo)) / (2 * a)
            Dim x2 As Double = (-b - Sqrt(conteudo)) / (2 * a)


            TxtBox.Text = "x1 = " & x1 & vbCrLf & "x2 = " & x2


            ' A MODIFICAR: quando for feita a FR, vai aparecer outro visor a mostrai x2= 
        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------------
    Private Sub BttSD_Click(sender As Object, e As EventArgs) Handles BttSD.Click

    End Sub
End Class