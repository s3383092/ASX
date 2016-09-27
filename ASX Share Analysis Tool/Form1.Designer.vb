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
        Me.components = New System.ComponentModel.Container()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tabFront = New System.Windows.Forms.TabPage()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.dgvFilterStocks = New System.Windows.Forms.DataGridView()
        Me.prgrssAllStocks = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dspAllStockStatus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dvgMatch = New System.Windows.Forms.DataGridView()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.dgvAllStocks = New System.Windows.Forms.DataGridView()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.cboCompanyName = New System.Windows.Forms.ComboBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.tabImport = New System.Windows.Forms.TabPage()
        Me.prgrssImportScreen = New System.Windows.Forms.ProgressBar()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.dspStatus = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.dspFileLocation = New System.Windows.Forms.TextBox()
        Me.btnImportFile = New System.Windows.Forms.Button()
        Me.dgvImport = New System.Windows.Forms.DataGridView()
        Me.tabPreferences = New System.Windows.Forms.TabPage()
        Me.lblConfirmLocation = New System.Windows.Forms.Label()
        Me.btnNewLocation = New System.Windows.Forms.Button()
        Me.lblDfltFilePath = New System.Windows.Forms.Label()
        Me.txtDfltFilePath = New System.Windows.Forms.TextBox()
        Me.tabWatchlist = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DailyStockPricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnResetLocation = New System.Windows.Forms.Button()
        Me.tbcMain.SuspendLayout()
        Me.tabFront.SuspendLayout()
        CType(Me.dgvFilterStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgMatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAll.SuspendLayout()
        CType(Me.dgvAllStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistory.SuspendLayout()
        Me.tabImport.SuspendLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPreferences.SuspendLayout()
        Me.tabWatchlist.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DailyStockPricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tabFront)
        Me.tbcMain.Controls.Add(Me.tabAll)
        Me.tbcMain.Controls.Add(Me.tabHistory)
        Me.tbcMain.Controls.Add(Me.tabImport)
        Me.tbcMain.Controls.Add(Me.tabPreferences)
        Me.tbcMain.Controls.Add(Me.tabWatchlist)
        Me.tbcMain.Location = New System.Drawing.Point(16, 15)
        Me.tbcMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(1364, 674)
        Me.tbcMain.TabIndex = 0
        '
        'tabFront
        '
        Me.tabFront.Controls.Add(Me.lblResults)
        Me.tabFront.Controls.Add(Me.lblPreview)
        Me.tabFront.Controls.Add(Me.dgvFilterStocks)
        Me.tabFront.Controls.Add(Me.prgrssAllStocks)
        Me.tabFront.Controls.Add(Me.Label1)
        Me.tabFront.Controls.Add(Me.dspAllStockStatus)
        Me.tabFront.Controls.Add(Me.Button1)
        Me.tabFront.Controls.Add(Me.dvgMatch)
        Me.tabFront.Controls.Add(Me.dgvHistory)
        Me.tabFront.Location = New System.Drawing.Point(4, 25)
        Me.tabFront.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFront.Name = "tabFront"
        Me.tabFront.Padding = New System.Windows.Forms.Padding(4)
        Me.tabFront.Size = New System.Drawing.Size(1356, 645)
        Me.tabFront.TabIndex = 1
        Me.tabFront.Text = "Front Page"
        Me.tabFront.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(77, 20)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(62, 17)
        Me.lblResults.TabIndex = 11
        Me.lblResults.Text = "Results"
        Me.lblResults.Visible = False
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.Location = New System.Drawing.Point(9, 20)
        Me.lblPreview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(64, 17)
        Me.lblPreview.TabIndex = 10
        Me.lblPreview.Text = "Preview"
        '
        'dgvFilterStocks
        '
        Me.dgvFilterStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFilterStocks.Enabled = False
        Me.dgvFilterStocks.Location = New System.Drawing.Point(9, 42)
        Me.dgvFilterStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvFilterStocks.Name = "dgvFilterStocks"
        Me.dgvFilterStocks.ReadOnly = True
        Me.dgvFilterStocks.Size = New System.Drawing.Size(1336, 554)
        Me.dgvFilterStocks.TabIndex = 8
        '
        'prgrssAllStocks
        '
        Me.prgrssAllStocks.Location = New System.Drawing.Point(81, 602)
        Me.prgrssAllStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.prgrssAllStocks.Name = "prgrssAllStocks"
        Me.prgrssAllStocks.Size = New System.Drawing.Size(381, 27)
        Me.prgrssAllStocks.TabIndex = 5
        Me.prgrssAllStocks.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 604)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Status :"
        '
        'dspAllStockStatus
        '
        Me.dspAllStockStatus.Enabled = False
        Me.dspAllStockStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dspAllStockStatus.Location = New System.Drawing.Point(81, 602)
        Me.dspAllStockStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dspAllStockStatus.Name = "dspAllStockStatus"
        Me.dspAllStockStatus.ReadOnly = True
        Me.dspAllStockStatus.Size = New System.Drawing.Size(380, 26)
        Me.dspAllStockStatus.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1220, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Filter stocks"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dvgMatch
        '
        Me.dvgMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMatch.Location = New System.Drawing.Point(11, 43)
        Me.dvgMatch.Margin = New System.Windows.Forms.Padding(4)
        Me.dvgMatch.Name = "dvgMatch"
        Me.dvgMatch.Size = New System.Drawing.Size(1335, 548)
        Me.dvgMatch.TabIndex = 6
        Me.dvgMatch.Visible = False
        '
        'dgvHistory
        '
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Location = New System.Drawing.Point(9, 42)
        Me.dgvHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.Size = New System.Drawing.Size(1336, 554)
        Me.dgvHistory.TabIndex = 9
        Me.dgvHistory.Visible = False
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.dgvAllStocks)
        Me.tabAll.Location = New System.Drawing.Point(4, 25)
        Me.tabAll.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Padding = New System.Windows.Forms.Padding(4)
        Me.tabAll.Size = New System.Drawing.Size(1356, 645)
        Me.tabAll.TabIndex = 0
        Me.tabAll.Text = "All Stocks"
        Me.tabAll.UseVisualStyleBackColor = True
        '
        'dgvAllStocks
        '
        Me.dgvAllStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllStocks.Location = New System.Drawing.Point(8, 7)
        Me.dgvAllStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAllStocks.Name = "dgvAllStocks"
        Me.dgvAllStocks.ReadOnly = True
        Me.dgvAllStocks.Size = New System.Drawing.Size(1335, 628)
        Me.dgvAllStocks.TabIndex = 8
        '
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.cboCompanyName)
        Me.tabHistory.Controls.Add(Me.lblCompany)
        Me.tabHistory.Location = New System.Drawing.Point(4, 25)
        Me.tabHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Padding = New System.Windows.Forms.Padding(4)
        Me.tabHistory.Size = New System.Drawing.Size(1356, 645)
        Me.tabHistory.TabIndex = 2
        Me.tabHistory.Text = "History"
        Me.tabHistory.UseVisualStyleBackColor = True
        '
        'cboCompanyName
        '
        Me.cboCompanyName.FormattingEnabled = True
        Me.cboCompanyName.Items.AddRange(New Object() {"Please select a company"})
        Me.cboCompanyName.Location = New System.Drawing.Point(325, 7)
        Me.cboCompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCompanyName.Name = "cboCompanyName"
        Me.cboCompanyName.Size = New System.Drawing.Size(541, 24)
        Me.cboCompanyName.TabIndex = 3
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(8, 11)
        Me.lblCompany.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(108, 17)
        Me.lblCompany.TabIndex = 1
        Me.lblCompany.Text = "Company Name"
        '
        'tabImport
        '
        Me.tabImport.Controls.Add(Me.prgrssImportScreen)
        Me.tabImport.Controls.Add(Me.lblFile)
        Me.tabImport.Controls.Add(Me.dspStatus)
        Me.tabImport.Controls.Add(Me.lblStatus)
        Me.tabImport.Controls.Add(Me.btnImport)
        Me.tabImport.Controls.Add(Me.dspFileLocation)
        Me.tabImport.Controls.Add(Me.btnImportFile)
        Me.tabImport.Controls.Add(Me.dgvImport)
        Me.tabImport.Location = New System.Drawing.Point(4, 25)
        Me.tabImport.Margin = New System.Windows.Forms.Padding(4)
        Me.tabImport.Name = "tabImport"
        Me.tabImport.Padding = New System.Windows.Forms.Padding(4)
        Me.tabImport.Size = New System.Drawing.Size(1356, 645)
        Me.tabImport.TabIndex = 3
        Me.tabImport.Text = "Import"
        Me.tabImport.UseVisualStyleBackColor = True
        '
        'prgrssImportScreen
        '
        Me.prgrssImportScreen.Location = New System.Drawing.Point(81, 602)
        Me.prgrssImportScreen.Margin = New System.Windows.Forms.Padding(4)
        Me.prgrssImportScreen.Name = "prgrssImportScreen"
        Me.prgrssImportScreen.Size = New System.Drawing.Size(381, 27)
        Me.prgrssImportScreen.TabIndex = 12
        Me.prgrssImportScreen.Visible = False
        '
        'lblFile
        '
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(11, 10)
        Me.lblFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(51, 27)
        Me.lblFile.TabIndex = 9
        Me.lblFile.Text = "File :"
        '
        'dspStatus
        '
        Me.dspStatus.Enabled = False
        Me.dspStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dspStatus.Location = New System.Drawing.Point(81, 602)
        Me.dspStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.dspStatus.Name = "dspStatus"
        Me.dspStatus.ReadOnly = True
        Me.dspStatus.Size = New System.Drawing.Size(380, 26)
        Me.dspStatus.TabIndex = 8
        Me.dspStatus.Text = "Please find a .txt or .csv file.."
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(11, 604)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(67, 20)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status :"
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(1239, 6)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(107, 31)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'dspFileLocation
        '
        Me.dspFileLocation.Enabled = False
        Me.dspFileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dspFileLocation.Location = New System.Drawing.Point(64, 9)
        Me.dspFileLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.dspFileLocation.Name = "dspFileLocation"
        Me.dspFileLocation.ReadOnly = True
        Me.dspFileLocation.Size = New System.Drawing.Size(1041, 26)
        Me.dspFileLocation.TabIndex = 5
        '
        'btnImportFile
        '
        Me.btnImportFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportFile.Location = New System.Drawing.Point(1127, 6)
        Me.btnImportFile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImportFile.Name = "btnImportFile"
        Me.btnImportFile.Size = New System.Drawing.Size(107, 31)
        Me.btnImportFile.TabIndex = 4
        Me.btnImportFile.Text = "Find File"
        Me.btnImportFile.UseVisualStyleBackColor = True
        '
        'dgvImport
        '
        Me.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImport.Location = New System.Drawing.Point(11, 46)
        Me.dgvImport.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvImport.Name = "dgvImport"
        Me.dgvImport.ReadOnly = True
        Me.dgvImport.Size = New System.Drawing.Size(1335, 546)
        Me.dgvImport.TabIndex = 3
        '
        'tabPreferences
        '
        Me.tabPreferences.Controls.Add(Me.btnResetLocation)
        Me.tabPreferences.Controls.Add(Me.lblConfirmLocation)
        Me.tabPreferences.Controls.Add(Me.btnNewLocation)
        Me.tabPreferences.Controls.Add(Me.lblDfltFilePath)
        Me.tabPreferences.Controls.Add(Me.txtDfltFilePath)
        Me.tabPreferences.Location = New System.Drawing.Point(4, 25)
        Me.tabPreferences.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPreferences.Name = "tabPreferences"
        Me.tabPreferences.Padding = New System.Windows.Forms.Padding(4)
        Me.tabPreferences.Size = New System.Drawing.Size(1356, 645)
        Me.tabPreferences.TabIndex = 4
        Me.tabPreferences.Text = "Preferences"
        Me.tabPreferences.UseVisualStyleBackColor = True
        '
        'lblConfirmLocation
        '
        Me.lblConfirmLocation.Location = New System.Drawing.Point(209, 87)
        Me.lblConfirmLocation.Name = "lblConfirmLocation"
        Me.lblConfirmLocation.Size = New System.Drawing.Size(153, 22)
        Me.lblConfirmLocation.TabIndex = 6
        '
        'btnNewLocation
        '
        Me.btnNewLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewLocation.Location = New System.Drawing.Point(444, 49)
        Me.btnNewLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewLocation.Name = "btnNewLocation"
        Me.btnNewLocation.Size = New System.Drawing.Size(259, 31)
        Me.btnNewLocation.TabIndex = 5
        Me.btnNewLocation.Text = "Choose New Location"
        Me.btnNewLocation.UseVisualStyleBackColor = True
        '
        'lblDfltFilePath
        '
        Me.lblDfltFilePath.AutoSize = True
        Me.lblDfltFilePath.Location = New System.Drawing.Point(9, 57)
        Me.lblDfltFilePath.Name = "lblDfltFilePath"
        Me.lblDfltFilePath.Size = New System.Drawing.Size(112, 17)
        Me.lblDfltFilePath.TabIndex = 1
        Me.lblDfltFilePath.Text = "Default File Path"
        '
        'txtDfltFilePath
        '
        Me.txtDfltFilePath.Enabled = False
        Me.txtDfltFilePath.Location = New System.Drawing.Point(152, 54)
        Me.txtDfltFilePath.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDfltFilePath.Name = "txtDfltFilePath"
        Me.txtDfltFilePath.ReadOnly = True
        Me.txtDfltFilePath.Size = New System.Drawing.Size(276, 22)
        Me.txtDfltFilePath.TabIndex = 0
        '
        'tabWatchlist
        '
        Me.tabWatchlist.Controls.Add(Me.SplitContainer1)
        Me.tabWatchlist.Location = New System.Drawing.Point(4, 25)
        Me.tabWatchlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabWatchlist.Name = "tabWatchlist"
        Me.tabWatchlist.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabWatchlist.Size = New System.Drawing.Size(1356, 645)
        Me.tabWatchlist.TabIndex = 5
        Me.tabWatchlist.Text = "Watchlist"
        Me.tabWatchlist.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 6)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(1019, 634)
        Me.SplitContainer1.SplitterDistance = 333
        Me.SplitContainer1.TabIndex = 1
        '
        'DailyStockPricesBindingSource
        '
        Me.DailyStockPricesBindingSource.DataMember = "Daily_Stock_Prices"
        '
        'btnResetLocation
        '
        Me.btnResetLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetLocation.Location = New System.Drawing.Point(711, 49)
        Me.btnResetLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetLocation.Name = "btnResetLocation"
        Me.btnResetLocation.Size = New System.Drawing.Size(156, 31)
        Me.btnResetLocation.TabIndex = 7
        Me.btnResetLocation.Text = "Reset Location"
        Me.btnResetLocation.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1404, 708)
        Me.Controls.Add(Me.tbcMain)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASX Share Market Analysis Tool"
        Me.tbcMain.ResumeLayout(False)
        Me.tabFront.ResumeLayout(False)
        Me.tabFront.PerformLayout()
        CType(Me.dgvFilterStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgMatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAll.ResumeLayout(False)
        CType(Me.dgvAllStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistory.ResumeLayout(False)
        Me.tabHistory.PerformLayout()
        Me.tabImport.ResumeLayout(False)
        Me.tabImport.PerformLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPreferences.ResumeLayout(False)
        Me.tabPreferences.PerformLayout()
        Me.tabWatchlist.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DailyStockPricesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcMain As TabControl
    Friend WithEvents tabAll As TabPage
    Friend WithEvents tabFront As TabPage
    Friend WithEvents tabHistory As TabPage
    Friend WithEvents tabImport As TabPage
    Friend WithEvents tabPreferences As TabPage
    Friend WithEvents dspStatus As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents dspFileLocation As TextBox
    Friend WithEvents btnImportFile As Button
    Friend WithEvents dgvImport As DataGridView
    Friend WithEvents cboCompanyName As ComboBox
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblFile As Label
    Friend WithEvents tabWatchlist As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lblDfltFilePath As Label
    Friend WithEvents txtDfltFilePath As TextBox
    'Friend WithEvents ASXShareMarketAnalysisToolDataSet2 As ASXShareMarketAnalysisToolDataSet2
    Friend WithEvents DailyStockPricesBindingSource As BindingSource
    'Friend WithEvents Daily_Stock_PricesTableAdapter As ASXShareMarketAnalysisToolDataSet2TableAdapters.Daily_Stock_PricesTableAdapter
    Friend WithEvents DailystockidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecuritycodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecuritydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpeningpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HighsalepriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LowsalepriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClosingpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalvolumeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents dspAllStockStatus As TextBox
    Friend WithEvents prgrssImportScreen As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prgrssAllStocks As System.Windows.Forms.ProgressBar
    Friend WithEvents dvgMatch As DataGridView
    Friend WithEvents btnNewLocation As Button
    Friend WithEvents dgvFilterStocks As DataGridView
    Friend WithEvents dgvAllStocks As DataGridView
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents lblResults As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lblConfirmLocation As Label
    Friend WithEvents btnResetLocation As Button
End Class
