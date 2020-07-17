'Option Strict On

' Author:       Kaifkhan Vakil 
' Date:         2020-07-15
' Description: In the following code i will track the car list data and their all details along with their price and status in the database. I have created clas in the following program to 
' track all the function and define constructors which will help me build up the code. 

Public Class carInventoryForm
#Region "Variables and constants"
    Const MIN_PRICE As Decimal = 0
    Const MAX_PRICE As Decimal = 99999
    Const MIN_YEAR As Integer = 1920
    Const MAX_YEAR As Integer = 2020

    Dim newCar As New List(Of Car)
    Dim editMode As Boolean = False
    Dim modification As Boolean = False
    Dim listViewIndex As Integer = -1



#End Region

#Region "Event Handlers"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim validMake As String = cbMakeList.Text
        Dim validModel As String = txtModel.Text
        Dim validPrice As String = txtPrice.Text
        Dim validYear As String = cbYearList.Text
        Dim validStatus As Boolean = ckCondition.Checked
        Dim problems As String = validatingCar(validMake, validModel, validYear, validPrice)
        Dim car As Car

        If (String.IsNullOrEmpty(problems)) Then
            If (editMode) Then
                newCar(listViewIndex).manufacturer = validMake
                newCar(listViewIndex).design = validModel
                newCar(listViewIndex).time = validYear
                newCar(listViewIndex).amount = validPrice
                newCar(listViewIndex).status = validStatus

                dataUpdate()
                ResetForm()

                lblOutput.Text = "It worked!"

            Else
                car = New Car(validMake, validModel, validYear, validPrice, validStatus)
                newCar.Add(car)
                ResetForm()


                dataUpdate()

                lblOutput.Text = "It works"
            End If
        Else
            lblOutput.Text = problems

        End If

    End Sub

#End Region

#Region "Subs and functions"

    Function validatingCar(make As String, model As String, year As String, price As String) As String
        Dim errorDetected As String = String.Empty
        Dim inputYear As Integer
        Dim inputPrice As Decimal


        If (String.IsNullOrWhiteSpace(make)) Then
            errorDetected += "Select a car manufacturer from the list" & vbCrLf
        End If
        If (String.IsNullOrWhiteSpace(model)) Then
            errorDetected += "Enter car model in the input box" & vbCrLf
        End If
        If (Integer.TryParse(year, inputYear)) Then
            If (inputYear < MIN_YEAR Or inputYear > MAX_YEAR) Then
                errorDetected += "Please select a year from the list"
            End If
        Else
            errorDetected += "Input of the year should be a valid year from the list"
        End If

        If (Decimal.TryParse(price, inputPrice)) Then
            If (inputPrice < MIN_PRICE Or inputPrice > MAX_PRICE) Then
                errorDetected += "Please enter the valid price between " & MIN_PRICE & "and " & MIN_PRICE
            End If
        Else
            errorDetected += "Inout of the year should be a valid year from the list"
        End If
        Return errorDetected
    End Function

    Private Sub ResetForm()
        lvCarList.SelectedIndices.Clear()

        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        cbMakeList.SelectedIndex = -1
        ckCondition.Checked = False
        cbYearList.SelectedIndex = -1


        editMode = False

        lblOutput.Text = "Reset form "
    End Sub


    Private Sub dataUpdate()
        Dim carRef As ListViewItem

        modification = True
        lvCarList.Items.Clear()

        For Each car As Car In newCar
            carRef = New ListViewItem()

            carRef.SubItems.Add(car.manufacturer)
            carRef.SubItems.Add(car.design)
            carRef.SubItems.Add(car.time)
            carRef.SubItems.Add(car.amount)
            carRef.Checked = car.status

            lvCarList.Items.Add(carRef)

        Next

        ' Loop around new list
    End Sub

    Private Sub lvCarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCarList.SelectedIndexChanged
        If (Not lvCarList.FocusedItem Is Nothing) Then
            listViewIndex = lvCarList.FocusedItem.Index
            Dim car As Car = newCar(listViewIndex)

            editMode = True

            cbMakeList.Text = car.manufacturer
            txtModel.Text = car.design
            cbYearList.Text = car.time
            txtPrice.Text = car.amount
            ckCondition.Checked = car.status


        End If
    End Sub
#End Region


End Class
