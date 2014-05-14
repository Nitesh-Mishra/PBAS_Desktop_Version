Imports System.Data.Odbc

Public Class PBAS_Login
    Dim con As New OdbcConnection("DSN=PBASDSN;")

    Private Sub PBAS_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        luid.Select()
        luid.Focus()

    End Sub


    Private Sub Login_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        log_sup.Visible = False
        Signup_Tab.Show()

    End Sub

    Private Sub Signup_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        Signup_Tab.Show()
    End Sub




    Private Sub Cancelbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelbtn.Click
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure, you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub Loginbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loginbtn.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim uid As String
            Dim pass As String
            uid = luid.Text
            pass = lpwd.Text
            uidmodule.muid = uid
            uidmodule.mpwd = pass
            cmd = New OdbcCommand("select * from userinfo where User_Id='" + uid + "' and Pwd='" + pass + "'", con)
            If (cmd.ExecuteNonQuery() = 1) Then
                Me.Hide()
                PBAS_Management.Show()
                luid.Clear()
                lpwd.Clear()
            Else
                MsgBox("Invalid Login")
            End If

        Catch ex As Exception

        End Try
        con.Close()
    End Sub



    Private Sub Signup_Link_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Signup_Link.LinkClicked
        Login_Tab.Hide()
        Signup_Tab.Show()
        log_sup.SelectTab(1)
    End Sub



    Private Sub signupbtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signupbtn.Click
        Try
            con.Open()
            Dim cmd1, cmd2 As OdbcCommand
            Dim s_uid, s_pass, sr_pass As String
            s_uid = suid.Text
            s_pass = spwd.Text
            sr_pass = srpwd.Text
            If s_pass = sr_pass Then
                'MsgBox("password match")
                cmd1 = New OdbcCommand("select * from userinfo where User_Id='" + s_uid + "'", con)
                If (cmd1.ExecuteNonQuery = 1) Then
                    MsgBox("User Already exists, Please login to access")
                Else
                    cmd2 = New OdbcCommand("insert into userinfo values('" + s_uid + "','" + s_pass + "')", con)
                    cmd2.ExecuteNonQuery()

                    MsgBox("signup successful, Please login now")

                    Signup_Tab.Hide()
                    Login_Tab.Show()
                    log_sup.SelectTab(0)

                    suid.Clear()
                    spwd.Clear()
                    srpwd.Clear()
                End If
            Else
                MsgBox("Password not matching")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub Login_Link_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Login_Link.LinkClicked
        Signup_Tab.Hide()
        Login_Tab.Show()
        log_sup.SelectTab(0)
        'log_sup.TabPages(0).Text = "LOGIN"
    End Sub

    Private Sub lpwd_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lpwd.Enter
        
    End Sub

   

    ' Private Sub luid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles luid.KeyPress
    ' If Asc(e.KeyChar) < 25 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
    'e.Handled = True
    'MsgBox("You can only use letter")
    'End If
    'End Sub



    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure, you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub Signup_Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Signup_Tab.Click
        suid.Focus()
    End Sub

    
End Class