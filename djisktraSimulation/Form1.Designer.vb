<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGetShortestPath = New System.Windows.Forms.Button()
        Me.btnMakeGraph = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGetShortestPath
        '
        Me.btnGetShortestPath.BackColor = System.Drawing.Color.PaleGreen
        Me.btnGetShortestPath.FlatAppearance.BorderSize = 0
        Me.btnGetShortestPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetShortestPath.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btnGetShortestPath.Location = New System.Drawing.Point(210, 148)
        Me.btnGetShortestPath.Name = "btnGetShortestPath"
        Me.btnGetShortestPath.Size = New System.Drawing.Size(204, 31)
        Me.btnGetShortestPath.TabIndex = 0
        Me.btnGetShortestPath.Text = "Trouvé le plus court itinéraire"
        Me.btnGetShortestPath.UseVisualStyleBackColor = False
        '
        'btnMakeGraph
        '
        Me.btnMakeGraph.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnMakeGraph.FlatAppearance.BorderSize = 0
        Me.btnMakeGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakeGraph.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeGraph.Location = New System.Drawing.Point(32, 116)
        Me.btnMakeGraph.Name = "btnMakeGraph"
        Me.btnMakeGraph.Size = New System.Drawing.Size(167, 59)
        Me.btnMakeGraph.TabIndex = 1
        Me.btnMakeGraph.Text = "Construire un graphique térritorial"
        Me.btnMakeGraph.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnGetShortestPath)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(229, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 202)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Index de chaque région"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(420, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 31)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Effacer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(210, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 27)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Entrer l'index de la région de destination"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(210, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 27)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Entrer l'index de la région source"
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Items.AddRange(New Object() {"Dakar 0", "Diourbel 1", "Fatick 2", "Kaffrine 3 ", "Kaolack 4", "Kedougou 5", "Kolda 6 ", "Louga 7", "Matam 8", "Saint-Louis 9", "Sedhiou 10", "Tambacounda 11", "Thies 12", "Gambie 13", "Touba 14", "Ziguinchor 15"})
        Me.ListBox1.Location = New System.Drawing.Point(15, 26)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(164, 154)
        Me.ListBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(487, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Implémentation de l'Algorithme de Djikstra en VB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.djisktraSimulation.My.Resources.Resources.logo_uadb_i1
        Me.PictureBox1.Location = New System.Drawing.Point(32, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 422)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMakeGraph)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Implémentation de l'Algorithme de Djikstra en VB"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGetShortestPath As Button
    Friend WithEvents btnMakeGraph As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
