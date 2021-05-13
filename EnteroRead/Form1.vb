Public Class Form1

    Private _codes As BioCodes

    Public ReadOnly Property Glucose() As System.Boolean
        Get
            Return Me.txtGlucose.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property GlucoseGas() As System.Boolean
        Get
            Return Me.txtGlucoseGas.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Lysine() As System.Boolean
        Get
            Return Me.txtLysine.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Ornithine() As System.Boolean
        Get
            Return Me.txtOrnithine.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property HydrogenSulfine() As System.Boolean
        Get
            Return Me.txtHydrogenSulfine.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Indole() As System.Boolean
        Get
            Return Me.chkIndole.Checked
        End Get
    End Property

    Public ReadOnly Property Adonitol() As System.Boolean
        Get
            Return Me.txtAdonitol.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Lactose() As System.Boolean
        Get
            Return Me.txtLactose.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Arabinose() As System.Boolean
        Get
            Return Me.txtArabinose.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Sorbitol() As System.Boolean
        Get
            Return Me.txtSorbitol.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Dulcitol() As System.Boolean
        Get
            Return Me.txtDulcitol.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Phenylalaine() As System.Boolean
        Get
            Return Me.txtPhenylalaine.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Urea() As System.Boolean
        Get
            Return Me.txtUrea.Text.Equals("+")
        End Get
    End Property

    Public ReadOnly Property Citrate() As System.Boolean
        Get
            Return Me.txtCitrate.Text.Equals("+")
        End Get
    End Property

    Private Sub Update1()
        Dim t1 As System.Int32 = 0
        If Me.Glucose Then
            t1 += 2
        End If
        If Me.GlucoseGas Then
            t1 += 1
        End If
        Me.txt1.Text = t1.ToString
    End Sub

    Private Sub Update2()
        Dim t2 As System.Int32 = 0
        If Me.Lysine Then
            t2 += 4
        End If
        If Me.Ornithine Then
            t2 += 2
        End If
        If Me.HydrogenSulfine Then
            t2 += 1
        End If
        Me.txt2.Text = t2.ToString
    End Sub

    Private Sub Update3()
        Dim t3 As System.Int32 = 0
        If Me.Indole Then
            t3 += 4
        End If
        If Me.Adonitol Then
            t3 += 2
        End If
        If Me.Lactose Then
            t3 += 1
        End If
        Me.txt3.Text = t3.ToString
    End Sub

    Private Sub Update4()
        Dim t4 As System.Int32 = 0
        If Me.Arabinose Then
            t4 += 4
        End If
        If Me.Sorbitol Then
            t4 += 2
        End If
        If Me.Dulcitol Then
            t4 += 1
        End If
        Me.txt4.Text = t4.ToString
    End Sub

    Private Sub Update5()
        Dim t5 As System.Int32 = 0
        If Me.Phenylalaine Then
            t5 += 4
        End If
        If Me.Urea Then
            t5 += 2
        End If
        If Me.Citrate Then
            t5 += 1
        End If
        Me.txt5.Text = t5.ToString
    End Sub

    Private _prev As System.Int32 = -1

    Private Sub UpdateCode()
        Me.Update1()
        Me.Update2()
        Me.Update3()
        Me.Update4()
        Me.Update5()

        Dim code As System.String
        code = String.Format("{0}{1}{2}{3}{4}", Me.txt1.Text, Me.txt2.Text, Me.txt3.Text, Me.txt4.Text, Me.txt5.Text)

        If code = "00000" Then
            Exit Sub
        End If
        Dim i As System.Int32 = -1
        For Each li As ListViewItem In Me.ListView1.Items
            If li.Text = code Then
                If i = -1 Then i = li.Index
                li.BackColor = Color.LightBlue
                'Exit For
            Else
                li.BackColor = Nothing
            End If
        Next

        'Debug.WriteLine(i)
        If i > -1 Then
            '    If Me._prev > -1 Then
            '        Me.ListView1.Items(Me._prev).BackColor = Nothing
            '    End If
            'Me.ListView1.Items(i).BackColor = Color.LightBlue
            If i > 0 Then i = i - 1
            If i > 0 Then i = i - 1
            Me.ListView1.TopItem = Me.ListView1.Items(i)
        End If

    End Sub

    Private Sub txtValidating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtGlucose.Validating, txtAdonitol.Validating, txtArabinose.Validating, txtCitrate.Validating, txtDulcitol.Validating, txtGlucose.Validating, txtGlucoseGas.Validating, txtHydrogenSulfine.Validating, txtLactose.Validating, txtLysine.Validating, txtOrnithine.Validating, txtPhenylalaine.Validating, txtSorbitol.Validating, txtUrea.Validating, txtVP.Validating
        If TypeOf sender Is TextBox Then
            Dim t As TextBox = DirectCast(sender, TextBox)
            If t.Text <> "-" And t.Text <> "+" Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtValidated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlucose.Validated, txtAdonitol.Validated, txtArabinose.Validated, txtCitrate.Validated, txtDulcitol.Validated, txtGlucose.Validated, txtGlucoseGas.Validated, txtHydrogenSulfine.Validated, txtLactose.Validated, txtLysine.Validated, txtOrnithine.Validated, txtPhenylalaine.Validated, txtSorbitol.Validated, txtUrea.Validated, txtVP.Validated

    End Sub

    Private Sub txtEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlucose.Enter, txtAdonitol.Enter, txtArabinose.Enter, txtCitrate.Enter, txtDulcitol.Enter, txtGlucose.Enter, txtGlucoseGas.Enter, txtHydrogenSulfine.Enter, txtLactose.Enter, txtLysine.Enter, txtOrnithine.Enter, txtPhenylalaine.Enter, txtSorbitol.Enter, txtUrea.Enter, txtVP.Enter
        If TypeOf sender Is TextBox Then
            Dim t As TextBox = DirectCast(sender, TextBox)
            t.SelectAll()
        End If
    End Sub


    Private Sub txtKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlucose.KeyPress, txtAdonitol.KeyPress, txtArabinose.KeyPress, txtCitrate.KeyPress, txtDulcitol.KeyPress, txtGlucose.KeyPress, txtGlucoseGas.KeyPress, txtHydrogenSulfine.KeyPress, txtLactose.KeyPress, txtLysine.KeyPress, txtOrnithine.KeyPress, txtPhenylalaine.KeyPress, txtSorbitol.KeyPress, txtUrea.KeyPress, txtVP.KeyPress, chkIndole.KeyPress
        Select Case e.KeyChar
            Case "+"c
                If TypeOf sender Is CheckBox Then
                    DirectCast(sender, CheckBox).Checked = True
                End If
                Debug.WriteLine(e.KeyChar)
                e.Handled = False
                Me.SelectNextControl(sender, True, True, True, True)
            Case "-"c
                If TypeOf sender Is CheckBox Then
                    DirectCast(sender, CheckBox).Checked = False
                End If
                Debug.WriteLine(e.KeyChar)
                e.Handled = False
                Me.SelectNextControl(sender, True, True, True, True)
            Case Else
                Debug.WriteLine(e.KeyChar)
                e.Handled = True
        End Select

    End Sub

    Private Sub txtGlucose_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlucose.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtGlucoseGas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlucoseGas.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtLysine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLysine.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtOrnithine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrnithine.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtHydrogenSulfine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHydrogenSulfine.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtAdonitol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdonitol.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtLactose_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLactose.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtArabinose_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArabinose.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtSorbitol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSorbitol.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtDulcitol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDulcitol.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtPhenylalaine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhenylalaine.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtUrea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUrea.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub txtCitrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCitrate.TextChanged
        Me.UpdateCode()
    End Sub

    Private Sub chkIndole_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIndole.CheckedChanged
        Me.UpdateCode()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Me.txtAdonitol.Text = "-"
        Me.txtArabinose.Text = "-"
        Me.txtCitrate.Text = "-"
        Me.txtDulcitol.Text = "-"
        Me.txtGlucose.Text = "-"
        Me.txtGlucoseGas.Text = "-"
        Me.txtHydrogenSulfine.Text = "-"
        Me.txtLactose.Text = "-"
        Me.txtLysine.Text = "-"
        Me.txtOrnithine.Text = "-"
        Me.txtPhenylalaine.Text = "-"
        Me.txtSorbitol.Text = "-"
        Me.txtUrea.Text = "-"
        Me.chkIndole.CheckState = CheckState.Unchecked
        Me.chkIndole.Update()

        For Each li As ListViewItem In Me.ListView1.Items
            li.BackColor = Nothing
        Next
        Me.ListView1.TopItem = Me.ListView1.Items(0)

        Me.Update()
        Me.txtGlucose.Focus()
        Me.txtGlucose.SelectAll()

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.ListView1.BeginUpdate()
        Me.ListView1.Items.Clear()

   

        For Each code As Code In My.Application.Data
            Dim li As New ListViewItem()
            li.Text = code.Key
            li.SubItems.Add(code.Name)
            li.SubItems.Add(code.ATypicalTests)
            li.SubItems.Add(code.ConfirmatoryTests)

            Me.ListView1.Items.Add(li)
        Next


        Me.ListView1.EndUpdate()
    End Sub

    Private Sub txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlucose.Click, txtAdonitol.Click, txtArabinose.Click, txtCitrate.Click, txtDulcitol.Click, txtGlucose.Click, txtGlucoseGas.Click, txtHydrogenSulfine.Click, txtLactose.Click, txtLysine.Click, txtOrnithine.Click, txtPhenylalaine.Click, txtSorbitol.Click, txtUrea.Click, txtVP.Click
        If TypeOf sender Is TextBox Then
            With DirectCast(sender, TextBox)
                If Not .ReadOnly Then
                    .Focus()
                    .SelectAll()
                End If
            End With
        End If
    End Sub


    Private Sub txt_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlucose.DoubleClick, txtAdonitol.DoubleClick, txtArabinose.DoubleClick, txtCitrate.DoubleClick, txtDulcitol.DoubleClick, txtGlucose.DoubleClick, txtGlucoseGas.DoubleClick, txtHydrogenSulfine.DoubleClick, txtLactose.DoubleClick, txtLysine.DoubleClick, txtOrnithine.DoubleClick, txtPhenylalaine.DoubleClick, txtSorbitol.DoubleClick, txtUrea.DoubleClick, txtVP.DoubleClick
        If TypeOf sender Is TextBox Then
            With DirectCast(sender, TextBox)
                If Not .ReadOnly Then
                    If .Text = "-" Then
                        .Text = "+"
                    ElseIf .Text = "+" Then
                        .Text = "-"
                    End If
                End If
            End With
        End If
    End Sub
End Class
