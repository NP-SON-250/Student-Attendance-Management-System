Imports System.Data.SqlClient

Public Class Studentrecord

    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"
    Private Sub RefreshDataGridViews()
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim query As String = "SELECT * FROM students"
            Using adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        ' Binding data to the DataGridView
        StudentListDataGridView.DataSource = dataTable
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Attendencerecord.Show()
        Me.Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Attendencerecord.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Attendencerecord.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LectureLandingPage.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        LectureLandingPage.Show()
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        LectureLandingPage.Show()
        Me.Close()

    End Sub

    Private Sub LectureStudentDataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Enrollmentsview.Show()
        Me.Hide()


    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Enrollmentsview.Show()
        Me.Hide()


    End Sub

    Private Sub DataGridView7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
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

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Dim success As Boolean = False
        Dim exists As Boolean = False
        Dim regnumber As String = regnumbertxt.Text
        Dim fullnames As String = fullnametxt.Text
        Dim gender As String = genderComboBox.Text
        Dim studyyear As String = studyyeartxt.Text
        Dim username As String = usernametxt.Text
        Dim password As String = passwordstxt.Text
        Dim message As String = "Registration Number: " & regnumber & vbCrLf & "Full Name: " & fullnames & vbCrLf & "Gender: " & gender & vbCrLf & "Year Of Study: " & studyyear & vbCrLf & "Username: " & username & vbCrLf & "Password: " & password
        MsgBox(message)


        Using connection As New SqlConnection(Connetionstring)
            connection.Open()
            If String.IsNullOrWhiteSpace(regnumber) OrElse String.IsNullOrWhiteSpace(fullnames) OrElse String.IsNullOrWhiteSpace(gender) OrElse
                String.IsNullOrWhiteSpace(studyyear) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the record with the same pk already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM students WHERE Regnumber = @reg"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@reg", regnumber)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("Student Registration Number Exist In Database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' If the record doesn't exist, proceed with insertion
            If Not exists Then



                Dim query As String = "INSERT INTO students VALUES (@reg, @fullname, @gender, @studyyear,@username, @password)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@reg", regnumber)
                    command.Parameters.AddWithValue("@fullname", fullnames)
                    command.Parameters.AddWithValue("@gender", gender)
                    command.Parameters.AddWithValue("@studyyear", studyyear)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        success = True
                    End If
                End Using
            End If
        End Using


        If success Then
            MessageBox.Show("Student Registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            regnumbertxt.Clear()
            genderComboBox.SelectedIndex = -1
            fullnametxt.Clear()
            studyyeartxt.Clear()
            usernametxt.Clear()
            passwordstxt.Clear()
            RefreshDataGridViews()
        Else
            MessageBox.Show("Failed To Register data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Studentrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridViews()
    End Sub

    Private Sub Updatebtns_Click(sender As Object, e As EventArgs) Handles Updatebtns.Click
        Dim regnumberToUpdate As String = regnumbertxt.Text
        Dim newfullname As String = fullnametxt.Text
        Dim newgender As String = genderComboBox.Text
        Dim newstudyyear As String = studyyeartxt.Text
        Dim newusername As String = usernametxt.Text
        Dim newpassword As String = passwordstxt.Text
        If String.IsNullOrWhiteSpace(regnumberToUpdate) Then
            MessageBox.Show("Please Enter Registration Number To Update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(newfullname) OrElse String.IsNullOrWhiteSpace(newgender) OrElse String.IsNullOrWhiteSpace(newstudyyear) OrElse String.IsNullOrWhiteSpace(newusername) OrElse String.IsNullOrWhiteSpace(newpassword) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If
        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim updateQuery As String = "UPDATE students SET Fullname = @fullname, Gender = @gender, Studyyear = @study, Username = @username, Password = @password WHERE Regnumber = @regnumber"
            Using updateCommand As New SqlCommand(updateQuery, connection)
                updateCommand.Parameters.AddWithValue("@fullname", newfullname)
                updateCommand.Parameters.AddWithValue("@gender", newgender)
                updateCommand.Parameters.AddWithValue("@study", newstudyyear)
                updateCommand.Parameters.AddWithValue("@username", newusername)
                updateCommand.Parameters.AddWithValue("@password", newpassword)
                updateCommand.Parameters.AddWithValue("@regnumber", regnumberToUpdate)

                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Student Info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    regnumbertxt.Clear()
                    fullnametxt.Clear()
                    genderComboBox.SelectedIndex = -1
                    studyyeartxt.Clear()
                    usernametxt.Clear()
                    passwordstxt.Clear()


                    RefreshDataGridViews() ' Refresh the DataGridView after update
                Else
                    MessageBox.Show("No Record Found With The Entered Registration Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub deletebtns_Click(sender As Object, e As EventArgs) Handles deletebtns.Click
        Dim RegnumberToDelete As String = regnumbertxt.Text


        If String.IsNullOrWhiteSpace(RegnumberToDelete) Then
            MessageBox.Show("Please enter a Registration Number To delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim deleteQuery As String = "DELETE FROM students WHERE Regnumber = @reg"
            Using deleteCommand As New SqlCommand(deleteQuery, connection)
                deleteCommand.Parameters.AddWithValue("@reg", RegnumberToDelete)

                Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    regnumbertxt.Clear() ' Clear the TextBox after successful deletion

                    RefreshDataGridViews()
                Else
                    MessageBox.Show("No record found with the Entered Registration Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub regnumbertxt_TextChanged(sender As Object, e As EventArgs) Handles regnumbertxt.TextChanged

    End Sub

    Private Sub coursename_Click(sender As Object, e As EventArgs) Handles coursename.Click

    End Sub

    Private Sub fullnametxt_TextChanged(sender As Object, e As EventArgs) Handles fullnametxt.TextChanged

    End Sub

    Private Sub Courselecture_Click(sender As Object, e As EventArgs) Handles Courselecture.Click

    End Sub

    Private Sub genderComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles genderComboBox.SelectedIndexChanged

    End Sub

    Private Sub coursecredit_Click(sender As Object, e As EventArgs) Handles coursecredit.Click

    End Sub

    Private Sub studyyeartxt_TextChanged(sender As Object, e As EventArgs) Handles studyyeartxt.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub usernametxt_TextChanged(sender As Object, e As EventArgs) Handles usernametxt.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub passwordstxt_TextChanged(sender As Object, e As EventArgs) Handles passwordstxt.TextChanged

    End Sub

    Private Sub coursecode_Click(sender As Object, e As EventArgs) Handles coursecode.Click

    End Sub

    Private Sub addstudent_Click(sender As Object, e As EventArgs) Handles addstudent.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Attendencereport.Show()
        Me.Hide()
    End Sub

    Private Sub report_Click(sender As Object, e As EventArgs) Handles report.Click
        Attendencereport.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView9.CellContentClick
        Attendencereport.Show()
        Me.Hide()
    End Sub
End Class