<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_port = New System.Windows.Forms.TextBox()
        Me.r_udp = New System.Windows.Forms.RadioButton()
        Me.r_tcp = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t_ip = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ServeripDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FwkprotocolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FwkportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.t_log = New System.Windows.Forms.TextBox()
        Me.t_password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t_username = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "ServerList"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "IP"
        Me.DataColumn1.ColumnName = "server_ip"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Protocol"
        Me.DataColumn2.ColumnName = "fwk_protocol"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Port"
        Me.DataColumn3.ColumnName = "fwk_port"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Comment"
        Me.DataColumn4.ColumnName = "comment"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(19, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.t_port)
        Me.GroupBox1.Controls.Add(Me.r_udp)
        Me.GroupBox1.Controls.Add(Me.r_tcp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.t_ip)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 140)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(182, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 49)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Port"
        '
        't_port
        '
        Me.t_port.Location = New System.Drawing.Point(76, 86)
        Me.t_port.Name = "t_port"
        Me.t_port.Size = New System.Drawing.Size(100, 20)
        Me.t_port.TabIndex = 5
        '
        'r_udp
        '
        Me.r_udp.AutoSize = True
        Me.r_udp.Location = New System.Drawing.Point(126, 61)
        Me.r_udp.Name = "r_udp"
        Me.r_udp.Size = New System.Drawing.Size(43, 17)
        Me.r_udp.TabIndex = 4
        Me.r_udp.Text = "udp"
        Me.r_udp.UseVisualStyleBackColor = True
        '
        'r_tcp
        '
        Me.r_tcp.AutoSize = True
        Me.r_tcp.Checked = True
        Me.r_tcp.Location = New System.Drawing.Point(76, 61)
        Me.r_tcp.Name = "r_tcp"
        Me.r_tcp.Size = New System.Drawing.Size(40, 17)
        Me.r_tcp.TabIndex = 3
        Me.r_tcp.TabStop = True
        Me.r_tcp.Text = "tcp"
        Me.r_tcp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Protocol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server IP"
        '
        't_ip
        '
        Me.t_ip.Location = New System.Drawing.Point(76, 21)
        Me.t_ip.Name = "t_ip"
        Me.t_ip.Size = New System.Drawing.Size(181, 20)
        Me.t_ip.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServeripDataGridViewTextBoxColumn, Me.FwkprotocolDataGridViewTextBoxColumn, Me.FwkportDataGridViewTextBoxColumn, Me.comment})
        Me.DataGridView2.DataSource = Me.BindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(13, 160)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(527, 163)
        Me.DataGridView2.TabIndex = 4
        '
        'ServeripDataGridViewTextBoxColumn
        '
        Me.ServeripDataGridViewTextBoxColumn.DataPropertyName = "server_ip"
        Me.ServeripDataGridViewTextBoxColumn.HeaderText = "Server IP"
        Me.ServeripDataGridViewTextBoxColumn.Name = "ServeripDataGridViewTextBoxColumn"
        '
        'FwkprotocolDataGridViewTextBoxColumn
        '
        Me.FwkprotocolDataGridViewTextBoxColumn.DataPropertyName = "fwk_protocol"
        Me.FwkprotocolDataGridViewTextBoxColumn.HeaderText = "Protocol"
        Me.FwkprotocolDataGridViewTextBoxColumn.Name = "FwkprotocolDataGridViewTextBoxColumn"
        Me.FwkprotocolDataGridViewTextBoxColumn.ToolTipText = "TCP or UDP"
        '
        'FwkportDataGridViewTextBoxColumn
        '
        Me.FwkportDataGridViewTextBoxColumn.DataPropertyName = "fwk_port"
        Me.FwkportDataGridViewTextBoxColumn.HeaderText = "Port"
        Me.FwkportDataGridViewTextBoxColumn.Name = "FwkportDataGridViewTextBoxColumn"
        '
        'comment
        '
        Me.comment.DataPropertyName = "comment"
        Me.comment.HeaderText = "Comment"
        Me.comment.Name = "comment"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "ServerList"
        Me.BindingSource1.DataSource = Me.DataSet1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.t_log)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 414)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 205)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Debug Log"
        '
        't_log
        '
        Me.t_log.BackColor = System.Drawing.SystemColors.Info
        Me.t_log.Location = New System.Drawing.Point(6, 23)
        Me.t_log.Multiline = True
        Me.t_log.Name = "t_log"
        Me.t_log.ReadOnly = True
        Me.t_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.t_log.Size = New System.Drawing.Size(515, 175)
        Me.t_log.TabIndex = 0
        '
        't_password
        '
        Me.t_password.BackColor = System.Drawing.Color.Red
        Me.t_password.ForeColor = System.Drawing.SystemColors.Window
        Me.t_password.Location = New System.Drawing.Point(318, 377)
        Me.t_password.Name = "t_password"
        Me.t_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t_password.Size = New System.Drawing.Size(134, 20)
        Me.t_password.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 644)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(552, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Username"
        '
        't_username
        '
        Me.t_username.BackColor = System.Drawing.Color.LightGray
        Me.t_username.ForeColor = System.Drawing.SystemColors.Window
        Me.t_username.Location = New System.Drawing.Point(318, 347)
        Me.t_username.Name = "t_username"
        Me.t_username.Size = New System.Drawing.Size(134, 20)
        Me.t_username.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(462, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "(optional)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(272, 622)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(268, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Warning! This version only support fwknop 2.6.x Server"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 666)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.t_username)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t_password)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "fwknop-gui [2017/11/03] V0.9"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t_ip As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents t_port As System.Windows.Forms.TextBox
    Friend WithEvents r_udp As System.Windows.Forms.RadioButton
    Friend WithEvents r_tcp As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents t_log As System.Windows.Forms.TextBox
    Friend WithEvents t_password As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents t_username As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents ServeripDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FwkprotocolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FwkportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents comment As DataGridViewTextBoxColumn
End Class
