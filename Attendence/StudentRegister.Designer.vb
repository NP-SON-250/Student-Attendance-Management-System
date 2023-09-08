<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRegister))
        Me.LectureStudentDataGridView6 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.genderComboBox = New System.Windows.Forms.ComboBox()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.passwordstxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.studyyeartxt = New System.Windows.Forms.TextBox()
        Me.fullnametxt = New System.Windows.Forms.TextBox()
        Me.regnumbertxt = New System.Windows.Forms.TextBox()
        Me.coursename = New System.Windows.Forms.Label()
        Me.Courselecture = New System.Windows.Forms.Label()
        Me.coursecredit = New System.Windows.Forms.Label()
        Me.coursecode = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.LectureStudentDataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LectureStudentDataGridView6
        '
        Me.LectureStudentDataGridView6.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.LectureStudentDataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LectureStudentDataGridView6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.LectureStudentDataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LectureStudentDataGridView6.Location = New System.Drawing.Point(180, 0)
        Me.LectureStudentDataGridView6.Name = "LectureStudentDataGridView6"
        Me.LectureStudentDataGridView6.RowHeadersWidth = 62
        Me.LectureStudentDataGridView6.RowTemplate.Height = 28
        Me.LectureStudentDataGridView6.Size = New System.Drawing.Size(1034, 646)
        Me.LectureStudentDataGridView6.TabIndex = 160
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 641)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 159
        Me.PictureBox1.TabStop = False
        '
        'genderComboBox
        '
        Me.genderComboBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.genderComboBox.FormattingEnabled = True
        Me.genderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.genderComboBox.Location = New System.Drawing.Point(636, 193)
        Me.genderComboBox.Name = "genderComboBox"
        Me.genderComboBox.Size = New System.Drawing.Size(186, 28)
        Me.genderComboBox.TabIndex = 191
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Addbtn.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbtn.Location = New System.Drawing.Point(396, 394)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(186, 37)
        Me.Addbtn.TabIndex = 190
        Me.Addbtn.Text = "&Register"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'passwordstxt
        '
        Me.passwordstxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.passwordstxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordstxt.Location = New System.Drawing.Point(903, 255)
        Me.passwordstxt.Name = "passwordstxt"
        Me.passwordstxt.Size = New System.Drawing.Size(186, 33)
        Me.passwordstxt.TabIndex = 189
        '
        'usernametxt
        '
        Me.usernametxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.usernametxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(903, 183)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(186, 33)
        Me.usernametxt.TabIndex = 188
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(898, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 25)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "&Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(898, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 25)
        Me.Label10.TabIndex = 186
        Me.Label10.Text = "&Password"
        '
        'studyyeartxt
        '
        Me.studyyeartxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.studyyeartxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studyyeartxt.Location = New System.Drawing.Point(636, 254)
        Me.studyyeartxt.Name = "studyyeartxt"
        Me.studyyeartxt.Size = New System.Drawing.Size(186, 33)
        Me.studyyeartxt.TabIndex = 185
        '
        'fullnametxt
        '
        Me.fullnametxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.fullnametxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnametxt.Location = New System.Drawing.Point(312, 252)
        Me.fullnametxt.Name = "fullnametxt"
        Me.fullnametxt.Size = New System.Drawing.Size(186, 33)
        Me.fullnametxt.TabIndex = 184
        '
        'regnumbertxt
        '
        Me.regnumbertxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.regnumbertxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regnumbertxt.Location = New System.Drawing.Point(313, 181)
        Me.regnumbertxt.Name = "regnumbertxt"
        Me.regnumbertxt.Size = New System.Drawing.Size(186, 33)
        Me.regnumbertxt.TabIndex = 183
        '
        'coursename
        '
        Me.coursename.AutoSize = True
        Me.coursename.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.coursename.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursename.Location = New System.Drawing.Point(308, 227)
        Me.coursename.Name = "coursename"
        Me.coursename.Size = New System.Drawing.Size(111, 25)
        Me.coursename.TabIndex = 182
        Me.coursename.Text = "&Full Name"
        '
        'Courselecture
        '
        Me.Courselecture.AutoSize = True
        Me.Courselecture.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Courselecture.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Courselecture.Location = New System.Drawing.Point(631, 155)
        Me.Courselecture.Name = "Courselecture"
        Me.Courselecture.Size = New System.Drawing.Size(82, 25)
        Me.Courselecture.TabIndex = 181
        Me.Courselecture.Text = "&Gender"
        '
        'coursecredit
        '
        Me.coursecredit.AutoSize = True
        Me.coursecredit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.coursecredit.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecredit.Location = New System.Drawing.Point(631, 226)
        Me.coursecredit.Name = "coursecredit"
        Me.coursecredit.Size = New System.Drawing.Size(113, 25)
        Me.coursecredit.TabIndex = 180
        Me.coursecredit.Text = "&Study Year"
        '
        'coursecode
        '
        Me.coursecode.AutoSize = True
        Me.coursecode.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.coursecode.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecode.Location = New System.Drawing.Point(308, 155)
        Me.coursecode.Name = "coursecode"
        Me.coursecode.Size = New System.Drawing.Size(131, 25)
        Me.coursecode.TabIndex = 179
        Me.coursecode.Text = "&Reg Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(615, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 25)
        Me.Label3.TabIndex = 193
        Me.Label3.Text = "Already Have Account?"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(614, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 39)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "G6"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(546, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 39)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "SAMS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(655, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 25)
        Me.Label4.TabIndex = 196
        Me.Label4.Text = "Student Registration Form"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(97, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 39)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "G6"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 39)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "SAMS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Location = New System.Drawing.Point(857, 402)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(110, 20)
        Me.LinkLabel1.TabIndex = 199
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "&Back To Login"
        '
        'StudentRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 641)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.genderComboBox)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.passwordstxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.studyyeartxt)
        Me.Controls.Add(Me.fullnametxt)
        Me.Controls.Add(Me.regnumbertxt)
        Me.Controls.Add(Me.coursename)
        Me.Controls.Add(Me.Courselecture)
        Me.Controls.Add(Me.coursecredit)
        Me.Controls.Add(Me.coursecode)
        Me.Controls.Add(Me.LectureStudentDataGridView6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentRegister"
        CType(Me.LectureStudentDataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LectureStudentDataGridView6 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents genderComboBox As ComboBox
    Friend WithEvents Addbtn As Button
    Friend WithEvents passwordstxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents studyyeartxt As TextBox
    Friend WithEvents fullnametxt As TextBox
    Friend WithEvents regnumbertxt As TextBox
    Friend WithEvents coursename As Label
    Friend WithEvents Courselecture As Label
    Friend WithEvents coursecredit As Label
    Friend WithEvents coursecode As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
