Imports pbas.PBAS_Login
Imports System.Data.Odbc
Public Class PBAS_Management
    Dim con As New OdbcConnection("DSN=PBASDSN")
    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles TLE_link.LinkClicked
        If year.Text = "" Then
            MsgBox("First enter the year", MsgBoxStyle.Critical)
        Else
            uidmodule.myear = year.Text
            PBAS_Part_B_C1.Show()
        End If


    End Sub



    Private Sub Gen_Info_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Gen_Info_Link.LinkClicked
        If PBAS_Gen_Info.Visible = True Then
            MsgBox("Form is already open", MsgBoxStyle.Critical)
        Else
            PBAS_Gen_Info.Show()
        End If
    End Sub

    Private Sub CEP_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CEP_Link.LinkClicked

        If year.Text = "" Then
            MsgBox("First enter the year", MsgBoxStyle.Critical)
        Else
            uidmodule.myear = year.Text
            PBAS_Part_B_C2.Show()
        End If

    End Sub

    Private Sub RPAC_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RPAC_Link.LinkClicked

        If year.Text = "" Then
            MsgBox("First enter the year", MsgBoxStyle.Critical)
        Else
            uidmodule.myear = year.Text
            PBAS_PART_B_C3.Show()
        End If

    End Sub

    Private Sub SAPI_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles SAPI_Link.LinkClicked

        If year.Text = "" Then
            MsgBox("First enter the year", MsgBoxStyle.Critical)
        Else
            uidmodule.myear = year.Text
            PBAS_PART_B_C4.Show()
        End If

    End Sub

    Private Sub ORI_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ORI_Link.LinkClicked
        If year.Text = "" Then
            MsgBox("First enter the year", MsgBoxStyle.Critical)
        Else
            uidmodule.myear = year.Text
            PBAS_Part_C.Show()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If year.Text = "" Then
            MsgBox("First enter the year", MsgBoxStyle.Critical)
        Else
            uidmodule.myear = year.Text
            PBAS_Report.Show()
        End If

    End Sub


    Private Sub PBAS_Management_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        useridlbl.Text = muid
        year.Select()
    End Sub

    Private Sub year_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles year.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 45 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub


    Private Sub Acad_Act_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Acad_Act_Link.LinkClicked
        If year.Text = "" Then
            MsgBox("First enter the year", MsgBoxStyle.Critical)
        Else
            uidmodule.myear = year.Text
            PBAS_Acad_Act.Show()
        End If
    End Sub


    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        Try
            If year.Text = "" Then
                MsgBox("Please enter the year.")
            Else
                Dim q As String
                q = q_combo.Text
                If (q = "Workshop") Then
                    PBAS_PART_B_C3.Show()
                    PBAS_PART_B_C3.PPC_Tab.Show()
                End If
                If (q = "Lectures") Then
                    PBAS_Part_B_C1.Show()
                    PBAS_Part_B_C1.LSTP_Tab.Show()
                End If
                If (q = "Seminar") Then
                    PBAS_Part_B_C1.Show()
                    PBAS_Part_B_C1.LSTP_Tab.Show()
                End If
                If (q = "Tutorial") Then
                    PBAS_Part_B_C1.Show()
                    PBAS_Part_B_C1.LSTP_Tab.Show()
                End If
            End If 
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub PC_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PC_Save.Click
        Try
            con.Open()
            Dim cp As String
            cp = PC_CP.Text
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from userinfo where User_Id='" + muid + "' and Pwd='" + cp + "' ", con)
            If (cmd.ExecuteNonQuery > 0) Then
                If (PC_NP.Text = PC_CnP.Text) Then
                    Dim cmd1 As OdbcCommand
                    cmd1 = New OdbcCommand("update userinfo set Pwd='" + PC_CnP.Text + "' where User_Id='" + muid + "'", con)
                    cmd1.ExecuteNonQuery()
                    MsgBox("Password changed successfully", MsgBoxStyle.Information)
                    PC_CP.Clear()
                    PC_CnP.Clear()
                    PC_NP.Clear()
                Else
                    MsgBox("New password and confirm password is not matched", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Password not matched", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub PC_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        PBAS_Login.Show()
    End Sub

 
    Private Sub LinkLabel3_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            con.Open()
            Dim cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8, cmd9, cmd10, cmd11, cmd12, cmd13, cmd14, cmd15, cmd16, cmd17, cmd18, cmd19, cmd20, cmd21 As OdbcCommand
            Dim intResponse As Integer
            uidmodule.myear = year.Text
            intResponse = MsgBox("Are you sure to delete this record", _
                                 vbYesNo + vbQuestion + vbDefaultButton2, _
                                 "Delete")
            If intResponse = vbYes Then
                'cmd1 = New OdbcCommand("delete from acad_act,Teach_lstp where User_Id='" + muid + "' and Year='" + myear + "'", con)
                'cmd1.ExecuteNonQuery()

                MsgBox("Data deleted successfully", MsgBoxStyle.Critical)
                Me.Dispose()
                PBAS_Login.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Me.Dispose()
        PBAS_Acad_Act.Dispose()
        PBAS_Gen_Info.Dispose()
        PBAS_Part_B_C1.Dispose()
        PBAS_Part_B_C2.Dispose()
        PBAS_PART_B_C3.Dispose()
        PBAS_Part_C.Dispose()
        PBAS_Login.Show()
    End Sub

End Class