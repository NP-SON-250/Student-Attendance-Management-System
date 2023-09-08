Imports System.Data.SqlClient

Public Class StudentEnrolment


    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"
    Private Sub RefreshDataGridViews()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim query As String = "SELECT * FROM enrollment"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using


        ' Binding data to the DataGridView
        enrolledDataGridView.DataSource = dataTable
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        StudentAttendenceView.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        StudentAttendenceView.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        StudentAttendenceView.Show()
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

    Private Sub enrollbtn_Click(sender As Object, e As EventArgs) Handles enrollbtn.Click
        Dim success As Boolean = False
        Dim exists As Boolean = False
        Dim regnumber As String = regnumbertxt.Text
        Dim coursecode As String = coursecodetxt.Text
        Dim enrollkey As String = enrollkeytxt.Text
        Dim message As String = "Registration Number: " & regnumber & vbCrLf & "Course Code: " & coursecode & vbCrLf & "Enrollment Key: " & enrollkey
        MsgBox(message)


        Using connection As New SqlConnection(Connetionstring)
            connection.Open()
            If String.IsNullOrWhiteSpace(regnumber) OrElse String.IsNullOrWhiteSpace(coursecode) OrElse String.IsNullOrWhiteSpace(enrollkey) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim checkcourseQuery As String = "SELECT COUNT(*) FROM enrollment WHERE Regnumber = @regnu and CourseCode = @enrolledcourse"
            Using checkCommand As New SqlCommand(checkcourseQuery, connection)
                checkCommand.Parameters.AddWithValue("@regnu", regnumber)
                checkCommand.Parameters.AddWithValue("@enrolledcourse", coursecode)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then

                    MessageBox.Show("You Already Enrolled This Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            Dim checkQuery As String = "SELECT COUNT(*) FROM enrollkeys WHERE Enrolkey = @enrolkey"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@enrolkey", enrollkey)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count <= 0 Then
                    exists = True
                    MessageBox.Show("This Enrollment Key Doesn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using


            ' If the record doesn't exist, proceed with insertion
            If Not exists Then



                Dim query As String = "INSERT INTO enrollment VALUES (@attendreg, @attendcourse, @attenddate)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@attendreg", regnumber)
                    command.Parameters.AddWithValue("@attendcourse", coursecode)
                    command.Parameters.AddWithValue("@attenddate", enrollkey)

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
            regnumbertxt.Clear()
            enrollkeytxt.Clear()

            RefreshDataGridViews()
        Else
            MessageBox.Show("Failed To Register data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Leavebtns_Click(sender As Object, e As EventArgs) Handles Leavebtns.Click
        Dim courseToDelete As String = coursecodetxt.Text
        Dim RegnumberToDelete As String = regnumbertxt.Text

        If String.IsNullOrWhiteSpace(courseToDelete) OrElse String.IsNullOrWhiteSpace(RegnumberToDelete) Then
            MessageBox.Show("Please enter a Course Code And Registration Number Are Required To Leave Enrolled Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim deleteQuery As String = "DELETE FROM enrollment WHERE CourseCode = @coursecode and Regnumber = @regnumber"
            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@coursecode", courseToDelete)
                deleteCommand.Parameters.AddWithValue("@regnumber", RegnumberToDelete)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("You Left This Course successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    coursecodetxt.Clear() ' Clear the TextBox after successful deletion
                    regnumbertxt.Clear()
                    RefreshDataGridViews()
                Else
                    MessageBox.Show("No record found with the Entered Course Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub StudentEnrolment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridViews()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshDataGridViews()
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim search As String = Searchtxt.Text
        MsgBox(search)

        If String.IsNullOrWhiteSpace(search) Then
            MessageBox.Show("Please enter a Registration Number To Search Info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()
        Dim act As String = "activate"
        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim regquery As String = "SELECT COUNT(*) FROM enrollment WHERE Regnumber = @myreged"
            Using checkCommand As New SqlCommand(regquery, connection)
                checkCommand.Parameters.AddWithValue("@myreged", search)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count <= 0 Then

                    MessageBox.Show("Entered Registration Number Have'nt Enrolled Any Course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            Dim dataTablex As New DataTable()
            Dim regquer As String = "SELECT * FROM enrollment WHERE Regnumber = @myreged"

            Using adapter As New SqlDataAdapter(regquer, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@myreged", search)


                adapter.Fill(dataTablex)
                enrolledDataGridView.DataSource = dataTablex
                Searchtxt.Clear()
            End Using

        End Using
    End Sub
End Class