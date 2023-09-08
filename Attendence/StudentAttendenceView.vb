Imports System.Data.SqlClient

Public Class StudentAttendenceView

    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"

    Private Sub RefreshDataGridViewattendence()
        Dim attendencedataTable As New DataTable()


        Using attendconnection As New SqlConnection(Connetionstring)
            attendconnection.Open()

            Dim query As String = "select attendence.CourseCode,courses.CourseName,attendence.Regnumber,students.Fullname,attendence.Date,attendence.Status from attendence,courses,students where attendence.CourseCode=courses.Coursecode and attendence.Regnumber=students.Regnumber"
            Using myadapter As New SqlDataAdapter(query, attendconnection)
                myadapter.Fill(attendencedataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        ListofattendedstudentDataGridView.DataSource = attendencedataTable
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        StudentEnrolment.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        StudentEnrolment.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
        StudentEnrolment.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        StudentLandingPage.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        StudentLandingPage.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        StudentLandingPage.Show()
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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub StudentAttendenceView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridViewattendence()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim coursecoo As String = SearchCoursecodetxt.Text
        Dim regnmbrs As String = regnumbertxt.Text


        If String.IsNullOrWhiteSpace(coursecoo) OrElse String.IsNullOrWhiteSpace(regnmbrs) Then
            MessageBox.Show("Please enter a Course Code And Reg Number To Search Info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()
        Dim act As String = "activate"
        Using connection As New SqlConnection(Connetionstring)
            connection.Open()


            Dim query As String = "select attendence.CourseCode,courses.CourseName,attendence.Regnumber,students.Fullname,attendence.Date,attendence.Status from attendence,courses,students where attendence.CourseCode=courses.Coursecode and attendence.Regnumber=students.Regnumber and attendence.Regnumber=@searchreg and attendence.CourseCode=@searchcourse"

            Using adapter As New SqlDataAdapter(query, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@searchreg", regnmbrs)
                adapter.SelectCommand.Parameters.AddWithValue("@searchcourse", coursecoo)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        ListofattendedstudentDataGridView.DataSource = dataTable
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        RefreshDataGridViewattendence()
        SearchCoursecodetxt.Clear()
        regnumbertxt.Clear()

    End Sub
End Class