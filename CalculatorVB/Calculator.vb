Public Class Calculator
    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click,
        btn9.Click, btnDot.Click, btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click, btnClear.Click, btnEqual.Click

        Dim text As String = txtResult.Text
        Dim button As Button = CType(sender, Button)
        If button.Name = "btn1" Then
            txtResult.Text = txtResult.Text + "1"
        End If
        If button.Name = "btn2" Then
            txtResult.Text = txtResult.Text + "2"
        End If
        If button.Name = "btn3" Then
            txtResult.Text = txtResult.Text + "3"
        End If
        If button.Name = "btn4" Then
            txtResult.Text = txtResult.Text + "4"
        End If
        If button.Name = "btn5" Then
            txtResult.Text = txtResult.Text + "5"
        End If
        If button.Name = "btn6" Then
            txtResult.Text = txtResult.Text + "6"
        End If
        If button.Name = "btn7" Then
            txtResult.Text = txtResult.Text + "7"
        End If
        If button.Name = "btn8" Then
            txtResult.Text = txtResult.Text + "8"
        End If
        If button.Name = "btn9" Then
            txtResult.Text = txtResult.Text + "9"
        End If
        If button.Name = "btn0" Then
            txtResult.Text = txtResult.Text + "0"
        End If

        If button.Name = "btnDot" AndAlso text.Substring(text.Length - 1) <> "." Then
            txtResult.Text = txtResult.Text + "."
        End If
        If text.Length > 0 AndAlso ("+-/*".Contains(text.Substring(text.Length - 1)) = False) Then
            If button.Name = "btnPlus" Then
                txtResult.Text = txtResult.Text + "+"
            End If
            If button.Name = "btnMinus" Then
                txtResult.Text = txtResult.Text + "-"
            End If
            If button.Name = "btnMultiply" Then
                txtResult.Text = txtResult.Text + "*"
            End If
            If button.Name = "btnDivide" Then
                txtResult.Text = txtResult.Text + "/"
            End If
        End If


        If button.Name = "btnEqual" Then
            Dim equation As String = txtResult.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            txtResult.Text = result
        End If
        If button.Name = "btnClear" Then
            txtResult.Text = ""
        End If
    End Sub


End Class
