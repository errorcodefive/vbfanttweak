Imports Microsoft.Office.Interop

Public Structure playerInfo
    Public firstName As String
    Public lastName As String
    Public team As String
    Public position As String
    Public ID As String
    Public statsList() As Decimal
End Structure

Public Class Form1
    Dim rawData(412, 43) As String
    Dim skip As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm2 As Form2 = New Form2
        frm2.Enabled = True
        frm2.Visible = True

        Dim d As New Dialog1

        d.ShowDialog()

        skip = False
        If skip = False Then
            Dim xlFile As String = "C:\Projects\4_PlayerStats.xls"



            Dim excel As Excel.Application = New Excel.Application
                Dim rawBook As Excel.Workbook = excel.Workbooks.Open(xlFile)
                Dim rawSheet As Excel.Worksheet = rawBook.Worksheets(1)

            '''iterate through the file to find the dimensions for the cell
            Dim rowsDone, colsDone As Boolean
            rowsDone = False
            colsDone = False
            Dim cRow As Integer = 3
            Dim cCol As Integer = 1
            While colsDone = False

                If Not (rawSheet.Cells(1, cCol).value() = "") Then
                    cCol = cCol + 1
                Else
                    colsDone = True

                End If
            End While

            While rowsDone = False

                If Not (rawSheet.Cells(cRow, 1).Value() = "") Then
                    cRow = cRow + 1
                Else
                    rowsDone = True
                End If
            End While

            '''ROWS AND COLUMNS COUNTED


            For x As Integer = 1 To cRow
                For y As Integer = 0 To cCol

                    rawData(x, y) = rawSheet.Cells(x, y + 1).Value()

                Next
                frm2.lblMisc.Text = x
            Next
            MsgBox("Finished loading")
                For y As Integer = 0 To 43
                    Dim tempCol As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                    tempCol.DataPropertyName = rawData(0, y)
                    tempCol.HeaderText = rawData(0, y)
                    tempCol.Name = rawData(0, y)
                    dataPlayer.Columns.Add(tempCol)

                Next
                For x As Integer = 1 To 412
                    Dim temprow As DataGridViewRow = dataPlayer.RowTemplate.Clone()
                    Dim n As Integer = dataPlayer.Rows.Add()
                    For y As Integer = 0 To 42
                        dataPlayer.Rows(n).Cells(y).Value = rawData(x, y)
                    Next
                Next
                excel.Quit()


            
        End If
        If skip = True Then
            Dim csv = "C:\Users\Kyle\Downloads\out.csv"
            Dim inCSV As New System.IO.StreamReader(csv)
            For x As Integer = 0 To 412
                Dim oneLine As String = inCSV.ReadLine()
                Dim splitLine() As String = oneLine.Split(",")
                For y As Integer = 0 To 43
                    rawData(x, y) = splitLine(y)
                Next
            Next
            For y As Integer = 0 To 43
                Dim tempCol As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                tempCol.DataPropertyName = rawData(0, y)
                tempCol.HeaderText = rawData(0, y)
                tempCol.Name = rawData(0, y)
                dataPlayer.Columns.Add(tempCol)
            Next
            For x As Integer = 1 To 412
                Dim temprow As DataGridViewRow = dataPlayer.RowTemplate.Clone()
                Dim n As Integer = dataPlayer.Rows.Add()
                For y As Integer = 0 To 42
                    dataPlayer.Rows(n).Cells(y).Value = rawData(x, y)
                Next

            Next
        End If
        For y As Integer = 0 To 43
            Dim tempCol As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            tempCol.DataPropertyName = rawData(0, y)
            tempCol.HeaderText = rawData(0, y)
            tempCol.Name = rawData(0, y)
            dataPlayer.Columns.Add(tempCol)

        Next
        For x As Integer = 1 To 412
            Dim temprow As DataGridViewRow = dataPlayer.RowTemplate.Clone()
            Dim n As Integer = dataPlayer.Rows.Add()
            For y As Integer = 0 To 42
                dataPlayer.Rows(n).Cells(y).Value = rawData(x, y)
            Next

        Next
        If skip = True Then
            Dim graphing As Form3 = New Form3(rawData)
            graphing.Enabled = True
            graphing.Visible = True
            Visible = False
        End If
    End Sub

    Private Sub btnToCSV_Click(sender As Object, e As EventArgs) Handles btnToCSV.Click
        Dim filePath As String = "C:\Users\Kyle\Downloads\out.csv"
        Dim outCSV As New System.IO.StreamWriter(filePath)
        Dim outString As String = ""

        For y As Integer = 0 To 412
            For x As Integer = 0 To 42
                outString = outString + dataPlayer.Rows(y).Cells(x).Value + ","

            Next
            outString = outString + Environment.NewLine
        Next
        outCSV.Write(outString)
        outCSV.Close()
        MsgBox("Output Finished")
    End Sub

    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click
        Dim graphing As Form3 = New Form3(rawData)
        graphing.Enabled = True
        graphing.Visible = True
        Me.Visible = False

    End Sub
End Class
