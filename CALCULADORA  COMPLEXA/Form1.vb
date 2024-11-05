Imports System.Diagnostics.Eventing.Reader
Imports System.Math
Imports System.Threading
' A MODIFICAR:
'              Botão de cancelar nas combinações que crasha    
'              Ver se está tudo a ser escrito como deve seer
'              casas decimais da trignometria 
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
        n2 = CDbl(Val(TxtBox.Text)) ' CDbl mantem as casas decimais

        Dim resultado As Double

        Select Case op
            Case 1
                resultado = n1 + n2
                TxtBox.Text = n1 & " + " & n2 & " = " & Format(resultado, "0.######")
            Case 2
                resultado = n1 - n2
                TxtBox.Text = n1 & " - " & n2 & " = " & Format(resultado, "0.######")
            Case 3
                resultado = n1 * n2
                TxtBox.Text = n1 & " × " & n2 & " = " & Format(resultado, "0.######")
            Case 4
                If n2 <> 0 Then
                    resultado = n1 / n2
                    TxtBox.Text = n1 & " ÷ " & n2 & " = " & Format(resultado, "0.######")
                Else
                    TxtBox.Text = "Erro: Divisão por zero"
                    Exit Sub
                End If
            Case 5
                resultado = n1 ^ n2
                TxtBox.Text = n1 & " ^ " & n2 & " = " & Format(resultado, "0.######")

            Case 6
                resultado = If(isRadians, Sin(n2), Sin(n2 * PI / 180))
                TxtBox.Text = "SIN(" & n2 & If(isRadians, " rad", "°") & ") = " & Format(resultado, "0.######")
            Case 7
                resultado = If(isRadians, Cos(n2), Cos(n2 * PI / 180))
                TxtBox.Text = "COS(" & n2 & If(isRadians, " rad", "°") & ") = " & Format(resultado, "0.######")
            Case 8
                resultado = If(isRadians, Tan(n2), Tan(n2 * PI / 180))
                TxtBox.Text = "TAN(" & n2 & If(isRadians, " rad", "°") & ") = " & Format(resultado, "0.######")
            Case 9
                resultado = If(isRadians, Asin(n2), Asin(n2) * 180 / PI)
                TxtBox.Text = "SIN⁻¹(" & n2 & If(isRadians, " rad", "°") & ") = " & Format(resultado, "0.######")
            Case 10
                resultado = If(isRadians, Acos(n2), Acos(n2) * 180 / PI)
                TxtBox.Text = "COS⁻¹(" & n2 & If(isRadians, " rad", "°") & ") = " & Format(resultado, "0.######")
            Case 11
                resultado = If(isRadians, Atan(n2), Atan(n2) * 180 / PI)
                TxtBox.Text = "TAN⁻¹(" & n2 & If(isRadians, " rad", "°") & ") = " & Format(resultado, "0.######")
            Case 12
                resultado = Log10(n2)
                TxtBox.Text = "log(" & n2 & ") = " & Format(resultado, "0.######")
            Case 13
                resultado = n2 ^ 0.5
                TxtBox.Text = "√" & n2 & " = " & Format(resultado, "0.######")
        End Select
        eae = 0
    End Sub
    '-------------------------------------------------------------------------------------------------------
    Private Sub BttMAIS_Click(sender As Object, e As EventArgs) Handles BttMAIS.Click
        op = 1
        eae = 0
        n1 = Val(TxtBox.Text)
        TxtBox.Text &= " + "
    End Sub

    Private Sub BttMENOS_Click(sender As Object, e As EventArgs) Handles BttMENOS.Click
        op = 2
        eae = 0
        n1 = Val(TxtBox.Text)
        TxtBox.Text &= " - "
    End Sub

    Private Sub BttVEZES_Click(sender As Object, e As EventArgs) Handles BttVEZES.Click
        op = 3
        eae = 0
        n1 = Val(TxtBox.Text)
        TxtBox.Text &= " × "
    End Sub

    Private Sub BttDIVIDIR_Click(sender As Object, e As EventArgs) Handles BttDIVIDIR.Click
        op = 4
        eae = 0
        n1 = Val(TxtBox.Text)
        TxtBox.Text &= " ÷ "
    End Sub

    '-------------------------------------------------------------------------------------------------------


    Private Sub BttSQR_Click(sender As Object, e As EventArgs) Handles BttSQR.Click
        op = 13
        eae = 0
        TxtBox.Text = "√"

    End Sub

    Private Sub BttPI_Click(sender As Object, e As EventArgs) Handles BttPI.Click
        TxtBox.Text = Str(PI)
        eae = 0
    End Sub

    Private Sub BttELEVADO_Click(sender As Object, e As EventArgs) Handles BttELEVADO.Click
        op = 5
        eae = 0
        n1 = Val(TxtBox.Text)
        TxtBox.Text &= " ^ "
    End Sub


    '-------------------------------------------------------------------------------------------------------

    ' trignometria
    Private Sub BttSIN_Click(sender As Object, e As EventArgs) Handles BttSIN.Click
        op = 6
        TxtBox.Text = "SIN("
    End Sub

    Private Sub BttCOS_Click(sender As Object, e As EventArgs) Handles BttCOS.Click
        TxtBox.Text = "COS("
        op = 7
    End Sub

    Private Sub BttTAN_Click(sender As Object, e As EventArgs) Handles BttTAN.Click
        TxtBox.Text = "TAN("
        op = 8
    End Sub


    Private Sub BttSIN1_Click(sender As Object, e As EventArgs) Handles BttSIN1.Click
        TxtBox.Text = "SIN⁻¹("
        op = 9
    End Sub

    Private Sub BttCOS1_Click(sender As Object, e As EventArgs) Handles BttCOS1.Click
        TxtBox.Text = "COS⁻¹("
        op = 10
    End Sub

    Private Sub BttTAN1_Click(sender As Object, e As EventArgs) Handles BttTAN1.Click
        TxtBox.Text = "TAN⁻¹("
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
        op = 12
        eae = 0
        TxtBox.Text = "log("
    End Sub




    Private Sub BttAPAGAR_Click(sender As Object, e As EventArgs) Handles BttAPAGAR.Click
        If TxtBox.Text.Length > 0 Then
            ' apaga o último caractere
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

        Dim inputP As String = InputBox("Valor de p:")

        If inputP = "" Then
            BttC_Click(sender, e)
            Exit Sub
        End If

        Dim p As Double = Val(inputP)

        If p > n1 Then
            MsgBox("Erro de Sintaxe, p não pode ser > n", vbCritical, "Permutação")
            Exit Sub
        ElseIf p < 0 Or p <> Int(p) Then
            MsgBox("Erro de Sintaxe, p deve ser um número inteiro positivo", vbCritical, "Permutação")
            Exit Sub
        End If


        'If n = "" Then
        '  MsgBox("Erro de Sintaxe, n tem que ser um número ", vbCritical, "Permutação ")
        ' End If


        ' TxtBox.Text = Str(Fatorial(n1) / Fatorial(n1 - n)) ' nPr

        TxtBox.Text &= "P" & p & "=" & Str(Fatorial(n1) / Fatorial(n1 - p)) 'nPc
        eae = 0


    End Sub

    Private Sub BttCONTAGENS_Click(sender As Object, e As EventArgs) Handles BttCONTAGENS.Click
        n1 = Val(TxtBox.Text)

        Dim inputP As String = InputBox("Valor de p:")

        If inputP = "" Then
            BttC_Click(sender, e)
            Exit Sub
        End If

        Dim p As Double = Val(inputP)

        If p > n1 Then
            MsgBox("Erro de Sintaxe, p não pode ser > n", vbCritical, "Permutação")
            Exit Sub
        ElseIf p < 0 Or p <> Int(p) Then
            MsgBox("Erro de Sintaxe, p deve ser um número inteiro positivo", vbCritical, "Permutação")
            Exit Sub
        End If

        TxtBox.Text &= "C" & p & "=" & Str(Fatorial(n1) / (Fatorial(p) * Fatorial(n1 - p))) 'nCp
        eae = 0


        'TxtBox.Text = Str(Fatorial(n1) / (Fatorial(n) * Fatorial(n1 - n))) ' nCr



        '  Module Module1
        'Sub Main()
        '    Console.WriteLine(":D")
        '   Thread.Sleep(5000) ' 5000 milissegundos (5 segundos)
        '  Console.WriteLine("XD")
        'End Sub
        'End Module

        ' BttC.Click()
        '-------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub BttSQRELE_Click(sender As Object, e As EventArgs) Handles BttSQRELE.Click ' numero^(1/n)
        n1 = Val(TxtBox.Text)
        Dim n As Double = InputBox("Valor de x:")

        ' TxtBox.Text = Str(n1 ^ (1 / n))
        TxtBox.Text = "^" & n & "√" & n1 & "=" & Str(n1 ^ (1 / n))
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

        End If
    End Sub
    '--------------------------------------------------------------------------------------------------------------
    Private Sub BttSD_Click(sender As Object, e As EventArgs) Handles BttSD.Click
        Me.Close()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        tecla(Asc(e.KeyChar))
    End Sub
End Class



'tecla(asc(e.KeyChar))
' mudar key previw np txtbox par true 