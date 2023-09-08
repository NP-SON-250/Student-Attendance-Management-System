<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lectureregister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lectureregister))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lectcode = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.degree = New System.Windows.Forms.Label()
        Me.Fullname = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.leccodetext = New System.Windows.Forms.TextBox()
        Me.degreetxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.Fullnametxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 640)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(165, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 39)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "G6"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 467)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SAMS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(342, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(875, 640)
        Me.DataGridView1.TabIndex = 12
        '
        'registerbtn
        '
        Me.registerbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.registerbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.registerbtn.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerbtn.Location = New System.Drawing.Point(429, 446)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(131, 36)
        Me.registerbtn.TabIndex = 13
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(585, 450)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Already Have Account?"
        '
        'lectcode
        '
        Me.lectcode.AutoSize = True
        Me.lectcode.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lectcode.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lectcode.Location = New System.Drawing.Point(408, 118)
        Me.lectcode.Name = "lectcode"
        Me.lectcode.Size = New System.Drawing.Size(140, 25)
        Me.lectcode.TabIndex = 16
        Me.lectcode.Text = "Lecture Code"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.email.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(820, 118)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(68, 25)
        Me.email.TabIndex = 17
        Me.email.Text = "Email"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.username.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(820, 195)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(117, 25)
        Me.username.TabIndex = 18
        Me.username.Text = "User Name"
        '
        'degree
        '
        Me.degree.AutoSize = True
        Me.degree.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.degree.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.degree.Location = New System.Drawing.Point(408, 282)
        Me.degree.Name = "degree"
        Me.degree.Size = New System.Drawing.Size(78, 25)
        Me.degree.TabIndex = 19
        Me.degree.Text = "Degree"
        '
        'Fullname
        '
        Me.Fullname.AutoSize = True
        Me.Fullname.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Fullname.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fullname.Location = New System.Drawing.Point(408, 195)
        Me.Fullname.Name = "Fullname"
        Me.Fullname.Size = New System.Drawing.Size(111, 25)
        Me.Fullname.TabIndex = 20
        Me.Fullname.Text = "Full Name"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.password.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(820, 282)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(103, 25)
        Me.password.TabIndex = 21
        Me.password.Text = "Password"
        '
        'leccodetext
        '
        Me.leccodetext.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.leccodetext.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leccodetext.Location = New System.Drawing.Point(413, 155)
        Me.leccodetext.Name = "leccodetext"
        Me.leccodetext.Size = New System.Drawing.Size(210, 33)
        Me.leccodetext.TabIndex = 22
        '
        'degreetxt
        '
        Me.degreetxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.degreetxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.degreetxt.Location = New System.Drawing.Point(413, 324)
        Me.degreetxt.Name = "degreetxt"
        Me.degreetxt.Size = New System.Drawing.Size(210, 33)
        Me.degreetxt.TabIndex = 23
        '
        'passtxt
        '
        Me.passtxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.passtxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.Location = New System.Drawing.Point(825, 324)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(210, 33)
        Me.passtxt.TabIndex = 24
        '
        'usernametxt
        '
        Me.usernametxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.usernametxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(825, 236)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(210, 33)
        Me.usernametxt.TabIndex = 25
        '
        'emailtxt
        '
        Me.emailtxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.emailtxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailtxt.Location = New System.Drawing.Point(825, 155)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(210, 33)
        Me.emailtxt.TabIndex = 26
        '
        'Fullnametxt
        '
        Me.Fullnametxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Fullnametxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fullnametxt.Location = New System.Drawing.Point(413, 236)
        Me.Fullnametxt.Name = "Fullnametxt"
        Me.Fullnametxt.Size = New System.Drawing.Size(210, 33)
        Me.Fullnametxt.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(634, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 39)
        Me.Label5.TabIndex = 201
        Me.Label5.Text = "G6"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(566, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 39)
        Me.Label6.TabIndex = 200
        Me.Label6.Text = "SAMS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(675, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 25)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Lecture Registration Form"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Location = New System.Drawing.Point(827, 451)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(110, 20)
        Me.LinkLabel1.TabIndex = 202
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "&Back To Login"
        '
        'Lectureregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1214, 641)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Fullnametxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.degreetxt)
        Me.Controls.Add(Me.leccodetext)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Fullname)
        Me.Controls.Add(Me.degree)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.lectcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.registerbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lectureregister"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents registerbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lectcode As Label
    Friend WithEvents email As Label
    Friend WithEvents username As Label
    Friend WithEvents degree As Label
    Friend WithEvents Fullname As Label
    Friend WithEvents password As Label
    Friend WithEvents leccodetext As TextBox
    Friend WithEvents degreetxt As TextBox
    Friend WithEvents passtxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents Fullnametxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
