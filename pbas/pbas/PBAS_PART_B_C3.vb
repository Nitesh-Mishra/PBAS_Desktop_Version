Imports System.Data.Odbc

Public Class PBAS_PART_B_C3
    Dim con As New OdbcConnection("DSN=PBASDSN")
    Private Sub PBAS_PART_B_C3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim q As String
        q = PBAS_Management.q_combo.Text
        If (q = "Workshop") Then
            Category3.SelectTab(8)
        End If
        yearc3.Text = myear
        ILC_DOE.Format = DateTimePickerFormat.Custom
        ILC_DOE.CustomFormat = "yyyy/MM/dd"
        PPC_DOE.Format = DateTimePickerFormat.Custom
        PPC_DOE.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub PPIJ_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PPIJ_Link.LinkClicked
        APB_Tab.Hide()
        FCP_Tab.Hide()
        BPE_Tab.Hide()
        OPC_Tab.Hide()
        CPC_Tab.Hide()
        RG_Tab.Hide()
        FDP_Tab.Hide()
        PPC_Tab.Hide()
        ILC_Tab.Hide()
        PPIJ_Tab.Show()
        Category3.SelectTab(0)
    End Sub

    Private Sub APB_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles APB_Link.LinkClicked
        PPIJ_Tab.Hide()
        FCP_Tab.Hide()
        BPE_Tab.Hide()
        OPC_Tab.Hide()
        CPC_Tab.Hide()
        RG_Tab.Hide()
        FDP_Tab.Hide()
        PPC_Tab.Hide()
        ILC_Tab.Hide()
        APB_Tab.Show()
        Category3.SelectTab(1)
    End Sub

    Private Sub FCP_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles FCP_Link.LinkClicked
        PPIJ_Tab.Hide()
        BPE_Tab.Hide()
        OPC_Tab.Hide()
        CPC_Tab.Hide()
        RG_Tab.Hide()
        FDP_Tab.Hide()
        PPC_Tab.Hide()
        ILC_Tab.Hide()
        APB_Tab.Hide()
        FCP_Tab.Show()
        Category3.SelectTab(2)
    End Sub

    Private Sub BPE_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles BPE_Link.LinkClicked
        PPIJ_Tab.Hide()
        OPC_Tab.Hide()
        CPC_Tab.Hide()
        RG_Tab.Hide()
        FDP_Tab.Hide()
        PPC_Tab.Hide()
        ILC_Tab.Hide()
        APB_Tab.Hide()
        FCP_Tab.Hide()
        BPE_Tab.Show()
        Category3.SelectTab(3)
    End Sub

    Private Sub OPC_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles OPC_Link.LinkClicked
        PPIJ_Tab.Hide()
        CPC_Tab.Hide()
        RG_Tab.Hide()
        FDP_Tab.Hide()
        PPC_Tab.Hide()
        ILC_Tab.Hide()
        APB_Tab.Hide()
        FCP_Tab.Hide()
        BPE_Tab.Hide()
        OPC_Tab.Show()
        Category3.SelectTab(4)
    End Sub

    Private Sub CPC_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CPC_Link.LinkClicked
        PPIJ_Tab.Hide()
        RG_Tab.Hide()
        FDP_Tab.Hide()
        PPC_Tab.Hide()
        ILC_Tab.Hide()
        APB_Tab.Hide()
        FCP_Tab.Hide()
        BPE_Tab.Hide()
        OPC_Tab.Hide()
        CPC_Tab.Show()
        Category3.SelectTab(5)
    End Sub

    Private Sub RG_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RG_Link.LinkClicked
        PPIJ_Tab.Hide()
        FDP_Tab.Hide()
        PPC_Tab.Hide()
        ILC_Tab.Hide()
        APB_Tab.Hide()
        FCP_Tab.Hide()
        BPE_Tab.Hide()
        OPC_Tab.Hide()
        CPC_Tab.Hide()
        RG_Tab.Show()
        Category3.SelectTab(6)
    End Sub

    Private Sub EDP_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EDP_Link.LinkClicked
        PPIJ_Tab.Hide()
        PPC_Tab.Hide()
        ILC_Tab.Hide()
        APB_Tab.Hide()
        FCP_Tab.Hide()
        BPE_Tab.Hide()
        OPC_Tab.Hide()
        CPC_Tab.Hide()
        RG_Tab.Hide()
        FDP_Tab.Show()
        Category3.SelectTab(7)
    End Sub

    Private Sub PPC_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PPC_Link.LinkClicked
        PPIJ_Tab.Hide()
        ILC_Tab.Hide()
        APB_Tab.Hide()
        FCP_Tab.Hide()
        BPE_Tab.Hide()
        OPC_Tab.Hide()
        CPC_Tab.Hide()
        RG_Tab.Hide()
        FDP_Tab.Hide()
        PPC_Tab.Show()
        Category3.SelectTab(8)
    End Sub

    Private Sub ILC_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ILC_Link.LinkClicked
        PPIJ_Tab.Hide()
        APB_Tab.Hide()
        FCP_Tab.Hide()
        BPE_Tab.Hide()
        OPC_Tab.Hide()
        CPC_Tab.Hide()
        RG_Tab.Hide()
        FDP_Tab.Hide()
        PPC_Tab.Hide()
        ILC_Tab.Show()
        Category3.SelectTab(9)
    End Sub

    Private Sub ILC_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ILC_Add.Click
        Try
            con.Open()
            If ILC_TOL.Text = "" Or ILC_TCS.Text = "" Or ILC_DOE.Text = Now Or ILC_Organized.Text = "" Or ILC_WINS.Text = "" Or ILC_API.Text = "" Then
                MsgBox("Fields can't be left blank")
            Else
                Dim cmd1 As OdbcCommand
                Dim tol1 As String
                tol1 = ILC_TOL.Text
                cmd1 = New OdbcCommand("select * from Teach_ILC where User_Id='" + muid + "' and Teach_ILC_TOL='" + tol1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    Dim cmd As OdbcCommand
                    Dim tol, tcs, doe, organized, wins, api As String
                    tol = ILC_TOL.Text
                    tcs = ILC_TCS.Text
                    doe = ILC_DOE.Text
                    organized = ILC_Organized.Text
                    wins = ILC_WINS.Text
                    api = ILC_API.Text
                    Dim com As String
                    com = ILC_Combo.Text
                    cmd = New OdbcCommand("update Teach_ILC set Teach_ILC_TOL='" + tol + "',Teach_ILC_TCS='" + tcs + "',Teach_ILC_DOE='" + doe + "',Teach_ILC_Organized='" + organized + "',Teach_ILC_WINS='" + wins + "',Teach_ILC_API='" + api + "' where User_Id='" + muid + "' and Teach_ILC_TOL='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully")
                    ILC_TOL.Clear()
                    ILC_TCS.Clear()
                    ILC_DOE.Value = Now
                    ILC_Organized.Clear()
                    ILC_WINS.Text = "---- Select ----"
                    ILC_API.Clear()
                    ILC_Combo.Text = "--- Select ---"
                Else
                    Dim cmd As OdbcCommand
                    Dim tol, tcs, doe, organized, wins, api As String
                    tol = ILC_TOL.Text
                    tcs = ILC_TCS.Text
                    doe = ILC_DOE.Text
                    organized = ILC_Organized.Text
                    wins = ILC_WINS.Text
                    api = ILC_API.Text
                    cmd = New OdbcCommand("insert into Teach_ILC values('" + muid + "','" + myear + "','" + tol + "','" + tcs + "','" + doe + "','" + organized + "','" + wins + "','" + api + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Inserted Successfully")
                    ILC_TOL.Clear()
                    ILC_TCS.Clear()
                    ILC_DOE.Value = Now
                    ILC_Organized.Clear()
                    ILC_WINS.Text = "---- Select ----"
                    ILC_API.Clear()
                    ILC_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub ILC_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ILC_TOL.Clear()
        ILC_TCS.Clear()
        ILC_DOE.Value = Now
        ILC_Organized.Clear()
        ILC_WINS.Text = ""
        ILC_API.Clear()
        ILC_Combo.Text = ""
    End Sub

    Private Sub ILC_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ILC_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim tol As String
            tol = ILC_Combo.Text
            cmd = New OdbcCommand("select * from Teach_ILC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_ILC_TOL='" + tol + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                ILC_TOL.Text = dr(2)
                ILC_TCS.Text = dr(3)
                ILC_DOE.Value = dr(4)
                ILC_Organized.Text = dr(5)
                ILC_WINS.Text = dr(6)
                ILC_API.Text = dr(7)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub ILC_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ILC_Delete.Click
        Try
            con.Open()
            If ILC_TOL.Text = "" Or ILC_TCS.Text = "" Or ILC_DOE.Text = Now Or ILC_Organized.Text = "" Or ILC_WINS.Text = "" Or ILC_API.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim cmd As OdbcCommand
                Dim tol As String
                tol = ILC_TOL.Text
                cmd = New OdbcCommand(" delete from Teach_ILC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_ILC_TOL='" + tol + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                ILC_TOL.Clear()
                ILC_TCS.Clear()
                ILC_DOE.Value = Now
                ILC_Organized.Clear()
                ILC_WINS.Text = "---- Select ----"
                ILC_API.Clear()
                ILC_Combo.Text = "--- Select ---"
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub ILC_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim tol, tcs, doe, organized, wins, api As String
            tol = ILC_TOL.Text
            tcs = ILC_TCS.Text
            doe = ILC_DOE.Text
            organized = ILC_Organized.Text
            wins = ILC_WINS.Text
            api = ILC_WINS.Text
            cmd = New OdbcCommand("update Teach_ILC set Teach_ILC_TOL='" + tol + "',Teach_ILC_TCS='" + tcs + "',Teach_ILC_DOE='" + doe + "',Teach_ILC_Organized='" + organized + "',Teach_ILC_Wins='" + wins + "',Teach_ILC_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_ILC_TOL='" + tol + "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub ILC_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ILC_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            ILC_Combo.Items.Clear()

            cmd = New OdbcCommand("select Teach_ILC_TOL from Teach_ILC where User_Id='" + muid + "' and Year='" + myear + "' ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                ILC_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub PPC_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPC_Add.Click
        Try
            con.Open()
            If PPC_TPP.Text = "" Or PPC_TCS.Text = "" Or PPC_DOE.Text = Now Or PPC_Organized.Text = "" Or PPC_WINS.Text = "" Or PPC_API.Text = "" Then
                MsgBox("Fields can't be left blank")
            Else
                Dim tpp1 As String
                tpp1 = PPC_TPP.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_PPC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PPC_TPP='" + tpp1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    Dim cmd As OdbcCommand
                    Dim tpp, tcs, doe, organized, wins, api As String
                    tpp = PPC_TPP.Text
                    tcs = PPC_TCS.Text
                    doe = PPC_DOE.Text
                    organized = PPC_Organized.Text
                    wins = PPC_WINS.Text
                    api = PPC_API.Text
                    Dim com As String
                    com = PPC_Combo.Text
                    cmd = New OdbcCommand("update Teach_PPC set Teach_PPC_TPP='" + tpp + "', Teach_PPC_TCS='" + tcs + "', Teach_PPC_DOE='" + doe + "', Teach_PPC_Organized='" + organized + "', Teach_PPC_WINS='" + wins + "', Teach_PPC_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PPC_TPP='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully")
                    PPC_TPP.Clear()
                    PPC_TCS.Clear()
                    PPC_DOE.Value = Now
                    PPC_Organized.Clear()
                    PPC_WINS.Text = "---- Select ----"
                    PPC_API.Clear()
                    PPC_Combo.Text = "--- Select ---"
                Else
                    Dim cmd As OdbcCommand
                    Dim tpp, tcs, doe, organized, wins, api As String
                    tpp = PPC_TPP.Text
                    tcs = PPC_TCS.Text
                    doe = PPC_DOE.Text
                    organized = PPC_Organized.Text
                    wins = PPC_WINS.Text
                    api = PPC_API.Text
                    cmd = New OdbcCommand("insert into Teach_PPC values('" + muid + "','" + myear + "','" + tpp + "','" + tcs + "','" + doe + "','" + organized + "','" + wins + "','" + api + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Added Successfully")
                    PPC_TPP.Clear()
                    PPC_TCS.Clear()
                    PPC_DOE.Value = Now
                    PPC_Organized.Clear()
                    PPC_WINS.Text = "---- Select ----"
                    PPC_API.Clear()
                    PPC_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PPC_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim tpp, tcs, doe, organized, wins, api As String
            tpp = PPC_TPP.Text
            tcs = PPC_TCS.Text
            doe = PPC_DOE.Text
            organized = PPC_Organized.Text
            wins = PPC_WINS.Text
            api = PPC_API.Text
            cmd = New OdbcCommand("update Teach_PPC set Teach_PPC_TPP='" + tpp + "', Teach_PPC_TCS='" + tcs + "', Teach_PPC_DOE='" + doe + "', Teach_PPC_Organized='" + organized + "', Teach_PPC_WINS='" + wins + "', Teach_PPC_API='" + api + "' where Uer_Id='" + muid + "' and Year='" + myear + "' ", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")
            PPC_TPP.Clear()
            PPC_TCS.Clear()
            PPC_DOE.Value = Now
            PPC_Organized.Clear()
            PPC_WINS.Text = "---- Select ----"
            PPC_API.Clear()
            PPC_Combo.Text = "--- Select ---"
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PPC_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPC_Delete.Click
        Try
            con.Open()
            If PPC_TPP.Text = "" Or PPC_TCS.Text = "" Or PPC_DOE.Text = Now Or PPC_Organized.Text = "" Or PPC_WINS.Text = "" Or PPC_API.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim cmd As OdbcCommand
                Dim tpp As String
                tpp = PPC_TPP.Text
                cmd = New OdbcCommand("delete from Teach_PPC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PPC_TPP='" + tpp + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                PPC_TPP.Clear()
                PPC_TCS.Clear()
                PPC_DOE.Value = Now
                PPC_Organized.Clear()
                PPC_WINS.Text = "---- Select ----"
                PPC_API.Clear()
                PPC_Combo.Text = "--- Select ---"
            End If
        Catch ex As Exception
        End Try
        con.Close()
    End Sub

    Private Sub PPC_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPC_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim tpp As String
            tpp = PPC_Combo.Text
            cmd = New OdbcCommand("select * from Teach_PPC where User_Id='" + muid + "' and Teach_PPC_TPP='" + tpp + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                PPC_TPP.Text = dr(2)
                PPC_TCS.Text = dr(3)
                PPC_DOE.Value = dr(4)
                PPC_Organized.Text = dr(5)
                PPC_WINS.Text = dr(6)
                PPC_API.Text = dr(7)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PPC_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PPC_TPP.Clear()
        PPC_TCS.Clear()
        PPC_DOE.Value = Now
        PPC_Organized.Clear()
        PPC_WINS.Text = "---- Select ----"
        PPC_API.Clear()
        PPC_Combo.Text = "--- Select ---"
    End Sub

    Private Sub PPC_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PPC_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            PPC_Combo.Items.Clear()

            cmd = New OdbcCommand("select Teach_PPC_TPP from Teach_PPC where User_Id='" + muid + "' and Year='" + myear + "' ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                PPC_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub PPIJ_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPIJ_Add.Click
        Try
            con.Open()
            If PPIJ_TNO.Text = "" Or PPIJ_Journal.Text = "" Or PPIJ_ISBN.Text = "" Or PPIJ_PR.Text = "" Or PPIJ_NCA.Text = "" Or PPIJ_API.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim tno1 As String
                tno1 = PPIJ_TNO.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_PPIJ where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PPIJ_TNO='" + tno1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then

                    Dim cmd As OdbcCommand
                    Dim tno, journal, isbn, pr, nca, ma, api As String
                    tno = PPIJ_TNO.Text
                    journal = PPIJ_Journal.Text
                    isbn = PPIJ_ISBN.Text
                    pr = PPIJ_PR.Text
                    nca = PPIJ_NCA.Text
                    If PPIJ_Yes.Focus = True Then
                        ma = PPIJ_Yes.Text
                    Else
                        ma = PPIJ_No.Text
                    End If
                    api = PPIJ_API.Text
                    Dim com As String
                    com = PPIJ_Combo.Text
                    cmd = New OdbcCommand("update Teach_PPIJ set Teach_PPIJ_TNO='" + tno + "', Teach_PPIJ_Journal='" + journal + "', Teach_PPIJ_ISBN='" + isbn + "', Teach_PPIJ_PR='" + pr + "', Teach_PPIJ_NCA='" + nca + "', Teach_PPIJ_MA='" + ma + "', Teach_PPIJ_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PPIJ_TNO='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    PPIJ_TNO.Clear()
                    PPIJ_Journal.Clear()
                    PPIJ_ISBN.Clear()
                    PPIJ_PR.Clear()
                    PPIJ_NCA.Clear()
                    PPIJ_No.Select()
                    PPIJ_API.Clear()
                    PPIJ_Combo.Text = "---- Select ----"
                Else
                    Dim cmd As OdbcCommand
                    Dim tno, journal, isbn, pr, nca, ma, api As String
                    tno = PPIJ_TNO.Text
                    journal = PPIJ_Journal.Text
                    isbn = PPIJ_ISBN.Text
                    pr = PPIJ_PR.Text
                    nca = PPIJ_NCA.Text
                    If PPIJ_Yes.Equals(True) Then
                        ma = PPIJ_Yes.Text
                    Else
                        ma = PPIJ_No.Text
                    End If
                    api = PPIJ_API.Text
                    cmd = New OdbcCommand("insert into Teach_PPIJ values('" + muid + "', '" + myear + "' ,'" + tno + "','" + journal + "', '" + isbn + "', '" + pr + "', '" + nca + "','" + ma + "', '" + api + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Added Successfully", MsgBoxStyle.Information)
                    PPIJ_TNO.Clear()
                    PPIJ_Journal.Clear()
                    PPIJ_ISBN.Clear()
                    PPIJ_PR.Clear()
                    PPIJ_NCA.Clear()
                    PPIJ_No.Select()
                    PPIJ_API.Clear()
                    PPIJ_Combo.Text = "---- Select ----"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub PPIJ_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPIJ_Delete.Click
        Try
            con.Open()
            If PPIJ_TNO.Text = "" Or PPIJ_Journal.Text = "" Or PPIJ_ISBN.Text = "" Or PPIJ_PR.Text = "" Or PPIJ_NCA.Text = "" Or PPC_API.Text = "" Then
                MsgBox("First select the entry to delete", MsgBoxStyle.Exclamation)
            Else
                Dim tno As String
                tno = PPIJ_TNO.Text
                Dim cmd As OdbcCommand
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_PPIJ where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PPIJ_TNO='" + tno + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    PPIJ_TNO.Clear()
                    PPIJ_Journal.Clear()
                    PPIJ_ISBN.Clear()
                    PPIJ_PR.Clear()
                    PPIJ_NCA.Clear()
                    PPIJ_No.Select()
                    PPIJ_API.Clear()
                    PPIJ_No.Select()
                    PPIJ_Combo.Text = "---- Select ----"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PPIJ_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPIJ_Show.Click
        Try
            con.Open()
            Dim tno As String
            tno = PPIJ_Combo.Text
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from Teach_PPIJ where User_Id='" + muid + "' and Year='" + myear + "' and Teach_PPIJ_TNO='" + tno + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                PPIJ_TNO.Text = dr(2)
                PPIJ_Journal.Text = dr(3)
                PPIJ_ISBN.Text = dr(4)
                PPIJ_PR.Text = dr(5)
                PPIJ_NCA.Text = dr(6)
                If dr(7) = PPIJ_Yes.Text.ToString Then
                    PPIJ_Yes.Select()
                Else
                    PPIJ_No.Select()
                End If
                PPIJ_API.Text = dr(8)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PPIJ_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PPIJ_Combo.MouseClick
        Try
            con.Open()
            PPIJ_Combo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Teach_PPIJ_TNO from Teach_PPIJ where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                PPIJ_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub APB_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APB_Add.Click
        Try
            con.Open()
            If APB_TNO.Text = "" Or APB_BEP.Text = "" Or APB_ISSN.Text = "" Or APB_WPR.Text = "" Or APB_NOC.Text = "" Or APB_API.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim tno1 As String
                tno1 = APB_TNO.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_APB where User_Id='" + muid + "' and Year='" + myear + "' and Teach_APB_TNO='" + tno1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    Dim cmd As OdbcCommand
                    Dim tno, bep, issn, wpr, noc, ma, api As String
                    tno = APB_TNO.Text
                    bep = APB_BEP.Text
                    issn = APB_ISSN.Text
                    wpr = APB_WPR.Text
                    noc = APB_NOC.Text
                    If ACPB_Yes.Focus = True Then
                        ma = ACPB_Yes.Text
                    Else
                        ma = ACPB_No.Text
                    End If

                    api = APB_API.Text
                    Dim com As String
                    com = APB_Combo.Text
                    cmd = New OdbcCommand("update Teach_APB set Teach_APB_TNO='" + tno + "',Teach_APB_BEP='" + bep + "',Teach_APB_ISSN='" + issn + "',Teach_APB_WPR='" + wpr + "',Teach_APB_NOC='" + noc + "',Teach_APB_MA='" + ma + "',Teach_APB_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_APB_TNO='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    APB_TNO.Clear()
                    APB_BEP.Clear()
                    APB_ISSN.Clear()
                    APB_WPR.Clear()
                    APB_NOC.Clear()
                    ACPB_No.Select()
                    APB_API.Clear()
                    APB_Combo.Text = "--- Select ---"

                Else
                    Dim cmd As OdbcCommand
                    Dim tno, bep, issn, wpr, noc, ma, api As String
                    tno = APB_TNO.Text
                    bep = APB_BEP.Text
                    issn = APB_ISSN.Text
                    wpr = APB_WPR.Text
                    noc = APB_NOC.Text
                    If ACPB_Yes.Focus = True Then
                        ma = ACPB_Yes.Text
                    Else
                        ma = ACPB_No.Text
                    End If
                    api = APB_API.Text
                    cmd = New OdbcCommand("insert into Teach_APB values('" + muid + "','" + myear + "' ,'" + tno + "', '" + bep + "', '" + issn + "', '" + wpr + "', '" + noc + "', '" + ma + "', '" + api + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Added Successfully", MsgBoxStyle.Information)
                    APB_TNO.Clear()
                    APB_BEP.Clear()
                    APB_ISSN.Clear()
                    APB_WPR.Clear()
                    APB_NOC.Clear()
                    ACPB_No.Select()
                    APB_API.Clear()
                    APB_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub APB_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APB_Delete.Click
        Try
            con.Open()
            If APB_TNO.Text = "" Or APB_BEP.Text = "" Or APB_ISSN.Text = "" Or APB_WPR.Text = "" Or APB_NOC.Text = "" Or APB_API.Text = "" Then
                MsgBox("First select the entry to delete", MsgBoxStyle.Exclamation)
            Else
                Dim cmd As OdbcCommand
                Dim tno As String
                tno = APB_TNO.Text
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_APB where User_Id='" + muid + "' and Year='" + myear + "' and Teach_APB_TNO='" + tno + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    APB_TNO.Clear()
                    APB_BEP.Clear()
                    APB_ISSN.Clear()
                    APB_WPR.Clear()
                    APB_NOC.Clear()
                    ACPB_No.Select()
                    APB_API.Clear()
                    APB_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub APB_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles APB_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            APB_Combo.Items.Clear()
            cmd = New OdbcCommand("select Teach_APB_TNO from Teach_APB where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                APB_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub APB_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APB_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim tno As String
            tno = APB_Combo.Text
            cmd = New OdbcCommand("select * from Teach_APB where User_Id='" + muid + "' and Year='" + myear + "' and Teach_APB_TNO='" + tno + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                APB_TNO.Text = dr(2)
                APB_BEP.Text = dr(3)
                APB_ISSN.Text = dr(4)
                APB_WPR.Text = dr(5)
                APB_NOC.Text = dr(6)
                If dr(7) = ACPB_Yes.Text.ToString Then
                    ACPB_Yes.Select()
                Else
                    ACPB_No.Select()
                End If
                APB_API.Text = dr(8)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub FDP_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDP_Add.Click
        Try
            con.Open()
            If FDP_Programme.Text = "" Or FDP_Duration.Text = "" Or FDP_Organized.Text = "" Or FDP_API.Text = "" Then
                MsgBox("Fields can't be left blank")
            Else
                Dim programme1 As String
                programme1 = FDP_Programme.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_FDP where User_Id='" + muid + "' and Year='" + myear + "' and Teach_FDP_Programme='" + programme1 + "'", con)
                If (cmd1.ExecuteNonQuery) > 0 Then
                    Dim cmd As OdbcCommand
                    Dim programme, duration, organized, api As String
                    programme = FDP_Programme.Text
                    duration = FDP_Duration.Text
                    organized = FDP_Organized.Text
                    api = FDP_API.Text
                    Dim com As String
                    com = FDP_Combo.Text
                    cmd = New OdbcCommand("update Teach_FDP set Teach_FDP_Programme='" + programme + "',Teach_FDP_Duration='" + duration + "', Teach_FDP_Organized='" + organized + "',Teach_FDP_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_FDP_Programme='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully")
                    FDP_Programme.Clear()
                    FDP_Duration.Clear()
                    FDP_Organized.Clear()
                    FDP_API.Clear()
                    FDP_Combo.Text = "--- Select ---"
                Else
                    Dim programme, duration, organized, api As String
                    Dim cmd As OdbcCommand
                    programme = FDP_Programme.Text
                    duration = FDP_Duration.Text
                    organized = FDP_Organized.Text
                    api = FDP_API.Text
                    cmd = New OdbcCommand("insert into Teach_FDP values('" + muid + "','" + myear + "','" + programme + "','" + duration + "','" + organized + "','" + api + "') ", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Added Successfully")
                    FDP_Programme.Clear()
                    FDP_Duration.Clear()
                    FDP_Organized.Clear()
                    FDP_API.Clear()
                    FDP_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub FDP_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDP_Delete.Click
        Try
            con.Open()
            If FDP_Programme.Text = "" Or FDP_Duration.Text = "" Or FDP_Organized.Text = "" Or FDP_API.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim cmd As OdbcCommand
                Dim programme As String
                programme = FDP_Programme.Text
                cmd = New OdbcCommand("delete from Teach_FDP where User_Id='" + muid + "' and Year='" + myear + "' and Teach_FDP_Programme='" + programme + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                FDP_Programme.Clear()
                FDP_Duration.Clear()
                FDP_Organized.Clear()
                FDP_API.Clear()
                FDP_Combo.Text = "--- Select ---"
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub FDP_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FDP_Combo.MouseClick
        Try
            con.Open()
            FDP_Combo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Teach_FDP_Programme from Teach_FDP where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                FDP_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
        
    End Sub

    Private Sub FDP_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDP_Show.Click
        Try
            con.Open()
            Dim programme As String
            programme = FDP_Combo.Text
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from Teach_FDP where User_Id='" + muid + "' and Year='" + myear + "' and Teach_FDP_Programme='" + programme + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                FDP_Programme.Text = dr(2)
                FDP_Duration.Text = dr(3)
                FDP_Organized.Text = dr(4)
                FDP_API.Text = dr(5)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub FCP_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCP_Add.Click
        Try
            con.Open()
            If FCP_TNO.Text = "" Or FCP_BEP.Text = "" Or FCP_ISSN.Text = "" Or FCP_NOC.Text = "" Or FCP_API.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim tno1 As String
                tno1 = FCP_TNO.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_FCP where User_Id='" + muid + "' and Year='" + myear + "' and Teach_FCP_TNO='" + tno1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    Dim cmd As OdbcCommand
                    Dim tno, bep, issn, noc, ma, api As String
                    tno = FCP_TNO.Text
                    bep = FCP_BEP.Text
                    issn = FCP_ISSN.Text
                    noc = FCP_NOC.Text
                    If FPCP_Yes.Focus = True Then
                        ma = FPCP_Yes.Text
                    Else
                        ma = FPCP_No.Text
                    End If
                    api = FCP_API.Text
                    Dim com As String
                    com = FCP_Combo.Text
                    cmd = New OdbcCommand("update Teach_FCP set Teach_FCP_TNO='" + tno + "',Teach_FCP_BEP='" + bep + "',Teach_FCP_ISSN='" + issn + "',Teach_FCP_NOC='" + noc + "',Teach_FCP_MA='" + ma + "',Teach_FCP_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_FCP_TNO='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    FCP_TNO.Clear()
                    FCP_BEP.Clear()
                    FCP_ISSN.Clear()
                    FCP_NOC.Clear()
                    FPCP_No.Select()
                    FCP_API.Clear()
                    FCP_Combo.Text = "--- Select ---"
                Else
                    Dim cmd As OdbcCommand
                    Dim tno, bep, issn, noc, ma, api As String
                    tno = FCP_TNO.Text
                    bep = FCP_BEP.Text
                    issn = FCP_ISSN.Text
                    noc = FCP_NOC.Text
                    If FPCP_Yes.Focus = True Then
                        ma = FPCP_Yes.Text
                    Else
                        ma = FPCP_No.Text
                    End If
                    api = FCP_API.Text
                    cmd = New OdbcCommand("insert into Teach_FCP values('" + muid + "', '" + myear + "' ,'" + tno + "', '" + bep + "', '" + issn + "', '" + noc + "', '" + ma + "', '" + api + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.Information)
                    FCP_TNO.Clear()
                    FCP_BEP.Clear()
                    FCP_ISSN.Clear()
                    FCP_NOC.Clear()
                    FPCP_No.Select()
                    FCP_API.Clear()
                    FCP_Combo.Text = "--- Select ---"
                End If
            End If

        Catch ex As Exception

        End Try
        con.Close()
    End Sub



    Private Sub FCP_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCP_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim tno As String
            tno = FCP_Combo.Text
            cmd = New OdbcCommand("select * from Teach_FCP where User_Id='" + muid + "' and Year='" + myear + "' and Teach_FCP_TNO='" + tno + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                FCP_TNO.Text = dr(2)
                FCP_BEP.Text = dr(3)
                FCP_ISSN.Text = dr(4)
                FCP_NOC.Text = dr(5)

                If dr(6) = FPCP_Yes.Text Then
                    FPCP_Yes.Select()
                Else
                    FPCP_No.Select()
                End If
                FCP_API.Text = dr(7)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub FCP_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FCP_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            FCP_Combo.Items.Clear()
            cmd = New OdbcCommand("select Teach_FCP_TNO from Teach_FCP where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                FCP_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub




    Private Sub FCP_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCP_Delete.Click
        Try
            con.Open()
            If FCP_TNO.Text = "" Or FCP_BEP.Text = "" Or FCP_ISSN.Text = "" Or FCP_NOC.Text = "" Or FCP_API.Text = "" Then
                MsgBox("First select the entry to delete", MsgBoxStyle.Exclamation)
            Else
                Dim cmd As OdbcCommand
                Dim tno As String
                tno = FCP_TNO.Text
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_FCP where User_Id='" + muid + "' and Year='" + myear + "' and Teach_FCP_TNO='" + tno + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    FCP_TNO.Clear()
                    FCP_BEP.Clear()
                    FCP_ISSN.Clear()
                    FCP_NOC.Clear()
                    FPCP_No.Select()
                    FCP_API.Clear()
                    FCP_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub BPE_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPE_Add.Click
        Try
            con.Open()
            If BPE_TPN.Text = "" Or BPE_TBA.Text = "" Or BPE_PISSN.Text = "" Or BPE_WPR.Text = "" Or BPE_NOC.Text = "" Or BPE_API.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim tno1 As String
                tno1 = BPE_TPN.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_BPE where User_Id='" + muid + "' and Year='" + myear + "' and Teach_BPE_TPN='" + tno1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    Dim cmd As OdbcCommand
                    Dim tno, bep, issn, wpr, noc, ma, api As String
                    tno = BPE_TPN.Text
                    bep = BPE_TBA.Text
                    issn = BPE_PISSN.Text
                    wpr = BPE_WPR.Text
                    noc = BPE_NOC.Text
                    If BPSA_Yes.Equals(True) Then
                        ma = BPSA_Yes.Text
                    Else
                        ma = BPSA_No.Text
                    End If
                    api = BPE_API.Text
                    Dim com As String
                    com = BPE_Combo.Text
                    cmd = New OdbcCommand("update Teach_BPE set Teach_BPE_TPN='" + tno + "',Teach_BPE_TBA='" + bep + "',Teach_BPE_PISSN='" + issn + "',Teach_BPE_WPR='" + wpr + "',Teach_BPE_NOC='" + noc + "',Teach_BPE_MA='" + ma + "',Teach_BPE_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_BPE_TPN='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    BPE_TPN.Clear()
                    BPE_TBA.Clear()
                    BPE_PISSN.Clear()
                    BPE_WPR.Clear()
                    BPE_NOC.Clear()
                    BPSA_No.Select()
                    BPE_API.Clear()
                    BPE_Combo.Text = "--- Select ---"
                Else
                    Dim cmd As OdbcCommand
                    Dim tno, bep, issn, wpr, noc, ma, api As String
                    tno = BPE_TPN.Text
                    bep = BPE_TBA.Text
                    issn = BPE_PISSN.Text
                    wpr = BPE_WPR.Text
                    noc = BPE_NOC.Text
                    If BPSA_Yes.Focus = True Then
                        ma = BPSA_Yes.Text
                    Else
                        ma = BPSA_No.Text
                    End If
                    api = BPE_API.Text
                    cmd = New OdbcCommand("insert into Teach_BPE values('" + muid + "', '" + myear + "' ,'" + tno + "', '" + bep + "', '" + issn + "', '" + wpr + "', '" + noc + "', '" + ma + "', '" + api + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.Information)
                    BPE_TPN.Clear()
                    BPE_TBA.Clear()
                    BPE_PISSN.Clear()
                    BPE_WPR.Clear()
                    BPE_NOC.Clear()
                    BPSA_No.Select()
                    BPE_API.Clear()
                    BPE_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub BPE_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPE_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim tno As String
            tno = BPE_Combo.Text
            cmd = New OdbcCommand("select * from Teach_BPE where User_Id='" + muid + "' and Year='" + myear + "' and Teach_BPE_TPN='" + tno + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                BPE_TPN.Text = dr(2)
                BPE_TBA.Text = dr(3)
                BPE_PISSN.Text = dr(4)
                BPE_WPR.Text = dr(5)
                BPE_NOC.Text = dr(6)
                If dr(7) = BPSA_Yes.Text.ToString Then
                    BPSA_Yes.Select()
                Else
                    BPSA_No.Select()
                End If
                BPE_API.Text = dr(8)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub BPE_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPE_Delete.Click
        Try
            con.Open()
            If BPE_TPN.Text = "" Or BPE_TBA.Text = "" Or BPE_PISSN.Text = "" Or BPE_WPR.Text = "" Or BPE_NOC.Text = "" Or BPE_API.Text = "" Then
                MsgBox("First select the data to delete", MsgBoxStyle.Exclamation)
            Else
                Dim cmd As OdbcCommand
                Dim tno As String
                tno = BPE_TPN.Text
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_BPE where User_Id='" + muid + "' and Year='" + myear + "' and Teach_BPE_TPN='" + tno + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    BPE_TPN.Clear()
                    BPE_TBA.Clear()
                    BPE_PISSN.Clear()
                    BPE_WPR.Clear()
                    BPE_NOC.Clear()
                    BPSA_No.Select()
                    BPE_API.Clear()
                    BPE_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub BPE_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BPE_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            BPE_Combo.Items.Clear()
            cmd = New OdbcCommand("select Teach_BPE_TPN from Teach_BPE where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                BPE_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub



    Private Sub OPC_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPC_Add.Click
        Try
            con.Open()
            If OPC_Title.Text = "" Or OPC_Agency.Text = "" Or OPC_Period.Text = "" Or OPC_GAM.Text = "" Or OPC_API.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim title As String
                title = OPC_Title.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_OPC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_OPC_Title='" + title + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    Dim cmd As OdbcCommand
                    Dim title1, agency, period, gam, api As String
                    title1 = OPC_Title.Text
                    agency = OPC_Agency.Text
                    period = OPC_Period.Text
                    gam = OPC_GAM.Text
                    api = OPC_API.Text
                    Dim com As String
                    com = OPC_Combo.Text
                    cmd = New OdbcCommand("update Teach_OPC set Teach_OPC_Title='" + title1 + "',Teach_OPC_Agency='" + agency + "',Teach_OPC_Period='" + period + "',Teach_OPC_GAM='" + gam + "',Teach_OPC_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_OPC_Title='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    OPC_Title.Clear()
                    OPC_Agency.Clear()
                    OPC_Period.Clear()
                    OPC_GAM.Clear()
                    OPC_API.Clear()
                    OPC_Combo.Text = "--- Select ---"
                Else
                    Dim cmd As OdbcCommand
                    Dim title1, agency, period, gam, api As String
                    title1 = OPC_Title.Text
                    agency = OPC_Agency.Text
                    period = OPC_Period.Text
                    gam = OPC_GAM.Text
                    api = OPC_API.Text
                    cmd = New OdbcCommand("insert into Teach_OPC values('" + muid + "','" + myear + "' ,'" + title1 + "', '" + agency + "', '" + period + "', '" + gam + "', '" + api + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.Information)
                    OPC_Title.Clear()
                    OPC_Agency.Clear()
                    OPC_Period.Clear()
                    OPC_GAM.Clear()
                    OPC_API.Clear()
                    OPC_Combo.Text = "--- Select ---"
                End If
            End If

        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub OPC_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPC_Delete.Click
        Try
            con.Open()
            If OPC_Title.Text = "" Or OPC_Agency.Text = "" Or OPC_Period.Text = "" Or OPC_GAM.Text = "" Or OPC_API.Text = "" Then
                MsgBox("First select the entry to delete", MsgBoxStyle.Exclamation)
            Else
                Dim cmd As OdbcCommand
                Dim tno As String
                tno = OPC_Title.Text
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_OPC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_OPC_Title='" + tno + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    OPC_Title.Clear()
                    OPC_Agency.Clear()
                    OPC_Period.Clear()
                    OPC_GAM.Clear()
                    OPC_API.Clear()
                    OPC_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub OPC_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles OPC_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            OPC_Combo.Items.Clear()
            cmd = New OdbcCommand("select Teach_OPC_Title from Teach_OPC where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                OPC_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub OPC_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPC_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim title As String
            title = OPC_Combo.Text
            cmd = New OdbcCommand("select * from Teach_OPC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_OPC_Title='" + title + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                OPC_Title.Text = dr(2)
                OPC_Agency.Text = dr(3)
                OPC_Period.Text = dr(4)
                OPC_GAM.Text = dr(5)
                OPC_API.Text = dr(6)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RG_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RG_Add.Click
        Try
            con.Open()
            If RG_NE.Text = "" Or RG_TS.Text = "" Or RG_DA.Text = "" Or RG_API.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim ne1 As String
                ne1 = RG_NE.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_RG where User_Id='" + muid + "' and Year='" + myear + "' and Teach_RG_NE='" + ne1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    Dim cmd As OdbcCommand
                    Dim ne, ts, da, api As String
                    ne = RG_NE.Text
                    ts = RG_TS.Text
                    da = RG_DA.Text
                    api = RG_API.Text
                    Dim com As String
                    com = RG_Combo.Text
                    cmd = New OdbcCommand("update Teach_RG set Teach_RG_NE='" + ne + "',Teach_RG_TS='" + ts + "',Teach_RG_DA='" + da + "', Teach_RG_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_RG_NE='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    RG_NE.Clear()
                    RG_TS.Clear()
                    RG_DA.Clear()
                    RG_API.Clear()
                    RG_Combo.Text = "--- Select ---"
                Else
                    Dim cmd As OdbcCommand
                    Dim ne, ts, da, api As String
                    ne = RG_NE.Text
                    ts = RG_TS.Text
                    da = RG_DA.Text
                    api = RG_API.Text
                    cmd = New OdbcCommand("insert into Teach_RG values('" + muid + "','" + myear + "', '" + ne + "', '" + ts + "', '" + da + "', '" + api + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.Information)
                    RG_NE.Clear()
                    RG_TS.Clear()
                    RG_DA.Clear()
                    RG_API.Clear()
                    RG_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RG_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RG_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim ne1 As String
            ne1 = RG_Combo.Text
            cmd = New OdbcCommand("select * from Teach_RG where User_Id='" + muid + "' and Year='" + myear + "' and Teach_RG_NE='" + ne1 + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                RG_NE.Text = dr(2)
                RG_TS.Text = dr(3)
                RG_DA.Text = dr(4)
                RG_API.Text = dr(5)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RG_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RG_Delete.Click
        Try
            con.Open()
            If RG_NE.Text = "" Or RG_TS.Text = "" Or RG_DA.Text = "" Or RG_API.Text = "" Then
                MsgBox("First select the entry to delete", MsgBoxStyle.Exclamation)
            Else
                Dim cmd As OdbcCommand
                Dim ne1 As String
                ne1 = RG_NE.Text
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_RG where User_Id='" + muid + "' and Year='" + myear + "' and Teach_RG_NE='" + ne1 + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    RG_NE.Clear()
                    RG_TS.Clear()
                    RG_DA.Clear()
                    RG_API.Clear()
                    RG_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RG_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RG_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            RG_Combo.Items.Clear()
            cmd = New OdbcCommand("select Teach_RG_NE from Teach_RG where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                RG_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

 

    Private Sub CPC_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPC_Add.Click
        Try
            con.Open()
            If CPC_Title.Text = "" Or CPC_Agency.Text = "" Or CPC_Period.Text = "" Or CPC_GAM.Text = "" Or CPC_WPD.Text = "" Or CPC_API.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim title As String
                title = CPC_Title.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_CPC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_CPC_Title='" + title + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    Dim cmd As OdbcCommand
                    Dim title1, agency, period, gam, wpd, api As String
                    title1 = CPC_Title.Text
                    agency = CPC_Agency.Text
                    period = CPC_Period.Text
                    gam = CPC_GAM.Text
                    wpd = CPC_WPD.Text
                    api = CPC_API.Text
                    Dim com As String
                    com = CPC_Combo.Text
                    cmd = New OdbcCommand("update Teach_CPC set Teach_CPC_Title='" + title1 + "',Teach_CPC_Agency='" + agency + "',Teach_CPC_Period='" + period + "',Teach_CPC_GAM='" + gam + "',Teach_CPC_WPD='" + wpd + "',Teach_CPC_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_CPC_Title='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    CPC_Title.Clear()
                    CPC_Agency.Clear()
                    CPC_Period.Clear()
                    CPC_GAM.Clear()
                    CPC_WPD.Clear()
                    CPC_API.Clear()
                    CPC_Combo.Text = "--- Select ---"
                Else
                    Dim cmd As OdbcCommand
                    Dim title1, agency, period, gam, wpd, api As String
                    title1 = CPC_Title.Text
                    agency = CPC_Agency.Text
                    period = CPC_Period.Text
                    gam = CPC_GAM.Text
                    wpd = CPC_WPD.Text
                    api = CPC_API.Text
                    cmd = New OdbcCommand("insert into Teach_CPC values('" + muid + "','" + myear + "', '" + title1 + "', '" + agency + "', '" + period + "', '" + gam + "','" + wpd + "' ,'" + api + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.Information)
                    CPC_Title.Clear()
                    CPC_Agency.Clear()
                    CPC_Period.Clear()
                    CPC_GAM.Clear()
                    CPC_WPD.Clear()
                    CPC_API.Clear()
                    CPC_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub CPC_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPC_Delete.Click
        Try
            con.Open()
            If CPC_Title.Text = "" Or CPC_Agency.Text = "" Or CPC_Period.Text = "" Or CPC_GAM.Text = "" Or CPC_WPD.Text = "" Or CPC_API.Text = "" Then
                MsgBox("First select the entry to delete", MsgBoxStyle.Exclamation)
            Else
                Dim cmd As OdbcCommand
                Dim tno As String
                tno = CPC_Title.Text
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_CPC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_CPC_Title='" + tno + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    CPC_Title.Clear()
                    CPC_Agency.Clear()
                    CPC_Period.Clear()
                    CPC_GAM.Clear()
                    CPC_WPD.Clear()
                    CPC_API.Clear()
                    CPC_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub CPC_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPC_Show.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim title As String
            title = CPC_Combo.Text
            cmd = New OdbcCommand("select * from Teach_CPC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_CPC_Title='" + title + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                CPC_Title.Text = dr(2)
                CPC_Agency.Text = dr(3)
                CPC_Period.Text = dr(4)
                CPC_GAM.Text = dr(5)
                CPC_WPD.Text = dr(6)
                CPC_API.Text = dr(7)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub CPC_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CPC_Combo.MouseClick
        Try
            con.Open()
            Dim cmd As OdbcCommand
            CPC_Combo.Items.Clear()
            cmd = New OdbcCommand("select Teach_CPC_Title from Teach_CPC where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                CPC_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub PPIJ_NCA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PPIJ_NCA.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub PPIJ_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PPIJ_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub APB_NOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles APB_NOC.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub APB_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles APB_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub FCP_NOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FCP_NOC.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub FCP_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FCP_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub BPE_NOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BPE_NOC.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub BPE_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BPE_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub


    Private Sub OPC_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OPC_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub CPC_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CPC_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub RG_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RG_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub FDP_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FDP_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub PPC_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PPC_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub ILC_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ILC_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

End Class