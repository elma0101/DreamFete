<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class participants
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(participants))
        Panel1 = New Panel()
        Panel3 = New Panel()
        PictureBox4 = New PictureBox()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        ImageList1 = New ImageList(components)
        Label6 = New Label()
        Panel4 = New Panel()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(340, 1085)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightCyan
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(0, 974)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(340, 77)
        Panel3.TabIndex = 9
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(99, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(47, 71)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bahnschrift Condensed", 15.75F)
        Label5.ForeColor = SystemColors.ActiveCaption
        Label5.Location = New Point(146, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 39)
        Label5.TabIndex = 0
        Label5.Text = "Logout"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(70, 188)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 89)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(70, 91)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(76, 91)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(70, 297)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(76, 77)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bahnschrift Condensed", 15.75F)
        Label4.ForeColor = SystemColors.ActiveCaption
        Label4.Location = New Point(144, 314)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 39)
        Label4.TabIndex = 4
        Label4.Text = "Participant"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bahnschrift Condensed", 15.75F)
        Label1.ForeColor = SystemColors.ActiveCaption
        Label1.Location = New Point(146, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 39)
        Label1.TabIndex = 2
        Label1.Text = "Event"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bahnschrift Condensed", 15.75F)
        Label3.ForeColor = SystemColors.ActiveCaption
        Label3.Location = New Point(146, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 39)
        Label3.TabIndex = 3
        Label3.Text = "Client"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(339, -2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1210, 88)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bahnschrift Condensed", 20.25F)
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(27, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(419, 49)
        Label2.TabIndex = 0
        Label2.Text = "EVENTS MANAGEMENT SYSTEM"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(409, 122)
        Label6.Name = "Label6"
        Label6.Size = New Size(230, 39)
        Label6.TabIndex = 2
        Label6.Text = "nom de l evenement"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.ForeColor = SystemColors.ControlText
        Panel4.Location = New Point(640, 142)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(861, 3)
        Panel4.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(446, 190)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(438, 33)
        ComboBox1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 9.75F)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(1099, 170)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 72)
        Button1.TabIndex = 5
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MediumTurquoise
        Button2.Font = New Font("Segoe UI", 9.75F)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(1273, 170)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 72)
        Button2.TabIndex = 6
        Button2.Text = "Reserver le badge"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(428, 315)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1045, 148)
        DataGridView1.TabIndex = 7
        ' 
        ' participants
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.Control
        ClientSize = New Size(1544, 1050)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Panel4)
        Controls.Add(Label6)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "participants"
        Text = "  Event Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
