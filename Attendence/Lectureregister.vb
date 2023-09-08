Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Lectureregister

    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Dim success As Boolean = False
        Dim exists As Boolean = False
        Dim lecturecode As String = leccodetext.Text
        Dim fullname As String = Fullnametxt.Text
        Dim degree As String = degreetxt.Text
        Dim email As String = emailtxt.Text
        Dim username As String = usernametxt.Text
        Dim password As String = passtxt.Text
        Dim message As String = "lecturecode: " & lecturecode & vbCrLf & "fullname: " & fullname & vbCrLf & "degree: " & degree & vbCrLf & "email: " & email & vbCrLf & "username: " & username & vbCrLf & "password: " & password

        MsgBox(message)


        Using connection As New SqlConnection(Connetionstring)
            connection.Open()
            If String.IsNullOrWhiteSpace(lecturecode) OrElse String.IsNullOrWhiteSpace(fullname) OrElse String.IsNullOrWhiteSpace(degree) OrElse
                String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if the record with the same pk already exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM lectures WHERE lectcode = @lecturecode"
            Using checkCommand As New SqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@lecturecode", lecturecode)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count > 0 Then
                    exists = True
                    MessageBox.Show("Lecture Code Registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

            ' If the record doesn't exist, proceed with insertion
            If Not exists Then



                Dim query As String = "INSERT INTO lectures VALUES (@lecturecode, @fullname, @degree, @email, @username, @password)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@lecturecode", lecturecode)
                    command.Parameters.AddWithValue("@fullname", fullname)
                    command.Parameters.AddWithValue("@degree", degree)
                    command.Parameters.AddWithValue("@email", email)
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
            MessageBox.Show("Lecture Registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            leccodetext.Clear()
            Fullnametxt.Clear()
            emailtxt.Clear()
            usernametxt.Clear()
            degreetxt.Clear()
            passtxt.Clear()
            LoginForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Failed to Register data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Fetching data from the database









    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Lectureregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Fullnametxt_TextChanged(sender As Object, e As EventArgs) Handles Fullnametxt.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class