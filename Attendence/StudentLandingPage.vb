Imports System.Data.SqlClient

Public Class StudentLandingPage

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

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        StudentAttendenceView.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        StudentAttendenceView.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
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

    Private Sub StudentLandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridViews()
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim search As String = Searchtxt.Text
        MsgBox(search)

        If String.IsNullOrWhiteSpace(search) Then
            MessageBox.Show("Please enter a Course Name To Search Info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dataTable As New DataTable()
        Dim act As String = "activate"
        Using connection As New SqlConnection(Connetionstring)
            connection.Open()

            Dim regquery As String = "SELECT COUNT(*) FROM courses WHERE CourseName = @myreged"
            Using checkCommand As New SqlCommand(regquery, connection)
                checkCommand.Parameters.AddWithValue("@myreged", search)
                Dim count As Integer = CInt(checkCommand.ExecuteScalar())
                If count <= 0 Then

                    MessageBox.Show("Enterred Course Name Doesn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            Dim dataTablex As New DataTable()
            Dim regquer As String = "SELECT * FROM courses WHERE CourseName = @myreged"

            Using adapter As New SqlDataAdapter(regquer, connection)
                ' Add the parameter to the adapter
                adapter.SelectCommand.Parameters.AddWithValue("@myreged", search)


                adapter.Fill(dataTablex)
                courselistDataGridView.DataSource = dataTablex
                Searchtxt.Clear()
            End Using

        End Using

       


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshDataGridViews()
    End Sub
End Class