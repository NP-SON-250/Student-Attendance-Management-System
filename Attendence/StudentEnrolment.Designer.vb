<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentEnrolment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentEnrolment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.enrollbtn = New System.Windows.Forms.Button()
        Me.Leavebtns = New System.Windows.Forms.Button()
        Me.enrollkeytxt = New System.Windows.Forms.TextBox()
        Me.regnumbertxt = New System.Windows.Forms.TextBox()
        Me.coursecodes = New System.Windows.Forms.Label()
        Me.studename = New System.Windows.Forms.Label()
        Me.coursecodetxt = New System.Windows.Forms.TextBox()
        Me.coursecode = New System.Windows.Forms.Label()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Searchtxt = New System.Windows.Forms.TextBox()
        Me.Searchstudent = New System.Windows.Forms.Label()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.enrolledDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enrolledDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enrollbtn
        '
        Me.enrollbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.enrollbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.enrollbtn.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollbtn.Location = New System.Drawing.Point(571, 327)
        Me.enrollbtn.Name = "enrollbtn"
        Me.enrollbtn.Size = New System.Drawing.Size(91, 37)
        Me.enrollbtn.TabIndex = 289
        Me.enrollbtn.Text = "&Enroll"
        Me.enrollbtn.UseVisualStyleBackColor = False
        '
        'Leavebtns
        '
        Me.Leavebtns.BackColor = System.Drawing.Color.IndianRed
        Me.Leavebtns.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Leavebtns.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Leavebtns.Location = New System.Drawing.Point(759, 327)
        Me.Leavebtns.Name = "Leavebtns"
        Me.Leavebtns.Size = New System.Drawing.Size(80, 37)
        Me.Leavebtns.TabIndex = 287
        Me.Leavebtns.Text = "&Leave"
        Me.Leavebtns.UseVisualStyleBackColor = False
        '
        'enrollkeytxt
        '
        Me.enrollkeytxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.enrollkeytxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollkeytxt.Location = New System.Drawing.Point(586, 276)
        Me.enrollkeytxt.Name = "enrollkeytxt"
        Me.enrollkeytxt.Size = New System.Drawing.Size(225, 33)
        Me.enrollkeytxt.TabIndex = 282
        '
        'regnumbertxt
        '
        Me.regnumbertxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.regnumbertxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regnumbertxt.Location = New System.Drawing.Point(320, 247)
        Me.regnumbertxt.Name = "regnumbertxt"
        Me.regnumbertxt.Size = New System.Drawing.Size(225, 33)
        Me.regnumbertxt.TabIndex = 281
        '
        'coursecodes
        '
        Me.coursecodes.AutoSize = True
        Me.coursecodes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.coursecodes.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecodes.Location = New System.Drawing.Point(317, 298)
        Me.coursecodes.Name = "coursecodes"
        Me.coursecodes.Size = New System.Drawing.Size(134, 25)
        Me.coursecodes.TabIndex = 280
        Me.coursecodes.Text = "&Course Code"
        '
        'studename
        '
        Me.studename.AutoSize = True
        Me.studename.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.studename.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studename.Location = New System.Drawing.Point(580, 244)
        Me.studename.Name = "studename"
        Me.studename.Size = New System.Drawing.Size(162, 25)
        Me.studename.TabIndex = 276
        Me.studename.Text = "&Enrollment Key"
        '
        'coursecodetxt
        '
        Me.coursecodetxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.coursecodetxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecodetxt.Location = New System.Drawing.Point(321, 327)
        Me.coursecodetxt.Name = "coursecodetxt"
        Me.coursecodetxt.Size = New System.Drawing.Size(225, 33)
        Me.coursecodetxt.TabIndex = 275
        '
        'coursecode
        '
        Me.coursecode.AutoSize = True
        Me.coursecode.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.coursecode.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecode.Location = New System.Drawing.Point(316, 219)
        Me.coursecode.Name = "coursecode"
        Me.coursecode.Size = New System.Drawing.Size(131, 25)
        Me.coursecode.TabIndex = 274
        Me.coursecode.Text = "&Reg Number"
        '
        'Searchbtn
        '
        Me.Searchbtn.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Searchbtn.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchbtn.Location = New System.Drawing.Point(669, 151)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(121, 37)
        Me.Searchbtn.TabIndex = 273
        Me.Searchbtn.Text = "&Search"
        Me.Searchbtn.UseVisualStyleBackColor = False
        '
        'Searchtxt
        '
        Me.Searchtxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Searchtxt.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchtxt.Location = New System.Drawing.Point(451, 151)
        Me.Searchtxt.Name = "Searchtxt"
        Me.Searchtxt.Size = New System.Drawing.Size(186, 33)
        Me.Searchtxt.TabIndex = 272
        '
        'Searchstudent
        '
        Me.Searchstudent.AutoSize = True
        Me.Searchstudent.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Searchstudent.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchstudent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Searchstudent.Location = New System.Drawing.Point(433, 112)
        Me.Searchstudent.Name = "Searchstudent"
        Me.Searchstudent.Size = New System.Drawing.Size(254, 25)
        Me.Searchstudent.TabIndex = 271
        Me.Searchstudent.Text = "&Search With Reg Number"
        '
        'DataGridView6
        '
        Me.DataGridView6.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(180, 85)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowHeadersWidth = 62
        Me.DataGridView6.RowTemplate.Height = 28
        Me.DataGridView6.Size = New System.Drawing.Size(1034, 560)
        Me.DataGridView6.TabIndex = 270
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1056, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 269
        Me.Label8.Text = "Logout"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1066, 12)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 268
        Me.PictureBox5.TabStop = False
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView5.Location = New System.Drawing.Point(1051, 5)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 62
        Me.DataGridView5.RowTemplate.Height = 28
        Me.DataGridView5.Size = New System.Drawing.Size(78, 73)
        Me.DataGridView5.TabIndex = 267
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(846, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 266
        Me.Label3.Text = "Attendence"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(872, 11)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(43, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 265
        Me.PictureBox4.TabStop = False
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView4.Location = New System.Drawing.Point(840, 4)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 62
        Me.DataGridView4.RowTemplate.Height = 28
        Me.DataGridView4.Size = New System.Drawing.Size(107, 73)
        Me.DataGridView4.TabIndex = 264
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(640, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 263
        Me.Label9.Text = "Enrollments"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(665, 12)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 262
        Me.PictureBox6.TabStop = False
        '
        'DataGridView7
        '
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView7.Location = New System.Drawing.Point(638, 7)
        Me.DataGridView7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.RowHeadersWidth = 62
        Me.DataGridView7.RowTemplate.Height = 28
        Me.DataGridView7.Size = New System.Drawing.Size(111, 72)
        Me.DataGridView7.TabIndex = 261
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(481, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "Home"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(482, 12)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 259
        Me.PictureBox2.TabStop = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2.Location = New System.Drawing.Point(469, 6)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(78, 70)
        Me.DataGridView2.TabIndex = 258
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(105, 495)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 27)
        Me.Label4.TabIndex = 257
        Me.Label4.Text = "G6"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 495)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 39)
        Me.Label5.TabIndex = 256
        Me.Label5.Text = "SAMS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 85)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 560)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 255
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(290, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 39)
        Me.Label6.TabIndex = 254
        Me.Label6.Text = "G6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 39)
        Me.Label7.TabIndex = 253
        Me.Label7.Text = "SAMS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, -5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1216, 90)
        Me.DataGridView1.TabIndex = 252
        '
        'enrolledDataGridView
        '
        Me.enrolledDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Border
        Me.enrolledDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.enrolledDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.enrolledDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.enrolledDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.enrolledDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.enrolledDataGridView.Location = New System.Drawing.Point(295, 443)
        Me.enrolledDataGridView.Name = "enrolledDataGridView"
        Me.enrolledDataGridView.RowHeadersWidth = 62
        Me.enrolledDataGridView.RowTemplate.Height = 28
        Me.enrolledDataGridView.Size = New System.Drawing.Size(696, 186)
        Me.enrolledDataGridView.TabIndex = 290
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(729, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 37)
        Me.Button1.TabIndex = 291
        Me.Button1.Text = "&Refresh List"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(365, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 25)
        Me.Label2.TabIndex = 292
        Me.Label2.Text = "&List Of Enrolled Students"
        '
        'StudentEnrolment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1214, 641)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.enrolledDataGridView)
        Me.Controls.Add(Me.enrollbtn)
        Me.Controls.Add(Me.Leavebtns)
        Me.Controls.Add(Me.enrollkeytxt)
        Me.Controls.Add(Me.regnumbertxt)
        Me.Controls.Add(Me.coursecodes)
        Me.Controls.Add(Me.studename)
        Me.Controls.Add(Me.coursecodetxt)
        Me.Controls.Add(Me.coursecode)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Searchtxt)
        Me.Controls.Add(Me.Searchstudent)
        Me.Controls.Add(Me.DataGridView6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.DataGridView7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentEnrolment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentEnrolment"
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enrolledDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents enrollbtn As Button
    Friend WithEvents Leavebtns As Button
    Friend WithEvents enrollkeytxt As TextBox
    Friend WithEvents regnumbertxt As TextBox
    Friend WithEvents coursecodes As Label
    Friend WithEvents studename As Label
    Friend WithEvents coursecodetxt As TextBox
    Friend WithEvents coursecode As Label
    Friend WithEvents Searchbtn As Button
    Friend WithEvents Searchtxt As TextBox
    Friend WithEvents Searchstudent As Label
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents enrolledDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
