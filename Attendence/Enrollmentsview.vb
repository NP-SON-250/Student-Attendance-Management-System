Imports System.Data.SqlClient
Imports System.Threading

Public Class Enrollmentsview

    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"
    Private Sub RefreshDataGridViews()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim query As String = "SELECT * FROM enrollkeys"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        EnrollListDataGridView.DataSource = dataTable
    End Sub

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
        ListofenrolledstudentDataGridView.DataSource = mydataTable
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        LoginForm.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Attendencerecord.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Attendencerecord.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Attendencerecord.Show()
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Studentrecord.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LectureLandingPage.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        LectureLandingPage.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        LectureLandingPage.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Attendencerecord.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        Attendencerecord.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView4_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Attendencerecord.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView5_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Enrollmentsview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridViews()
        RefreshDataGridViewene()
    End Sub

    Private Sub Createbtn_Click(sender As Object, e As EventArgs) Handles Createbtn.Click
        Dim success As Boolean = False
        Dim exists As Boolean = False
        Dim coursecode As String = coursecodetxt.Text
        Dim enrollkey As String = enroolkeytxt.Text
        Dim message As String = "Course Code: " & coursecode & vbCrLf & "Enrollment Key: " & enrollkey
        MsgBox(message)


        Using connection As New SqlConnection(Connetionstring)
            connection.Open()
            If String.IsNullOrWhiteSpace(coursecode) OrElse String.IsNullOrWhiteSpace(enrollkey) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim checkcourseQuery As String = "SELECT COUNT(*) FROM courses WHERE CourseCode = @course"
            Using checkCommand As New SqlCommand(checkcourseQuery, connection)
                checkCommand.Parameters.AddWithValue("@course", coursecode)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count <= 0 Then

                    MessageBox.Show("Course Code Entered Has'nt Registered In Course Table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using
            ' Check if the course code has enrollment key already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM enrollkeys WHERE CourseCode = @course"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@course", coursecode)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("Course Code Entered Has No Enrollment Key In Database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' If the record doesn't exist, proceed with insertion
            If Not exists Then



                Dim query As String = "INSERT INTO enrollkeys VALUES (@coursecode, @Enrolledkey)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@coursecode", coursecode)
                    command.Parameters.AddWithValue("@Enrolledkey", enrollkey)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        success = True
                    End If
                End Using
            End If
        End Using


        If success Then
            MessageBox.Show("Enrollment Key Created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            coursecodetxt.Clear()
            enroolkeytxt.Clear()
            RefreshDataGridViews()
        Else
            MessageBox.Show("Failed To Register data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Updatebtns_Click(sender As Object, e As EventArgs) Handles Updatebtns.Click
        Dim coursed As String = coursecodetxt.Text
        Dim enrolled As String = enroolkeytxt.Text
        If String.IsNullOrWhiteSpace(coursed) OrElse String.IsNullOrWhiteSpace(enrolled) Then
            MessageBox.Show("Please Enter Course Code To Update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(coursed) OrElse String.IsNullOrWhiteSpace(enrolled) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim updateQuery As String = "UPDATE enrollkeys SET Enrolkey = @enrolkey WHERE CourseCode = @courseco"
            Using updateCommand As New SqlCommand(updateQuery, connection)
                updateCommand.Parameters.AddWithValue("@courseco", coursed)
                updateCommand.Parameters.AddWithValue("@enrolkey", enrolled)

                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Course Enrollment Key Changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    coursecodetxt.Clear()
                    enroolkeytxt.Clear()

                    RefreshDataGridViews() ' Refresh the DataGridView after update
                Else
                    MessageBox.Show("No Record Found With The Entered Registration Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub deletebtns_Click(sender As Object, e As EventArgs) Handles deletebtns.Click
        Dim CoursecodeToDelete As String = coursecodetxt.Text


        If String.IsNullOrWhiteSpace(CoursecodeToDelete) Then
            MessageBox.Show("Please enter a Course Code To delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim deleteQuery As String = "DELETE FROM enrollkeys WHERE CourseCode = @coursee"
            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@coursee", CoursecodeToDelete)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Enrollment Key deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    regnumbertxt.Clear() ' Clear the TextBox after successful deletion

                    RefreshDataGridViews()
                Else
                    MessageBox.Show("No record found with the Entered Course Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim search As String = Searchtxt.Text


        If String.IsNullOrWhiteSpace(search) Then
            MessageBox.Show("Please enter a Registration Number To Search Info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()
        Dim act As String = "activate"
        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim regquery As String = "select Regnumber From enrollment where Regnumber=@myreged"
            Using checkCommand As New SqlCommand(regquery, connection)
                checkCommand.Parameters.AddWithValue("@myreged", search)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count <= 0 Then

                    MessageBox.Show("Student With Entered Registration Number Have'nt Enrolled Your Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using
            Dim query As String = "select enrollment.CourseCode, courses.CourseName, enrollment.Regnumber, students.Fullname from enrollment, courses,students where enrollment.Regnumber=students.Regnumber and enrollment.CourseCode=courses.Coursecode and enrollment.Regnumber=@searcreg"

            Using adapter As New SqlDataAdapter(query, connection)
                    ' Add the parameter to the adapter
                    adapter.SelectCommand.Parameters.AddWithValue("@searcreg", search)

                    adapter.Fill(dataTable)
                End Using
            End Using

            ' Binding data to the DataGridView
            ListofenrolledstudentDataGridView.DataSource = dataTable

    End Sub

    Private Sub enrolldeletebtn_Click(sender As Object, e As EventArgs) Handles enrolldeletebtn.Click
        Dim CoursecodeToDelete As String = ccoursecodetxt.Text
        Dim regnumberToDelete As String = regnumbertxt.Text

        If String.IsNullOrWhiteSpace(CoursecodeToDelete) Then
            MessageBox.Show("Please enter a Course Code To delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(regnumberToDelete) Then
            MessageBox.Show("Please enter a Registration Number To delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(regnumberToDelete) And String.IsNullOrWhiteSpace(CoursecodeToDelete) Then
            MessageBox.Show("Please enter a Registration Number And a Course Code To delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim deleteenrollQuery As String = "DELETE FROM enrollment WHERE CourseCode = @coursee and Regnumber = @registered"
            Using deleteCommand As New SqlCommand(deleteenrollQuery, connection)
                deleteCommand.Parameters.AddWithValue("@coursee", CoursecodeToDelete)
                deleteCommand.Parameters.AddWithValue("@registered", regnumberToDelete)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Enrollment Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    regnumbertxt.Clear() ' Clear the TextBox after successful deletion

                    RefreshDataGridViews()
                Else
                    MessageBox.Show("No record found with the Entered Registration Number Or Course Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        RefreshDataGridViews()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RefreshDataGridViewene()
    End Sub
End Class