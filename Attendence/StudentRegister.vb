Imports System.Data.SqlClient

Public Class StudentRegister

    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"

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
            LoginForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Failed To Register data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class