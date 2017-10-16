<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bn_next = New System.Windows.Forms.Button()
        Me.tb_firstName = New System.Windows.Forms.TextBox()
        Me.bn_prev = New System.Windows.Forms.Button()
        Me.tb_primarykey = New System.Windows.Forms.TextBox()
        Me.primarykey = New System.Windows.Forms.Label()
        Me.firstName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bn_browse = New System.Windows.Forms.Button()
        Me.tb_csvimport = New System.Windows.Forms.TextBox()
        Me.CSVfiletoimport = New System.Windows.Forms.Label()
        Me.lastName = New System.Windows.Forms.Label()
        Me.tb_lastName = New System.Windows.Forms.TextBox()
        Me.tb_phone = New System.Windows.Forms.TextBox()
        Me.tb_postalcode = New System.Windows.Forms.TextBox()
        Me.tb_country = New System.Windows.Forms.TextBox()
        Me.tb_province = New System.Windows.Forms.TextBox()
        Me.tb_city = New System.Windows.Forms.TextBox()
        Me.tb_streetNumber = New System.Windows.Forms.TextBox()
        Me.postalcode = New System.Windows.Forms.Label()
        Me.country = New System.Windows.Forms.Label()
        Me.province = New System.Windows.Forms.Label()
        Me.city = New System.Windows.Forms.Label()
        Me.streetNumber = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.tb_status = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.bt_clear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bn_next
        '
        Me.bn_next.Location = New System.Drawing.Point(337, 402)
        Me.bn_next.Margin = New System.Windows.Forms.Padding(4)
        Me.bn_next.Name = "bn_next"
        Me.bn_next.Size = New System.Drawing.Size(100, 28)
        Me.bn_next.TabIndex = 0
        Me.bn_next.Text = "Next"
        Me.bn_next.UseVisualStyleBackColor = True
        '
        'tb_firstName
        '
        Me.tb_firstName.Location = New System.Drawing.Point(124, 42)
        Me.tb_firstName.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_firstName.Name = "tb_firstName"
        Me.tb_firstName.Size = New System.Drawing.Size(367, 22)
        Me.tb_firstName.TabIndex = 1
        '
        'bn_prev
        '
        Me.bn_prev.Location = New System.Drawing.Point(124, 402)
        Me.bn_prev.Margin = New System.Windows.Forms.Padding(4)
        Me.bn_prev.Name = "bn_prev"
        Me.bn_prev.Size = New System.Drawing.Size(100, 28)
        Me.bn_prev.TabIndex = 2
        Me.bn_prev.Text = "Prev"
        Me.bn_prev.UseVisualStyleBackColor = True
        '
        'tb_primarykey
        '
        Me.tb_primarykey.Location = New System.Drawing.Point(124, 11)
        Me.tb_primarykey.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_primarykey.Name = "tb_primarykey"
        Me.tb_primarykey.Size = New System.Drawing.Size(76, 22)
        Me.tb_primarykey.TabIndex = 3
        '
        'primarykey
        '
        Me.primarykey.AutoSize = True
        Me.primarykey.Location = New System.Drawing.Point(16, 16)
        Me.primarykey.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.primarykey.Name = "primarykey"
        Me.primarykey.Size = New System.Drawing.Size(84, 17)
        Me.primarykey.TabIndex = 4
        Me.primarykey.Text = "Primary Key"
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Location = New System.Drawing.Point(16, 47)
        Me.firstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(76, 17)
        Me.firstName.TabIndex = 5
        Me.firstName.Text = "First Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.bn_browse)
        Me.Panel1.Controls.Add(Me.tb_csvimport)
        Me.Panel1.Controls.Add(Me.CSVfiletoimport)
        Me.Panel1.Location = New System.Drawing.Point(19, 497)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 78)
        Me.Panel1.TabIndex = 6
        '
        'bn_browse
        '
        Me.bn_browse.Location = New System.Drawing.Point(635, 31)
        Me.bn_browse.Margin = New System.Windows.Forms.Padding(4)
        Me.bn_browse.Name = "bn_browse"
        Me.bn_browse.Size = New System.Drawing.Size(92, 28)
        Me.bn_browse.TabIndex = 2
        Me.bn_browse.Text = "Browse"
        Me.bn_browse.UseVisualStyleBackColor = True
        '
        'tb_csvimport
        '
        Me.tb_csvimport.Location = New System.Drawing.Point(9, 37)
        Me.tb_csvimport.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_csvimport.Name = "tb_csvimport"
        Me.tb_csvimport.Size = New System.Drawing.Size(600, 22)
        Me.tb_csvimport.TabIndex = 1
        '
        'CSVfiletoimport
        '
        Me.CSVfiletoimport.AutoSize = True
        Me.CSVfiletoimport.Location = New System.Drawing.Point(5, 5)
        Me.CSVfiletoimport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CSVfiletoimport.Name = "CSVfiletoimport"
        Me.CSVfiletoimport.Size = New System.Drawing.Size(124, 17)
        Me.CSVfiletoimport.TabIndex = 0
        Me.CSVfiletoimport.Text = "CSV File to Import:"
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Location = New System.Drawing.Point(16, 77)
        Me.lastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(76, 17)
        Me.lastName.TabIndex = 7
        Me.lastName.Text = "Last Name"
        '
        'tb_lastName
        '
        Me.tb_lastName.Location = New System.Drawing.Point(124, 72)
        Me.tb_lastName.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_lastName.Name = "tb_lastName"
        Me.tb_lastName.Size = New System.Drawing.Size(367, 22)
        Me.tb_lastName.TabIndex = 8
        '
        'tb_phone
        '
        Me.tb_phone.Location = New System.Drawing.Point(124, 252)
        Me.tb_phone.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_phone.Name = "tb_phone"
        Me.tb_phone.Size = New System.Drawing.Size(367, 22)
        Me.tb_phone.TabIndex = 9
        '
        'tb_postalcode
        '
        Me.tb_postalcode.Location = New System.Drawing.Point(124, 222)
        Me.tb_postalcode.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_postalcode.Name = "tb_postalcode"
        Me.tb_postalcode.Size = New System.Drawing.Size(367, 22)
        Me.tb_postalcode.TabIndex = 10
        '
        'tb_country
        '
        Me.tb_country.Location = New System.Drawing.Point(124, 192)
        Me.tb_country.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_country.Name = "tb_country"
        Me.tb_country.Size = New System.Drawing.Size(367, 22)
        Me.tb_country.TabIndex = 11
        '
        'tb_province
        '
        Me.tb_province.Location = New System.Drawing.Point(124, 162)
        Me.tb_province.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_province.Name = "tb_province"
        Me.tb_province.Size = New System.Drawing.Size(367, 22)
        Me.tb_province.TabIndex = 12
        '
        'tb_city
        '
        Me.tb_city.Location = New System.Drawing.Point(124, 132)
        Me.tb_city.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_city.Name = "tb_city"
        Me.tb_city.Size = New System.Drawing.Size(367, 22)
        Me.tb_city.TabIndex = 13
        '
        'tb_streetNumber
        '
        Me.tb_streetNumber.Location = New System.Drawing.Point(124, 102)
        Me.tb_streetNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_streetNumber.Name = "tb_streetNumber"
        Me.tb_streetNumber.Size = New System.Drawing.Size(367, 22)
        Me.tb_streetNumber.TabIndex = 14
        '
        'postalcode
        '
        Me.postalcode.AutoSize = True
        Me.postalcode.Location = New System.Drawing.Point(16, 227)
        Me.postalcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.postalcode.Name = "postalcode"
        Me.postalcode.Size = New System.Drawing.Size(84, 17)
        Me.postalcode.TabIndex = 15
        Me.postalcode.Text = "Postal Code"
        '
        'country
        '
        Me.country.AutoSize = True
        Me.country.Location = New System.Drawing.Point(16, 197)
        Me.country.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(57, 17)
        Me.country.TabIndex = 16
        Me.country.Text = "Country"
        '
        'province
        '
        Me.province.AutoSize = True
        Me.province.Location = New System.Drawing.Point(16, 167)
        Me.province.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.province.Name = "province"
        Me.province.Size = New System.Drawing.Size(63, 17)
        Me.province.TabIndex = 17
        Me.province.Text = "Province"
        '
        'city
        '
        Me.city.AutoSize = True
        Me.city.Location = New System.Drawing.Point(16, 137)
        Me.city.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(31, 17)
        Me.city.TabIndex = 18
        Me.city.Text = "City"
        '
        'streetNumber
        '
        Me.streetNumber.AutoSize = True
        Me.streetNumber.Location = New System.Drawing.Point(16, 107)
        Me.streetNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.streetNumber.Name = "streetNumber"
        Me.streetNumber.Size = New System.Drawing.Size(100, 17)
        Me.streetNumber.TabIndex = 19
        Me.streetNumber.Text = "Street Number"
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(16, 257)
        Me.phone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(103, 17)
        Me.phone.TabIndex = 20
        Me.phone.Text = "Phone Number"
        '
        'tb_status
        '
        Me.tb_status.Location = New System.Drawing.Point(124, 322)
        Me.tb_status.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_status.Name = "tb_status"
        Me.tb_status.Size = New System.Drawing.Size(367, 22)
        Me.tb_status.TabIndex = 22
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(16, 327)
        Me.status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(48, 17)
        Me.status.TabIndex = 21
        Me.status.Text = "Status"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(18, 287)
        Me.email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(98, 17)
        Me.email.TabIndex = 23
        Me.email.Text = "Email Address"
        '
        'tb_email
        '
        Me.tb_email.Location = New System.Drawing.Point(124, 282)
        Me.tb_email.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(367, 22)
        Me.tb_email.TabIndex = 24
        '
        'bt_clear
        '
        Me.bt_clear.Location = New System.Drawing.Point(624, 402)
        Me.bt_clear.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_clear.Name = "bt_clear"
        Me.bt_clear.Size = New System.Drawing.Size(154, 28)
        Me.bt_clear.TabIndex = 25
        Me.bt_clear.Text = "Clear DB && Exit"
        Me.bt_clear.UseVisualStyleBackColor = True
        '
        'ContactForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 588)
        Me.Controls.Add(Me.bt_clear)
        Me.Controls.Add(Me.tb_email)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.tb_status)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.streetNumber)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.province)
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.postalcode)
        Me.Controls.Add(Me.tb_streetNumber)
        Me.Controls.Add(Me.tb_city)
        Me.Controls.Add(Me.tb_province)
        Me.Controls.Add(Me.tb_country)
        Me.Controls.Add(Me.tb_postalcode)
        Me.Controls.Add(Me.tb_phone)
        Me.Controls.Add(Me.tb_lastName)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.primarykey)
        Me.Controls.Add(Me.tb_primarykey)
        Me.Controls.Add(Me.bn_prev)
        Me.Controls.Add(Me.tb_firstName)
        Me.Controls.Add(Me.bn_next)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ContactForm"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bn_next As Button
    Friend WithEvents tb_firstName As TextBox
    Friend WithEvents bn_prev As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_primarykey As TextBox
    Friend WithEvents primarykey As Label
    Friend WithEvents firstName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bn_browse As Button
    Friend WithEvents tb_csvimport As TextBox
    Friend WithEvents CSVfiletoimport As Label
    Friend WithEvents lastName As Label
    Friend WithEvents tb_lastName As TextBox
    Friend WithEvents tb_phone As TextBox
    Friend WithEvents tb_postalcode As TextBox
    Friend WithEvents tb_country As TextBox
    Friend WithEvents tb_province As TextBox
    Friend WithEvents tb_city As TextBox
    Friend WithEvents tb_streetNumber As TextBox
    Friend WithEvents postalcode As Label
    Friend WithEvents country As Label
    Friend WithEvents province As Label
    Friend WithEvents city As Label
    Friend WithEvents streetNumber As Label
    Friend WithEvents phone As Label
    Friend WithEvents tb_status As TextBox
    Friend WithEvents status As Label
    Friend WithEvents email As Label
    Friend WithEvents tb_email As TextBox
    Friend WithEvents bt_clear As Button
End Class
