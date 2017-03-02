Option Explicit On
Imports System.Data.OleDb

Public Class login
    Dim objcon As New OleDbConnection
    Dim strsql As String
    Dim strconnection As String = "Provider= Microsoft.JET.OLEDB.4.0;Data Source= logdb.mdb"
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim attempt As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RRIdbDataSet.tb_admin' table. You can move, or remove it, as needed.
        Me.Tb_adminTableAdapter.Fill(Me.RRIdbDataSet.tb_admin)

    End Sub

 
    Private Sub log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log.Click
        Dim warning As String = "Warning!" & vbNewLine & vbNewLine + _
            "If attemt var = 3" + vbNewLine + _
            "system will shutdown."

        If (TextBox1.Text = "") And (TextBox2.Text = "") Then
            attempt = attempt + 1
            MsgBox("please input username and password !" & vbNewLine & vbNewLine + _
                   warning, MsgBoxStyle.Exclamation, "Sorry sir! " & _
                   "Now attempt var =  " & attempt)
        ElseIf (TextBox1.Text = "") Then
            attempt = attempt + 1
            MsgBox("please input username !" & vbNewLine & vbNewLine + _
                   warning, MsgBoxStyle.Exclamation, "Sorry sir! " & _
                   "Now attempt var =  " & attempt)
        ElseIf (TextBox2.Text = "") Then
            attempt = attempt + 1
            MsgBox("please input password !" & vbNewLine & vbNewLine + _
                   warning, MsgBoxStyle.Exclamation, "Sorry sir! " & _
                   "Now attempt var =  " & attempt)
        Else

            Dim strname = TextBox1.Text
            Dim strpass = TextBox2.Text

            Tb_adminBindingSource.Filter = "username = '" & TextBox1.Text & "' and pass = '" & TextBox2.Text & "'"

            If Tb_adminBindingSource.Count <> 0 Then
                'play login sound
                member = strname
                My.Computer.Audio.Play(Application.StartupPath + "\sound\login.wav")
                MsgBox("Hello!" + strname + vbNewLine + _
                       "log in succesfull", MsgBoxStyle.OkOnly, _
                       "wlcome " + strname)
                Form1.Show()
                Me.Close()

            Else
                attempt = attempt +
                MsgBox("oops ! --> " & strname & "  _&_  " & strpass + vbNewLine + vbNewLine + _
                       "the username and password you entered " + vbNewLine + _
                       "is not valid. " + vbNewLine + _
                       "please try again ", MsgBoxStyle.Exclamation, "invalid")

            End If

            Tb_adminBindingSource.RemoveFilter()

        End If
        If attempt = 3 Then
            MsgBox("windows is shutting down ", MsgBoxStyle.Critical, "good bye sir!")
            Me.Close()
        End If
    End Sub

    Private Sub ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ex.Click
        Dim msg As String = " do you want to exit?"
        Dim title As String = "Exit application"
        Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim icon As MessageBoxIcon = MessageBoxIcon.Exclamation
        Dim result As DialogResult = MessageBox.Show(msg, title, button, icon, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            My.Computer.Audio.Play(Application.StartupPath + "\sound\logout.wav")
            MessageBox.Show("thank u" + vbNewLine + _
                            "exit application confirm")
            Me.Close()
        ElseIf result = DialogResult.No Then
            MsgBox("Welcome Back", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Pressed")

        End If
    End Sub


    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Tb_adminBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Tb_adminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RRIdbDataSet)

    End Sub

    Private Sub Tb_adminBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Tb_adminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RRIdbDataSet)

    End Sub

    Private Sub Tb_adminBindingNavigatorSaveItem_Click_2(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Tb_adminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RRIdbDataSet)

    End Sub
End Class
