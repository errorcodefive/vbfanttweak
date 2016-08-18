Public Class Form4
    Dim posArray(8) As Boolean
    Dim pointArray(38) As Double

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged

        CheckBox1.Checked = CheckBox11.Checked
        CheckBox2.Checked = CheckBox11.Checked
        CheckBox3.Checked = CheckBox11.Checked
        CheckBox4.Checked = CheckBox11.Checked

    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        CheckBox5.Checked = CheckBox10.Checked
        CheckBox6.Checked = CheckBox10.Checked
        CheckBox7.Checked = CheckBox10.Checked
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        CheckBox1.Checked = CheckBox9.Checked
        CheckBox2.Checked = CheckBox9.Checked
        CheckBox3.Checked = CheckBox9.Checked
        CheckBox4.Checked = CheckBox9.Checked
        CheckBox5.Checked = CheckBox9.Checked
        CheckBox6.Checked = CheckBox9.Checked
        CheckBox7.Checked = CheckBox9.Checked
        CheckBox8.Checked = CheckBox9.Checked
        CheckBox10.Checked = CheckBox9.Checked
        CheckBox11.Checked = CheckBox9.Checked

    End Sub

    Private Sub btnPosUpdate_Click(sender As Object, e As EventArgs)

        posArray(0) = CheckBox1.Checked()
        posArray(1) = CheckBox2.Checked()
        posArray(2) = CheckBox3.Checked()
        posArray(3) = CheckBox4.Checked()
        posArray(4) = CheckBox5.Checked()
        posArray(5) = CheckBox6.Checked()
        posArray(6) = CheckBox7.Checked()
        posArray(7) = CheckBox8.Checked()



    End Sub
    Function sendUpdatePos()
        posArray(0) = CheckBox1.Checked
        posArray(1) = CheckBox2.Checked
        posArray(2) = CheckBox3.Checked
        posArray(3) = CheckBox4.Checked
        posArray(4) = CheckBox5.Checked
        posArray(5) = CheckBox6.Checked
        posArray(6) = CheckBox7.Checked
        posArray(7) = CheckBox8.Checked

        Return posArray
    End Function
    Function sendUpdatePoints()
        updatePoints()
        Return pointArray
    End Function
    Function updatePoints()

        pointArray(0) = numPyards.Value
        pointArray(1) = numPassTD.Value
        pointArray(2) = numPassInt.Value
        pointArray(3) = numPassSack.Value
        pointArray(4) = NumericUpDown8.Value
        pointArray(5) = NumericUpDown7.Value
        pointArray(6) = NumericUpDown5.Value
        pointArray(7) = NumericUpDown6.Value
        pointArray(8) = NumericUpDown12.Value
        pointArray(9) = NumericUpDown11.Value
        pointArray(10) = NumericUpDown10.Value
        pointArray(11) = NumericUpDown9.Value
        pointArray(12) = NumericUpDown15.Value
        pointArray(13) = NumericUpDown16.Value
        pointArray(14) = NumericUpDown18.Value
        pointArray(15) = NumericUpDown17.Value
        pointArray(16) = NumericUpDown14.Value
        pointArray(17) = NumericUpDown13.Value
        pointArray(18) = NumericUpDown19.Value
        pointArray(19) = NumericUpDown24.Value
        pointArray(20) = NumericUpDown23.Value
        pointArray(21) = NumericUpDown22.Value
        pointArray(22) = NumericUpDown21.Value
        pointArray(23) = NumericUpDown20.Value
        pointArray(24) = NumericUpDown29.Value
        pointArray(25) = NumericUpDown28.Value
        pointArray(26) = NumericUpDown27.Value
        pointArray(27) = NumericUpDown27.Value
        pointArray(28) = NumericUpDown26.Value
        pointArray(29) = NumericUpDown26.Value
        pointArray(30) = NumericUpDown25.Value
        pointArray(31) = NumericUpDown25.Value
        pointArray(32) = NumericUpDown30.Value
        pointArray(33) = NumericUpDown31.Value
        pointArray(34) = NumericUpDown33.Value
        pointArray(35) = NumericUpDown32.Value
        pointArray(36) = NumericUpDown34.Value
        pointArray(37) = NumericUpDown35.Value



    End Function
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatePoints()

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

    End Sub
End Class