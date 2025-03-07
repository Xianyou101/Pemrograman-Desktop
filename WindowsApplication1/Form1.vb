Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim nip As String = txtNIP.Text
        Dim nama As String = txtNama.Text
        Dim fakultas As String = cmbFakultas.SelectedItem.ToString()
        Dim jenisKelamin As String = If(RadioButton1.Checked, "Laki - Laki", "Perempuan")
        Dim jurusan As String = cmbJurusan.SelectedItem.ToString()


        MessageBox.Show("Nip : " & nip & vbCrLf &
                         "Nama : " & nama & vbCrLf &
                         "Fakultas : " & fakultas & vbCrLf &
                         "Jurusan : " & jurusan & vbCrLf &
                         "Jenis Kelamin : " & jenisKelamin,
                         "Informasi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
