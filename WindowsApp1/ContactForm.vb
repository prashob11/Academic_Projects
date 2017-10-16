'  File ContactForm
'  Sample code was taken from:
'  'https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-read-from-comma-delimited-text-files
' 
' Assignment #2
' Due Oct 11, 2017
'
' Requirement 1: Expand on this form to display information in database that displays the following fields
' First Name (TextBox)
' Last Name (TextBox)
' Street Number (TextBox)
' City (TextBox) 
' Province (TextBox)
' Country (TextBox)
' Postal Code  (TextBox)( https://stackoverflow.com/questions/16614648/canadian-postal-code-regex)
' Phone Number (TextBox)( http://www.visual-basic-tutorials.com/Tutorials/Strings/validate-phone-number-in-visual-basic.htm)
' email Address (TextBox)( https://stackoverflow.com/questions/1331084/how-do-i-validate-email-address-formatting-with-the-net-framework)
'
' Add Next and Prevous Buttons to navigate through the database ( handle index 0 and max index)
' Display the current primary key of the database in a textbox or label
' Add a Status TextBox and dispaly any formatting errors that are encoutered, 
' If multiple errors exist only show last one.

' Requirement 2: Expand on the below example to create a import the contents of the CSV file 
' created in Assignment1, read the data into entity classes and save data to database.  
' After import Next and Prev buttons should work.
'
' TODO for Dan - add example of how to save data
'
' Please always try to write clean And readable code
' Here Is a good reference doc http://ricardogeek.com/docs/clean_code.html  
' Submit to Bitbucket under Assignment2




Imports System.Text.RegularExpressions

Public Class ContactForm

    Dim index As Integer = 1
    Dim postalRegEx As String = "^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$"
    Dim phoneRegEx As String = "^(\d{3}-\d{3}-\d{4})"
    Dim emailRegex As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"

    'hashtable sample code
    ' https://support.microsoft.com/en-ca/help/307933/how-to-work-with-the-hashtable-collection-in-visual-basic--net-or-in-v
    '
    Dim allData As New Dictionary(Of Integer, Customer)


    Private Sub UpdateData(index As Integer)
        Dim personData As Customer = Nothing
        Try
            allData.TryGetValue(index, personData)
            tb_primarykey.Text = index
            tb_firstName.Text = personData.firstName
            tb_lastName.Text = personData.lastName
            tb_streetNumber.Text = personData.streetNumber
            tb_city.Text = personData.city
            tb_province.Text = personData.province
            tb_country.Text = personData.country
            tb_postalcode.Text = personData.postalCode
            tb_phone.Text = personData.phoneNumber
            tb_email.Text = personData.emailAddress
        Catch ex As Exception
            If tb_firstName.Text = "" Then
                MsgBox("Upload a CSV file to populate fields",, "Message")
            Else
                MsgBox("Enter a valid ID between 1 - " + allData.Count.ToString,, "Message")
            End If

        End Try
        If Not tb_firstName.Text = "" Then
            StatusUpdate()
        End If
    End Sub

    Private Sub StatusUpdate()
        If Not Regex.Match(tb_email.Text, emailRegex).Success Then
            tb_status.Text = "Invalid email address! Should be in xxx@xxx.xxx format"
        ElseIf Not Regex.Match(tb_phone.Text, phoneRegEx).Success Then
            tb_status.Text = "Invalid phone number! Should be in xxx-xxx-xxxx format"
        ElseIf Not Regex.Match(tb_postalcode.Text, postalRegEx).Success Then
            tb_status.Text = "Invalid postal Code "
        Else
            tb_status.Text = "No Errors found!"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromKnownColor(KnownColor.DarkGray)
        LoadFromDatabase()

    End Sub

    Private Sub LoadFromDatabase()
        allData.Clear()
        Dim index As Integer = 1
        Using context As New sqlModel

            Dim listOfCustomers = context.Customers.ToList

            For Each cust As Customer In listOfCustomers
                allData.Add(index, cust)
                UpdateData(index)
                index = index + 1
            Next
        End Using
    End Sub


    Private Sub LoadFromCSVFile(csvFile As String)
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(csvFile)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            Dim rowNumber As Integer = 0
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim rowData As New ArrayList
                    Dim NewCust As New Customer
                    NewCust.firstName = currentRow(0)
                    NewCust.lastName = currentRow(1)
                    NewCust.streetNumber = currentRow(2)
                    NewCust.city = currentRow(3)
                    NewCust.province = currentRow(4)
                    NewCust.country = currentRow(5)
                    NewCust.postalCode = currentRow(6)
                    NewCust.phoneNumber = currentRow(7)
                    NewCust.emailAddress = currentRow(8)

                    Using context As New sqlModel
                        context.Customers.Add(NewCust)
                        context.SaveChanges()
                    End Using

                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
        LoadFromDatabase()
    End Sub




    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles bn_prev.Click
        If tb_firstName.Text = "" Then
            MsgBox("Upload a CSV file to populate fields",, "Message")
        ElseIf index > 1 Then
            index = index - 1
            UpdateData(index)
        Else
            MsgBox("This is the First Record! Next will be Last record in Database",, "Message")
            index = allData.Count
            UpdateData(index)
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles bn_next.Click
        If tb_firstName.Text = "" Then
            MsgBox("Upload a CSV file to populate fields",, "Message")
        ElseIf index < allData.Count Then
            index = index + 1
            UpdateData(index)
        Else
            MsgBox("This is the Last Record! Resetting back to First Record in Database",, "Message")
            index = 1
            UpdateData(index)
        End If
    End Sub


    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles bn_browse.Click
        ImportCSVFile()
    End Sub

    Private Sub ImportCSVFile()
        Dim importFile As String = ""
        Dim csvFile As String = ""

        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Select CSV file to import"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            importFile = fd.FileName
            tb_csvimport.Text = importFile
            csvFile = importFile
            MsgBox("File Uploaded Sucessfully!")

        Else

        End If
        LoadFromCSVFile(csvFile)

    End Sub


    Private Sub tb_primarykey_TextChanged(sender As Object, e As EventArgs) Handles tb_primarykey.TextChanged
        Try
            index = Convert.ToInt32(tb_primarykey.Text)
            UpdateData(index)
        Catch ex As Exception
            MsgBox("Enter a valid ID between 1 - " + allData.Count.ToString,, "Message")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_clear.Click
        Using context As New sqlModel
            context.Database.ExecuteSqlCommand("truncate table Customer")
            context.SaveChanges()
        End Using
        MsgBox("Database Cleared & Exiting Application!",, "Bye!")
        Application.Exit()
    End Sub
End Class