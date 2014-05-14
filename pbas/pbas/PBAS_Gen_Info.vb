Imports System.Data.Odbc


Public Class PBAS_Gen_Info
    Dim con As New OdbcConnection("DSN=PBASDSN")




    Private Sub GI1_Addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GI1_Addbtn.Click
        Try
            con.Open()
            Dim cmd1 As OdbcCommand
            cmd1 = New OdbcCommand("select * from Gen_Info where user_id='" + muid + "'", con)
            If (cmd1.ExecuteNonQuery() > 0) Then
                Dim cmd As OdbcCommand
                Dim name, fname, mname, dept, desig, dlp, add, padd, email As String
                Dim tno, gp As String
                name = GI_Name.Text
                fname = GI_Fname.Text
                mname = GI_Mname.Text
                dept = GI_Dept.Text
                desig = GI_Desig.Text
                gp = GI_Gp.Text
                dlp = GI_DTP.Text
                add = GI_AFC.Text
                padd = GI_PA.Text
                tno = GI_TNO.Text
                email = GI_Email.Text
                cmd = New OdbcCommand("update Gen_Info set Gen_Info_Name='" + name + "', Gen_Info_Fname='" + fname + "', Gen_Info_Mname='" + mname + "', Gen_Info_Department='" + dept + "', Gen_Info_CD='" + desig + "', Gen_Info_GP='" + gp + "', Gen_Info_DLP='" + dlp + "', Gen_Info_AFC='" + add + "', Gen_Info_PA='" + padd + "', Gen_Info_TNO='" + tno + "', Gen_Info_Email='" + email + "' where User_Id='" + muid + "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                GI_Name.Clear()
                GI_Fname.Clear()
                GI_Mname.Clear()
                GI_Dept.Clear()
                GI_Desig.Clear()
                GI_Gp.Clear()
                GI_DTP.Value = Now
                GI_AFC.Clear()
                GI_PA.Clear()
                GI_TNO.Clear()
                GI_Email.Clear()
                Dim cmd2 As New OdbcCommand
                cmd2 = New OdbcCommand(" select * from Gen_Info where User_Id = '" + muid + "'", con)
                Dim dr As OdbcDataReader
                dr = cmd2.ExecuteReader()
                While dr.Read
                    GI_Name.Text = dr(1)
                    GI_Fname.Text = dr(2)
                    GI_Mname.Text = dr(3)
                    GI_Dept.Text = dr(4)
                    GI_Desig.Text = dr(5)
                    GI_Gp.Text = dr(6)
                    GI_DTP.Value = dr(7)
                    GI_AFC.Text = dr(8)
                    GI_PA.Text = dr(9)
                    GI_TNO.Text = dr(10)
                    GI_Email.Text = dr(11)
                End While
                GI_Name.Enabled = False
                GI_Fname.Enabled = False
                GI_Mname.Enabled = False
                GI_Dept.Enabled = False
                GI_Desig.Enabled = False
                GI_Gp.Enabled = False
                GI_DTP.Enabled = False
                GI_AFC.Enabled = False
                GI_PA.Enabled = False
                GI_TNO.Enabled = False
                GI_Email.Enabled = False
            Else
                Dim cmd As OdbcCommand
                Dim uid, pwd As String
                uid = uidmodule.muid
                pwd = uidmodule.mpwd
                Dim name, fname, mname, dept, desig, dlp, add, padd, email As String
                Dim tno, gp As String
                name = GI_Name.Text
                fname = GI_Fname.Text
                mname = GI_Mname.Text
                dept = GI_Dept.Text
                desig = GI_Desig.Text
                gp = GI_Gp.Text
                dlp = GI_DTP.Text
                add = GI_AFC.Text
                padd = GI_PA.Text
                tno = GI_TNO.Text
                email = GI_Email.Text

                cmd = New OdbcCommand("insert into gen_info values('" + muid + "','" + name + "','" + fname + "','" + mname + "','" + dept + "','" + desig + "','" + gp + "','" + dlp + "','" + add + "','" + padd + "','" + tno + "','" + email + "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Your Information is saved", MsgBoxStyle.Information)
                GI_Name.Clear()
                GI_Fname.Clear()
                GI_Mname.Clear()
                GI_Dept.Clear()
                GI_Desig.Clear()
                GI_Gp.Clear()
                GI_DTP.Value = Now
                GI_AFC.Clear()
                GI_PA.Clear()
                GI_TNO.Clear()
                GI_Email.Clear()


                Dim cmd2 As New OdbcCommand
                cmd2 = New OdbcCommand(" select * from Gen_Info where User_Id = '" + muid + "'", con)
                Dim dr As OdbcDataReader
                dr = cmd2.ExecuteReader()
                While dr.Read
                    GI_Name.Text = dr(1)
                    GI_Fname.Text = dr(2)
                    GI_Mname.Text = dr(3)
                    GI_Dept.Text = dr(4)
                    GI_Desig.Text = dr(5)
                    GI_Gp.Text = dr(6)
                    GI_DTP.Value = dr(7)
                    GI_AFC.Text = dr(8)
                    GI_PA.Text = dr(9)
                    GI_TNO.Text = dr(10)
                    GI_Email.Text = dr(11)
                End While
                GI_Name.Enabled = False
                GI_Fname.Enabled = False
                GI_Mname.Enabled = False
                GI_Dept.Enabled = False
                GI_Desig.Enabled = False
                GI_Gp.Enabled = False
                GI_DTP.Enabled = False
                GI_AFC.Enabled = False
                GI_PA.Enabled = False
                GI_TNO.Enabled = False
                GI_Email.Enabled = False

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub

   

    Private Sub PBAS_Part_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            con.Open()
            Dim cmd As New OdbcCommand
            cmd = New OdbcCommand(" select * from Gen_Info where User_Id = '" + muid + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader()
            If dr.Read Then
                GI_Name.Text = dr(1)
                GI_Fname.Text = dr(2)
                GI_Mname.Text = dr(3)
                GI_Dept.Text = dr(4)
                GI_Desig.Text = dr(5)
                GI_Gp.Text = dr(6)
                GI_DTP.Value = dr(7)
                GI_AFC.Text = dr(8)
                GI_PA.Text = dr(9)
                GI_TNO.Text = dr(10)
                GI_Email.Text = dr(11)

                GI_Name.Enabled = False
                GI_Fname.Enabled = False
                GI_Mname.Enabled = False
                GI_Dept.Enabled = False
                GI_Desig.Enabled = False
                GI_Gp.Enabled = False
                GI_DTP.Enabled = False
                GI_AFC.Enabled = False
                GI_PA.Enabled = False
                GI_TNO.Enabled = False
                GI_Email.Enabled = False
            Else
                GI_Name.Enabled = True
                GI_Fname.Enabled = True
                GI_Mname.Enabled = True
                GI_Dept.Enabled = True
                GI_Desig.Enabled = True
                GI_Gp.Enabled = True
                GI_DTP.Enabled = True
                GI_AFC.Enabled = True
                GI_PA.Enabled = True
                GI_TNO.Enabled = True
                GI_Email.Enabled = True
            End If

        Catch ex As Exception

        End Try
        con.Close()
        Try
            
            GI_DTP.Format = DateTimePickerFormat.Custom
            GI_DTP.CustomFormat = "yyyy/MM/dd"
            
        Catch ex As Exception

        End Try
        con.Close()
    End Sub



    Private Sub GI1_Showbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            con.Open()
            Dim cmd As New OdbcCommand
            cmd = New OdbcCommand(" select * from Gen_Info where User_Id = '" + muid + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader()
            While dr.Read
                GI_Name.Text = dr(1)
                GI_Fname.Text = dr(2)
                GI_Mname.Text = dr(3)
                GI_Dept.Text = dr(4)
                GI_Desig.Text = dr(5)
                GI_Gp.Text = dr(6)
                GI_DTP.Value = dr(7)
                GI_AFC.Text = dr(8)
                GI_PA.Text = dr(9)
                GI_TNO.Text = dr(10)
                GI_Email.Text = dr(11)
            End While

        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub GI1_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    
   

    Private Sub GI_TNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GI_TNO.KeyPress
        'Dim allowedchars As String = "0123456789$,"
        'If allowedchars.IndexOf(e.KeyChar) = -1 Then
        'e.Handled = True
        'MsgBox("Enter numeric values only")
        'End If
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub GI_Gp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GI_Gp.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub GI1_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GI1_Edit.Click
        GI_Name.Enabled = True
        GI_Fname.Enabled = True
        GI_Mname.Enabled = True
        GI_Dept.Enabled = True
        GI_Desig.Enabled = True
        GI_Gp.Enabled = True
        GI_DTP.Enabled = True
        GI_AFC.Enabled = True
        GI_PA.Enabled = True
        GI_TNO.Enabled = True
        GI_Email.Enabled = True
    End Sub

    
End Class