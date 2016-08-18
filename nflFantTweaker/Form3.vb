Public Class Form3
    Dim pData As New ArrayList
    Dim pQB As New ArrayList
    Dim pRB As New ArrayList
    Dim pWR As New ArrayList
    Dim pTE As New ArrayList
    Dim pDL As New ArrayList
    Dim pLB As New ArrayList
    Dim pDB As New ArrayList
    Dim pK As New ArrayList
    Dim mg As Graphics
    Dim linePen As Pen
    Dim posArray(8) As Boolean
    Dim scoring(38) As Double

    Dim graphArray As New List(Of player)

    Dim frmSettings As Form4 = New Form4
    Public Structure player
        Public score As Double
        Public name As String

        Public team As String
        Public position As String
        Dim xpos As Integer

        Sub xsetvalue(xin As Integer)
            xpos = xin
        End Sub
    End Structure
    Public Sub New(rawData(,) As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim numRow As Integer = rawData.GetLength(0)
        Dim numCol As Integer = rawData.GetLength(1)

        For x As Integer = 0 To numRow - 1
            Dim pTemp(numCol) As String
            Dim tempOut As String = ""
            For y As Integer = 0 To numCol - 1
                pTemp(y) = rawData(x, y)
                tempOut = tempOut + rawData(x, y)
            Next
            pData.Add(pTemp)
        Next
        For x As Integer = 5 To 43
            Dim score As Double
            Dim temp As String
            temp = rawData(0, x)
            temp = temp.Substring(temp.IndexOf("=") + 1)
            If temp.IndexOf("/") > 0 Then
                Dim denom As String
                denom = temp.Substring(temp.IndexOf("/") + 1)
                score = 1 / denom
            ElseIf temp.Length = 0 Then
                score = 0
            Else
                score = temp
            End If
            scoring(x - 5) = score
        Next

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmSettings.Enabled = True
        frmSettings.Visible = True
        pData.RemoveAt(0)
        mg = Me.CreateGraphics
        linePen = New Pen(Brushes.Black, 6)


        For Each y In pData
            Dim pos As String = y(3)

            If pos = "QB" Then
                pQB.Add(y)
            ElseIf pos = "RB" Then
                pRB.Add(y)
            ElseIf pos = "WR" Then
                pWR.Add(y)
            ElseIf pos = "TE" Then
                pTE.Add(y)
            ElseIf pos = "DL" Then
                pDL.Add(y)
            ElseIf pos = "LB" Then
                pLB.Add(y)
            ElseIf pos = "DB" Then
                pDB.Add(y)
            ElseIf pos = "K" Then
                pK.Add(y)
            End If

        Next

        'Dim outToFile As String = ""
        'outToFile = "#QB" + vbCrLf
        'For Each j In pQB
        '    For i As Integer = 1 To 42
        '        outToFile = outToFile + j(i).ToString + ","
        '    Next
        '    outToFile = outToFile + vbCrLf
        'Next
        'outToFile = outToFile + "#RB" + vbCrLf
        'For Each j In pRB
        '    For i As Integer = 1 To 42
        '        outToFile = outToFile + j(i).ToString + ","
        '    Next
        '    outToFile = outToFile + vbCrLf
        'Next
        'outToFile = outToFile + "#WR" + vbCrLf
        'For Each j In pWR
        '    For i As Integer = 1 To 42
        '        outToFile = outToFile + j(i).ToString + ","
        '    Next
        '    outToFile = outToFile + vbCrLf
        'Next
        'outToFile = outToFile + "#TE" + vbCrLf
        'For Each j In pTE
        '    For i As Integer = 1 To 42
        '        outToFile = outToFile + j(i).ToString + ","
        '    Next
        '    outToFile = outToFile + vbCrLf
        'Next
        'outToFile = outToFile + "#DL" + vbCrLf
        'For Each j In pDL
        '    For i As Integer = 1 To 42
        '        outToFile = outToFile + j(i).ToString + ","
        '    Next
        '    outToFile = outToFile + vbCrLf
        'Next
        'outToFile = outToFile + "#LB" + vbCrLf
        'For Each j In pLB
        '    For i As Integer = 1 To 42
        '        outToFile = outToFile + j(i).ToString + ","
        '    Next
        '    outToFile = outToFile + vbCrLf
        'Next
        'outToFile = outToFile + "#DB" + vbCrLf
        'For Each j In pDB
        '    For i As Integer = 1 To 42
        '        outToFile = outToFile + j(i).ToString + ","
        '    Next
        '    outToFile = outToFile + vbCrLf
        'Next
        'outToFile = outToFile + "#K" + vbCrLf
        'For Each j In pK
        '    For i As Integer = 1 To 42
        '        outToFile = outToFile + j(i).ToString + ","
        '    Next
        '    outToFile = outToFile + vbCrLf
        'Next

        'My.Computer.FileSystem.WriteAllText("C:\Users\Kyle\Downloads\playerlist.txt", outToFile, False)



        redraw()

    End Sub
    Function redraw()
        mg.Clear(Color.White)
        graphArray.Clear()

        posArray = frmSettings.sendUpdatePos
        scoring = frmSettings.sendUpdatePoints

        'Dim scoreOutToFile As String = ""
        'For Each i In scoring
        '    scoreOutToFile = scoreOutToFile + i.ToString + ","
        'Next
        'My.Computer.FileSystem.WriteAllText("C:\Users\Kyle\Downloads\scorearray.txt", scoreOutToFile, False)

        Dim activeRosterScore As New ArrayList
        Dim tempPlayer As player
        If posArray(0) = True Then
            For Each x In pQB
                Dim pointTotal As Double = 0
                Dim index As Integer = 3
                For i As Integer = 5 To 42
                    pointTotal = pointTotal + (x(i) * scoring(i - 5))
                Next
                activeRosterScore.Add(pointTotal)
                tempPlayer.name = x(0) + " " + x(1)
                tempPlayer.position = x(3)
                tempPlayer.team = x(2)
                tempPlayer.score = pointTotal
                graphArray.Add(tempPlayer)
            Next
        End If
        If posArray(1) = True Then
            For Each x In pRB
                Dim pointTotal As Double = 0
                Dim index As Integer = 3
                For i As Integer = 5 To 42
                    pointTotal = pointTotal + (x(i) * scoring(i - 5))
                Next
                activeRosterScore.Add(pointTotal)
                tempPlayer.name = x(0) + " " + x(1)
                tempPlayer.position = x(3)
                tempPlayer.team = x(2)
                tempPlayer.score = pointTotal
                graphArray.Add(tempPlayer)
            Next
        End If
        If posArray(2) = True Then
            For Each x In pWR
                Dim pointTotal As Double = 0
                Dim index As Integer = 3
                For i As Integer = 5 To 42
                    pointTotal = pointTotal + (x(i) * scoring(i - 5))
                Next
                activeRosterScore.Add(pointTotal)
                tempPlayer.name = x(0) + " " + x(1)
                tempPlayer.position = x(3)
                tempPlayer.team = x(2)
                tempPlayer.score = pointTotal
                graphArray.Add(tempPlayer)
            Next
        End If
        If posArray(3) = True Then
            For Each x In pTE
                Dim pointTotal As Double = 0
                Dim index As Integer = 3
                For i As Integer = 5 To 42
                    pointTotal = pointTotal + (x(i) * scoring(i - 5))
                Next
                activeRosterScore.Add(pointTotal)
                tempPlayer.name = x(0) + " " + x(1)
                tempPlayer.position = x(3)
                tempPlayer.team = x(2)
                tempPlayer.score = pointTotal
                graphArray.Add(tempPlayer)
            Next
        End If
        If posArray(4) = True Then
            For Each x In pDL
                Dim pointTotal As Double = 0
                Dim index As Integer = 3
                For i As Integer = 5 To 42
                    pointTotal = pointTotal + (x(i) * scoring(i - 5))
                Next
                activeRosterScore.Add(pointTotal)
                tempPlayer.name = x(0) + " " + x(1)
                tempPlayer.position = x(3)
                tempPlayer.team = x(2)
                tempPlayer.score = pointTotal
                graphArray.Add(tempPlayer)
            Next
        End If
        If posArray(5) = True Then
            For Each x In pLB
                Dim pointTotal As Double = 0
                Dim index As Integer = 3
                For i As Integer = 5 To 42
                    pointTotal = pointTotal + (x(i) * scoring(i - 5))
                Next
                activeRosterScore.Add(pointTotal)
                tempPlayer.name = x(0) + " " + x(1)
                tempPlayer.position = x(3)
                tempPlayer.team = x(2)
                tempPlayer.score = pointTotal
                graphArray.Add(tempPlayer)
            Next
        End If
        If posArray(6) = True Then
            For Each x In pDB
                Dim pointTotal As Double = 0
                Dim index As Integer = 3
                For i As Integer = 5 To 42
                    pointTotal = pointTotal + (x(i) * scoring(i - 5))
                Next
                activeRosterScore.Add(pointTotal)
                tempPlayer.name = x(0) + " " + x(1)
                tempPlayer.position = x(3)
                tempPlayer.team = x(2)
                tempPlayer.score = pointTotal
                graphArray.Add(tempPlayer)
            Next
        End If
        If posArray(7) = True Then
            For Each x In pK
                Dim pointTotal As Double = 0
                Dim index As Integer = 3
                For i As Integer = 5 To 42
                    pointTotal = pointTotal + (x(i) * scoring(i - 5))
                Next
                activeRosterScore.Add(pointTotal)
                tempPlayer.name = x(0) + " " + x(1)
                tempPlayer.position = x(3)
                tempPlayer.team = x(2)
                tempPlayer.score = pointTotal
                graphArray.Add(tempPlayer)
            Next
        End If

        drawGraph(activeRosterScore)

    End Function

    'Function dLine(graph As Graphics, penn As Pen, pStart As Point, pEnd As Point, fStart As Point, fEnd As Point)
    Function dLine(graph As Graphics, penn As Pen, pStart As Point, pEnd As Point, windowSize As Point)


        'modify following so that fstart and fend are bottom left and top right corners of drawing area (smaller than form)
        Dim lineStart As Point
        Dim lineEnd As Point
        'draw window height = windowsize -150
        'width = windowsize-100
        lineStart.X = pStart.X + 50
        lineStart.Y = windowSize.Y - pStart.Y - 75

        lineEnd.X = pEnd.X + 50
        lineEnd.Y = windowSize.Y - pEnd.Y - 75

        graph.DrawLine(penn, lineStart, lineEnd)

    End Function

    Function drawGraph(playerscore As ArrayList)
        playerscore.Sort()

        Dim length As Integer
        Dim lengthPer As Integer
        Dim vertScale As Double
        Dim max As Double = 0
        Dim total As Double = 0
        For Each x In playerscore
            length = length + 1
            If x > max Then
                max = x
            End If
            total = total + x
        Next

        While True
            Dim swapped = False
            For i As Integer = 1 To length - 1
                If graphArray(i - 1).score > graphArray(i).score Then
                    Dim tempswap As player = graphArray(i)
                    graphArray(i) = graphArray(i - 1)
                    graphArray(i - 1) = tempswap
                    swapped = True
                End If
            Next
            If swapped = False Then
                Exit While

            End If
        End While
        Dim var As Double = 0
        Dim aver As Double = total / length
        For Each x In playerscore
            var = var + Math.Pow((x - aver), 2)
        Next
        var = var / length
        lblN.Text = "N = " + length.ToString
        lblMax.Text = "Max = " + max.ToString
        lblAver.Text = "Aver = " + (total / length).ToString
        lblVar.Text = "Var = " + var.ToString

        vertScale = (Me.Height - 150) / max
        lengthPer = Math.Floor((Me.Width - 100) / length)
        Dim index As Integer = 0
        For Each x In playerscore
            Dim start As New Point(index * lengthPer, 0)
            Dim endP As New Point(index * lengthPer, x * vertScale)
            dLine(mg, linePen, start, endP, New Point(Me.Width, Me.Height))
            Dim ppp As player
            ppp = graphArray(index)
            ppp.xpos = index * lengthPer
            graphArray(index) = ppp

            index = index + 1

        Next

    End Function

    Private Sub Form3_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove


    End Sub

    Private Sub btnRedraw_Click(sender As Object, e As EventArgs) Handles btnRedraw.Click
        redraw()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPlayer.Click

    End Sub

    Private Sub Form3_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If e.X < (Me.Width - 50) And e.X > 50 Then
            If e.Y > 75 And e.Y < (Me.Width - 75) Then
                lblxy.Text = e.X.ToString + " " + e.Y.ToString
                Dim found As Boolean = False
                For Each x In graphArray

                    If (x.xpos + 50) > e.X - 3 And (x.xpos + 50) < e.X + 3 Then
                        found = True
                        lblPlayer.Text = x.name + vbNewLine + x.team + " " + x.position + vbNewLine + x.score.ToString
                    End If
                Next
                If found = False Then
                    lblPlayer.Text = ""
                End If
            End If
        End If
    End Sub
End Class