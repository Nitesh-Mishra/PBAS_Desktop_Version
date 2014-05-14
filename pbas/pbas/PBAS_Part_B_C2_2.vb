Imports System.Data.Odbc


Public Class PBAS_Part_B_C2

    Dim con As New OdbcConnection("DSN=PBASDSN")

    Private Sub ECFA_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ECFA_Link.LinkClicked
        CLMI_Tab.Hide()
        PDA_Tab.Hide()
        ECFA_Tab.Show()
        Category2.SelectTab(0)
    End Sub

    Private Sub CLMI_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CLMI_Link.LinkClicked
        ECFA_Tab.Hide()
        PDA_Tab.Hide()
        CLMI_Tab.Show()
        Category2.SelectTab(1)
    End Sub

    Private Sub PDA_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PDA_Link.LinkClicked
        CLMI_Tab.Hide()
        ECFA_Tab.Hide()
        PDA_Tab.Show()
        Category2.SelectTab(2)
    End Sub

    Private Sub ECFA_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECFA_Add.Click
        Try
            If ECFA_TOA.Text = "" Or ECFA_AH.Text = "" Or ECFA_API.Text = "" Then
                MsgBox("Fields can't be left blank")
            Else
                con.Open()
                Dim cmd1 As OdbcCommand
                Dim toa1 As String
                toa1 = ECFA_TOA.Text
                cmd1 = New OdbcCommand("select * from Teach_ECFA where User_Id='" + muid + "' and Year='" + myear + "' and Teach_ECFA_TOA='" + toa1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    If ECFA_API.Text > 10 Then
                        MsgBox("Please enter correct API")
                    Else
                        Dim cmd As OdbcCommand
                        Dim toa, ah, api As String
                        toa = ECFA_TOA.Text
                        ah = ECFA_AH.Text
                        api = ECFA_API.Text
                        Dim com As String
                        com = ECFA_Combo.Text
                        cmd = New OdbcCommand("update Teach_ECFA set Teach_ECFA_TOA='" + toa + "',Teach_ECFA_AH='" + ah + "',Teach_ECFA_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and  Teach_ECFA_TOA='" + com + "'", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Updated Successfully")
                        ECFA_TOA.Clear()
                        ECFA_AH.Clear()
                        ECFA_API.Clear()
                        ECFA_Combo.Text = "--- Select ---"
                    End If
                Else
                    If ECFA_API.Text > 10 Then
                        MsgBox("Please enter correct API")
                    Else
                        Dim toa, ah, api As String
                        Dim cmd As OdbcCommand
                        toa = ECFA_TOA.Text
                        ah = ECFA_AH.Text
                        api = ECFA_API.Text
                        cmd = New OdbcCommand("insert into Teach_ECFA Values('" + muid + "', '" + myear + "' ,'" + toa + "','" + ah + "','" + api + "')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Added Successfully")
                        ECFA_TOA.Clear()
                        ECFA_AH.Clear()
                        ECFA_API.Clear()
                        ECFA_Combo.Text = "--- Select ---"
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub ECFA_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ECFA_TOA.Clear()
        ECFA_AH.Clear()
        ECFA_API.Clear()
        ECFA_Combo.Text = "--- Select ---"
    End Sub

    Private Sub ECFA_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECFA_Show.Click
        Try
            con.Open()
            Dim toa As String
            toa = ECFA_Combo.Text
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from Teach_ECFA where User_Id='" + muid + "' and Year='" + myear + "' and Teach_ECFA_TOA='" + toa + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                ECFA_TOA.Text = dr(2)
                ECFA_AH.Text = dr(3)
                ECFA_API.Text = dr(4)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub ECFA_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim cmd As OdbcCommand
            Dim toa, ah, api As String
            toa = ECFA_TOA.Text
            ah = ECFA_AH.Text
            api = ECFA_API.Text
            Dim com As String
            com = ECFA_Combo.Text
            cmd = New OdbcCommand("update Teach_ECFA set Teach_ECFA_TOA='" + toa + "',Teach_ECFA_AH='" + ah + "',Teach_ECFA_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and  Teach_ECFA_TOA='" + com + "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")
            ECFA_TOA.Clear()
            ECFA_AH.Clear()
            ECFA_API.Clear()
            ECFA_Combo.Text = "--- Select ---"
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub ECFA_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECFA_Delete.Click
        Try
            con.Open()
            If ECFA_TOA.Text = "" Or ECFA_AH.Text = "" Or ECFA_API.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim cmd As OdbcCommand
                Dim toa As String
                toa = ECFA_TOA.Text
                cmd = New OdbcCommand("delete from Teach_ECFA where User_Id='" + muid + "' and Year='" + myear + "' and Teach_ECFA_TOA='" + toa + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted Successfully")
                ECFA_TOA.Clear()
                ECFA_AH.Clear()
                ECFA_API.Clear()
                ECFA_Combo.Text = "--- Select ---"
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub CMLI_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMLI_Add.Click
        Try
            con.Open()
            If CLMI_TOA.Text = "" Or CLMI_YSR.Text = "" Or CLMI_API.Text = "" Then
                MsgBox("Fields can't be left blank")
            Else
                Dim cmd1 As OdbcCommand
                Dim toa1 As String
                toa1 = CLMI_TOA.Text
                cmd1 = New OdbcCommand("select Teach_CLMI_TOA  from Teach_CLMI where User_Id='" + muid + "' and Year='" + myear + "' and Teach_CLMI_TOA='" + toa1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    If CLMI_API.Text > 5 Then
                        MsgBox("Please enter correct API")
                    Else
                        Dim cmd As OdbcCommand
                        Dim toa, ysr, api As String
                        toa = CLMI_TOA.Text
                        ysr = CLMI_YSR.Text
                        api = CLMI_API.Text
                        Dim com As String
                        com = CLMI_Combo.Text
                        cmd = New OdbcCommand("update Teach_CLMI set Teach_CLMI_TOA='" + toa + "',Teach_CLMI_YSR='" + ysr + "',Teach_CLMI_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_CLMI_TOA='" + com + "' ", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Updated Successfully")
                        CLMI_TOA.Clear()
                        CLMI_YSR.Clear()
                        CLMI_API.Clear()
                        CLMI_Combo.Text = "--- Select ---"
                    End If
                Else
                    If CLMI_API.Text > 5 Then
                        MsgBox("Please enter correct API")
                    Else
                        Dim cmd As OdbcCommand
                        Dim toa, ysr, api As String
                        toa = CLMI_TOA.Text
                        ysr = CLMI_YSR.Text
                        api = CLMI_API.Text
                        cmd = New OdbcCommand("insert into Teach_CLMI values('" + muid + "', '" + myear + "' ,'" + toa + "','" + ysr + "','" + api + "')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Added Successfully")
                        CLMI_TOA.Clear()
                        CLMI_YSR.Clear()
                        CLMI_API.Clear()
                        CLMI_Combo.Text = "--- Select ---"
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub CLMI_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLMI_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim toa As String
            toa = CLMI_Combo.Text
            cmd = New OdbcCommand("select * from Teach_CLMI where User_Id='" + muid + "' and Year='" + myear + "' and Teach_CLMI_TOA='" + toa + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                CLMI_TOA.Text = dr(2)
                CLMI_YSR.Text = dr(3)
                CLMI_API.Text = dr(4)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub CLMI_CLear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CLMI_TOA.Clear()
        CLMI_YSR.Clear()
        CLMI_API.Clear()
        CLMI_Combo.Text = "--- Select ---"
    End Sub

    Private Sub CLMI_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim toa, ysr, api As String
            toa = CLMI_TOA.Text
            ysr = CLMI_YSR.Text
            api = CLMI_API.Text
            cmd = New OdbcCommand("update Teach_CLMI set Teach_CLMI_TOA='" + toa + "',Teach_CLMI_YSR='" + ysr + "',Teach_CLMI_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_CLMI_TOA='" + toa + "' ", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub CLMI_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLMI_Delete.Click
        Try
            con.Open()
            If CLMI_TOA.Text = "" Or CLMI_YSR.Text = "" Or CLMI_API.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim cmd As OdbcCommand
                Dim toa As String
                toa = CLMI_TOA.Text
                cmd = New OdbcCommand("delete from Teach_CLMI where User_Id='" + muid + "' and Year='" + myear + "' and Teach_CLMI_TOA='" + toa + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted Successfully")
                CLMI_TOA.Clear()
                CLMI_YSR.Clear()
                CLMI_API.Clear()
                CLMI_Combo.Text = "--- Select ---"
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PDA_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDA_Add.Click
        Try
            con.Open()
            If PDA_TOA.Text = "" Or PDA_YWR.Text = "" Or PDA_API.Text = "" Then
                MsgBox("Fields can't be left blank")
            Else
                Dim cmd1 As OdbcCommand
                Dim toa1 As String
                toa1 = PDA_TOA.Text
                cmd1 = New OdbcCommand("select * from Teach_PDA where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PDA_TOA='" + toa1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    If PDA_API.Text > 5 Then
                        MsgBox("Please enter correct API")
                    Else
                        Dim toa, ywr, api As String
                        Dim cmd As OdbcCommand
                        toa = PDA_TOA.Text
                        ywr = PDA_YWR.Text
                        api = PDA_API.Text
                        Dim com As String
                        com = PDA_Combo.Text
                        cmd = New OdbcCommand("update Teach_PDA set Teach_PDA_TOA='" + toa + "',Teach_PDA_YWR='" + ywr + "',Teach_PDA_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PDA_TOA='" + com + "'", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Updated Successfully")
                        PDA_TOA.Clear()
                        PDA_YWR.Clear()
                        PDA_API.Clear()
                        PDA_Combo.Text = "--- select ---"
                    End If
                Else
                    If PDA_API.Text > 5 Then
                        MsgBox("Please enter correct API")
                    Else
                        Dim toa, ywr, api As String
                        Dim cmd As OdbcCommand
                        toa = PDA_TOA.Text
                        ywr = PDA_YWR.Text
                        api = PDA_API.Text
                        cmd = New OdbcCommand("insert into Teach_PDA values('" + muid + "', '" + myear + "' ,'" + toa + "','" + ywr + "','" + api + "')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Added Successfully")
                        PDA_TOA.Clear()
                        PDA_YWR.Clear()
                        PDA_API.Clear()
                        PDA_Combo.Text = "--- select ---"
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PDA_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PDA_TOA.Clear()
        PDA_YWR.Clear()
        PDA_API.Clear()
        PDA_Combo.Text = "--- select ---"
    End Sub

    Private Sub PDA_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDA_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim toa As String
            toa = PDA_Combo.Text
            cmd = New OdbcCommand("select * from Teach_PDA where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PDA_TOA='" + toa + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                PDA_TOA.Text = dr(2)
                PDA_YWR.Text = dr(3)
                PDA_API.Text = dr(4)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PDA_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            con.Open()
            Dim toa, ywr, api As String
            Dim cmd As OdbcCommand
            toa = PDA_TOA.Text
            ywr = PDA_YWR.Text
            api = PDA_API.Text
            cmd = New OdbcCommand("update Teach_PDA set Teach_PDA_TOA='" + toa + "',Teach_PDA_YWR='" + ywr + "',Teach_PDA_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PDA_TOA='" + toa + "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")
            PDA_TOA.Clear()
            PDA_YWR.Clear()
            PDA_API.Clear()
            PDA_Combo.Text = "--- select ---"
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PDA_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDA_Delete.Click
        Try
            con.Open()
            Dim toa As String
            If PDA_TOA.Text = "" Or PDA_YWR.Text = "" Or PDA_API.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                toa = PDA_TOA.Text
                Dim cmd As OdbcCommand
                cmd = New OdbcCommand("delete from Teach_PDA where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PDA_TOA='" + toa + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted Successfuuly")
                PDA_TOA.Clear()
                PDA_YWR.Clear()
                PDA_API.Clear()
                PDA_Combo.Text = "--- select ---"
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub



    Private Sub ECFA_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ECFA_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            ECFA_Combo.Items.Clear()
            cmd = New OdbcCommand("select Teach_ECFA_TOA from Teach_ECFA where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                ECFA_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub CLMI_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CLMI_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            CLMI_Combo.Items.Clear()
            cmd = New OdbcCommand("select Teach_CLMI_TOA from Teach_CLMI where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                CLMI_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub CLMI_Combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLMI_Combo.SelectedIndexChanged

    End Sub

    Private Sub PDA_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PDA_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            PDA_Combo.Items.Clear()
            cmd = New OdbcCommand("select Teach_PDA_TOA from Teach_PDA where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                PDA_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PDA_Combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDA_Combo.SelectedIndexChanged

    End Sub

    Private Sub PBAS_Part_B_C2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        yearc2.Text = myear
    End Sub

    Private Sub ECFA_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ECFA_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub ECFA_AH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ECFA_AH.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub CLMI_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CLMI_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub PDA_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PDA_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub ECFA_Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECFA_Tab.Click
        ECFA_TOA.Focus()
    End Sub

    Private Sub CLMI_Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLMI_Tab.Click
        CLMI_TOA.Focus()
    End Sub

    Private Sub PDA_Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDA_Tab.Click
        PDA_TOA.Focus()
    End Sub


    Private Sub ECFA_TOA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ECFA_TOA.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) AndAlso Asc(e.KeyChar) <> 45 Then
            MsgBox("Enter Alphabets only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub


    Private Sub CLMI_TOA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CLMI_TOA.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) AndAlso Asc(e.KeyChar) <> 45 Then
            MsgBox("Enter Alphabets only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub


    Private Sub CLMI_YSR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CLMI_YSR.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) AndAlso Asc(e.KeyChar) <> 45 Then
            MsgBox("Enter Alphabets only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub


    Private Sub PDA_TOA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PDA_TOA.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) AndAlso Asc(e.KeyChar) <> 45 Then
            MsgBox("Enter Alphabets only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub PDA_YWR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PDA_YWR.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) AndAlso Asc(e.KeyChar) <> 45 Then
            MsgBox("Enter Alphabets only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

End Class