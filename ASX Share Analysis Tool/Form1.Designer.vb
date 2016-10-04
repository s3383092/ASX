﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.DailyStockPricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabPreferences = New System.Windows.Forms.TabPage()
        Me.txtDfltFilePath = New System.Windows.Forms.TextBox()
        Me.lblDfltFilePath = New System.Windows.Forms.Label()
        Me.btnNewLocation = New System.Windows.Forms.Button()
        Me.lblConfirmLocation = New System.Windows.Forms.Label()
        Me.btnResetLocation = New System.Windows.Forms.Button()
        Me.tabImport = New System.Windows.Forms.TabPage()
        Me.dgvImport = New System.Windows.Forms.DataGridView()
        Me.btnImportFile = New System.Windows.Forms.Button()
        Me.dspFileLocation = New System.Windows.Forms.TextBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dspStatus = New System.Windows.Forms.TextBox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.prgrssImportScreen = New System.Windows.Forms.ProgressBar()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.cboCompanyName = New System.Windows.Forms.ComboBox()
        Me.chrtHistory = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chkHistoryWatch = New System.Windows.Forms.CheckBox()
        Me.dgvHistoryStocks = New System.Windows.Forms.DataGridView()
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.dgvAllStocks = New System.Windows.Forms.DataGridView()
        Me.tabFront = New System.Windows.Forms.TabPage()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.dvgMatch = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dspAllStockStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prgrssAllStocks = New System.Windows.Forms.ProgressBar()
        Me.dgvFilterStocks = New System.Windows.Forms.DataGridView()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        CType(Me.DailyStockPricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPreferences.SuspendLayout()
        Me.tabImport.SuspendLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistory.SuspendLayout()
        CType(Me.chrtHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistoryStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAll.SuspendLayout()
        CType(Me.dgvAllStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFront.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgMatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFilterStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'DailyStockPricesBindingSource
        '
        Me.DailyStockPricesBindingSource.DataMember = "Daily_Stock_Prices"
        '
        'tabPreferences
        '
        Me.tabPreferences.Controls.Add(Me.btnResetLocation)
        Me.tabPreferences.Controls.Add(Me.lblConfirmLocation)
        Me.tabPreferences.Controls.Add(Me.btnNewLocation)
        Me.tabPreferences.Controls.Add(Me.lblDfltFilePath)
        Me.tabPreferences.Controls.Add(Me.txtDfltFilePath)
        Me.tabPreferences.Location = New System.Drawing.Point(4, 22)
        Me.tabPreferences.Name = "tabPreferences"
        Me.tabPreferences.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPreferences.Size = New System.Drawing.Size(1015, 522)
        Me.tabPreferences.TabIndex = 4
        Me.tabPreferences.Text = "Preferences"
        Me.tabPreferences.UseVisualStyleBackColor = True
        '
        'txtDfltFilePath
        '
        Me.txtDfltFilePath.Enabled = False
        Me.txtDfltFilePath.Location = New System.Drawing.Point(114, 44)
        Me.txtDfltFilePath.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDfltFilePath.Name = "txtDfltFilePath"
        Me.txtDfltFilePath.ReadOnly = True
        Me.txtDfltFilePath.Size = New System.Drawing.Size(208, 20)
        Me.txtDfltFilePath.TabIndex = 0
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
        'lblConfirmLocation
        '
        Me.lblConfirmLocation.Location = New System.Drawing.Point(157, 71)
        Me.lblConfirmLocation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmLocation.Name = "lblConfirmLocation"
        Me.lblConfirmLocation.Size = New System.Drawing.Size(115, 18)
        Me.lblConfirmLocation.TabIndex = 6
        '
        'btnResetLocation
        '
        Me.btnResetLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetLocation.Location = New System.Drawing.Point(533, 40)
        Me.btnResetLocation.Name = "btnResetLocation"
        Me.btnResetLocation.Size = New System.Drawing.Size(117, 25)
        Me.btnResetLocation.TabIndex = 7
        Me.btnResetLocation.Text = "Reset Location"
        Me.btnResetLocation.UseVisualStyleBackColor = True
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
        'dgvImport
        '
        Me.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImport.Location = New System.Drawing.Point(8, 37)
        Me.dgvImport.Name = "dgvImport"
        Me.dgvImport.ReadOnly = True
        Me.dgvImport.Size = New System.Drawing.Size(1001, 444)
        Me.dgvImport.TabIndex = 3
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
        'lblFile
        '
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(8, 8)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(38, 22)
        Me.lblFile.TabIndex = 9
        Me.lblFile.Text = "File :"
        '
        'prgrssImportScreen
        '
        Me.prgrssImportScreen.Location = New System.Drawing.Point(61, 489)
        Me.prgrssImportScreen.Name = "prgrssImportScreen"
        Me.prgrssImportScreen.Size = New System.Drawing.Size(286, 22)
        Me.prgrssImportScreen.TabIndex = 12
        Me.prgrssImportScreen.Visible = False
        '
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.dgvHistoryStocks)
        Me.tabHistory.Controls.Add(Me.chkHistoryWatch)
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
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(6, 9)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(82, 13)
        Me.lblCompany.TabIndex = 1
        Me.lblCompany.Text = "Company Name"
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
        'chrtHistory
        '
        Me.chrtHistory.BorderlineColor = System.Drawing.Color.Black
        Me.chrtHistory.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chrtHistory.BorderlineWidth = 3
        ChartArea1.Name = "ChartArea1"
        Me.chrtHistory.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtHistory.Legends.Add(Legend1)
        Me.chrtHistory.Location = New System.Drawing.Point(7, 34)
        Me.chrtHistory.Name = "chrtHistory"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Open"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Close"
        Me.chrtHistory.Series.Add(Series1)
        Me.chrtHistory.Series.Add(Series2)
        Me.chrtHistory.Size = New System.Drawing.Size(1002, 450)
        Me.chrtHistory.TabIndex = 4
        Me.chrtHistory.Text = "History"
        '
        'chkHistoryWatch
        '
        Me.chkHistoryWatch.AutoSize = True
        Me.chkHistoryWatch.Location = New System.Drawing.Point(657, 9)
        Me.chkHistoryWatch.Name = "chkHistoryWatch"
        Me.chkHistoryWatch.Size = New System.Drawing.Size(104, 17)
        Me.chkHistoryWatch.TabIndex = 5
        Me.chkHistoryWatch.Text = "Add to Watchlist"
        Me.chkHistoryWatch.UseVisualStyleBackColor = True
        Me.chkHistoryWatch.Visible = False
        '
        'dgvHistoryStocks
        '
        Me.dgvHistoryStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistoryStocks.Location = New System.Drawing.Point(7, 490)
        Me.dgvHistoryStocks.Name = "dgvHistoryStocks"
        Me.dgvHistoryStocks.Size = New System.Drawing.Size(1002, 29)
        Me.dgvHistoryStocks.TabIndex = 6
        Me.dgvHistoryStocks.Visible = False
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
        'dgvHistory
        '
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Location = New System.Drawing.Point(7, 34)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.Size = New System.Drawing.Size(1002, 450)
        Me.dgvHistory.TabIndex = 9
        Me.dgvHistory.Visible = False
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
        'prgrssAllStocks
        '
        Me.prgrssAllStocks.Location = New System.Drawing.Point(61, 489)
        Me.prgrssAllStocks.Name = "prgrssAllStocks"
        Me.prgrssAllStocks.Size = New System.Drawing.Size(286, 22)
        Me.prgrssAllStocks.TabIndex = 5
        Me.prgrssAllStocks.Visible = False
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
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tabFront)
        Me.tbcMain.Controls.Add(Me.tabAll)
        Me.tbcMain.Controls.Add(Me.tabHistory)
        Me.tbcMain.Controls.Add(Me.tabImport)
        Me.tbcMain.Controls.Add(Me.tabPreferences)
        Me.tbcMain.Location = New System.Drawing.Point(12, 12)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(1023, 548)
        Me.tbcMain.TabIndex = 0
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
        Me.tabPreferences.ResumeLayout(False)
        Me.tabPreferences.PerformLayout()
        Me.tabImport.ResumeLayout(False)
        Me.tabImport.PerformLayout()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistory.ResumeLayout(False)
        Me.tabHistory.PerformLayout()
        CType(Me.chrtHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistoryStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAll.ResumeLayout(False)
        CType(Me.dgvAllStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFront.ResumeLayout(False)
        Me.tabFront.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgMatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFilterStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcMain.ResumeLayout(False)
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
    Friend WithEvents tabPreferences As TabPage
    Friend WithEvents btnResetLocation As Button
    Friend WithEvents lblConfirmLocation As Label
    Friend WithEvents btnNewLocation As Button
    Friend WithEvents lblDfltFilePath As Label
    Friend WithEvents txtDfltFilePath As TextBox
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
    Friend WithEvents chkHistoryWatch As CheckBox
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
End Class
