Imports System
Imports System.IO

Imports System.Text
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Initialization subroutine

    End Sub

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

            TextFileReader.TextFieldType = FileIO.FieldType.Delimited
            TextFileReader.SetDelimiters(",")
            'Need to create table headers somewhere

            FileType = Path.GetExtension(OpenFileDialog1.FileName)

            If FileType = ".txt" Then
                'Handles importing a .txt file
                Dim CurrentRow As String()

                'Loops through the data and imports it into a table
                While Not TextFileReader.EndOfData
                    Try
                        'Adding the column names
                        CurrentRow = TextFileReader.ReadFields()
                        dgvImport.Columns.Add("ID", "ID")
                        dgvImport.Columns.Add("Date", "Date")
                        dgvImport.Columns.Add("Open", "Open")
                        dgvImport.Columns.Add("High", "High")
                        dgvImport.Columns.Add("Low", "Low")
                        dgvImport.Columns.Add("Close", "Close")
                        dgvImport.Columns.Add("Volume", "Volume")

                        'Adds the data in
                        dgvImport.Rows.Add(CurrentRow)
                    Catch ex As  _
                    Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                        "Is Not valid And will be skipped.")
                    End Try
                End While
                TextFileReader.Dispose() 'Removes TextFileReader for next time

            ElseIf FileType = ".csv" Then
                'handles importing a .csv file
                Dim sr As New IO.StreamReader(OpenFileDialog1.FileName)
                Dim dt As New DataTable
                Dim newline() As String = sr.ReadLine.Split(","c)
                dt.Columns.AddRange({New DataColumn(newline(0)),
                         New DataColumn(newline(1)),
                         New DataColumn(newline(2)),
                         New DataColumn(newline(3)),
                         New DataColumn(newline(4)),
                         New DataColumn(newline(5)),
                         New DataColumn(newline(6))})
                While (Not sr.EndOfStream)
                    newline = sr.ReadLine.Split(","c)
                    Dim newrow As DataRow = dt.NewRow
                    newrow.ItemArray = {newline(0), newline(1), newline(2), newline(3), newline(4), newline(5), newline(6)}
                    dt.Rows.Add(newrow)
                End While
                dgvImport.DataSource = dt
            Else
                MsgBox("Please select a .txt Or .csv type file")
            End If
        End If

    End Sub


End Class
