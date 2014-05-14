
Imports System.Data.Odbc

Public Class PBAS_PART_B_C4
    Dim con As New OdbcConnection("DSN=PBASDSN")

    Private Sub PBAS_PART_B_C4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.Open()
            Dim c1cmdl1, c1cmdl2 As OdbcCommand
            Dim suml1, suml2 As Integer
            c1cmdl1 = New OdbcCommand("select sum(Teach_LSTP_CTAPI)  from Teach_LSTP where User_Id='" + muid + "' and Year='" + myear + "' ", con)
            Dim c1odrl1, c1odrl2 As OdbcDataReader
            c1odrl1 = c1cmdl1.ExecuteReader
            While c1odrl1.Read
                suml1 = c1odrl1(0)
            End While
            If suml1 > 50 Then
                suml1 = 50
            End If
            c1cmdl2 = New OdbcCommand("select sum(Teach_LSTP_TLAPI)  from Teach_LSTP where User_Id='" + muid + "' and Year='" + myear + "' ", con)
            c1odrl2 = c1cmdl2.ExecuteReader
            While c1odrl2.Read
                suml2 = c1odrl2(0)
            End While
            If suml2 > 10 Then
                suml2 = 10
            End If
            'MsgBox(suml2)
            Dim suml3 As Integer
            suml3 = suml1 + suml2
            Dim c1cmd2 As OdbcCommand
            Dim sumt1 As Integer
            c1cmd2 = New OdbcCommand("select sum(Teach_TLM_API) from Teach_TLM where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c1odr2 As OdbcDataReader
            c1odr2 = c1cmd2.ExecuteReader
            While c1odr2.Read
                sumt1 = c1odr2(0)
            End While
            'MsgBox(sumt1)

            Dim c1cmd3 As OdbcCommand
            c1cmd3 = New OdbcCommand("select sum(Teach_RIMC_ARP) from Teach_RIMC where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c1odr3 As OdbcDataReader
            c1odr3 = c1cmd3.ExecuteReader
            Dim sumr1 As Integer
            While c1odr3.Read
                sumr1 = c1odr3(0)
            End While
            'MsgBox(sumr1)

            Dim c1cmd4 As OdbcCommand
            c1cmd4 = New OdbcCommand("select sum(Teach_EDAP_API) from Teach_EDAP where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c1odr4 As OdbcDataReader
            c1odr4 = c1cmd4.ExecuteReader
            Dim sume1 As Integer
            While c1odr4.Read
                sume1 = c1odr4(0)
            End While
            'MsgBox(sume1)
            Dim sumc1 As Integer
            sumc1 = suml3 + sumt1 + sumr1 + sume1
            'MsgBox(sumc1)
            c1api.Text = sumc1



            Dim c2cmd1 As OdbcCommand
            c2cmd1 = New OdbcCommand("select sum(Teach_ECFA_API) from Teach_ECFA where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c2odr1 As OdbcDataReader
            Dim sumed1 As Integer
            c2odr1 = c2cmd1.ExecuteReader
            While c2odr1.Read
                sumed1 = c2odr1(0)
            End While
            'MsgBox(sumed1)

            Dim c2cmd2 As OdbcCommand
            Dim sumec1, sumec2 As Integer
            c2cmd2 = New OdbcCommand("select sum(Teach_CLMI_API) from Teach_CLMI where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c2odr2 As OdbcDataReader
            c2odr2 = c2cmd2.ExecuteReader
            While c2odr2.Read
                sumec1 = c2odr2(0)
            End While
            'MsgBox(sumec1)
            Dim c2cmd3 As OdbcCommand
            c2cmd3 = New OdbcCommand("select sum(Teach_PDA_API) from Teach_PDA where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim sump1 As Integer
            Dim c2odr3 As OdbcDataReader
            c2odr3 = c2cmd3.ExecuteReader
            While c2odr3.Read
                sump1 = c2odr3(0)
            End While
            'MsgBox(sump1)

            Dim sumc2 As Integer
            sumc2 = sumed1 + sumec2 + sump1
            'MsgBox(sumc2)
            c2api.Text = sumc2

            tapi.Text = sumc1 + sumc2


            Dim c3cmd1 As OdbcCommand
            c3cmd1 = New OdbcCommand("select sum(Teach_RIMC_ARP) from Teach_RIMC where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3odr1 As OdbcDataReader
            c3odr1 = c3cmd1.ExecuteReader
            Dim c3sum1 As Integer
            While c3odr1.Read
                c3sum1 = c3odr1(0)
            End While
            'MsgBox(c3sum1)

            Dim c3cmd2 As OdbcCommand
            c3cmd2 = New OdbcCommand("select sum(Teach_APB_API) from Teach_APB where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3suma1 As Integer
            Dim c3odr2 As OdbcDataReader
            c3odr2 = c3cmd2.ExecuteReader
            While c3odr2.Read
                c3suma1 = c3odr2(0)
            End While
            'MsgBox(c3suma1)

            Dim c3cmd3 As OdbcCommand
            c3cmd3 = New OdbcCommand("select sum(Teach_FCP_API) from Teach_FCP where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3sumf1 As Integer
            Dim c3odr3 As OdbcDataReader
            c3odr3 = c3cmd3.ExecuteReader
            While c3odr3.Read
                c3sumf1 = c3odr3(0)
            End While
            'MsgBox(c3sumf1)

            Dim c3cmd4 As OdbcCommand
            c3cmd4 = New OdbcCommand("select sum(Teach_BPE_API) from Teach_BPE where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3odr4 As OdbcDataReader
            c3odr4 = c3cmd4.ExecuteReader
            Dim c3sumb1 As Integer
            While c3odr4.Read
                c3sumb1 = c3odr4(0)
            End While
            'MsgBox(c3sumb1)

            Dim c3cmd5 As OdbcCommand
            c3cmd5 = New OdbcCommand("select sum(Teach_OPC_API) from Teach_OPC where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3odr5 As OdbcDataReader
            c3odr5 = c3cmd5.ExecuteReader
            Dim c3sumo1 As Integer
            While c3odr5.Read
                c3sumo1 = c3odr5(0)
            End While
            'MsgBox(c3sumo1)

            Dim c3cmd6 As OdbcCommand
            c3cmd6 = New OdbcCommand("select sum(Teach_CPC_API) from Teach_CPC where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3odr6 As OdbcDataReader
            c3odr6 = c3cmd6.ExecuteReader
            Dim c3sumc1 As Integer
            While c3odr6.Read
                c3sumc1 = c3odr6(0)
            End While
            'MsgBox(c3sumc1)

            Dim c3cmd7 As OdbcCommand
            c3cmd7 = New OdbcCommand("select sum(Teach_RG_API) from Teach_RG where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3odr7 As OdbcDataReader
            c3odr7 = c3cmd7.ExecuteReader
            Dim c3sumr1 As Integer
            While c3odr7.Read
                c3sumr1 = c3odr7(0)
            End While
            'MsgBox(c3sumr1)

            Dim c3cmd8 As OdbcCommand
            c3cmd8 = New OdbcCommand("select sum(Teach_FDP_API) from Teach_FDP where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3odr8 As OdbcDataReader
            c3odr8 = c3cmd8.ExecuteReader
            Dim c3sumfd1 As Integer
            While c3odr8.Read
                c3sumfd1 = c3odr8(0)
            End While
            'MsgBox(c3sumfd1)

            Dim c3cmd9 As OdbcCommand
            c3cmd9 = New OdbcCommand("select sum(Teach_PPC_API) from Teach_PPC where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3odr9 As OdbcDataReader
            c3odr9 = c3cmd9.ExecuteReader
            Dim c3sump1 As Integer
            While c3odr9.Read
                c3sump1 = c3odr9(0)
            End While
            'MsgBox(c3sump1)

            Dim c3cmd10 As OdbcCommand
            c3cmd10 = New OdbcCommand("select sum(Teach_ILC_API) from Teach_ILC where User_Id='" + muid + "' and Year='" + myear + "'", con)
            Dim c3odr10 As OdbcDataReader
            c3odr10 = c3cmd10.ExecuteReader
            Dim c3sumi1 As Integer
            While c3odr10.Read
                c3sumi1 = c3odr10(0)
            End While
            'MsgBox(c3sumi1)

            Dim sumc3 As Integer
            sumc3 = c3sum1 + c3suma1 + c3sumf1 + c3sumb1 + c3sumo1 + c3sumc1 + c3sumr1 + c3sumfd1 + c3sump1 + c3sumi1
            c3api.Text = sumc3
            'MsgBox(sumc3)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        lay1.Text = myear
        lay2.Text = myear
        lay3.Text = myear
        
        con.Close()
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class