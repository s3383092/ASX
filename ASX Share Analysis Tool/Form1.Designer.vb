<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tabFront = New System.Windows.Forms.TabPage()
        Me.dgdFrontPage = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.dgdAllStocks = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colASXID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWatch = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colBid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAsk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHigh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVolume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.cboCompanyName = New System.Windows.Forms.ComboBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.dgdHistory = New System.Windows.Forms.DataGridView()
        Me.colHistDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHistBid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHistAsk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHistHigh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHistLow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHistVolume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabImport = New System.Windows.Forms.TabPage()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.dspStatus = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.dspFileLocation = New System.Windows.Forms.TextBox()
        Me.btnImportFile = New System.Windows.Forms.Button()
        Me.dgvImport = New System.Windows.Forms.DataGridView()
        Me.tabPreferences = New System.Windows.Forms.TabPage()
        Me.lblDfltFilePath = New System.Windows.Forms.Label()
        Me.txtDfltFilePath = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tbcMain.SuspendLayout()
        Me.tabFront.SuspendLayout()
        CType(Me.dgdFrontPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAll.SuspendLayout()
        CType(Me.dgdAllStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistory.SuspendLayout()
        CType(Me.dgdHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImport.SuspendLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPreferences.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tabFront)
        Me.tbcMain.Controls.Add(Me.tabAll)
        Me.tbcMain.Controls.Add(Me.tabHistory)
        Me.tbcMain.Controls.Add(Me.tabImport)
        Me.tbcMain.Controls.Add(Me.tabPreferences)
        Me.tbcMain.Controls.Add(Me.TabPage1)
        Me.tbcMain.Location = New System.Drawing.Point(12, 12)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(1023, 548)
        Me.tbcMain.TabIndex = 0
        '
        'tabFront
        '
        Me.tabFront.Controls.Add(Me.dgdFrontPage)
        Me.tabFront.Location = New System.Drawing.Point(4, 22)
        Me.tabFront.Name = "tabFront"
        Me.tabFront.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabFront.Size = New System.Drawing.Size(1015, 522)
        Me.tabFront.TabIndex = 0
        Me.tabFront.Text = "Front Page"
        Me.tabFront.UseVisualStyleBackColor = True
        '
        'dgdFrontPage
        '
        Me.dgdFrontPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdFrontPage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgdFrontPage.Enabled = False
        Me.dgdFrontPage.Location = New System.Drawing.Point(6, 6)
        Me.dgdFrontPage.Name = "dgdFrontPage"
        Me.dgdFrontPage.ReadOnly = True
        Me.dgdFrontPage.Size = New System.Drawing.Size(1004, 512)
        Me.dgdFrontPage.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ASX ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Watchlist"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Bid"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ask"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "High"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Low"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Volume"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.dgdAllStocks)
        Me.tabAll.Location = New System.Drawing.Point(4, 22)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabAll.Size = New System.Drawing.Size(1015, 522)
        Me.tabAll.TabIndex = 1
        Me.tabAll.Text = "All Stocks"
        Me.tabAll.UseVisualStyleBackColor = True
        '
        'dgdAllStocks
        '
        Me.dgdAllStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdAllStocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colASXID, Me.colName, Me.colWatch, Me.colBid, Me.colAsk, Me.colHigh, Me.colLow, Me.colVolume})
        Me.dgdAllStocks.Enabled = False
        Me.dgdAllStocks.Location = New System.Drawing.Point(6, 6)
        Me.dgdAllStocks.Name = "dgdAllStocks"
        Me.dgdAllStocks.ReadOnly = True
        Me.dgdAllStocks.Size = New System.Drawing.Size(1006, 512)
        Me.dgdAllStocks.TabIndex = 1
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 50
        '
        'colASXID
        '
        Me.colASXID.HeaderText = "ASX ID"
        Me.colASXID.Name = "colASXID"
        Me.colASXID.ReadOnly = True
        Me.colASXID.Width = 50
        '
        'colName
        '
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 300
        '
        'colWatch
        '
        Me.colWatch.HeaderText = "Watchlist"
        Me.colWatch.Name = "colWatch"
        Me.colWatch.ReadOnly = True
        Me.colWatch.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colWatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colWatch.Width = 60
        '
        'colBid
        '
        Me.colBid.HeaderText = "Bid"
        Me.colBid.Name = "colBid"
        Me.colBid.ReadOnly = True
        '
        'colAsk
        '
        Me.colAsk.HeaderText = "Ask"
        Me.colAsk.Name = "colAsk"
        Me.colAsk.ReadOnly = True
        '
        'colHigh
        '
        Me.colHigh.HeaderText = "High"
        Me.colHigh.Name = "colHigh"
        Me.colHigh.ReadOnly = True
        '
        'colLow
        '
        Me.colLow.HeaderText = "Low"
        Me.colLow.Name = "colLow"
        Me.colLow.ReadOnly = True
        '
        'colVolume
        '
        Me.colVolume.HeaderText = "Volume"
        Me.colVolume.Name = "colVolume"
        Me.colVolume.ReadOnly = True
        '
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.cboCompanyName)
        Me.tabHistory.Controls.Add(Me.lblCompany)
        Me.tabHistory.Controls.Add(Me.dgdHistory)
        Me.tabHistory.Location = New System.Drawing.Point(4, 22)
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabHistory.Size = New System.Drawing.Size(1015, 522)
        Me.tabHistory.TabIndex = 2
        Me.tabHistory.Text = "History"
        Me.tabHistory.UseVisualStyleBackColor = True
        '
        'cboCompanyName
        '
        Me.cboCompanyName.FormattingEnabled = True
        Me.cboCompanyName.Items.AddRange(New Object() {"Please select a company"})
        Me.cboCompanyName.Location = New System.Drawing.Point(244, 6)
        Me.cboCompanyName.Name = "cboCompanyName"
        Me.cboCompanyName.Size = New System.Drawing.Size(407, 21)
        Me.cboCompanyName.TabIndex = 3
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(6, 9)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(82, 13)
        Me.lblCompany.TabIndex = 1
        Me.lblCompany.Text = "Company Name"
        '
        'dgdHistory
        '
        Me.dgdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHistDate, Me.colHistBid, Me.colHistAsk, Me.colHistHigh, Me.colHistLow, Me.colHistVolume})
        Me.dgdHistory.Location = New System.Drawing.Point(6, 33)
        Me.dgdHistory.Name = "dgdHistory"
        Me.dgdHistory.Size = New System.Drawing.Size(645, 483)
        Me.dgdHistory.TabIndex = 0
        '
        'colHistDate
        '
        Me.colHistDate.HeaderText = "Date"
        Me.colHistDate.Name = "colHistDate"
        Me.colHistDate.ReadOnly = True
        '
        'colHistBid
        '
        Me.colHistBid.HeaderText = "Bid"
        Me.colHistBid.Name = "colHistBid"
        Me.colHistBid.ReadOnly = True
        '
        'colHistAsk
        '
        Me.colHistAsk.HeaderText = "Ask"
        Me.colHistAsk.Name = "colHistAsk"
        Me.colHistAsk.ReadOnly = True
        '
        'colHistHigh
        '
        Me.colHistHigh.HeaderText = "High"
        Me.colHistHigh.Name = "colHistHigh"
        Me.colHistHigh.ReadOnly = True
        '
        'colHistLow
        '
        Me.colHistLow.HeaderText = "Low"
        Me.colHistLow.Name = "colHistLow"
        Me.colHistLow.ReadOnly = True
        '
        'colHistVolume
        '
        Me.colHistVolume.HeaderText = "Volume"
        Me.colHistVolume.Name = "colHistVolume"
        Me.colHistVolume.ReadOnly = True
        '
        'tabImport
        '
        Me.tabImport.Controls.Add(Me.lblFile)
        Me.tabImport.Controls.Add(Me.dspStatus)
        Me.tabImport.Controls.Add(Me.lblStatus)
        Me.tabImport.Controls.Add(Me.btnImport)
        Me.tabImport.Controls.Add(Me.dspFileLocation)
        Me.tabImport.Controls.Add(Me.btnImportFile)
        Me.tabImport.Controls.Add(Me.dgvImport)
        Me.tabImport.Location = New System.Drawing.Point(4, 22)
        Me.tabImport.Name = "tabImport"
        Me.tabImport.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabImport.Size = New System.Drawing.Size(1015, 522)
        Me.tabImport.TabIndex = 3
        Me.tabImport.Text = "Import"
        Me.tabImport.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(6, 13)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(23, 13)
        Me.lblFile.TabIndex = 9
        Me.lblFile.Text = "File"
        '
        'dspStatus
        '
        Me.dspStatus.Enabled = False
        Me.dspStatus.Location = New System.Drawing.Point(46, 483)
        Me.dspStatus.Name = "dspStatus"
        Me.dspStatus.ReadOnly = True
        Me.dspStatus.Size = New System.Drawing.Size(267, 20)
        Me.dspStatus.TabIndex = 8
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(6, 486)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(319, 483)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'dspFileLocation
        '
        Me.dspFileLocation.Enabled = False
        Me.dspFileLocation.Location = New System.Drawing.Point(46, 8)
        Me.dspFileLocation.Name = "dspFileLocation"
        Me.dspFileLocation.ReadOnly = True
        Me.dspFileLocation.Size = New System.Drawing.Size(267, 20)
        Me.dspFileLocation.TabIndex = 5
        '
        'btnImportFile
        '
        Me.btnImportFile.Location = New System.Drawing.Point(319, 8)
        Me.btnImportFile.Name = "btnImportFile"
        Me.btnImportFile.Size = New System.Drawing.Size(75, 23)
        Me.btnImportFile.TabIndex = 4
        Me.btnImportFile.Text = "Find File"
        Me.btnImportFile.UseVisualStyleBackColor = True
        '
        'dgvImport
        '
        Me.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImport.Enabled = False
        Me.dgvImport.Location = New System.Drawing.Point(8, 32)
        Me.dgvImport.Name = "dgvImport"
        Me.dgvImport.ReadOnly = True
        Me.dgvImport.Size = New System.Drawing.Size(1053, 444)
        Me.dgvImport.TabIndex = 3
        '
        'tabPreferences
        '
        Me.tabPreferences.Controls.Add(Me.lblDfltFilePath)
        Me.tabPreferences.Controls.Add(Me.txtDfltFilePath)
        Me.tabPreferences.Location = New System.Drawing.Point(4, 22)
        Me.tabPreferences.Name = "tabPreferences"
        Me.tabPreferences.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabPreferences.Size = New System.Drawing.Size(1015, 522)
        Me.tabPreferences.TabIndex = 4
        Me.tabPreferences.Text = "Preferences"
        Me.tabPreferences.UseVisualStyleBackColor = True
        '
        'lblDfltFilePath
        '
        Me.lblDfltFilePath.AutoSize = True
        Me.lblDfltFilePath.Location = New System.Drawing.Point(7, 46)
        Me.lblDfltFilePath.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDfltFilePath.Name = "lblDfltFilePath"
        Me.lblDfltFilePath.Size = New System.Drawing.Size(85, 13)
        Me.lblDfltFilePath.TabIndex = 1
        Me.lblDfltFilePath.Text = "Default File Path"
        '
        'txtDfltFilePath
        '
        Me.txtDfltFilePath.Enabled = False
        Me.txtDfltFilePath.Location = New System.Drawing.Point(114, 44)
        Me.txtDfltFilePath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDfltFilePath.Name = "txtDfltFilePath"
        Me.txtDfltFilePath.Size = New System.Drawing.Size(208, 20)
        Me.txtDfltFilePath.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1015, 522)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 5)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(764, 515)
        Me.SplitContainer1.SplitterDistance = 254
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 575)
        Me.Controls.Add(Me.tbcMain)
        Me.Name = "Form1"
        Me.Text = "ASX Share Market Analysis Tool"
        Me.tbcMain.ResumeLayout(False)
        Me.tabFront.ResumeLayout(False)
        CType(Me.dgdFrontPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAll.ResumeLayout(False)
        CType(Me.dgdAllStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistory.ResumeLayout(False)
        Me.tabHistory.PerformLayout()
        CType(Me.dgdHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImport.ResumeLayout(False)
        Me.tabImport.PerformLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPreferences.ResumeLayout(False)
        Me.tabPreferences.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcMain As TabControl
    Friend WithEvents tabFront As TabPage
    Friend WithEvents tabAll As TabPage
    Friend WithEvents dgdAllStocks As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colASXID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colWatch As DataGridViewCheckBoxColumn
    Friend WithEvents colBid As DataGridViewTextBoxColumn
    Friend WithEvents colAsk As DataGridViewTextBoxColumn
    Friend WithEvents colHigh As DataGridViewTextBoxColumn
    Friend WithEvents colLow As DataGridViewTextBoxColumn
    Friend WithEvents colVolume As DataGridViewTextBoxColumn
    Friend WithEvents tabHistory As TabPage
    Friend WithEvents tabImport As TabPage
    Friend WithEvents tabPreferences As TabPage
    Friend WithEvents dgdHistory As DataGridView
    Friend WithEvents colHistDate As DataGridViewTextBoxColumn
    Friend WithEvents colHistBid As DataGridViewTextBoxColumn
    Friend WithEvents colHistAsk As DataGridViewTextBoxColumn
    Friend WithEvents colHistHigh As DataGridViewTextBoxColumn
    Friend WithEvents colHistLow As DataGridViewTextBoxColumn
    Friend WithEvents colHistVolume As DataGridViewTextBoxColumn
    Friend WithEvents dgdFrontPage As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents dspStatus As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents dspFileLocation As TextBox
    Friend WithEvents btnImportFile As Button
    Friend WithEvents dgvImport As DataGridView
    Friend WithEvents cboCompanyName As ComboBox
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblFile As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lblDfltFilePath As Label
    Friend WithEvents txtDfltFilePath As TextBox
End Class
