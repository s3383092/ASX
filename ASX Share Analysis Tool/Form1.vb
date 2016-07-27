Imports System
Imports System.IO

Imports System.Text
Public Class Form1
    Dim lsData As New List(Of Hashtable)
    Dim iCurrentIndex As Integer
    'The two variables listed above need to be public because used in Controller

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

            Call ClearDGVImport()

            If FileType = ".txt" Then
                'Handles importing a .txt file
                'Adding the column names
                dgvImport.Columns.Add("ID", "ID")
                dgvImport.Columns.Add("Date", "Date")
                dgvImport.Columns.Add("Open", "Open")
                dgvImport.Columns.Add("High", "High")
                dgvImport.Columns.Add("Low", "Low")
                dgvImport.Columns.Add("Close", "Close")
                dgvImport.Columns.Add("Volume", "Volume")

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
        Dim htData As Hashtable = New Hashtable
        Dim iImportRows As Integer = 0
        Dim iRowCnt As Int32 = 0
        Dim sString As String = ""
        'instantiating a hashtable which will pass the varaibles to the insert function

        '??Need to find way to convert .txt or .csv file information into the below hashtable.??
        'EDT DEL START
        'htData("SecurityCode") =
        'htData("SecurityDate") =
        'htData("OpeningPrice") =
        'htData("HighSalesPrice") =
        'htData("LowSalesPrice") =
        'htData("TotalVolume") = 
        'EDT DEL FIN

        iImportRows = dgvImport.Rows.Count()

        'If iImportRows <> 0 Then
        '    For iRowCnt = 1 To iImportRows
        '        htData("SecurityCode") = dgvImport.Rows(iRowCnt).Cells(1).Value
        '        htData("SecurityDate") = dgvImport.Rows(iRowCnt).Cells(2).Value
        '        htData("OpeningPrice") = dgvImport.Rows(iRowCnt).Cells(3).Value
        '        htData("HighSalesPrice") = dgvImport.Rows(iRowCnt).Cells(4).Value
        '        htData("LowSalesPrice") = dgvImport.Rows(iRowCnt).Cells(5).Value
        '        htData("TotalVolume") = dgvImport.Rows(iRowCnt).Cells(6).Value
        '    Next
        'End If

        'Console.Write(htData)

        Dim Data As New List(Of String())
        For Each r As DataGridViewRow In dgvImport.Rows
            If r.Cells(0).Value IsNot Nothing Then
                Data.Add(r.Cells(0).Value.ToString().Split(","c))
            End If
        Next

        Console.Write(Data)

        'EDT DEL START
        'Dim oStockcontroller As StockController = New StockController
        'Dim iNumRows = oStockcontroller.insertStock(htData)
        'EDT DEL FIN
        'Passes the above hastable into insert stock function located in StockController

        ' Debug.Print(CStr(iNumRows))
        'Debugging information
    End Sub

    Private Sub ClearDGVImport()
        dgvImport.Rows.Clear()
        dgvImport.Columns.Clear()
    End Sub

End Class


