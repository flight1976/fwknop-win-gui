Imports System.ComponentModel
Imports System.IO
Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            '讀取datagridview目前游標所在位置設定資訊

            'MessageBox.Show(a)
            Dim fwk_ip As String = DataGridView2.CurrentRow.Cells(0).Value.ToString
            'cells無法使用ColumnName?
            'Dim fwk_value As String = DataGridView2.CurrentRow.Cells("fwk_protocol").Value.ToString & "/" & DataGridView2.CurrentRow.Cells("fwk_port").Value.ToString
            Dim fwk_value As String = DataGridView2.CurrentRow.Cells(1).Value.ToString & "/" & DataGridView2.CurrentRow.Cells(2).Value.ToString

            Dim p As Process = New Process()
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardInput = True
            p.StartInfo.RedirectStandardOutput = True
            'p.StartInfo.RedirectStandardError = True
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.FileName = ".\ext_bin\2.5\fwknop-2.5.1-w7.exe"

            '把密碼組合成-G --get-key參數使用的文字檔格式
            'todo:寫法不好，會暫存一個文字檔內含fwknop密碼(需改寫)
            'Dim passWriter As New StreamWriter(".\ext_data\password-tmp")
            'passWriter.WriteLine(fwk_ip & ":" & t_password.Text)
            'passWriter.Close()
            '20140430 把寫法改成直接用--key-rijndael參數輸入密碼
            If t_username.Text Is vbNullString Then
                p.StartInfo.Arguments = "-s -D " & fwk_ip & " -A """ & fwk_value & """ --key-rijndael=""" & t_password.Text & """ -vvv"
            Else
                p.StartInfo.Arguments = "-s -D " & fwk_ip & " -A """ & fwk_value & """ --key-rijndael=""" & t_password.Text & """ -vvv --spoof-user=" & t_username.Text
            End If

            p.Start()
            'MessageBox.Show(p.StartInfo.Arguments)
            'send password
            'Dim inputWriter As StreamWriter = p.StandardInput
            'inputWriter.AutoFlush = True
            'inputWriter.Write(t_password.Text & System.Environment.NewLine)

            Me.t_log.Text = p.StandardOutput.ReadToEnd()
            p.WaitForExit()
            p.Close()

            '刪除密碼暫存檔內容
            'Dim delfile As New FileInfo(".\ext_data\password-tmp")
            'delfile.Delete()

            'ToolStripStatusLabel2.Text = "command send.."
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        DataSet1.WriteXml("fwknop-config.xml")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'http://msdn.microsoft.com/en-us/library/5ycd1034(v=vs.80).aspx#Y0

        Dim newIPRow As DataRow = DataSet1.Tables("ServerList").NewRow()

        newIPRow("server_ip") = t_ip.Text
        If r_tcp.Checked Then
            newIPRow("fwk_protocol") = "tcp"
        Else
            newIPRow("fwk_protocol") = "udp"
        End If
        newIPRow("fwk_port") = t_port.Text

        DataSet1.Tables("ServerList").Rows.Add(newIPRow)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '檢查fwknop.exe執行檔是否存在
        'todo 改成呼叫libfko
        Dim fwknopExe As New FileInfo(".\ext_bin\2.5\fwknop-2.5.1-w7.exe")
        If Not fwknopExe.Exists Then
            MessageBox.Show("This program depends on fwknop-static.exe to send SPA packet. " & vbCrLf & "Please download fwknop-2.5.1-w7.exe to .\ext_bin\2.5 directory.")
            Button1.Enabled = False
        End If
        Dim chkConfig As New FileInfo("fwknop-config.xml")
        If chkConfig.Exists Then
            DataSet1.ReadXml("fwknop-config.xml")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles t_log.TextChanged

    End Sub

    Private Sub r_tcp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles r_tcp.CheckedChanged

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '關閉程式時自動儲存設定檔
        'DataSet1.WriteXml("fwknop-config.xml")
    End Sub
End Class
