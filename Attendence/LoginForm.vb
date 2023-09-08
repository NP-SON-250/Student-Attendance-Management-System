Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim Connetionstring As String = "Data Source=bonny-pc\sqlexpress;Initial Catalog=attendence;Integrated Security=True"


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Lectureregister.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Dim usertype As String = typeComboBox.Text



        If usertype = "Lecture" Then


            Using connection As New SqlConnection(Connetionstring)
                connection.Open()

                ' SQL query to retrieve the password for the entered username
                Dim query As String = "SELECT Password FROM lectures WHERE Username = @username"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)

                    Dim storedPassword As String = Convert.ToString(command.ExecuteScalar())

                    If String.IsNullOrEmpty(storedPassword) Then
                        ' Username not found in the database
                        MessageBox.Show("Username not found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf storedPassword = password Then
                        ' Passwords match
                        UsernameTextBox.Clear()
                        PasswordTextBox.Clear()
                        typeComboBox.SelectedIndex = -1
                        LectureLandingPage.Show()
                        Me.Hide()
                    Else
                        ' Passwords don't match, display an error message
                        MessageBox.Show("Incorrect password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

            Return

        End If


        If usertype = "Student" Then

            Using connection As New SqlConnection(Connetionstring)
                connection.Open()

                ' SQL query to retrieve the password for the entered username
                Dim query As String = "SELECT Password FROM students WHERE Username = @username"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)

                    Dim storedPassword As String = Convert.ToString(command.ExecuteScalar())

                    If String.IsNullOrEmpty(storedPassword) Then
                        ' Username not found in the database
                        MessageBox.Show("Username not found.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf storedPassword = password Then
                        ' Passwords match
                        UsernameTextBox.Clear()
                        PasswordTextBox.Clear()
                        typeComboBox.SelectedIndex = -1
                        StudentLandingPage.Show()
                        Me.Hide()
                    Else
                        ' Passwords don't match, display an error message
                        MessageBox.Show("Incorrect password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

            Return

        End If

    End Sub

    Private Sub lectureregisterlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lectureregisterlink.LinkClicked
        Lectureregister.Show()
        Me.Hide()
    End Sub

    Private Sub studentregisterlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles studentregisterlink.LinkClicked
        StudentRegister.Show()
        Me.Hide()
    End Sub
End Class
