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
                Dim TextFileTable As DataTable = Nothing
                Dim CurrentRow As String()

                While Not TextFileReader.EndOfData
                    Try
                        CurrentRow = TextFileReader.ReadFields()
                        dgvImport.Columns.Add("ID", "ID")
                        dgvImport.Columns.Add("Date", "Date")
                        dgvImport.Columns.Add("Open", "Open")
                        dgvImport.Columns.Add("High", "High")
                        dgvImport.Columns.Add("Low", "Low")
                        dgvImport.Columns.Add("Close", "Close")
                        dgvImport.Columns.Add("Volume", "Volume")

                        dgvImport.Rows.Add(CurrentRow)
                    Catch ex As _
                    Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                        "Is Not valid And will be skipped.")
                    End Try
                End While
                TextFileReader.Dispose()



            ElseIf FileType = ".csv" Then
                MsgBox("CSV")
            Else
                MsgBox("Please select a .txt Or .csv type file")
            End If

        End If

    End Sub

    'Private Sub ExtractCSV()
    '    Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C: \Documents and Settings\...\My Documents\My Database\Text\SemiColonDelimited.txt")

    '    TextFileReader.TextFieldType = FileIO.FieldType.Delimited
    '    TextFileReader.SetDelimiters(";")

    '    Dim TextFileTable As DataTable = Nothing
    '    Dim Column As DataColumn
    '    Dim Row As DataRow
    '    Dim UpperBound As Int32
    '    Dim ColumnCount As Int32
    '    Dim CurrentRow As String()

    '    While Not TextFileReader.EndOfData
    '        Try
    '            CurrentRow = TextFileReader.ReadFields()
    '            If Not CurrentRow Is Nothing Then
    '                ''# Check if DataTable has been created
    '                If TextFileTable Is Nothing Then
    '                    TextFileTable = New DataTable("TextFileTable")
    '                    ''# Get number of columns
    '                    UpperBound = CurrentRow.GetUpperBound(0)
    '                    ''# Create new DataTable
    '                    For ColumnCount = 0 To UpperBound
    '                        Column = New DataColumn()
    '                        Column.DataType = System.Type.GetType("System.String")
    '                        Column.ColumnName = "Column" & ColumnCount
    '                        Column.Caption = "Column" & ColumnCount
    '                        Column.ReadOnly = True
    '                        Column.Unique = False
    '                        TextFileTable.Columns.Add(Column)
    '                    Next
    '                End If
    '                Row = TextFileTable.NewRow
    '                For ColumnCount = 0 To UpperBound
    '                    Row("Column" & ColumnCount) = CurrentRow(ColumnCount).ToString
    '                Next
    '                TextFileTable.Rows.Add(Row)
    '            End If
    '        Catch ex As _
    '        Microsoft.VisualBasic.FileIO.MalformedLineException
    '            MsgBox("Line " & ex.Message &
    '            "is not valid and will be skipped.")
    '        End Try
    '    End While
    '    TextFileReader.Dispose()
    '    frmMain.DataGrid1.DataSource = TextFileTable
    'End Sub

End Class
