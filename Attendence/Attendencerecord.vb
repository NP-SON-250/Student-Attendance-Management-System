Imports System.Data.SqlClient

Public Class Attendencerecord

    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"

    Private Sub RefreshDataGridViewene()
        Dim mydataTable As New DataTable()


        Using myconnection As New SqlConnection(Connetionstring)
            myconnection.Open()

            Dim query As String = "select enrollment.CourseCode, courses.CourseName, enrollment.Regnumber, students.Fullname from enrollment, courses,students where enrollment.Regnumber=students.Regnumber and enrollment.CourseCode=courses.Coursecode"
            Using myadapter As New SqlDataAdapter(query, myconnection)
                myadapter.Fill(mydataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        EnrollListDataGridView.DataSource = mydataTable
    End Sub

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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        LoginForm.Show()
        Me.Close()


    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        LoginForm.Show()
        Me.Close()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LectureLandingPage.Show()
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        LectureLandingPage.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Studentrecord.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Studentrecord.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Studentrecord.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Enrollmentsview.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
        Enrollmentsview.Show()
        Me.Close()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Enrollmentsview.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Dim success As Boolean = False
        Dim exists As Boolean = False
        Dim regnumber As String = registrationnmbrtxt.Text
        Dim coursecode As String = coursecodetxt.Text
        Dim dates As String = attenddatetxt.Text
        Dim status As String = Statuscombbox.Text
        Dim message As String = "Registration Number: " & regnumber & vbCrLf & "Course Code: " & coursecode & vbCrLf & "Attendence Date: " & dates & vbCrLf & "Attendence Status: " & status
        MsgBox(message)


        Using connection As New SqlConnection(Connetionstring)
            connection.Open()
            If String.IsNullOrWhiteSpace(regnumber) OrElse String.IsNullOrWhiteSpace(coursecode) OrElse String.IsNullOrWhiteSpace(dates) OrElse String.IsNullOrWhiteSpace(status) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim checkcourseQuery As String = "SELECT COUNT(*) FROM enrollment WHERE CourseCode = @course"
            Using checkCommand As New SqlCommand(checkcourseQuery, connection)
                checkCommand.Parameters.AddWithValue("@course", coursecode)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count <= 0 Then

                    MessageBox.Show("No Student Enrolled Your Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            Dim checkQuery As String = "SELECT COUNT(*) FROM enrollment WHERE Regnumber = @regnum"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@regnum", regnumber)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count <= 0 Then
                    exists = True
                    MessageBox.Show("Student With This RegNumber Did Not Enrolled Your Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            Dim checkdateQuery As String = "SELECT COUNT(*) FROM attendence WHERE Regnumber = @regnum and CourseCode = @courses and Date = @todate"
            Using checkdateCommand As New SqlCommand(checkdateQuery, connection)
                checkdateCommand.Parameters.AddWithValue("@regnum", regnumber)
                checkdateCommand.Parameters.AddWithValue("@courses", coursecode)
                checkdateCommand.Parameters.AddWithValue("@todate", dates)
                Dim count As Integer = CInt(checkdateCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("Student Attendence On This Date Has previously Recorded, Please Update Instead.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            ' If the record doesn't exist, proceed with insertion
            If Not exists Then



                Dim query As String = "INSERT INTO attendence VALUES (@attendreg, @attendcourse, @attenddate, @attendstatus)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@attendreg", regnumber)
                    command.Parameters.AddWithValue("@attendcourse", coursecode)
                    command.Parameters.AddWithValue("@attenddate", dates)
                    command.Parameters.AddWithValue("@attendstatus", status)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        success = True
                    End If
                End Using
            End If
        End Using


        If success Then
            MessageBox.Show("Student Attendence Recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            coursecodetxt.Clear()
            registrationnmbrtxt.Clear()
            attenddatetxt.Clear()
            Statuscombbox.SelectedIndex = -1
            RefreshDataGridViewattendence()
        Else
            MessageBox.Show("Failed To Register data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Attendencerecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridViewene()
        RefreshDataGridViewattendence()
    End Sub

    Private Sub Updatebtns_Click(sender As Object, e As EventArgs) Handles Updatebtns.Click
        Dim regnumbertoupdate As String = registrationnmbrtxt.Text
        Dim coursetoupdate As String = coursecodetxt.Text
        Dim datetoupdate As String = attenddatetxt.Text
        Dim statustoupdate As String = Statuscombbox.Text
        If String.IsNullOrWhiteSpace(regnumbertoupdate) OrElse String.IsNullOrWhiteSpace(coursetoupdate) Then
            MessageBox.Show("Please Enter Course Code Student RegNumber To Change Student's Attendence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(datetoupdate) OrElse String.IsNullOrWhiteSpace(statustoupdate) Then
            MessageBox.Show("Please Enter Date And Select Status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim updateQuery As String = "UPDATE attendence SET Date = @update, Status = @upstatus WHERE CourseCode = @courseco and Regnumber = @upregnumber"
            Using updateCommand As New SqlCommand(updateQuery, connection)
                updateCommand.Parameters.AddWithValue("@courseco", coursetoupdate)
                updateCommand.Parameters.AddWithValue("@update", datetoupdate)
                updateCommand.Parameters.AddWithValue("@upstatus", statustoupdate)
                updateCommand.Parameters.AddWithValue("@upregnumber", regnumbertoupdate)
                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Student Attendence Record Changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    coursecodetxt.Clear()
                    registrationnmbrtxt.Clear()
                    attenddatetxt.Clear()
                    Statuscombbox.SelectedIndex = -1
                    RefreshDataGridViewattendence() ' Refresh the DataGridView after update
                Else
                    MessageBox.Show("No Record Found With The Entered Registration Number And Course Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub deletebtns_Click(sender As Object, e As EventArgs) Handles deletebtns.Click
        Dim CoursecodeToDelete As String = coursecodetxt.Text
        Dim RegnumberToDelete As String = registrationnmbrtxt.Text

        If String.IsNullOrWhiteSpace(CoursecodeToDelete) OrElse String.IsNullOrWhiteSpace(RegnumberToDelete) Then
            MessageBox.Show("Please enter a Registration Number And Course Code To delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim deleteQuery As String = "DELETE FROM attendence WHERE CourseCode = @coursee and Regnumber = @deletereg"
            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@coursee", CoursecodeToDelete)
                deleteCommand.Parameters.AddWithValue("@deletereg", RegnumberToDelete)
                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Student attendence Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear the TextBox after successful deletion
                    registrationnmbrtxt.Clear()
                    coursecodetxt.Clear()
                    RefreshDataGridViewattendence()
                Else
                    MessageBox.Show("No record found with the Entered Course Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
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

    Private Sub report_Click(sender As Object, e As EventArgs) Handles report.Click
        Attendencereport.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Attendencereport.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView9.CellContentClick
        Attendencereport.Show()
        Me.Hide()
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        RefreshDataGridViewattendence()
        SearchCoursecodetxt.Clear()
        regnumbertxt.Clear()
    End Sub
End Class