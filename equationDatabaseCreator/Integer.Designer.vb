<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInteger

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
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TextBox7 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.SuspendLayout()
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(197, 20)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(100, 23)
		Me.Button3.TabIndex = 27
		Me.Button3.Text = "Integer"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(391, 159)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(95, 23)
		Me.Button2.TabIndex = 26
		Me.Button2.Text = "Path"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(23, 197)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(463, 73)
		Me.Label5.TabIndex = 25
		Me.Label5.Text = "Path"
		'
		'TextBox7
		'
		Me.TextBox7.Location = New System.Drawing.Point(391, 115)
		Me.TextBox7.Name = "TextBox7"
		Me.TextBox7.Size = New System.Drawing.Size(95, 20)
		Me.TextBox7.TabIndex = 24
		Me.TextBox7.Text = "10000"
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(26, 161)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(100, 20)
		Me.TextBox5.TabIndex = 23
		Me.TextBox5.Text = "-100"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(160, 164)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(13, 13)
		Me.Label3.TabIndex = 22
		Me.Label3.Text = "c"
		'
		'TextBox6
		'
		Me.TextBox6.Location = New System.Drawing.Point(197, 161)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(100, 20)
		Me.TextBox6.TabIndex = 21
		Me.TextBox6.Text = "100"
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(26, 119)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(100, 20)
		Me.TextBox3.TabIndex = 20
		Me.TextBox3.Text = "-100"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(160, 122)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(13, 13)
		Me.Label2.TabIndex = 19
		Me.Label2.Text = "b"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(197, 119)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(100, 20)
		Me.TextBox4.TabIndex = 18
		Me.TextBox4.Text = "100"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(391, 68)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(95, 23)
		Me.Button1.TabIndex = 17
		Me.Button1.Text = "Generate"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(197, 71)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 20)
		Me.TextBox2.TabIndex = 16
		Me.TextBox2.Text = "100"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(160, 74)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(13, 13)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "a"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(26, 71)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 14
		Me.TextBox1.Text = "-100"
		'
		'SaveFileDialog1
		'
		Me.SaveFileDialog1.Filter = """CSV|*.csv"""
		Me.SaveFileDialog1.Title = "Save results"
		'
		'FormInteger
		'
		Me.ClientSize = New System.Drawing.Size(513, 222)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.TextBox7)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox6)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox1)
		Me.Name = "FormInteger"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents TextBox7 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox6 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
