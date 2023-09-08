Imports System.Data.SqlClient

Public Class Attendencereport

    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"

    Private Sub RefreshDataGridViewene()
        Dim mydataTable As New DataTable()


        Using myconnection As New SqlConnection(Connetionstring)
            myconnection.Open()

            Dim query As String = "select attendence.CourseCode,courses.CourseName,attendence.Regnumber,students.Fullname,attendence.Date,attendence.Status from attendence,courses,students where attendence.CourseCode=courses.Coursecode and attendence.Regnumber=students.Regnumber"
            Using myadapter As New SqlDataAdapter(query, myconnection)
                myadapter.Fill(mydataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        ListofattendedstudentDataGridView.DataSource = mydataTable

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        LectureLandingPage.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LectureLandingPage.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        LectureLandingPage.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Studentrecord.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Studentrecord.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Studentrecord.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Enrollmentsview.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Enrollmentsview.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
        Enrollmentsview.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Attendencerecord.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Attendencerecord.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Attendencerecord.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim searchcourse As String = SearchCoursecodetxt.Text
        Dim searchdate1 As String = date1txt.Text
        Dim searchdate2 As String = date2txt.Text
        If String.IsNullOrWhiteSpace(searchcourse) Then
            MessageBox.Show("Please enter a Course Code To Search Info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(searchdate1) Then
            MessageBox.Show("Please enter Starting Dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(searchdate2) Then
            MessageBox.Show("Please enter End Dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()
        Dim act As String = "activate"
        Using connection As New SqlConnection(Connetionstring)
            connection.Open()
            Dim query As String = "select attendence.CourseCode,courses.CourseName,attendence.Regnumber,students.Fullname,attendence.Date,attendence.Status from attendence,courses,students where attendence.CourseCode=courses.Coursecode and attendence.Regnumber=students.Regnumber and attendence.CourseCode=@searchedcode and attendence.Date BETWEEN @firstdate and @seconddate"

            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@searchedcode", searchcourse)
                adapter.SelectCommand.Parameters.AddWithValue("@firstdate", searchdate1)
                adapter.SelectCommand.Parameters.AddWithValue("@seconddate", searchdate2)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        ListofattendedstudentDataGridView.DataSource = dataTable
    End Sub

    Private Sub Attendencereport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridViewene()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RefreshDataGridViewene()
    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click

        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim dgv As DataGridView = ListofattendedstudentDataGridView
        Dim rect As New Rectangle(100, 100, dgv.Width, dgv.Height)

        Using bmp As New Bitmap(dgv.Width, dgv.Height)
            dgv.DrawToBitmap(bmp, rect)
            e.Graphics.DrawImage(bmp, New Point(100, 100))
        End Using
    End Sub

End Class