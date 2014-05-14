Imports System.Data.Odbc
Public Class PBAS_Part_C
    Dim con As New OdbcConnection("DSN=PBASDSN")


    Private Sub ORIE_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORIE_Show.Click
        Try
            con.Open()
            Dim encs As String
            encs = orie_combo.Text
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from orie where User_Id='" + muid + "' and Year='" + myear + "' and Details='" + encs + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read

                ORIE_Textbox.Text = dr(3)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub



    Private Sub Encssave_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Encssave_btn.Click
        Try
            con.Open()
            If Encs_Text.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim encs, sno1 As String
                encs = Encs_Combo.Text
                sno1 = ""
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Enclosures where User_Id='" + muid + "' and Year='" + myear + "' and Enclosure='" + encs + "'", con)
                Dim dr3 As OdbcDataReader
                dr3 = cmd1.ExecuteReader
                While dr3.Read
                    sno1 = dr3(3)
                End While
                con.Close()
                con.Open()
                Dim cmd2 As OdbcCommand
                cmd2 = New OdbcCommand("select * from Enclosures where User_Id='" + muid + "' and Year='" + myear + "' and Enclosure='" + sno1 + "' ", con)
                If (cmd1.ExecuteNonQuery > 0) Then

                    Dim encs1 As String
                    encs1 = Encs_Text.Text
                    Dim cmd, cmd4 As OdbcCommand
                    cmd4 = New OdbcCommand("select * from Enclosures where User_Id='" + muid + "' and Year='" + myear + "' and Enclosure='" + encs + "' ", con)

                    Dim dr2 As OdbcDataReader
                    dr2 = cmd4.ExecuteReader()
                    Dim temp As String
                    temp = ""
                    While dr2.Read
                        temp = dr2(2)
                    End While

                    cmd = New OdbcCommand("update Enclosures set Enclosure='" + encs1 + "' where User_Id='" + muid + "' and Year='" + myear + "' and SNo='" + temp + "' ", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    Encs_Text.Clear()

                    Encs_Combo.Text = "--- Select ---"
                Else

                    Dim encs2 As String
                    Dim cmd As OdbcCommand

                    encs2 = Encs_Text.Text
                    cmd = New OdbcCommand("insert into Enclosures values('" + muid + "', '" + myear + "' ,'','" + encs2 + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Added Successfully", MsgBoxStyle.Information)
                    Encs_Text.Clear()

                    Encs_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        con.Close()
    End Sub

    Private Sub Encsshow_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Encsshow_btn.Click
        Try
            con.Open()
            Dim encs As String
            encs = Encs_Combo.Text
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from Enclosures where User_Id='" + muid + "' and Year='" + myear + "' and Enclosure='" + encs + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read

                Encs_Text.Text = dr(3)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub Encs_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Encs_Combo.MouseClick
        Try
            con.Open()
            Encs_Combo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Enclosure from Enclosures where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Encs_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub Encsdelete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Encsdelete_btn.Click
        Try
            con.Open()
            If Encs_Text.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim encs As String
                encs = Encs_Text.Text
                Dim cmd As OdbcCommand
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Enclosures where User_Id='" + muid + "' and Year='" + myear + "' and Enclosure='" + encs + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    Encs_Text.Clear()

                    Encs_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub ORIE_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORIE_Add.Click
        Try
            con.Open()
            If ORIE_Textbox.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim encs, sno1 As String
                encs = orie_combo.Text
                sno1 = ""
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from orie where User_Id='" + muid + "' and Year='" + myear + "' and Details='" + encs + "'", con)
                Dim dr3 As OdbcDataReader
                dr3 = cmd1.ExecuteReader
                While dr3.Read
                    sno1 = dr3(3)
                End While
                con.Close()
                con.Open()
                Dim cmd2 As OdbcCommand
                cmd2 = New OdbcCommand("select * from orie where User_Id='" + muid + "' and Year='" + myear + "' and Details='" + sno1 + "' ", con)
                If (cmd1.ExecuteNonQuery > 0) Then

                    Dim encs1 As String
                    encs1 = ORIE_Textbox.Text
                    Dim cmd, cmd4 As OdbcCommand
                    cmd4 = New OdbcCommand("select * from orie where User_Id='" + muid + "' and Year='" + myear + "' and Details='" + encs + "' ", con)

                    Dim dr2 As OdbcDataReader
                    dr2 = cmd4.ExecuteReader()
                    Dim temp As String
                    temp = ""
                    While dr2.Read
                        temp = dr2(2)
                    End While

                    cmd = New OdbcCommand("update orie set Details='" + encs1 + "' where User_Id='" + muid + "' and Year='" + myear + "' and SNo='" + temp + "' ", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    ORIE_Textbox.Clear()

                    orie_combo.Text = "--- Select ---"
                Else

                    Dim encs2 As String
                    Dim cmd As OdbcCommand

                    encs2 = ORIE_Textbox.Text
                    cmd = New OdbcCommand("insert into orie values('" + muid + "', '" + myear + "' ,'','" + encs2 + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Added Successfully", MsgBoxStyle.Information)
                    ORIE_Textbox.Clear()

                    orie_combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        con.Close()
    End Sub

    Private Sub orie_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orie_Delete.Click
        Try
            con.Open()
            If ORIE_Textbox.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim encs As String
                encs = ORIE_Textbox.Text
                Dim cmd As OdbcCommand
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from orie where User_Id='" + muid + "' and Year='" + myear + "' and Details='" + encs + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    ORIE_Textbox.Clear()

                    orie_combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub orie_combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles orie_combo.MouseClick
        Try
            con.Open()
            orie_combo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Details from orie where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                orie_combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

End Class