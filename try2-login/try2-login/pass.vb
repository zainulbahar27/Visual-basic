Public Class pass

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Ganti Password"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim msg As String = " do you want to exit?"
        Dim title As String = "Exit application"
        Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim icon As MessageBoxIcon = MessageBoxIcon.Exclamation
        Dim result As DialogResult = MessageBox.Show(msg, title, button, icon, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            My.Computer.Audio.Play(Application.StartupPath + "\sound\logout.wav")
            Form1.Show()
            Me.Close()

        ElseIf result = DialogResult.No Then
            MsgBox("Welcome Back", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Pressed")

        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Tb_adminBindingSource.Filter = "username = '" & member & "' and pass =  '" & passlama.Text & "'"
        If passlama.Text <> "" And Tb_adminBindingSource.Count <> 0 And passbaru.Text = konfirm.Text Then
            hidden.Visible = True
            hidden.Text = passbaru.Text
            Tb_adminBindingSource.EndEdit()
            Tb_adminTableAdapter.Update(RRIdbDataSet.tb_admin)
            MsgBox("Silahkan Login dengan password baru anda", MsgBoxStyle.OkOnly, _
                  "Password berhasil diganti")
            login.Show()
            hidden.Visible = False
            Me.Close()
        ElseIf passbaru.Text <> konfirm.Text Then
            MsgBox("Password baru tidak sama, silahkan cek ulang password", MsgBoxStyle.Critical)
            passlama.Text = ""
            passbaru.Text = ""
            konfirm.Text = ""
        ElseIf passbaru.Text = "" Then
            MsgBox("Password baru kosong, silahkan masukkan password baru anda", MsgBoxStyle.Critical)
            passlama.Text = ""
            passbaru.Text = ""
            konfirm.Text = ""
        Else
            MsgBox("Password lama tidak sesuai, silahkan cek ulang password", MsgBoxStyle.Critical)
            passlama.Text = ""
            passbaru.Text = ""
            konfirm.Text = ""
        End If
    End Sub

    Private Sub Tb_adminBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Tb_adminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RRIdbDataSet)

    End Sub

    Private Sub pass_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RRIdbDataSet.tb_admin' table. You can move, or remove it, as needed.
        Me.Tb_adminTableAdapter.Fill(Me.RRIdbDataSet.tb_admin)

    End Sub
End Class