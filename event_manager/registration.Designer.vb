<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registration))
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        txtemail = New TextBox()
        txttelephone = New TextBox()
        txtlastname = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(497, 250)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(497, 302)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 1
        Label2.Text = "Lastname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(497, 447)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 25)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(497, 394)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 25)
        Label5.TabIndex = 4
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(497, 348)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 25)
        Label6.TabIndex = 5
        Label6.Text = "Telephone"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(621, 250)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(239, 31)
        txtusername.TabIndex = 6
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(621, 436)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(239, 31)
        txtpassword.TabIndex = 8
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(621, 389)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(239, 31)
        txtemail.TabIndex = 9
        ' 
        ' txttelephone
        ' 
        txttelephone.Location = New Point(621, 343)
        txttelephone.Name = "txttelephone"
        txttelephone.Size = New Size(239, 31)
        txttelephone.TabIndex = 10
        ' 
        ' txtlastname
        ' 
        txtlastname.Location = New Point(621, 297)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(239, 31)
        txtlastname.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(674, 516)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 44)
        Button1.TabIndex = 12
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(674, 566)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 42)
        Button2.TabIndex = 13
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' registration
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1544, 1050)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtlastname)
        Controls.Add(txttelephone)
        Controls.Add(txtemail)
        Controls.Add(txtpassword)
        Controls.Add(txtusername)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "registration"
        Text = "  Event Management System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttelephone As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
