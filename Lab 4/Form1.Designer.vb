<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carInventoryForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.cbMakeList = New System.Windows.Forms.ComboBox()
        Me.cbYearList = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.ckCondition = New System.Windows.Forms.CheckBox()
        Me.lvCarList = New System.Windows.Forms.ListView()
        Me.colCondition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ttCarDetail = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(12, 9)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(100, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNew
        '
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(12, 193)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(100, 23)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "&New"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(12, 147)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYear
        '
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(12, 101)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(100, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(12, 55)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbMakeList
        '
        Me.cbMakeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMakeList.FormattingEnabled = True
        Me.cbMakeList.Items.AddRange(New Object() {"Audi", "Mazda", "Mercedes", "BMW", "Chevrolet", "Subaru", "Dogde", "Aston Martin ", "Hyundai"})
        Me.cbMakeList.Location = New System.Drawing.Point(119, 6)
        Me.cbMakeList.Name = "cbMakeList"
        Me.cbMakeList.Size = New System.Drawing.Size(121, 24)
        Me.cbMakeList.TabIndex = 1
        Me.ttCarDetail.SetToolTip(Me.cbMakeList, "Select the make of the car from the list")
        '
        'cbYearList
        '
        Me.cbYearList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYearList.FormattingEnabled = True
        Me.cbYearList.Items.AddRange(New Object() {"1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cbYearList.Location = New System.Drawing.Point(119, 100)
        Me.cbYearList.Name = "cbYearList"
        Me.cbYearList.Size = New System.Drawing.Size(121, 24)
        Me.cbYearList.TabIndex = 5
        Me.ttCarDetail.SetToolTip(Me.cbYearList, "Select the year from the list")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(119, 55)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 22)
        Me.txtModel.TabIndex = 3
        Me.ttCarDetail.SetToolTip(Me.txtModel, "Enter the model of the car")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(119, 147)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtPrice.TabIndex = 7
        Me.ttCarDetail.SetToolTip(Me.txtPrice, "Enter the price of the the car")
        '
        'ckCondition
        '
        Me.ckCondition.AutoSize = True
        Me.ckCondition.Location = New System.Drawing.Point(119, 194)
        Me.ckCondition.Name = "ckCondition"
        Me.ckCondition.Size = New System.Drawing.Size(18, 17)
        Me.ckCondition.TabIndex = 9
        Me.ttCarDetail.SetToolTip(Me.ckCondition, "Check if the statsu of the car is new ")
        Me.ckCondition.UseVisualStyleBackColor = True
        '
        'lvCarList
        '
        Me.lvCarList.CheckBoxes = True
        Me.lvCarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCondition, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvCarList.FullRowSelect = True
        Me.lvCarList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvCarList.HideSelection = False
        Me.lvCarList.Location = New System.Drawing.Point(12, 219)
        Me.lvCarList.MultiSelect = False
        Me.lvCarList.Name = "lvCarList"
        Me.lvCarList.Size = New System.Drawing.Size(370, 156)
        Me.lvCarList.TabIndex = 10
        Me.ttCarDetail.SetToolTip(Me.lvCarList, "List of all the entry will be shown here.")
        Me.lvCarList.UseCompatibleStateImageBehavior = False
        Me.lvCarList.View = System.Windows.Forms.View.Details
        '
        'colCondition
        '
        Me.colCondition.Text = "New"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(9, 382)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(373, 159)
        Me.lblOutput.TabIndex = 11
        Me.ttCarDetail.SetToolTip(Me.lblOutput, "Output label, will show the errors")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(9, 553)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(118, 23)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(257, 553)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(133, 553)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(118, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'carInventoryForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(397, 588)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lvCarList)
        Me.Controls.Add(Me.ckCondition)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cbYearList)
        Me.Controls.Add(Me.cbMakeList)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "carInventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents cbMakeList As ComboBox
    Friend WithEvents cbYearList As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents ckCondition As CheckBox
    Friend WithEvents lvCarList As ListView
    Friend WithEvents colCondition As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents ttCarDetail As ToolTip
End Class
