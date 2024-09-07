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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtusername = New TextBox()
        txtlastname = New TextBox()
        txttelephone = New TextBox()
        txtemail = New TextBox()
        txtpassword = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(211, 65)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 21)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(211, 103)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 21)
        Label2.TabIndex = 1
        Label2.Text = "Lastname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(211, 143)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 21)
        Label3.TabIndex = 2
        Label3.Text = "Telephone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(211, 184)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 21)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(211, 225)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 21)
        Label5.TabIndex = 4
        Label5.Text = "Password"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(317, 61)
        txtusername.Margin = New Padding(2, 3, 2, 3)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(229, 28)
        txtusername.TabIndex = 5
        ' 
        ' txtlastname
        ' 
        txtlastname.Location = New Point(317, 98)
        txtlastname.Margin = New Padding(2, 3, 2, 3)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(229, 28)
        txtlastname.TabIndex = 6
        ' 
        ' txttelephone
        ' 
        txttelephone.Location = New Point(317, 138)
        txttelephone.Margin = New Padding(2, 3, 2, 3)
        txttelephone.Name = "txttelephone"
        txttelephone.Size = New Size(229, 28)
        txttelephone.TabIndex = 7
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(317, 178)
        txtemail.Margin = New Padding(2, 3, 2, 3)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(229, 28)
        txtemail.TabIndex = 8
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(317, 220)
        txtpassword.Margin = New Padding(2, 3, 2, 3)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(229, 28)
        txtpassword.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Font = New Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.GrayText
        Button1.Location = New Point(369, 268)
        Button1.Margin = New Padding(2, 3, 2, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 45)
        Button1.TabIndex = 10
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(875, 381)
        Controls.Add(Button1)
        Controls.Add(txtpassword)
        Controls.Add(txtemail)
        Controls.Add(txttelephone)
        Controls.Add(txtlastname)
        Controls.Add(txtusername)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form1"
        Text = "Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txttelephone As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Button1 As Button

End Class
