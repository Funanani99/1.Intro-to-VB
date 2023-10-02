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
        btnClickHere = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' btnClickHere
        ' 
        btnClickHere.Location = New Point(474, 417)
        btnClickHere.Name = "btnClickHere"
        btnClickHere.Size = New Size(112, 47)
        btnClickHere.TabIndex = 0
        btnClickHere.Text = "Click Here"
        btnClickHere.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(474, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(164, 31)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(474, 197)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(164, 31)
        TextBox2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(297, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 3
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(297, 203)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 4
        Label2.Text = "Surname"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(494, 308)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(131, 29)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Sign Me Up"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(494, 343)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(115, 29)
        CheckBox2.TabIndex = 6
        CheckBox2.Text = "Subscribe"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(793, 115)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 29)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(793, 143)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(93, 29)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(793, 178)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(82, 29)
        RadioButton3.TabIndex = 9
        RadioButton3.TabStop = True
        RadioButton3.Text = "Other"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Student", "Teacher", "Proffesional", "Manager"})
        ComboBox1.Location = New Point(474, 259)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 33)
        ComboBox1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(370, 295)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(297, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 25)
        Label4.TabIndex = 12
        Label4.Text = "Proffesion"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe Print", 20F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label5.Location = New Point(196, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(676, 70)
        Label5.TabIndex = 13
        Label5.Text = "Sign Up for the MindWorx LMS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(992, 570)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnClickHere)
        Name = "Form1"
        Text = "Intro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickHere As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
