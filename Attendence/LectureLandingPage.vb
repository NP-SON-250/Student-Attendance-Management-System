
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class LectureLandingPage


    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"
    Private Sub RefreshDataGridViews()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim query As String = "SELECT * FROM courses"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        courselistDataGridView.DataSource = dataTable
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LectureLandingDataGridView6.CellContentClick

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

    Private Sub addcourse_Click(sender As Object, e As EventArgs) Handles addcourse.Click

    End Sub

    Private Sub DataGridView7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Enrollmentsview.Show()
        Me.Hide()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Enrollmentsview.Show()
        Me.Hide()


    End Sub

    Private Sub DataGridView7_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
        Enrollmentsview.Show()
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



    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Dim success As Boolean = False
        Dim exists As Boolean = False
        Dim coursecode As String = coursecodetxt.Text
        Dim lecturecode As String = courselecturetxt.Text
        Dim coursename As String = courseNamestxt.Text
        Dim coursecredit As String = coursecreditetxt.Text
        Dim message As String = "coursecode: " & coursecode & vbCrLf & "lecturecode: " & lecturecode & vbCrLf & "coursename: " & coursename & vbCrLf & "coursecredit: " & coursecredit
        MsgBox(message)


        Using connection As New SqlConnection(Connetionstring)
            connection.Open()
            If String.IsNullOrWhiteSpace(coursecode) OrElse String.IsNullOrWhiteSpace(lecturecode) OrElse String.IsNullOrWhiteSpace(coursename) OrElse
                String.IsNullOrWhiteSpace(coursecredit) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the record with the same pk already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM courses WHERE Coursecode = @coursecode"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@coursecode", coursecode)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("Course Code Exist In Database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' If the record doesn't exist, proceed with insertion
            If Not exists Then



                Dim query As String = "INSERT INTO courses VALUES (@coursecode, @lecturecode, @coursename, @coursecredit)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@coursecode", coursecode)
                    command.Parameters.AddWithValue("@lecturecode", lecturecode)
                    command.Parameters.AddWithValue("@coursename", coursename)
                    command.Parameters.AddWithValue("@coursecredit", coursecredit)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        success = True
                    End If
                End Using
            End If
        End Using


        If success Then
            MessageBox.Show("Course Added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            coursecodetxt.Clear()
            courselecturetxt.Clear()
            courseNamestxt.Clear()
            coursecreditetxt.Clear()
            RefreshDataGridViews()
        Else
            MessageBox.Show("Failed to Register data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LectureLandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridViews()
    End Sub

    Private Sub courselistDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles courselistDataGridView.CellContentClick

    End Sub

    Private Sub deletebtns_Click(sender As Object, e As EventArgs) Handles deletebtns.Click
        Dim courseToDelete As String = coursecodetxt.Text


        If String.IsNullOrWhiteSpace(courseToDelete) Then
            MessageBox.Show("Please enter a Course Code To delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim deleteQuery As String = "DELETE FROM courses WHERE Coursecode = @coursecode"
            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@coursecode", courseToDelete)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    coursecodetxt.Clear() ' Clear the TextBox after successful deletion

                    RefreshDataGridViews()
                Else
                    MessageBox.Show("No record found with the Entered Course Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub Updatebtns_Click(sender As Object, e As EventArgs) Handles Updatebtns.Click
        Dim CoursecodeToUpdate As String = coursecodetxt.Text
        Dim newlecturecode As String = courselecturetxt.Text
        Dim newcoursename As String = courseNamestxt.Text
        Dim newcoursecredit As String = coursecreditetxt.Text
        If String.IsNullOrWhiteSpace(CoursecodeToUpdate) Then
            MessageBox.Show("Please Enter Course Code To Update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(newcoursename) OrElse String.IsNullOrWhiteSpace(newcoursecredit) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim updateQuery As String = "UPDATE courses SET CourseName = @coursename, CourseCredit = @coursecredit WHERE Coursecode = @Coursecode"
            Using updateCommand As New SqlCommand(updateQuery, connection)
                updateCommand.Parameters.AddWithValue("@coursename", newcoursename)
                updateCommand.Parameters.AddWithValue("@coursecredit", newcoursecredit)
                updateCommand.Parameters.AddWithValue("@Coursecode", CoursecodeToUpdate)

                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Course Info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    coursecodetxt.Clear()
                    courselecturetxt.Clear()
                    courseNamestxt.Clear()
                    coursecreditetxt.Clear()
                    RefreshDataGridViews() ' Refresh the DataGridView after update
                Else
                    MessageBox.Show("No Record Found With The Entered Course Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub DataGridView6_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick
        Attendencereport.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Attendencereport.Show()
        Me.Hide()
    End Sub

    Private Sub report_Click(sender As Object, e As EventArgs) Handles report.Click
        Attendencereport.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshDataGridViews()
    End Sub
End Class