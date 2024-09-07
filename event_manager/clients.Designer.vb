<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clients))
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        Panel3 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Label7 = New Label()
        Panel6 = New Panel()
        Label8 = New Label()
        Panel7 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        txtnom_even = New TextBox()
        txtnbrs_partc = New TextBox()
        combotype_even = New ComboBox()
        Combolocal_even = New ComboBox()
        Comboduree_even = New ComboBox()
        date_even = New DateTimePicker()
        NumericUpDown1 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown3 = New NumericUpDown()
        NumericUpDown7 = New NumericUpDown()
        NumericUpDown8 = New NumericUpDown()
        NumericUpDown9 = New NumericUpDown()
        NumericUpDown10 = New NumericUpDown()
        Label18 = New Label()
        Label19 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label27 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown7, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown8, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown9, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(340, 1087)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(70, 188)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(79, 88)
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(70, 297)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(79, 79)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(70, 76)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(89, 83)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bahnschrift Condensed", 15.75F)
        Label2.ForeColor = SystemColors.ActiveCaption
        Label2.Location = New Point(155, 308)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 39)
        Label2.TabIndex = 4
        Label2.Text = "Participant"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bahnschrift Condensed", 15.75F)
        Label3.ForeColor = SystemColors.ActiveCaption
        Label3.Location = New Point(155, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 39)
        Label3.TabIndex = 5
        Label3.Text = "Client"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bahnschrift Condensed", 15.75F)
        Label4.ForeColor = SystemColors.ActiveCaption
        Label4.Location = New Point(155, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 39)
        Label4.TabIndex = 6
        Label4.Text = "Event"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightCyan
        Panel2.Controls.Add(PictureBox5)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(0, 898)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(340, 77)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(102, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(47, 59)
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(847, -638)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 58)
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bahnschrift Condensed", 15.75F)
        Label1.ForeColor = SystemColors.ActiveCaption
        Label1.Location = New Point(157, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 39)
        Label1.TabIndex = 3
        Label1.Text = "Logout"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightCyan
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(337, -2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1207, 88)
        Panel3.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bahnschrift Condensed", 20.25F)
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(27, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(419, 49)
        Label5.TabIndex = 7
        Label5.Text = "EVENTS MANAGEMENT SYSTEM"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold)
        Label6.Location = New Point(391, 120)
        Label6.Name = "Label6"
        Label6.Size = New Size(279, 39)
        Label6.TabIndex = 3
        Label6.Text = "informations evenement "
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(667, 143)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(861, 3)
        Panel4.TabIndex = 4
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaptionText
        Panel5.Location = New Point(667, 397)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(861, 3)
        Panel5.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold)
        Label7.Location = New Point(391, 373)
        Label7.Name = "Label7"
        Label7.Size = New Size(274, 39)
        Label7.TabIndex = 5
        Label7.Text = "informations personnels"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaptionText
        Panel6.Location = New Point(667, 662)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(861, 3)
        Panel6.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold)
        Label8.Location = New Point(391, 638)
        Label8.Name = "Label8"
        Label8.Size = New Size(258, 39)
        Label8.TabIndex = 7
        Label8.Text = "informations materiels"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.ActiveCaptionText
        Panel7.Location = New Point(391, 802)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1141, 3)
        Panel7.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 9.75F)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(1173, 898)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 72)
        Button1.TabIndex = 10
        Button1.Text = "Reserver"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button2.Font = New Font("Segoe UI", 9.75F)
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(1350, 898)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 72)
        Button2.TabIndex = 11
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(423, 187)
        Label9.Name = "Label9"
        Label9.Size = New Size(153, 25)
        Label9.TabIndex = 12
        Label9.Text = "Nom evenement :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(423, 275)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 25)
        Label10.TabIndex = 13
        Label10.Text = "Localisation"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(604, 275)
        Label11.Name = "Label11"
        Label11.Size = New Size(68, 25)
        Label11.TabIndex = 14
        Label11.Text = "Duree :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(1009, 187)
        Label12.Name = "Label12"
        Label12.Size = New Size(169, 25)
        Label12.TabIndex = 15
        Label12.Text = "Date d organisation"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(806, 187)
        Label13.Name = "Label13"
        Label13.Size = New Size(192, 25)
        Label13.TabIndex = 16
        Label13.Text = "Nombres participants :"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(604, 187)
        Label14.Name = "Label14"
        Label14.Size = New Size(148, 25)
        Label14.TabIndex = 17
        Label14.Text = "type evenement :"
        ' 
        ' txtnom_even
        ' 
        txtnom_even.Location = New Point(423, 223)
        txtnom_even.Name = "txtnom_even"
        txtnom_even.Size = New Size(165, 31)
        txtnom_even.TabIndex = 18
        ' 
        ' txtnbrs_partc
        ' 
        txtnbrs_partc.Location = New Point(806, 223)
        txtnbrs_partc.Name = "txtnbrs_partc"
        txtnbrs_partc.Size = New Size(165, 31)
        txtnbrs_partc.TabIndex = 19
        ' 
        ' combotype_even
        ' 
        combotype_even.FormattingEnabled = True
        combotype_even.Items.AddRange(New Object() {"Conference", "marriage", "Anniversaire", "Festival", "Manifestation", "Cérémonie de remise de prix", "Spectacle en direct"})
        combotype_even.Location = New Point(610, 223)
        combotype_even.Name = "combotype_even"
        combotype_even.Size = New Size(171, 33)
        combotype_even.TabIndex = 20
        ' 
        ' Combolocal_even
        ' 
        Combolocal_even.FormattingEnabled = True
        Combolocal_even.Items.AddRange(New Object() {" casablanca (1)", " casablanca (2)", " casablanca (3)", " mohamedia (1)", " mohamedia (2)", " settat", " marrakech"})
        Combolocal_even.Location = New Point(423, 308)
        Combolocal_even.Name = "Combolocal_even"
        Combolocal_even.Size = New Size(171, 33)
        Combolocal_even.TabIndex = 21
        ' 
        ' Comboduree_even
        ' 
        Comboduree_even.FormattingEnabled = True
        Comboduree_even.Items.AddRange(New Object() {" 1 jour", " 2 jours", " 3 jours", " 1 semaine", " 10 jours", " 2 semaines"})
        Comboduree_even.Location = New Point(610, 308)
        Comboduree_even.Name = "Comboduree_even"
        Comboduree_even.Size = New Size(171, 33)
        Comboduree_even.TabIndex = 22
        ' 
        ' date_even
        ' 
        date_even.Location = New Point(1009, 223)
        date_even.Name = "date_even"
        date_even.Size = New Size(284, 31)
        date_even.TabIndex = 23
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(623, 446)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(44, 31)
        NumericUpDown1.TabIndex = 24
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(751, 710)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(44, 31)
        NumericUpDown2.TabIndex = 25
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Location = New Point(501, 708)
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(44, 31)
        NumericUpDown3.TabIndex = 26
        ' 
        ' NumericUpDown7
        ' 
        NumericUpDown7.Location = New Point(1193, 445)
        NumericUpDown7.Name = "NumericUpDown7"
        NumericUpDown7.Size = New Size(44, 31)
        NumericUpDown7.TabIndex = 30
        ' 
        ' NumericUpDown8
        ' 
        NumericUpDown8.Location = New Point(623, 501)
        NumericUpDown8.Name = "NumericUpDown8"
        NumericUpDown8.Size = New Size(44, 31)
        NumericUpDown8.TabIndex = 31
        ' 
        ' NumericUpDown9
        ' 
        NumericUpDown9.Location = New Point(1472, 437)
        NumericUpDown9.Name = "NumericUpDown9"
        NumericUpDown9.Size = New Size(44, 31)
        NumericUpDown9.TabIndex = 32
        ' 
        ' NumericUpDown10
        ' 
        NumericUpDown10.Location = New Point(847, 445)
        NumericUpDown10.Name = "NumericUpDown10"
        NumericUpDown10.Size = New Size(44, 31)
        NumericUpDown10.TabIndex = 33
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(651, 713)
        Label18.Name = "Label18"
        Label18.Size = New Size(71, 25)
        Label18.TabIndex = 40
        Label18.Text = "Chaises"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(413, 710)
        Label19.Name = "Label19"
        Label19.Size = New Size(60, 25)
        Label19.TabIndex = 41
        Label19.Text = "Tables"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(907, 448)
        Label21.Name = "Label21"
        Label21.Size = New Size(286, 25)
        Label21.TabIndex = 43
        Label21.Text = "Responsable de la programmation"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(413, 504)
        Label22.Name = "Label22"
        Label22.Size = New Size(185, 25)
        Label22.TabIndex = 44
        Label22.Text = "Technicien audiovisuel"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(1254, 443)
        Label23.Name = "Label23"
        Label23.Size = New Size(212, 25)
        Label23.TabIndex = 45
        Label23.Text = "Personnel de restauration"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(679, 451)
        Label24.Name = "Label24"
        Label24.Size = New Size(116, 25)
        Label24.TabIndex = 46
        Label24.Text = "Photographe"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(413, 445)
        Label27.Name = "Label27"
        Label27.Size = New Size(161, 25)
        Label27.TabIndex = 49
        Label27.Text = "Personnel d accueil"
        ' 
        ' clients
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1544, 1050)
        Controls.Add(Label27)
        Controls.Add(Label24)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(NumericUpDown10)
        Controls.Add(NumericUpDown9)
        Controls.Add(NumericUpDown8)
        Controls.Add(NumericUpDown7)
        Controls.Add(NumericUpDown3)
        Controls.Add(NumericUpDown2)
        Controls.Add(NumericUpDown1)
        Controls.Add(date_even)
        Controls.Add(Comboduree_even)
        Controls.Add(Combolocal_even)
        Controls.Add(combotype_even)
        Controls.Add(txtnbrs_partc)
        Controls.Add(txtnom_even)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Label8)
        Controls.Add(Panel5)
        Controls.Add(Label7)
        Controls.Add(Panel4)
        Controls.Add(Label6)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "clients"
        Text = "  Event Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown7, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown8, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown9, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtnom_even As TextBox
    Friend WithEvents txtnbrs_partc As TextBox
    Friend WithEvents combotype_even As ComboBox
    Friend WithEvents Combolocal_even As ComboBox
    Friend WithEvents Comboduree_even As ComboBox
    Friend WithEvents date_even As DateTimePicker
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents NumericUpDown9 As NumericUpDown
    Friend WithEvents NumericUpDown10 As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
