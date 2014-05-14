Imports System.Data.Odbc

Public Class PBAS_Part_B_C1
    Dim con As New OdbcConnection("DSN=PBASDSN")
    Private Sub LSTP_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LSTP_Link.LinkClicked
        RIMC_Tab.Hide()
        TLM_Tab.Hide()
        EDAP_Tab.Hide()
        LSTP_Tab.Show()
        Category1.SelectTab(0)
    End Sub

    Private Sub RIMC_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RIMC_Link.LinkClicked
        LSTP_Tab.Hide()
        TLM_Tab.Hide()
        EDAP_Tab.Hide()
        RIMC_Tab.Show()
        Category1.SelectTab(1)
    End Sub

    Private Sub TLM_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles TLM_Link.LinkClicked
        LSTP_Tab.Hide()
        EDAP_Tab.Hide()
        RIMC_Tab.Hide()
        TLM_Tab.Show()
        Category1.SelectTab(2)
    End Sub

    Private Sub EDAP_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EDAP_Link.LinkClicked
        LSTP_Tab.Hide()
        RIMC_Tab.Hide()
        TLM_Tab.Hide()
        EDAP_Tab.Show()
        Category1.SelectTab(3)
    End Sub

    Private Sub PBAS_Part_B_C1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        yearc1.Text = myear
        RIMC_ARP.Enabled = False
    End Sub

    Private Sub LSTP_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSTP_Add.Click
        Try
            con.Open()
            If LSTP_Course.Text = "" Or LSTP_Level.Text = "" Or LSTP_MOT.Text = "" Or LSTP_NOCA.Text = "" Or LSTP_Practicals.Text = "" Or LSTP_CTDR.Text = "" Or LSTP_CTAPI.Text = "" Or LSTP_TLAPI.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim course1 As String
                course1 = LSTP_Course.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_LSTP where User_Id='" + muid + "' and Year='" + myear + "' and Teach_LSTP_Course='" + course1 + "'", con)
                If (cmd1.ExecuteNonQuery() > 0) Then
                    If LSTP_CTAPI.Text > 50 Or LSTP_TLAPI.Text > 10 Then
                        MsgBox("Please Enter correct API", MsgBoxStyle.Critical)
                        Exit Sub
                    ElseIf LSTP_CTDR.Text > 100 Then
                        MsgBox("Percentage can't be greater than 100", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        Dim course, level, mot, noca, nocc, practicals, ctdr, ctapi, tlapi As String
                        Dim cmd As OdbcCommand
                        course = LSTP_Course.Text
                        level = LSTP_Level.Text
                        mot = LSTP_MOT.Text
                        noca = LSTP_NOCA.Text
                        nocc = LSTP_NOCC.Text
                        practicals = LSTP_Practicals.Text
                        ctdr = LSTP_CTDR.Text
                        ctapi = LSTP_CTAPI.Text
                        tlapi = LSTP_TLAPI.Text
                        Dim com As String
                        com = LSTP_combo.Text
                        cmd = New OdbcCommand("update Teach_LSTP set Teach_LSTP_Course='" + course + "',Teach_LSTP_Level='" + level + "',Teach_LSTP_MOT='" + mot + "',Teach_LSTP_NOCA='" + noca + "',Teach_LSTP_NOCC='" + nocc + "',Teach_LSTP_Practicals='" + practicals + "',Teach_LSTP_CTDR='" + ctdr + "',Teach_LSTP_CTAPI='" + ctapi + "',Teach_LSTP_TLAPI='" + tlapi + "' where User_Id='" + muid + "' and Year='" + myear + "'and  Teach_LSTP_Course='" + com + "'", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                        LSTP_Course.Clear()
                        LSTP_Level.Clear()
                        LSTP_MOT.Clear()
                        LSTP_NOCA.Clear()
                        LSTP_NOCC.Clear()
                        LSTP_Practicals.Clear()
                        LSTP_CTDR.Clear()
                        LSTP_CTAPI.Clear()
                        LSTP_TLAPI.Clear()
                        LSTP_combo.Text = "-- Select --"
                    End If
                Else
                    If LSTP_CTAPI.Text > 50 Or LSTP_TLAPI.Text > 10 Then
                        MsgBox("Please Enter correct API", MsgBoxStyle.Critical)
                        Exit Sub
                    ElseIf LSTP_CTDR.Text > 100 Then
                        MsgBox("Percentage can't be greater than 100", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        Dim course, level, mot, noca, nocc, practicals, ctdr, ctapi, tlapi As String
                        Dim cmd As OdbcCommand
                        course = LSTP_Course.Text
                        level = LSTP_Level.Text
                        mot = LSTP_MOT.Text
                        noca = LSTP_NOCA.Text
                        nocc = LSTP_NOCC.Text
                        practicals = LSTP_Practicals.Text
                        ctdr = LSTP_CTDR.Text
                        ctapi = LSTP_CTAPI.Text
                        tlapi = LSTP_TLAPI.Text
                        cmd = New OdbcCommand("insert into Teach_LSTP values('" + muid + "','" + myear + "','" + course + "', '" + level + "','" + mot + "','" + noca + "','" + nocc + "','" + practicals + "','" + ctdr + "','" + ctapi + "','" + tlapi + "')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Added Successfully.", MsgBoxStyle.Information)
                        LSTP_Course.Clear()
                        LSTP_Level.Clear()
                        LSTP_MOT.Clear()
                        LSTP_NOCA.Clear()
                        LSTP_NOCC.Clear()
                        LSTP_Practicals.Clear()
                        LSTP_CTDR.Clear()
                        LSTP_CTAPI.Clear()
                        LSTP_TLAPI.Clear()
                        LSTP_combo.Text = "--- Select ---"
                    End If

                End If

            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub LSTP_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LSTP_Course.Clear()
        LSTP_Level.Clear()
        LSTP_MOT.Clear()
        LSTP_NOCA.Clear()
        LSTP_NOCC.Clear()
        LSTP_Practicals.Clear()
        LSTP_CTDR.Clear()
        LSTP_CTAPI.Clear()
        LSTP_TLAPI.Clear()
        LSTP_combo.Text = "-- Select --"
    End Sub

    Private Sub LSTP_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSTP_Show.Click
        Try
            con.Open()
            Dim course As String
            course = LSTP_combo.Text
            Dim cmd As OdbcCommand
            Dim dr As OdbcDataReader
            cmd = New OdbcCommand("select * from Teach_LSTP where User_Id='" + muid + "'and Year='" + myear + "' and Teach_LSTP_Course='" + course + "'", con)
            dr = cmd.ExecuteReader()
            While dr.Read
                LSTP_Course.Text = dr(2)
                LSTP_Level.Text = dr(3)
                LSTP_MOT.Text = dr(4)
                LSTP_NOCA.Text = dr(5)
                LSTP_NOCC.Text = dr(6)
                LSTP_Practicals.Text = dr(7)
                LSTP_CTDR.Text = dr(8)
                LSTP_CTAPI.Text = dr(9)
                LSTP_TLAPI.Text = dr(10)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub LSTP_combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LSTP_combo.MouseClick
        Try
            con.Open()
            LSTP_combo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Teach_LSTP_Course from Teach_LSTP where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                LSTP_combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub LSTP_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSTP_Delete.Click
        Try
            con.Open()
            If LSTP_Course.Text = "" Or LSTP_Level.Text = "" Or LSTP_MOT.Text = "" Or LSTP_NOCA.Text = "" Or LSTP_Practicals.Text = "" Or LSTP_CTDR.Text = "" Or LSTP_CTAPI.Text = "" Or LSTP_TLAPI.Text = "" Then
                MsgBox("First select the entry to delete", MsgBoxStyle.Exclamation)
            Else
                Dim course As String
                course = LSTP_Course.Text
                Dim cmd As OdbcCommand
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_LSTP where User_Id='" + muid + "' and Year='" + myear + "' and Teach_LSTP_Course='" + course + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    LSTP_Course.Clear()
                    LSTP_Level.Clear()
                    LSTP_MOT.Clear()
                    LSTP_NOCA.Clear()
                    LSTP_NOCC.Clear()
                    LSTP_Practicals.Clear()
                    LSTP_CTDR.Clear()
                    LSTP_CTAPI.Clear()
                    LSTP_TLAPI.Clear()
                    LSTP_combo.Text = "-- Select --"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RIMC_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIMC_Add.Click
        Try
            con.Open()
            If RIMC_Course.Text = "" Or RIMC_Cons.Text = "" Or RIMC_Pres.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim course1 As String
                course1 = RIMC_Course.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_RIMC where User_ID='" + muid + "' and year='" + myear + "' and Teach_RIMC_Course='" + course1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    Dim cmd As OdbcCommand
                    Dim course, consulted, prescribed, arp As String
                    course = RIMC_Course.Text
                    consulted = RIMC_Cons.Text
                    prescribed = RIMC_Pres.Text
                    arp = RIMC_ARP.Text
                    Dim com As String
                    com = RIMC_Combo.Text
                    cmd = New OdbcCommand("update Teach_RIMC set Teach_RIMC_Course='" + course + "',Teach_RIMC_Consulted='" + consulted + "',Teach_RIMC_Prescribed='" + prescribed + "',Teach_RIMC_ARP='" + arp + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_RIMC_Course='" + com + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                    RIMC_Course.Clear()
                    RIMC_Cons.Clear()
                    RIMC_Pres.Clear()
                    RIMC_ARP.Clear()
                    'RIMC_CAPI.Text = "-- Select --"
                    RIMC_Combo.Text = "--- Select ---"
                Else
                    Dim course, cons, pres, arp As String
                    course = RIMC_Course.Text
                    cons = RIMC_Cons.Text
                    pres = RIMC_Pres.Text
                    arp = RIMC_ARP.Text
                    Dim cmd As OdbcCommand
                    cmd = New OdbcCommand("insert into Teach_RIMC(User_Id,Year,Teach_RIMC_Course,Teach_RIMC_Consulted,Teach_RIMC_Prescribed,Teach_RIMC_ARP) values('" + muid + "', '" + myear + "', '" + course + "', '" + cons + "','" + pres + "','" + arp + "')", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Added Successfully", MsgBoxStyle.Information)
                    RIMC_Course.Clear()
                    RIMC_Cons.Clear()
                    RIMC_Pres.Clear()
                    RIMC_ARP.Clear()
                    'RIMC_CAPI.Text = "-- Select --"
                    RIMC_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RIMC_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RIMC_Combo.MouseClick
        Try
            con.Open()
            RIMC_Combo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Teach_RIMC_Course from Teach_RIMC where User_ID='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                RIMC_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RIMC_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIMC_Show.Click
        Try
            con.Open()
            Dim course As String
            course = RIMC_Combo.Text
            Dim cmd As OdbcCommand
            Dim dr As OdbcDataReader
            cmd = New OdbcCommand("select * from Teach_RIMC where User_ID='" + muid + "' and Year='" + myear + "' and Teach_RIMC_course='" + course + "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                RIMC_Course.Text = dr(2)
                RIMC_Cons.Text = dr(3)
                RIMC_Pres.Text = dr(4)
                RIMC_ARP.Text = dr(5)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RIMC_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim course, consulted, prescribed, arp As String
            course = RIMC_Course.Text
            consulted = RIMC_Cons.Text
            prescribed = RIMC_Pres.Text
            'arp = RIMC_CAPI.Text
            cmd = New OdbcCommand("update Teach_RIMC set Teach_RIMC_Course='" + course + "',Teach_RIMC_Consulted='" + consulted + "',Teach_RIMC_Prescribed='" + prescribed + "',Teach_RIMC_ARP='" + arp + "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RIMC_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIMC_Delete.Click
        Try
            con.Open()
            If RIMC_Course.Text = "" Or RIMC_Cons.Text = "" Or RIMC_Pres.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim course As String
                course = RIMC_Course.Text
                Dim cmd As OdbcCommand
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_RIMC where User_Id='" + muid + "' and Year='" + myear + "' and Teach_RIMC_Course='" + course + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    RIMC_Course.Clear()
                    RIMC_Cons.Clear()
                    RIMC_Pres.Clear()
                    RIMC_ARP.Clear()
                    'RIMC_CAPI.Text = "-- Select --"
                    RIMC_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub RIMC_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RIMC_Course.Clear()
        RIMC_Cons.Clear()
        RIMC_Pres.Clear()
        'RIMC_CAPI.Text = "---- Select ----"
    End Sub

    Private Sub TLM_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLM_Add.Click
        Try
            con.Open()
            If TLM_SD.Text = "" Or TLM_API.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Exclamation)
            Else
                Dim sd1 As String
                sd1 = TLM_SD.Text
                Dim cmd1 As OdbcCommand
                cmd1 = New OdbcCommand("select * from Teach_TLM where User_Id='" + muid + "' and Year='" + myear + "' and Teach_TLM_SD='" + sd1 + "'", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    If TLM_API.Text > 5 Then
                        MsgBox("Please enter correct API", MsgBoxStyle.Critical)
                    Else
                        Dim sd, api As String
                        Dim cmd As OdbcCommand
                        sd = TLM_SD.Text
                        api = TLM_API.Text
                        Dim com As String
                        com = TLM_Combo.Text
                        cmd = New OdbcCommand("update Teach_TLM set Teach_TLM_SD='" + sd + "',Teach_TLM_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_TLM_SD='" + sd + "'  ", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                        TLM_SD.Clear()
                        TLM_API.Clear()
                        TLM_Combo.Text = "--- Select ---"
                    End If
                Else
                    If TLM_API.Text > 5 Then
                        MsgBox("Please enter correct API")
                    Else
                        Dim sd, api As String
                        Dim cmd As OdbcCommand
                        sd = TLM_SD.Text
                        api = TLM_API.Text
                        cmd = New OdbcCommand("insert into Teach_TLM values('" + muid + "', '" + myear + "' , '" + sd + "','" + api + "')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Added Successfully", MsgBoxStyle.Information)
                        TLM_SD.Clear()
                        TLM_API.Clear()
                        TLM_Combo.Text = "--- Select ---"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        con.Close()
    End Sub

    Private Sub TLM_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLM_Show.Click
        Try
            con.Open()
            Dim sd As String
            sd = TLM_Combo.Text
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from Teach_TLM where User_Id='" + muid + "' and Year='" + myear + "' and Teach_TLM_SD='" + sd + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                TLM_SD.Text = dr(2)
                TLM_API.Text = dr(3)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub TLM_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            con.Open()
            Dim sd, api As String
            Dim cmd As OdbcCommand
            sd = TLM_SD.Text
            api = TLM_API.Text
            cmd = New OdbcCommand("update Teach_TLM set Teach_TLM_SD='" + sd + "',Teach_TLM_API='" + api + "'where User_Id='" + muid + "' and Year='" + myear + "' and Teach_TLM_SD='" + sd + "' ", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")
            TLM_SD.Clear()
            TLM_API.Clear()
            TLM_Combo.Text = "--- Select ---"
        Catch ex As Exception

        End Try
        con.Close()

    End Sub


    Private Sub TLM_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLM_Delete.Click
        Try
            con.Open()
            If TLM_SD.Text = "" Or TLM_API.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim sd As String
                sd = TLM_SD.Text
                Dim cmd As OdbcCommand
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_TLM where User_Id='" + muid + "' and Year='" + myear + "' and Teach_TLM_SD='" + sd + "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    TLM_SD.Clear()
                    TLM_API.Clear()
                    TLM_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub TLM_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TLM_SD.Clear()
        TLM_API.Clear()
    End Sub

    Private Sub EDAP_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDAP_Add.Click
        Try
            con.Open()
            If EDAP_TED.Text = "" Or EDAP_DA.Text = "" Or EDAP_ECO.Text = "" Or EDAP_API.Text = "" Then
                MsgBox("Fields can't be left black", MsgBoxStyle.Exclamation)
            Else
                Dim cmd1 As OdbcCommand
                Dim ted1 As String
                ted1 = EDAP_Combo.Text
                cmd1 = New OdbcCommand("select * from Teach_EDAP where User_ID='" + muid + "' and Year='" + myear + "' and Teach_EDAP_TED='" + ted1 + "' ", con)
                If (cmd1.ExecuteNonQuery > 0) Then
                    If EDAP_ECO.Text > 100 Then
                        MsgBox("Percentage can't be greater than 100", MsgBoxStyle.Critical)
                        Exit Sub
                    ElseIf EDAP_API.Text > 10 Then
                        MsgBox("Please enter correct API", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        Dim cmd As OdbcCommand
                        Dim ted, da, eco, api As String
                        ted = EDAP_TED.Text
                        da = EDAP_DA.Text
                        eco = EDAP_ECO.Text
                        api = EDAP_API.Text
                        Dim com As String
                        com = EDAP_Combo.Text
                        cmd = New OdbcCommand("update Teach_EDAP set Teach_EDAP_TED='" + ted + "',Teach_EDAP_DA='" + da + "',Teach_EDAP_ECO='" + eco + "',Teach_EDAP_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_EDAP_TED='" + com + "'", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                        EDAP_TED.Clear()
                        EDAP_DA.Clear()
                        EDAP_ECO.Clear()
                        EDAP_API.Clear()
                        EDAP_Combo.Text = "--- Select ---"
                    End If
                Else
                    If EDAP_ECO.Text > 100 Then
                        MsgBox("Percentage can't be greater than 100", MsgBoxStyle.Critical)
                        Exit Sub
                    ElseIf EDAP_API.Text > 10 Then
                        MsgBox("Please enter correct API", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        Dim ted, da, eco, api As String
                        ted = EDAP_TED.Text
                        da = EDAP_DA.Text
                        eco = EDAP_ECO.Text
                        api = EDAP_API.Text
                        Dim cmd As OdbcCommand
                        cmd = New OdbcCommand("insert into Teach_EDAP values('" + muid + "', '" + myear + "' ,'" + ted + "','" + da + "','" + eco + "','" + api + "')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data Added Successfully", MsgBoxStyle.Information)
                        EDAP_TED.Clear()
                        EDAP_DA.Clear()
                        EDAP_ECO.Clear()
                        EDAP_API.Clear()
                        EDAP_Combo.Text = "--- Select ---"
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub EDAP_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EDAP_TED.Clear()
        EDAP_DA.Clear()
        EDAP_ECO.Clear()
        EDAP_API.Clear()
        EDAP_Combo.Text = "--- Select ---"
    End Sub

    Private Sub EDAP_Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDAP_Show.Click
        Try
            con.Open()
            Dim ted As String
            ted = EDAP_Combo.Text
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from Teach_EDAP where User_ID='" + muid + "' and Year='" + myear + "' and Teach_EDAP_TED='" + ted + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                EDAP_TED.Text = dr(2)
                EDAP_DA.Text = dr(3)
                EDAP_ECO.Text = dr(4)
                EDAP_API.Text = dr(5)
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub EDAP_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Dim ted, da, eco, api As String
            ted = EDAP_TED.Text
            da = EDAP_DA.Text
            eco = EDAP_ECO.Text
            api = EDAP_API.Text
            cmd = New OdbcCommand("update Teach_EDAP set Teach_EDAP_TED='" + ted + "',Teach_EDAP_DA='" + da + "',Teach_EDAP_ECO='" + eco + "',Teach_EDAP_API='" + api + "' where User_Id='" + muid + "' and Year='" + myear + "' and Teach_EDAP_TED='" + ted + "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully")
            EDAP_TED.Clear()
            EDAP_DA.Clear()
            EDAP_ECO.Clear()
            EDAP_API.Clear()
            EDAP_Combo.Text = "--- Select ---"
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub EDAP_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDAP_Delete.Click
        Try
            con.Open()
            If EDAP_TED.Text = "" Or EDAP_DA.Text = "" Or EDAP_ECO.Text = "" Or EDAP_API.Text = "" Then
                MsgBox("First select the entry to delete")
            Else
                Dim ted As String
                ted = EDAP_TED.Text
                Dim cmd As OdbcCommand
                Dim intResponse As Integer

                intResponse = MsgBox("Are you sure to delete this record", _
                                     vbYesNo + vbQuestion + vbDefaultButton2, _
                                     "Delete")
                If intResponse = vbYes Then
                    cmd = New OdbcCommand("delete from Teach_EDAP where User_Id='" + muid + "' and Year='" + myear + "' and Teach_EDAP_TED='" + ted + "' ", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted Successfully", MsgBoxStyle.Critical)
                    EDAP_TED.Clear()
                    EDAP_DA.Clear()
                    EDAP_ECO.Clear()
                    EDAP_API.Clear()
                    EDAP_Combo.Text = "--- Select ---"
                End If
            End If
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub TLM_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TLM_Combo.MouseClick
        Try
            con.Open()
            TLM_Combo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Teach_TLM_SD from Teach_TLM where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                TLM_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()

    End Sub

    Private Sub EDAP_Combo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles EDAP_Combo.MouseClick
        Try
            con.Open()
            EDAP_Combo.Items.Clear()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Teach_EDAP_TED from Teach_EDAP where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                EDAP_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub LSTP_TLAPI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LSTP_TLAPI.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
        LSTP_TT.SetToolTip(LSTP_TLAPI, "10")
    End Sub

    Private Sub TLM_API_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TLM_API.GotFocus
        TLM_TT.SetToolTip(TLM_API, "For details, see help")
    End Sub

    Private Sub TLM_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TLM_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
        TLM_TT.SetToolTip(TLM_API, "For details, see help")
    End Sub



    Private Sub RIMC_CAPI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If RIMC_CAPI.SelectedIndex = 0 Then
        'RIMC_ARP.Text = 5
        ' Else
        'RIMC_ARP.Text = 0
        'End If
    End Sub


    Private Sub LSTP_CTDR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LSTP_CTDR.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
        Try

            LSTP_CTAPI.Text = (Val(LSTP_CTDR.Text) * 500) / 100
            If LSTP_CTAPI.Text > 50 Then
                LSTP_CTAPI.Text = 50
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
    End Sub

    Private Sub LSTP_NOCA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LSTP_NOCA.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub LSTP_NOCC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LSTP_NOCC.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub LSTP_CTAPI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LSTP_CTAPI.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub EDAP_ECO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EDAP_ECO.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub EDAP_API_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EDAP_API.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Enter numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub



    Private Sub LSTP_Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSTP_Tab.Click
        LSTP_Course.Focus()
    End Sub

    
    Private Sub LSTP_Practicals_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LSTP_Practicals.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub


    Private Sub RIMC_Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIMC_Tab.Click
        RIMC_Course.Focus()
    End Sub

    
    Private Sub EDAP_Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDAP_Tab.Click
        EDAP_TED.Focus()
    End Sub

    Private Sub TLM_Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLM_Tab.Click
        TLM_SD.Focus()
    End Sub

    Private Sub RIMC_Yes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIMC_Yes.CheckedChanged

        RIMC_ARP.Text = 5

    End Sub

    Private Sub RIMC_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIMC_No.CheckedChanged

        RIMC_ARP.Text = 0

    End Sub

End Class