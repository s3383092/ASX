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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.DailyStockPricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabImport = New System.Windows.Forms.TabPage()
        Me.prgrssImportScreen = New System.Windows.Forms.ProgressBar()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.dspStatus = New System.Windows.Forms.TextBox()
        Me.dspFileLocation = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnImportFile = New System.Windows.Forms.Button()
        Me.dgvImport = New System.Windows.Forms.DataGridView()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.chrtVolume = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.dtpHistory = New System.Windows.Forms.DateTimePicker()
        Me.dgvHistoryStocks = New System.Windows.Forms.DataGridView()
        Me.chrtHistory = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cboCompanyName = New System.Windows.Forms.ComboBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.dgvAllStocks = New System.Windows.Forms.DataGridView()
        Me.tabFront = New System.Windows.Forms.TabPage()
        Me.btnDisplayTop10 = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.dgvFilterStocks = New System.Windows.Forms.DataGridView()
        Me.prgrssAllStocks = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dspAllStockStatus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dvgMatch = New System.Windows.Forms.DataGridView()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tabTopTen = New System.Windows.Forms.TabPage()
        Me.dgvTop = New System.Windows.Forms.DataGridView()
        CType(Me.DailyStockPricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabImport.SuspendLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistory.SuspendLayout()
        CType(Me.chrtVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistoryStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAll.SuspendLayout()
        CType(Me.dgvAllStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFront.SuspendLayout()
        CType(Me.dgvFilterStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgMatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcMain.SuspendLayout()
        Me.tabTopTen.SuspendLayout()
        CType(Me.dgvTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DailyStockPricesBindingSource
        '
        Me.DailyStockPricesBindingSource.DataMember = "Daily_Stock_Prices"
        '
        'tabImport
        '
        Me.tabImport.Controls.Add(Me.prgrssImportScreen)
        Me.tabImport.Controls.Add(Me.lblFile)
        Me.tabImport.Controls.Add(Me.dspStatus)
        Me.tabImport.Controls.Add(Me.dspFileLocation)
        Me.tabImport.Controls.Add(Me.lblStatus)
        Me.tabImport.Controls.Add(Me.btnImport)
        Me.tabImport.Controls.Add(Me.btnImportFile)
        Me.tabImport.Controls.Add(Me.dgvImport)
        Me.tabImport.Location = New System.Drawing.Point(4, 22)
        Me.tabImport.Name = "tabImport"
        Me.tabImport.Padding = New System.Windows.Forms.Padding(3)
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
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.lblVolume)
        Me.tabHistory.Controls.Add(Me.chrtVolume)
        Me.tabHistory.Controls.Add(Me.btnHistory)
        Me.tabHistory.Controls.Add(Me.dtpHistory)
        Me.tabHistory.Controls.Add(Me.dgvHistoryStocks)
        Me.tabHistory.Controls.Add(Me.chrtHistory)
        Me.tabHistory.Controls.Add(Me.cboCompanyName)
        Me.tabHistory.Controls.Add(Me.lblCompany)
        Me.tabHistory.Location = New System.Drawing.Point(4, 22)
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHistory.Size = New System.Drawing.Size(1015, 522)
        Me.tabHistory.TabIndex = 2
        Me.tabHistory.Text = "History"
        Me.tabHistory.UseVisualStyleBackColor = True
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(6, 377)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(160, 25)
        Me.lblVolume.TabIndex = 10
        Me.lblVolume.Text = "Volume Traded"
        '
        'chrtVolume
        '
        Me.chrtVolume.BorderlineColor = System.Drawing.Color.Black
        Me.chrtVolume.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chrtVolume.BorderlineWidth = 3
        ChartArea5.Name = "ChartArea1"
        Me.chrtVolume.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.chrtVolume.Legends.Add(Legend5)
        Me.chrtVolume.Location = New System.Drawing.Point(6, 405)
        Me.chrtVolume.Name = "chrtVolume"
        Me.chrtVolume.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Volume"
        Me.chrtVolume.Series.Add(Series7)
        Me.chrtVolume.Size = New System.Drawing.Size(1006, 111)
        Me.chrtVolume.TabIndex = 9
        Me.chrtVolume.Text = "Volume Traded"
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(713, 3)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnHistory.TabIndex = 8
        Me.btnHistory.Text = "Graph"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'dtpHistory
        '
        Me.dtpHistory.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHistory.Location = New System.Drawing.Point(507, 4)
        Me.dtpHistory.Name = "dtpHistory"
        Me.dtpHistory.Size = New System.Drawing.Size(200, 20)
        Me.dtpHistory.TabIndex = 7
        '
        'dgvHistoryStocks
        '
        Me.dgvHistoryStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistoryStocks.Location = New System.Drawing.Point(9, 413)
        Me.dgvHistoryStocks.Name = "dgvHistoryStocks"
        Me.dgvHistoryStocks.Size = New System.Drawing.Size(1002, 29)
        Me.dgvHistoryStocks.TabIndex = 6
        Me.dgvHistoryStocks.Visible = False
        '
        'chrtHistory
        '
        Me.chrtHistory.BorderlineColor = System.Drawing.Color.Black
        Me.chrtHistory.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chrtHistory.BorderlineWidth = 3
        ChartArea6.Name = "ChartArea1"
        Me.chrtHistory.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.chrtHistory.Legends.Add(Legend6)
        Me.chrtHistory.Location = New System.Drawing.Point(7, 34)
        Me.chrtHistory.Name = "chrtHistory"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Legend = "Legend1"
        Series8.Name = "Open"
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series9.Legend = "Legend1"
        Series9.Name = "Close"
        Me.chrtHistory.Series.Add(Series8)
        Me.chrtHistory.Series.Add(Series9)
        Me.chrtHistory.Size = New System.Drawing.Size(1002, 340)
        Me.chrtHistory.TabIndex = 4
        Me.chrtHistory.Text = "History"
        '
        'cboCompanyName
        '
        Me.cboCompanyName.FormattingEnabled = True
        Me.cboCompanyName.Items.AddRange(New Object() {"Please select a company"})
        Me.cboCompanyName.Location = New System.Drawing.Point(94, 3)
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
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.dgvAllStocks)
        Me.tabAll.Location = New System.Drawing.Point(4, 22)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAll.Size = New System.Drawing.Size(1015, 522)
        Me.tabAll.TabIndex = 0
        Me.tabAll.Text = "All Stocks"
        Me.tabAll.UseVisualStyleBackColor = True
        '
        'dgvAllStocks
        '
        Me.dgvAllStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllStocks.Location = New System.Drawing.Point(7, 34)
        Me.dgvAllStocks.Name = "dgvAllStocks"
        Me.dgvAllStocks.ReadOnly = True
        Me.dgvAllStocks.Size = New System.Drawing.Size(1002, 450)
        Me.dgvAllStocks.TabIndex = 8
        '
        'tabFront
        '
        Me.tabFront.Controls.Add(Me.btnDisplayTop10)
        Me.tabFront.Controls.Add(Me.lblResults)
        Me.tabFront.Controls.Add(Me.lblPreview)
        Me.tabFront.Controls.Add(Me.dgvFilterStocks)
        Me.tabFront.Controls.Add(Me.prgrssAllStocks)
        Me.tabFront.Controls.Add(Me.Label1)
        Me.tabFront.Controls.Add(Me.dspAllStockStatus)
        Me.tabFront.Controls.Add(Me.Button1)
        Me.tabFront.Controls.Add(Me.dvgMatch)
        Me.tabFront.Controls.Add(Me.dgvHistory)
        Me.tabFront.Location = New System.Drawing.Point(4, 22)
        Me.tabFront.Name = "tabFront"
        Me.tabFront.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFront.Size = New System.Drawing.Size(1015, 522)
        Me.tabFront.TabIndex = 1
        Me.tabFront.Text = "Front Page"
        Me.tabFront.UseVisualStyleBackColor = True
        '
        'btnDisplayTop10
        '
        Me.btnDisplayTop10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayTop10.Location = New System.Drawing.Point(801, 5)
        Me.btnDisplayTop10.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplayTop10.Name = "btnDisplayTop10"
        Me.btnDisplayTop10.Size = New System.Drawing.Size(110, 25)
        Me.btnDisplayTop10.TabIndex = 12
        Me.btnDisplayTop10.Text = "Display top 10"
        Me.btnDisplayTop10.UseVisualStyleBackColor = True
        Me.btnDisplayTop10.Visible = False
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(58, 16)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(49, 13)
        Me.lblResults.TabIndex = 11
        Me.lblResults.Text = "Results"
        Me.lblResults.Visible = False
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.Location = New System.Drawing.Point(7, 16)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(52, 13)
        Me.lblPreview.TabIndex = 10
        Me.lblPreview.Text = "Preview"
        '
        'dgvFilterStocks
        '
        Me.dgvFilterStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFilterStocks.Enabled = False
        Me.dgvFilterStocks.Location = New System.Drawing.Point(7, 34)
        Me.dgvFilterStocks.Name = "dgvFilterStocks"
        Me.dgvFilterStocks.ReadOnly = True
        Me.dgvFilterStocks.Size = New System.Drawing.Size(1002, 450)
        Me.dgvFilterStocks.TabIndex = 8
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
        Me.dspAllStockStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.dspAllStockStatus.Name = "dspAllStockStatus"
        Me.dspAllStockStatus.ReadOnly = True
        Me.dspAllStockStatus.Size = New System.Drawing.Size(286, 22)
        Me.dspAllStockStatus.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(915, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Filter stocks"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dvgMatch
        '
        Me.dvgMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMatch.Location = New System.Drawing.Point(8, 35)
        Me.dvgMatch.Name = "dvgMatch"
        Me.dvgMatch.Size = New System.Drawing.Size(1001, 445)
        Me.dvgMatch.TabIndex = 6
        Me.dvgMatch.Visible = False
        '
        'dgvHistory
        '
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Location = New System.Drawing.Point(7, 34)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.Size = New System.Drawing.Size(1002, 450)
        Me.dgvHistory.TabIndex = 9
        Me.dgvHistory.Visible = False
        '
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tabFront)
        Me.tbcMain.Controls.Add(Me.tabAll)
        Me.tbcMain.Controls.Add(Me.tabHistory)
        Me.tbcMain.Controls.Add(Me.tabImport)
        Me.tbcMain.Controls.Add(Me.tabTopTen)
        Me.tbcMain.Location = New System.Drawing.Point(12, 12)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(1023, 548)
        Me.tbcMain.TabIndex = 0
        '
        'tabTopTen
        '
        Me.tabTopTen.Controls.Add(Me.dgvTop)
        Me.tabTopTen.Location = New System.Drawing.Point(4, 22)
        Me.tabTopTen.Name = "tabTopTen"
        Me.tabTopTen.Size = New System.Drawing.Size(1015, 522)
        Me.tabTopTen.TabIndex = 4
        Me.tabTopTen.Text = "Top 10"
        Me.tabTopTen.UseVisualStyleBackColor = True
        '
        'dgvTop
        '
        Me.dgvTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTop.Location = New System.Drawing.Point(14, 38)
        Me.dgvTop.Name = "dgvTop"
        Me.dgvTop.Size = New System.Drawing.Size(981, 451)
        Me.dgvTop.TabIndex = 0
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
        CType(Me.DailyStockPricesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabImport.ResumeLayout(False)
        Me.tabImport.PerformLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistory.ResumeLayout(False)
        Me.tabHistory.PerformLayout()
        CType(Me.chrtVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistoryStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAll.ResumeLayout(False)
        CType(Me.dgvAllStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFront.ResumeLayout(False)
        Me.tabFront.PerformLayout()
        CType(Me.dgvFilterStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgMatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcMain.ResumeLayout(False)
        Me.tabTopTen.ResumeLayout(False)
        CType(Me.dgvTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents tabImport As TabPage
    Friend WithEvents prgrssImportScreen As ProgressBar
    Friend WithEvents lblFile As Label
    Friend WithEvents dspStatus As TextBox
    Friend WithEvents dspFileLocation As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents btnImportFile As Button
    Friend WithEvents dgvImport As DataGridView
    Friend WithEvents tabHistory As TabPage
    Friend WithEvents dgvHistoryStocks As DataGridView
    Friend WithEvents chrtHistory As DataVisualization.Charting.Chart
    Friend WithEvents cboCompanyName As ComboBox
    Friend WithEvents lblCompany As Label
    Friend WithEvents tabAll As TabPage
    Friend WithEvents dgvAllStocks As DataGridView
    Friend WithEvents tabFront As TabPage
    Friend WithEvents lblResults As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents dgvFilterStocks As DataGridView
    Friend WithEvents prgrssAllStocks As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents dspAllStockStatus As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dvgMatch As DataGridView
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents tbcMain As TabControl
    Friend WithEvents btnHistory As Button
    Friend WithEvents dtpHistory As DateTimePicker
    Friend WithEvents chrtVolume As DataVisualization.Charting.Chart
    Friend WithEvents lblVolume As Label
    Friend WithEvents tabTopTen As TabPage
    Friend WithEvents btnDisplayTop10 As Button
    Friend WithEvents dgvTop As DataGridView
End Class
