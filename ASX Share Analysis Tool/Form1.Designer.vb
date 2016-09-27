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
        Me.dgvFrontPage = New System.Windows.Forms.DataGridView()
        Me.DailyStockPricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.dvgMatch = New System.Windows.Forms.DataGridView()
        Me.prgrssAllStocks = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dspAllStockStatus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvAllStocks = New System.Windows.Forms.DataGridView()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.cboCompanyName = New System.Windows.Forms.ComboBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
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
        Me.btnNewLocation = New System.Windows.Forms.Button()
        Me.lblDfltFilePath = New System.Windows.Forms.Label()
        Me.txtDfltFilePath = New System.Windows.Forms.TextBox()
        Me.tabWatchlist = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tbcMain.SuspendLayout()
        Me.tabFront.SuspendLayout()
        CType(Me.dgvFrontPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyStockPricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAll.SuspendLayout()
        CType(Me.dvgMatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAllStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistory.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImport.SuspendLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPreferences.SuspendLayout()
        Me.tabWatchlist.SuspendLayout()
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
        Me.tbcMain.Controls.Add(Me.tabWatchlist)
        Me.tbcMain.Location = New System.Drawing.Point(12, 12)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(1023, 548)
        Me.tbcMain.TabIndex = 0
        '
        'tabFront
        '
        Me.tabFront.Controls.Add(Me.dgvFrontPage)
        Me.tabFront.Location = New System.Drawing.Point(4, 22)
        Me.tabFront.Name = "tabFront"
        Me.tabFront.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabFront.Size = New System.Drawing.Size(1015, 522)
        Me.tabFront.TabIndex = 0
        Me.tabFront.Text = "Front Page"
        Me.tabFront.UseVisualStyleBackColor = True
        '
        'dgvFrontPage
        '
        Me.dgvFrontPage.AutoGenerateColumns = False
        Me.dgvFrontPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFrontPage.DataSource = Me.DailyStockPricesBindingSource
        Me.dgvFrontPage.Location = New System.Drawing.Point(7, 7)
        Me.dgvFrontPage.Name = "dgvFrontPage"
        Me.dgvFrontPage.Size = New System.Drawing.Size(1002, 509)
        Me.dgvFrontPage.TabIndex = 3
        '
        'DailyStockPricesBindingSource
        '
        Me.DailyStockPricesBindingSource.DataMember = "Daily_Stock_Prices"
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.dvgMatch)
        Me.tabAll.Controls.Add(Me.prgrssAllStocks)
        Me.tabAll.Controls.Add(Me.Label1)
        Me.tabAll.Controls.Add(Me.dspAllStockStatus)
        Me.tabAll.Controls.Add(Me.Button1)
        Me.tabAll.Controls.Add(Me.dgvAllStocks)
        Me.tabAll.Location = New System.Drawing.Point(4, 22)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabAll.Size = New System.Drawing.Size(1015, 522)
        Me.tabAll.TabIndex = 1
        Me.tabAll.Text = "All Stocks"
        Me.tabAll.UseVisualStyleBackColor = True
        '
        'dvgMatch
        '
        Me.dvgMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMatch.Location = New System.Drawing.Point(8, 36)
        Me.dvgMatch.Name = "dvgMatch"
        Me.dvgMatch.Size = New System.Drawing.Size(1001, 445)
        Me.dvgMatch.TabIndex = 6
        Me.dvgMatch.Visible = False
        '
        'prgrssAllStocks
        '
        Me.prgrssAllStocks.Location = New System.Drawing.Point(61, 489)
        Me.prgrssAllStocks.Name = "prgrssAllStocks"
        Me.prgrssAllStocks.Size = New System.Drawing.Size(286, 22)
        Me.prgrssAllStocks.TabIndex = 5
        Me.prgrssAllStocks.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Status :"
        '
        'dspAllStockStatus
        '
        Me.dspAllStockStatus.Enabled = False
        Me.dspAllStockStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dspAllStockStatus.Location = New System.Drawing.Point(61, 489)
        Me.dspAllStockStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dspAllStockStatus.Name = "dspAllStockStatus"
        Me.dspAllStockStatus.ReadOnly = True
        Me.dspAllStockStatus.Size = New System.Drawing.Size(286, 22)
        Me.dspAllStockStatus.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(915, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Filter stocks"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvAllStocks
        '
        Me.dgvAllStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllStocks.Location = New System.Drawing.Point(8, 37)
        Me.dgvAllStocks.Name = "dgvAllStocks"
        Me.dgvAllStocks.Size = New System.Drawing.Size(1001, 444)
        Me.dgvAllStocks.TabIndex = 1
        '
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.cboCompanyName)
        Me.tabHistory.Controls.Add(Me.lblCompany)
        Me.tabHistory.Controls.Add(Me.dgvHistory)
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
        'dgvHistory
        '
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Location = New System.Drawing.Point(6, 33)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.Size = New System.Drawing.Size(1003, 483)
        Me.dgvHistory.TabIndex = 0
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
        Me.tabImport.Location = New System.Drawing.Point(4, 22)
        Me.tabImport.Name = "tabImport"
        Me.tabImport.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabImport.Size = New System.Drawing.Size(1015, 522)
        Me.tabImport.TabIndex = 3
        Me.tabImport.Text = "Import"
        Me.tabImport.UseVisualStyleBackColor = True
        '
        'prgrssImportScreen
        '
        Me.prgrssImportScreen.Location = New System.Drawing.Point(61, 489)
        Me.prgrssImportScreen.Name = "prgrssImportScreen"
        Me.prgrssImportScreen.Size = New System.Drawing.Size(286, 22)
        Me.prgrssImportScreen.TabIndex = 12
        Me.prgrssImportScreen.Visible = False
        '
        'lblFile
        '
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(8, 8)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(38, 22)
        Me.lblFile.TabIndex = 9
        Me.lblFile.Text = "File :"
        '
        'dspStatus
        '
        Me.dspStatus.Enabled = False
        Me.dspStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dspStatus.Location = New System.Drawing.Point(61, 489)
        Me.dspStatus.Name = "dspStatus"
        Me.dspStatus.ReadOnly = True
        Me.dspStatus.Size = New System.Drawing.Size(286, 22)
        Me.dspStatus.TabIndex = 8
        Me.dspStatus.Text = "Please find a .txt or .csv file.."
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(8, 491)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(51, 16)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status :"
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(929, 5)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(80, 25)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'dspFileLocation
        '
        Me.dspFileLocation.Enabled = False
        Me.dspFileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dspFileLocation.Location = New System.Drawing.Point(48, 7)
        Me.dspFileLocation.Name = "dspFileLocation"
        Me.dspFileLocation.ReadOnly = True
        Me.dspFileLocation.Size = New System.Drawing.Size(782, 22)
        Me.dspFileLocation.TabIndex = 5
        '
        'btnImportFile
        '
        Me.btnImportFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportFile.Location = New System.Drawing.Point(845, 5)
        Me.btnImportFile.Name = "btnImportFile"
        Me.btnImportFile.Size = New System.Drawing.Size(80, 25)
        Me.btnImportFile.TabIndex = 4
        Me.btnImportFile.Text = "Find File"
        Me.btnImportFile.UseVisualStyleBackColor = True
        '
        'dgvImport
        '
        Me.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImport.Location = New System.Drawing.Point(8, 37)
        Me.dgvImport.Name = "dgvImport"
        Me.dgvImport.ReadOnly = True
        Me.dgvImport.Size = New System.Drawing.Size(1001, 444)
        Me.dgvImport.TabIndex = 3
        '
        'tabPreferences
        '
        Me.tabPreferences.Controls.Add(Me.btnNewLocation)
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
        'btnNewLocation
        '
        Me.btnNewLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewLocation.Location = New System.Drawing.Point(333, 40)
        Me.btnNewLocation.Name = "btnNewLocation"
        Me.btnNewLocation.Size = New System.Drawing.Size(194, 25)
        Me.btnNewLocation.TabIndex = 5
        Me.btnNewLocation.Text = "Choose New Location"
        Me.btnNewLocation.UseVisualStyleBackColor = True
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
        Me.txtDfltFilePath.ReadOnly = True
        Me.txtDfltFilePath.Size = New System.Drawing.Size(208, 20)
        Me.txtDfltFilePath.TabIndex = 0
        '
        'tabWatchlist
        '
        Me.tabWatchlist.Controls.Add(Me.SplitContainer1)
        Me.tabWatchlist.Location = New System.Drawing.Point(4, 22)
        Me.tabWatchlist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabWatchlist.Name = "tabWatchlist"
        Me.tabWatchlist.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabWatchlist.Size = New System.Drawing.Size(1015, 522)
        Me.tabWatchlist.TabIndex = 5
        Me.tabWatchlist.Text = "Watchlist"
        Me.tabWatchlist.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 5)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(764, 515)
        Me.SplitContainer1.SplitterDistance = 250
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASX Share Market Analysis Tool"
        Me.tbcMain.ResumeLayout(False)
        Me.tabFront.ResumeLayout(False)
        CType(Me.dgvFrontPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyStockPricesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAll.ResumeLayout(False)
        Me.tabAll.PerformLayout()
        CType(Me.dvgMatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAllStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistory.ResumeLayout(False)
        Me.tabHistory.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImport.ResumeLayout(False)
        Me.tabImport.PerformLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPreferences.ResumeLayout(False)
        Me.tabPreferences.PerformLayout()
        Me.tabWatchlist.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcMain As TabControl
    Friend WithEvents tabFront As TabPage
    Friend WithEvents tabAll As TabPage
    Friend WithEvents dgvAllStocks As DataGridView
    Friend WithEvents tabHistory As TabPage
    Friend WithEvents tabImport As TabPage
    Friend WithEvents tabPreferences As TabPage
    Friend WithEvents dgvHistory As DataGridView
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
    Friend WithEvents dgvFrontPage As DataGridView
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
End Class
