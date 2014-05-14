
Imports System.Data.Odbc
Public Class PBAS_Acad_Act
    Dim con As New OdbcConnection("DSN=PBASDSN")
    Private Sub GI2_Addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GI2_Addbtn.Click
        Try
            con.Open()
            Dim cmd1 As OdbcCommand
            Dim noc1 As String
            noc1 = GI_NOC.Text
            cmd1 = New OdbcCommand("select * from acad_act where User_Id = '" + muid + "' and Year='" + myear + "' and Gen_Info_Noc='" + noc1 + "'", con)
            If (cmd1.ExecuteNonQuery() > 0) Then
                Dim cmd As OdbcCommand
                Dim noc, place, dur, sa, aqyear As String
                noc = GI_NOC.Text
                place = GI_Place.Text
                dur = GI_Dur.Text
                sa = GI_SA.Text
                aqyear = GI_Aqyear.Text

                Dim com As String
                'com = GI2_Combo.Text
                

                cmd = New OdbcCommand("update acad_act set Gen_Info_Noc='" + noc + "', Gen_Info_Place='" + place + "', Gen_Info_Duration='" + dur + "',Gen_Info_SA='" + sa + "',Gen_Info_Aqyear='" + aqyear + "' where User_Id='" + muid + "' and Year='" + myear + "' and Gen_Info_noc='" + com + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                GI_NOC.Clear()
                GI_Place.Clear()
                GI_Dur.Clear()
                GI_SA.Clear()
                GI_Aqyear.Clear()

                GI_AQ_No.Select()
                GI_ASC_No.Select()
                GI2_Combo.Text = "---- Select ----"
            Else
                Dim aq, noc, place, dur, sa, aqyear, asc As String
                Dim cmd As OdbcCommand
                If GI_ASC_yes.Equals(True) Then
                    asc = "yes"
                Else
                    asc = "No"
                End If
                noc = GI_NOC.Text
                place = GI_Place.Text
                dur = GI_Dur.Text
                sa = GI_SA.Text
                aqyear = GI_Aqyear.Text
                If GI_AQ_Yes.Equals(True) Then
                    aq = "yes"
                Else
                    aq = "No"
                End If

                cmd = New OdbcCommand("insert into acad_act values('" + muid + "','" + myear + "','" + aq + "','" + noc + "','" + place + "','" + dur + "','" + sa + "','" + aqyear + "','" + asc + "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Your Information is saved", MsgBoxStyle.Information)
                GI_NOC.Clear()
                GI_Place.Clear()
                GI_Dur.Clear()
                GI_SA.Clear()
                GI_Aqyear.Clear()

                GI_AQ_No.Select()
                GI_ASC_No.Select()
                GI2_Combo.Text = "---- Select ----"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub PBAS_Acad_Act_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.Open()
            GI_NOC.Enabled = False
            GI_Place.Enabled = False
            GI_Dur.Enabled = False
            GI_SA.Enabled = False
            GI_Aqyear.Enabled = False
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Gen_Info_NOC from acad_act where User_Id='" + muid + "' and year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                GI2_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()

    End Sub

    Private Sub GI2_Showbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GI2_Showbtn.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim aqyear, ascyear As String
            Dim noc As String
            noc = GI2_Combo.Text
            cmd = New OdbcCommand("select * from acad_act where User_Id = '" + muid + "' and Year='" + myear + "' and Gen_Info_NOC='" + noc + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                aqyear = dr(2)
                GI_NOC.Text = dr(3)
                GI_Place.Text = dr(4)
                GI_Dur.Text = dr(5)
                GI_SA.Text = dr(6)
                GI_Aqyear.Text = dr(7)
                ascyear = dr(8)

            End While
            If aqyear = "yes" Then
                GI_AQ_Yes.Checked = True
            Else
                GI_AQ_No.Checked = True
            End If
            If ascyear = "yes" Then
                GI_ASC_yes.Checked = True
            Else
                GI_ASC_No.Checked = True
            End If
            GI_NOC.Enabled = True
            GI_Place.Enabled = True
            GI_Dur.Enabled = True
            GI_SA.Enabled = True
            GI_Aqyear.Enabled = True


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub GI2_Deletebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GI2_Deletebtn.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim noc As String
            noc = GI_NOC.Text
            Dim intResponse As Integer

            intResponse = MsgBox("Are you sure to delete this record", _
                                 vbYesNo + vbQuestion + vbDefaultButton2, _
                                 "Delete")
            If intResponse = vbYes Then
                cmd = New OdbcCommand("delete from Acad_Act where User_Id='" + muid + "' and Year='" + myear + "' and Gen_Info_noc='" + noc + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data deleted successfully", MsgBoxStyle.Critical)
            End If
            GI_NOC.Clear()
            GI_Place.Clear()
            GI_Dur.Clear()
            GI_SA.Clear()
            GI_Aqyear.Clear()

            GI_AQ_No.Select()
            GI_ASC_No.Select()
            GI2_Combo.Text = "---- Select ----"
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub GI2_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GI2_Combo.MouseClick
        Try
            con.Open()
            GI2_Combo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Gen_Info_NOC from acad_act where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                GI2_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

   

    Private Sub GI_Aqyear_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GI_Aqyear.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub GI_Ascyear_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GI_AQ_Yes.CheckedChanged
        GI_NOC.Enabled = True
        GI_Place.Enabled = True
        GI_Dur.Enabled = True
        GI_SA.Enabled = True
        GI_Aqyear.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GI_AQ_No.CheckedChanged
        GI_NOC.Enabled = False
        GI_Place.Enabled = False
        GI_Dur.Enabled = False
        GI_SA.Enabled = False
        GI_Aqyear.Enabled = False
    End Sub

End Class