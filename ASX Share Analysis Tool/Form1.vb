﻿Imports System
Imports System.IO
Imports System.Data.OleDb
Imports System.Text

Public Class Form1
    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnImportFile.Click 'Handle importing data
        Dim OpenFileDialog1 As New OpenFileDialog()
        Dim FileType As String
        'Opens the Open File explorer dialog
        OpenFileDialog1.Title = "Please Select a File"
        'OpenFileDialog1.InitialDirectory = "C:\Users\Downloads" 'Default file location
        OpenFileDialog1.Multiselect = False 'Disable Multiselect

        'Handles opening the file
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(OpenFileDialog1.FileName)
            Dim CurrentRow As String()

            TextFileReader.TextFieldType = FileIO.FieldType.Delimited
            TextFileReader.SetDelimiters(",")
            FileType = Path.GetExtension(OpenFileDialog1.FileName)

            dspFileLocation.Text = OpenFileDialog1.FileName

            Dim sInsightTrader As String = "InsightTrader"
            Dim TestPos As Integer = 0

            TestPos = InStr(1, OpenFileDialog1.FileName, sInsightTrader, CompareMethod.Text) 'Checks if the user has chosen an Insight Trader file type

            ' Changes a delimiter type to a space, because InsightTrader is a stupid file type
            If TestPos <> 0 Then
                TextFileReader.SetDelimiters(" ")
            End If

            Call ClearDGVImport()

            If FileType = ".txt" Then
                'Handles importing a .txt file
                'Adding the column names
                dgvImport.Columns.Add("ID", "Security Code")
                dgvImport.Columns.Add("Date", "Date")
                dgvImport.Columns.Add("Open", "Opening Price")
                dgvImport.Columns.Add("High", "High Sale price")
                dgvImport.Columns.Add("Low", "Low Sale Price")
                dgvImport.Columns.Add("Close", "Closing Price")
                dgvImport.Columns.Add("Volume", "Total Volume Traded")

                'Loops through the data and imports it into a table
                While Not TextFileReader.EndOfData
                    Try
                        CurrentRow = TextFileReader.ReadFields() 'Declares the Row to be added
                        dgvImport.Rows.Add(CurrentRow) 'Adds the data in
                    Catch ex As _
                Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                    "Is Not valid And will be skipped.")
                    End Try
                End While
                TextFileReader.Dispose() 'Removes TextFileReader for next time

            ElseIf FileType = ".csv" Then
                'handles importing a .csv file
                Dim sr As New IO.StreamReader(OpenFileDialog1.FileName)
                Dim dtImport As New DataTable
                Dim newline() As String = sr.ReadLine.Split(","c)
                dtImport.Columns.AddRange({New DataColumn(newline(0)),
                     New DataColumn(newline(1)),
                     New DataColumn(newline(2)),
                     New DataColumn(newline(3)),
                     New DataColumn(newline(4)),
                     New DataColumn(newline(5)),
                     New DataColumn(newline(6))})
                While (Not sr.EndOfStream)
                    newline = sr.ReadLine.Split(","c)
                    Dim newrow As DataRow = dtImport.NewRow
                    newrow.ItemArray = {newline(0), newline(1), newline(2), newline(3), newline(4), newline(5), newline(6)}
                    dtImport.Rows.Add(newrow)
                End While
                dgvImport.DataSource = dtImport
            Else
                MsgBox("Please select a .txt or .csv type file")
            End If
        End If

    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim Response = MsgBox("Are you sure you want to import this into the database?", vbYesNo, "Please confirm importing")
        If Response = MsgBoxResult.Yes Then
            'Show loading cursor and please wait
            lblPleaseWait.Show()
            Cursor.Current = Cursors.WaitCursor

            Dim MyChar() As Char = {"b", "i", "n", "\", "D", "e", "b", "u", "g"}
            Dim path As String = Environment.CurrentDirectory
            Dim newpath As String = path.TrimEnd(MyChar)
            Dim CON_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & newpath & "\ASXShareMarketAnalysisTool.accdb"
            Dim myConnection As OleDbConnection = New OleDbConnection(CON_STRING)
            'instantiates a connection object

            'temporary variables declared which pull data from grid 
            Dim sSecurityCode As String
            Dim sSecurityDate As String
            Dim sOpeningPrice As String
            Dim sHighSalePrice As String
            Dim sLowSalePrice As String
            Dim sClosingPrice As String
            Dim sTotalVolume As String

            'Once variables loaded with grid data convert to relative format and stored in variables above
            Dim dtSecurityDate As Date
            Dim dblOpeningPrice As Double
            Dim dblHighSalePrice As Double
            Dim dblLowSalePrice As Double
            Dim dblClosingPrice As Double
            Dim iTotalVolume As Integer

            'Variables required for loop and SQL injection query
            Dim sqlQuery As String
            Dim iCounter As Integer
            Dim iCountRows As Integer

            Try
                Debug.Print("Connection String: " & myConnection.ConnectionString)
                'Try/catch/finally is code  structure which facilitates the hnadling of execeptions that may occur in the program

                myConnection.Open()
                'open connection to access

                iCountRows = dgvImport.Rows.Count - 2
                iCounter = 0
                'Variables that will count through data grid view untill end of grid

                For iCounter = 0 To iCountRows
                    sSecurityCode = dgvImport.Rows(iCounter).Cells(0).Value
                    sSecurityDate = dgvImport.Rows(iCounter).Cells(1).Value
                    sOpeningPrice = dgvImport.Rows(iCounter).Cells(2).Value
                    sHighSalePrice = dgvImport.Rows(iCounter).Cells(3).Value
                    sLowSalePrice = dgvImport.Rows(iCounter).Cells(4).Value
                    sClosingPrice = dgvImport.Rows(iCounter).Cells(5).Value
                    sTotalVolume = dgvImport.Rows(iCounter).Cells(6).Value
                    'Count through one row and store in temporary variable

                    dtSecurityDate = CDate(sSecurityDate)
                    dblOpeningPrice = CDbl(sOpeningPrice)
                    dblHighSalePrice = CDbl(sHighSalePrice)
                    dblLowSalePrice = CDbl(sLowSalePrice)
                    dblClosingPrice = CDbl(sClosingPrice)
                    iTotalVolume = CInt(sTotalVolume)
                    'Convert temporary data to correct format for Access

                    sqlQuery = "INSERT INTO Daily_Stock_Prices (security_code, security_date, opening_price, high_sale_price, low_sale_price, closing_price, total_volume) VALUES (?, ?, ?, ?, ?, ?, ?)"
                    Using cmd As New OleDbCommand(sqlQuery, myConnection)
                        cmd.Parameters.AddWithValue("?", sSecurityCode)
                        cmd.Parameters.AddWithValue("?", dtSecurityDate)
                        cmd.Parameters.AddWithValue("?", dblOpeningPrice)
                        cmd.Parameters.AddWithValue("?", dblHighSalePrice)
                        cmd.Parameters.AddWithValue("?", dblLowSalePrice)
                        cmd.Parameters.AddWithValue("?", dblClosingPrice)
                        cmd.Parameters.AddWithValue("?", iTotalVolume)

                        'SQL statement which inserts Access tables(on left) with Variables(on right)
                        cmd.ExecuteNonQuery()
                    End Using
                Next
                'loop till end of data grid

                dspStatus.Text = "Import successful!"
                'Display import successfull in text box otherwise display errors outlined below
            Catch ex As OleDb.OleDbException
                dspStatus.Text = MsgBoxStyle.Critical & "Oledb Error"
            Catch ex As Exception
                dspStatus.Text = MsgBoxStyle.Critical & "General Error"
            Finally
                myConnection.Close()
            End Try

            lblPleaseWait.Hide()
            'Once import is complete hide "please wait"

        Else
            MsgBox("Importing has been aborted",, "Abort")
        End If

    End Sub

    Private Sub ClearDGVImport()
        dgvImport.Rows.Clear()
        dgvImport.Columns.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ASXShareMarketAnalysisToolDataSet2.Daily_Stock_Prices' table. You can move, or remove it, as needed.
        Me.Daily_Stock_PricesTableAdapter.Fill(Me.ASXShareMarketAnalysisToolDataSet2.Daily_Stock_Prices)

    End Sub

End Class


