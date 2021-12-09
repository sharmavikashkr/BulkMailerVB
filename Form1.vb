Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class BulkMailer
    Private Sub BulkMailer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click

        If WorkFolderPath.Text = "" Then
            StatusLabel.Text = "Please select the Work Folder"
            Return
        End If
        StatusLabel.Text = "Selected Work Folder: " + WorkFolderPath.Text

        Dim DT As DateTime = DateTime.Now
        Dim logFile As System.IO.StreamWriter

        logFile = My.Computer.FileSystem.OpenTextFileWriter(WorkFolderPath.Text + "\logs.txt", True)
        logFile.WriteLine(DT.ToString)
        logFile.WriteLine("Selected Work Folder: " + WorkFolderPath.Text)

        Dim APP As New Excel.Application
        Dim workbook As Excel.Workbook
        Dim worksheet As Excel.Worksheet

        Try
            workbook = APP.Workbooks.Open(WorkFolderPath.Text + "\Distributors.xlsx")
            worksheet = workbook.Worksheets("sheet1")

            Dim OutlookApp
            OutlookApp = CreateObject("outlook.Application")

            Dim Mail, DistributorCode
            Dim I As Integer
            Dim last_row As Integer

            last_row = APP.WorksheetFunction.CountA(worksheet.Range("A:A"))

            For I = 2 To last_row
                Mail = OutlookApp.createitem(0)
                DistributorCode = worksheet.Range("a" & I).Value
                Mail.TO = worksheet.Range("b" & I).Value
                Mail.CC = worksheet.Range("c" & I).Value
                Mail.Subject = worksheet.Range("d" & I).Value
                Mail.BODY = worksheet.Range("e" & I).Value

                StatusLabel.Text = "Processing Mail for Distributor: " + DistributorCode.ToString
                logFile.WriteLine("Processing Mail for Distributor: " + DistributorCode.ToString)

                Dim strFileSize As String = ""
                Dim di As New IO.DirectoryInfo(WorkFolderPath.Text)
                Dim aryFi As IO.FileInfo() = di.GetFiles("*.*")
                Dim fi As IO.FileInfo

                For Each fi In aryFi
                    strFileSize = (Math.Round(fi.Length / 1024)).ToString()
                    Console.WriteLine("File Name: {0}", fi.Name)
                    Console.WriteLine("File Full Name: {0}", fi.FullName)
                    Console.WriteLine("File Size (KB): {0}", strFileSize)
                    If fi.Name.StartsWith(DistributorCode.ToString + "_") Then
                        StatusLabel.Text = "Adding Attachment: " + fi.FullName + "for Distributor: " + DistributorCode.ToString
                        logFile.WriteLine("Adding Attachment: " + fi.FullName + "for Distributor: " + DistributorCode.ToString)
                        Mail.Attachments.Add(fi.FullName)
                    End If
                Next

                StatusLabel.Text = "Sending mail for distributor: " + DistributorCode.ToString
                logFile.WriteLine("Sending mail for distributor: " + DistributorCode.ToString)

                Mail.send

                StatusLabel.Text = "Delay 5 sec"
                logFile.WriteLine("Delay 5 sec")

                Threading.Thread.Sleep(5000)
                logFile.WriteLine("Delay over")
            Next
            logFile.WriteLine("Finished")
        Catch ex As Exception
            StatusLabel.Text = "Error Occurred: " + ex.Message
            logFile.WriteLine("Error Occurred: " + ex.Message)
        Finally
            workbook.Close()
            logFile.Close()
        End Try
    End Sub

    Private Sub WorkFolderDialogOpener_Click(sender As Object, e As EventArgs) Handles WorkFolderDialogOpener.Click
        If WorkFolderPicker.ShowDialog() = DialogResult.OK Then
            WorkFolderPath.Text = WorkFolderPicker.SelectedPath
        End If
    End Sub

    Private Sub WorkFolderPath_Cick(sender As Object, e As EventArgs) Handles WorkFolderPath.Click
        WorkFolderDialogOpener_Click(sender, e)
    End Sub
End Class
