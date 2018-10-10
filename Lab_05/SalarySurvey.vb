'Project: Lab 6 
'Author: Anthony DePinto 
'Date: Fall 2014
'Description: Description of the form being created 

'Date: 10 October 2018
'Student: Keith Smith

Option Explicit On
Option Strict On

Public Class SalarySurvey
    ' Create persistent data array to hold total sale counts
    Dim SalesRangeIntegerArray(8) As Integer

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ' Create temporary integer to hold calculated sale value
        Dim WeeklySaleAmountDecimal As Decimal
        Dim IndividualSaleDecimal As Decimal
        Dim TempArrayIndexInteger As Integer
        ' Constant values for base salary and commission rate on sales
        Const BASE_SALARY_DECIMAL As Decimal = 200D
        Const COMMISSION_RATE_DECIMAL As Decimal = 0.1D

        ' Try block to catch bad data entered into textfield
        Try
            WeeklySaleAmountDecimal = Convert.ToInt32(amountTextBox.Text)

            ' If number converted is less than 0, throw error (no negative sales value)
            If (WeeklySaleAmountDecimal < 0) Then
                Throw New Exception
            End If

            ' Calculate Individual sale (10% of total sales + $200)
            IndividualSaleDecimal = BASE_SALARY_DECIMAL + (WeeklySaleAmountDecimal * COMMISSION_RATE_DECIMAL)

            ' Use select case to determine index to pass to array updater below
            Select Case IndividualSaleDecimal
                Case 200 To 299
                    TempArrayIndexInteger = 0
                Case 300 To 399
                    TempArrayIndexInteger = 1
                Case 400 To 499
                    TempArrayIndexInteger = 2
                Case 500 To 599
                    TempArrayIndexInteger = 3
                Case 600 To 699
                    TempArrayIndexInteger = 4
                Case 700 To 799
                    TempArrayIndexInteger = 5
                Case 800 To 899
                    TempArrayIndexInteger = 6
                Case 900 To 999
                    TempArrayIndexInteger = 7
                Case Else
                    TempArrayIndexInteger = 8
            End Select

            ' Update array counter (increment) at calculated array index
            SalesRangeIntegerArray(TempArrayIndexInteger) += 1

        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Sale data entry error",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try

        ' Update labels with new results
        UpdateLabels()

        ' Clear and focus on data entry textbox
        With amountTextBox
            .Focus()
            .Clear()
        End With


    End Sub

    Private Sub SalarySurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make sure that labels have been drawn before calculate button has been clicked
        UpdateLabels()
    End Sub

    Private Sub UpdateLabels()
        ' Format rangesLabel
        rangesLabel.Text = String.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}",
                         vbCrLf,
                         "$200-299",
                         "$300-399",
                         "$400-499",
                         "$500-599",
                         "$600-699",
                         "$700-799",
                         "$800-899",
                         "$900-999",
                         "$999+")

        ' Format valuesLabel
        valuesLabel.Text = String.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}",
                                 vbCrLf,
                                 SalesRangeIntegerArray(0),
                                 SalesRangeIntegerArray(1),
                                 SalesRangeIntegerArray(2),
                                 SalesRangeIntegerArray(3),
                                 SalesRangeIntegerArray(4),
                                 SalesRangeIntegerArray(5),
                                 SalesRangeIntegerArray(6),
                                 SalesRangeIntegerArray(7),
                                 SalesRangeIntegerArray(8))
    End Sub
End Class ' SalarySurvey
