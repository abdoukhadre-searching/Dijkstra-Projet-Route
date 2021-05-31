Public Class Form1

    Dim g As New Graph

    Private Sub btnMakeGraph_Click(sender As Object, e As EventArgs) Handles btnMakeGraph.Click
        g.AddVertex(0, "Dakar", 0, 8)
        g.AddVertex(1, "Diourbel", 2, 11)
        g.AddVertex(2, "Fatick", 3, 8)
        g.AddVertex(3, "Kaffrine", 4, 12)
        g.AddVertex(4, "Kaolack", 4, 4)
        g.AddVertex(5, "Kédougou", 1, 3)
        g.AddVertex(6, "Kolda", 6, 1)
        g.AddVertex(7, "Louga", 7, 6)
        g.AddVertex(8, "Matam", 9, 5)
        g.AddVertex(9, "Saint-Louis", 12, 4)
        g.AddVertex(10, "Sédhiou", 12, 8)
        g.AddVertex(11, "Tambacounda", 12, 11)
        g.AddVertex(12, "Thiès", 12, 14)
        g.AddVertex(13, "Gambie", 14, 3)
        g.AddVertex(14, "Touba", 15, 12)
        g.AddVertex(15, "Ziguinchor", 16, 8)

        g.AddEdge(0, 12, 70)

        g.AddEdge(12, 0, 70)
        g.AddEdge(12, 1, 89)
        g.AddEdge(12, 2, 106)
        g.AddEdge(12, 7, 123)

        g.AddEdge(1, 12, 89)
        g.AddEdge(1, 14, 47)
        g.AddEdge(1, 2, 66)
        g.AddEdge(1, 4, 65)

        g.AddEdge(2, 12, 106)
        g.AddEdge(2, 1, 66)
        g.AddEdge(2, 4, 46)

        g.AddEdge(4, 2, 46)
        g.AddEdge(4, 12, 106)
        g.AddEdge(4, 1, 66)
        g.AddEdge(4, 13, 133)


        g.AddEdge(3, 4, 65)
        g.AddEdge(3, 14, 116)
        g.AddEdge(3, 11, 213)

        g.AddEdge(14, 1, 47)
        g.AddEdge(14, 3, 116)
        g.AddEdge(14, 7, 106)

        g.AddEdge(7, 12, 123)
        g.AddEdge(7, 14, 106)
        g.AddEdge(7, 9, 73)

        g.AddEdge(9, 7, 73)
        g.AddEdge(9, 8, 417)

        g.AddEdge(8, 9, 417)
        g.AddEdge(8, 11, 374)

        g.AddEdge(11, 3, 213)
        g.AddEdge(11, 8, 374)
        g.AddEdge(11, 6, 225)
        g.AddEdge(11, 5, 234)

        g.AddEdge(5, 11, 234)

        g.AddEdge(6, 11, 225)
        g.AddEdge(6, 10, 90)

        g.AddEdge(15, 10, 117)
        g.AddEdge(15, 13, 152)

        g.AddEdge(13, 15, 152)
        g.AddEdge(13, 4, 133)

        g.AddEdge(10, 6, 90)
        g.AddEdge(10, 15, 117)











        'g.AddEdge(0, 1, 5)
        'g.AddEdge(0, 2, 5)
        'g.AddEdge(1, 0, 5)
        'g.AddEdge(1, 2, 4)
        'g.AddEdge(1, 3, 3)
        'g.AddEdge(2, 0, 5)
        'g.AddEdge(2, 1, 4)
        'g.AddEdge(2, 3, 7)
        'g.AddEdge(2, 4, 7)
        ' g.AddEdge(2, 7, 8)
        'g.AddEdge(3, 1, 3)
        'g.AddEdge(3, 2, 7)
        'g.AddEdge(3, 7, 11)
        'g.AddEdge(3, 10, 16)
        'g.AddEdge(3, 11, 13)
        'g.AddEdge(3, 12, 14)
        'g.AddEdge(4, 2, 7)
        'g.AddEdge(4, 5, 4)
        'g.AddEdge(4, 7, 5)
        'g.AddEdge(5, 4, 4)
        'g.AddEdge(5, 6, 9)
        'g.AddEdge(6, 5, 9)
        'g.AddEdge(6, 13, 12)
        'g.AddEdge(7, 2, 8)
        'g.AddEdge(7, 3, 11)
        'g.AddEdge(7, 4, 5)
        'g.AddEdge(7, 8, 3)
        'g.AddEdge(8, 7, 3)
        'g.AddEdge(8, 9, 4)
        'g.AddEdge(9, 8, 4)
        'g.AddEdge(9, 13, 3)
        'g.AddEdge(9, 15, 8)
        'g.AddEdge(10, 3, 16)
        'g.AddEdge(10, 11, 5)
        'g.AddEdge(10, 13, 7)
        'g.AddEdge(10, 15, 4)
        'g.AddEdge(11, 3, 13)
        'g.AddEdge(11, 10, 5)
        'g.AddEdge(11, 12, 9)
        'g.AddEdge(11, 14, 4)
        'g.AddEdge(12, 3, 14)
        'g.AddEdge(12, 11, 9)
        'g.AddEdge(12, 14, 5)
        'g.AddEdge(13, 6, 12)
        'g.AddEdge(13, 9, 3)
        'g.AddEdge(13, 10, 7)
        'g.AddEdge(13, 15, 7)
        'g.AddEdge(14, 11, 4)
        'g.AddEdge(14, 12, 5)
        'g.AddEdge(15, 9, 8)
        'g.AddEdge(15, 10, 4)
        'g.AddEdge(15, 13, 7)

        MsgBox("Les Régions de la carte sont établies", vbInformation)
    End Sub

    Private Sub btnGetShortestPath_Click(sender As Object, e As EventArgs) Handles btnGetShortestPath.Click
        Dim shortestpath As List(Of String)
        shortestpath = g.AStar(CInt(TextBox1.Text), CInt(TextBox2.Text))

        Dim stOut As String = "" 'correction exigée
        For Each n In shortestpath
            stOut = stOut & n & " "
            'With formCarteSenegal
            'If .lblDakar.Text = stOut Then
            '.lblDakar.Visible = True
            'ElseIf .lblDiourbel.Text = stOut Then
            '.lblDiourbel.Visible = True
            'ElseIf .lblFatick.Text = stOut Then
            '.lblFatick.Visible = True
            'ElseIf .lblKaffrine.Text = stOut Then
            '.lblKaffrine.Visible = True
            'ElseIf .lblKao.Text = stOut Then
            '.lblKao.Visible = True
            'ElseIf .lblKedougou.Text = stOut Then
            '.lblKedougou.Visible = True
            'ElseIf .lblKolda.Text = stOut Then
            '.lblKolda.Visible = True
            'ElseIf .lblMatam.Text = stOut Then
            '.lblMatam.Visible = True
            'ElseIf .lblSaintLouis.Text = stOut Then
            '.lblSaintLouis.Visible = True
            'ElseIf .lblSédhiou.Text = stOut Then
            '.lblSédhiou.Visible = True
            'ElseIf .lblTamba.Text = stOut Then
            '.lblTamba.Visible = True
            'ElseIf .lblThies.Text = stOut Then
            '.lblThies.Visible = True
            'ElseIf .lblTouba.Text = stOut Then
            '.lblTouba.Visible = True
            'ElseIf .lblZig.Text = stOut Then
            '.lblZig.Visible = True
            'ElseIf .lbl_louga.Text = stOut Then
            '.lbl_louga.Visible = True
            'End If
            'End With
        Next
        With formCarteSenegal
            .Show()
            .Label3.Text = stOut & "Kilomètres"
        End With
        ' MsgBox("Le plus court itinéraire est la suivante : " & stOut)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 63 ' nombre entre 0 et 15 ici . code en ASCII
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 63 ' nombre entre 0 et 15 ici leur code en ASCII
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

End Class

Public Class Vertex

    Public Value As String      'payload of the vertex
    Public Index As Integer     'every vertex has an ID number
    Private X As Integer        'grid co-ordinate 
    Private Y As Integer        'grid o-ordinate 
    Public g As Integer         'g value (path distance from start) for use by A*
    Public f As Integer         'f value (g + h) for use by A* (or the start vertex point)
    Public Parent As Vertex     'previous vertex for use by A*

    Public Sub New(ByVal Index As Integer, ByVal Value As String, ByVal X As Integer, ByVal Y As Integer)
            Me.Index = Index
            Me.Value = Value
            Me.X = X
            Me.Y = Y
        End Sub

        Public Function h(destination As Vertex) As Integer
            'calculate Manhattan distance from this vertex to the desination vertex
            Return (destination.X - Me.X) + (destination.Y - Me.Y)

            'Return Math.Sqrt(((destination.X - Me.X) ^ 2 + (destination.Y - Me.Y) ^ 2))
        End Function

    End Class

Public Class Graph

    Private Const TOTAL_VERTICES As Integer = 52
    Public vertices() As Vertex                   'array of verex objects
    Private adjacencyMatrix(,) As Integer
    Private iVertex As Integer                    'for scanning vertices array

    Public Sub New()
        ReDim vertices(TOTAL_VERTICES)
        ReDim adjacencyMatrix(TOTAL_VERTICES, TOTAL_VERTICES)

        'initialise the adjacency matrix
        Dim x, y As Integer
        For x = 0 To TOTAL_VERTICES - 1
            For y = 0 To TOTAL_VERTICES - 1
                adjacencyMatrix(x, y) = 0
            Next
        Next
        iVertex = 0
    End Sub

    Public Sub AddVertex(ByVal index As Integer, ByVal value As String, ByVal X As Integer, ByVal Y As Integer)
        vertices(iVertex) = New Vertex(index, value, X, Y)
        iVertex += 1
    End Sub

    Public Sub AddEdge(ByVal StartVertex As Integer, ByVal EndVertex As Integer, Weight As Double)
        adjacencyMatrix(StartVertex, EndVertex) = Weight
        adjacencyMatrix(EndVertex, StartVertex) = Weight   'undirected graph is symetrical
    End Sub

    Public Function AStar(start As Integer, destination As Integer) As List(Of String)
        Dim openVertices As New List(Of Integer) 'this list is the fringe
        Dim closedVertices As New List(Of Integer)
        Dim unvisitedVertices As New List(Of Integer)
        Dim currentVertex As Vertex

        'all vertices are unvisited to begin with
        For i As Integer = 0 To TOTAL_VERTICES - 1
            unvisitedVertices.Add(i)
        Next

        'make the start vertex current
        unvisitedVertices.Remove(start)
        currentVertex = vertices(start)

        'calculate f value for start vertex (g + h)
        vertices(start).g = 0
        vertices(start).f = vertices(start).g + vertices(start).h(vertices(destination))

        While currentVertex IsNot vertices(destination)

            'for each vertex adjacent to current
            For i As Integer = 0 To TOTAL_VERTICES - 1
                If adjacencyMatrix(currentVertex.Index, i) > 0 Then 'it's a neighbour if it shares an edge 

                    'if it's not in closed list and not in open list
                    If (Not (closedVertices.Contains(i))) And (Not (openVertices.Contains(i))) Then
                        unvisitedVertices.Remove(i)
                        openVertices.Add(i)
                        vertices(i).Parent = currentVertex
                    End If

                    'calculate the f value for all open neighbours
                    Dim g As Integer
                    Dim f As Integer
                    g = currentVertex.g + adjacencyMatrix(currentVertex.Index, i)
                    f = g + vertices(i).h(vertices(destination))

                    'update the f value if it is brand new (existing value is 0) 
                    'or new value is smaller than existing value
                    If (vertices(i).f = 0) Or (f < vertices(i).f) Then
                        vertices(i).f = f
                        vertices(i).g = g
                        vertices(i).Parent = currentVertex
                    End If

                End If
            Next

            closedVertices.Add(currentVertex.Index)

            'remove vertex with lowest f value from open list and make it current
            Dim iSmallestf As Integer = 1000 'large value to start
            Dim iNextCurrent As Integer
            For Each i In openVertices
                If vertices(i).f < iSmallestf Then
                    iSmallestf = vertices(i).f
                    iNextCurrent = i
                End If
            Next
            openVertices.Remove(iNextCurrent)
            currentVertex = vertices(iNextCurrent)

        End While

        'generate the path information

        ''reverse of path 
        'MsgBox(vertices(destination).Parent.Value)
        'MsgBox(vertices(destination).Parent.Parent.Value)
        'MsgBox(vertices(destination).Parent.Parent.Parent.Value)
        'MsgBox(vertices(destination).Parent.Parent.Parent.Parent.Value)

        Dim shortestpath As New List(Of String)

        Dim v As Vertex
        v = vertices(destination)
        Do Until v Is Nothing
            shortestpath.Add(v.Value)
            v = v.Parent
        Loop

        shortestpath.Reverse()

        shortestpath.Add(currentVertex.g) 'returns length of path as a string

        Return shortestpath

    End Function

End Class
