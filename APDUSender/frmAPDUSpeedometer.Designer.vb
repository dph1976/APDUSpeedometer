<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAPDUSpeedometer
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
        Me.btnReadIMSI = New System.Windows.Forms.Button()
        Me.btnReadICCID = New System.Windows.Forms.Button()
        Me.btnSendAPDU = New System.Windows.Forms.Button()
        Me.txtAPDU = New System.Windows.Forms.TextBox()
        Me.lblReaderName = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.btnGetATR = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnRefesh = New System.Windows.Forms.Button()
        Me.cbxReader = New System.Windows.Forms.ComboBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.txtBatchAPDU = New System.Windows.Forms.TextBox()
        Me.btnSendBatchAPDU = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReadIMSI
        '
        Me.btnReadIMSI.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReadIMSI.Location = New System.Drawing.Point(40, 84)
        Me.btnReadIMSI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReadIMSI.Name = "btnReadIMSI"
        Me.btnReadIMSI.Size = New System.Drawing.Size(369, 30)
        Me.btnReadIMSI.TabIndex = 6
        Me.btnReadIMSI.Text = "Read IMSI 2G"
        Me.btnReadIMSI.UseVisualStyleBackColor = True
        '
        'btnReadICCID
        '
        Me.btnReadICCID.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReadICCID.Location = New System.Drawing.Point(40, 46)
        Me.btnReadICCID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReadICCID.Name = "btnReadICCID"
        Me.btnReadICCID.Size = New System.Drawing.Size(369, 30)
        Me.btnReadICCID.TabIndex = 5
        Me.btnReadICCID.Text = "Read ICCID"
        Me.btnReadICCID.UseVisualStyleBackColor = True
        '
        'btnSendAPDU
        '
        Me.btnSendAPDU.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendAPDU.Location = New System.Drawing.Point(40, 122)
        Me.btnSendAPDU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSendAPDU.Name = "btnSendAPDU"
        Me.btnSendAPDU.Size = New System.Drawing.Size(369, 30)
        Me.btnSendAPDU.TabIndex = 4
        Me.btnSendAPDU.Text = "Send a single APDU"
        Me.btnSendAPDU.UseVisualStyleBackColor = True
        '
        'txtAPDU
        '
        Me.txtAPDU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAPDU.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPDU.Location = New System.Drawing.Point(40, 160)
        Me.txtAPDU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAPDU.Name = "txtAPDU"
        Me.txtAPDU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAPDU.Size = New System.Drawing.Size(369, 20)
        Me.txtAPDU.TabIndex = 3
        '
        'lblReaderName
        '
        Me.lblReaderName.AutoSize = True
        Me.lblReaderName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReaderName.Location = New System.Drawing.Point(25, 59)
        Me.lblReaderName.Name = "lblReaderName"
        Me.lblReaderName.Size = New System.Drawing.Size(70, 19)
        Me.lblReaderName.TabIndex = 14
        Me.lblReaderName.Text = "Reader:"
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.Location = New System.Drawing.Point(24, 20)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(238, 29)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "APDU Speedometer"
        '
        'btnGetATR
        '
        Me.btnGetATR.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetATR.Location = New System.Drawing.Point(40, 11)
        Me.btnGetATR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGetATR.Name = "btnGetATR"
        Me.btnGetATR.Size = New System.Drawing.Size(369, 27)
        Me.btnGetATR.TabIndex = 7
        Me.btnGetATR.Text = "Get ATR"
        Me.btnGetATR.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHeader.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlHeader.Controls.Add(Me.btnRefesh)
        Me.pnlHeader.Controls.Add(Me.cbxReader)
        Me.pnlHeader.Controls.Add(Me.lblReaderName)
        Me.pnlHeader.Controls.Add(Me.lblFormTitle)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(984, 101)
        Me.pnlHeader.TabIndex = 6
        '
        'btnRefesh
        '
        Me.btnRefesh.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefesh.Location = New System.Drawing.Point(447, 57)
        Me.btnRefesh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefesh.Name = "btnRefesh"
        Me.btnRefesh.Size = New System.Drawing.Size(108, 27)
        Me.btnRefesh.TabIndex = 2
        Me.btnRefesh.Text = "Refresh"
        Me.btnRefesh.UseVisualStyleBackColor = True
        '
        'cbxReader
        '
        Me.cbxReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReader.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReader.FormattingEnabled = True
        Me.cbxReader.Location = New System.Drawing.Point(101, 57)
        Me.cbxReader.Name = "cbxReader"
        Me.cbxReader.Size = New System.Drawing.Size(308, 25)
        Me.cbxReader.TabIndex = 1
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(447, 11)
        Me.txtLog.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(525, 416)
        Me.txtLog.TabIndex = 12
        '
        'pnlBody
        '
        Me.pnlBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBody.Controls.Add(Me.txtBatchAPDU)
        Me.pnlBody.Controls.Add(Me.btnSendBatchAPDU)
        Me.pnlBody.Controls.Add(Me.btnReadIMSI)
        Me.pnlBody.Controls.Add(Me.btnReadICCID)
        Me.pnlBody.Controls.Add(Me.btnGetATR)
        Me.pnlBody.Controls.Add(Me.btnSendAPDU)
        Me.pnlBody.Controls.Add(Me.txtAPDU)
        Me.pnlBody.Controls.Add(Me.txtLog)
        Me.pnlBody.Location = New System.Drawing.Point(0, 98)
        Me.pnlBody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(984, 431)
        Me.pnlBody.TabIndex = 7
        '
        'txtBatchAPDU
        '
        Me.txtBatchAPDU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBatchAPDU.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatchAPDU.Location = New System.Drawing.Point(40, 231)
        Me.txtBatchAPDU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBatchAPDU.Multiline = True
        Me.txtBatchAPDU.Name = "txtBatchAPDU"
        Me.txtBatchAPDU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBatchAPDU.Size = New System.Drawing.Size(369, 196)
        Me.txtBatchAPDU.TabIndex = 14
        '
        'btnSendBatchAPDU
        '
        Me.btnSendBatchAPDU.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendBatchAPDU.Location = New System.Drawing.Point(40, 193)
        Me.btnSendBatchAPDU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSendBatchAPDU.Name = "btnSendBatchAPDU"
        Me.btnSendBatchAPDU.Size = New System.Drawing.Size(369, 30)
        Me.btnSendBatchAPDU.TabIndex = 13
        Me.btnSendBatchAPDU.Text = "Send a batch of APDU"
        Me.btnSendBatchAPDU.UseVisualStyleBackColor = True
        '
        'frmAPDUSpeedometer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 542)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBody)
        Me.MaximizeBox = False
        Me.Name = "frmAPDUSpeedometer"
        Me.Text = "APDU Speedometer by dph1976@gmail.com"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReadIMSI As Button
    Friend WithEvents btnReadICCID As Button
    Friend WithEvents btnSendAPDU As Button
    Friend WithEvents txtAPDU As TextBox
    Friend WithEvents lblReaderName As Label
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents btnGetATR As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents txtLog As TextBox
    Friend WithEvents pnlBody As Panel
    Friend WithEvents btnRefesh As Button
    Friend WithEvents cbxReader As ComboBox
    Friend WithEvents btnSendBatchAPDU As Button
    Friend WithEvents txtBatchAPDU As TextBox
End Class
