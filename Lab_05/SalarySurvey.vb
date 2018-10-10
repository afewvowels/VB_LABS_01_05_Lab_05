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

    ' Constant values for base salary and commission rate on sales
    Const BASE_SALARY_DECIMAL As Decimal = 200D
    Const COMMISSION_RATE_DECIMAL As Decimal = 0.1D

    ' Calculate salary and update totals
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ' Create temporary integer to hold calculated sale value
        Dim WeeklySaleAmountDecimal As Decimal
        Dim SalaryDecimal As Decimal
        Dim TempArrayIndexInteger As Integer

        ' Try block to catch bad data entered into textfield
        Try
            WeeklySaleAmountDecimal = Convert.ToDecimal(amountTextBox.Text)

            ' If number converted is less than 0, throw error (no negative sales value)
            If (WeeklySaleAmountDecimal < 0D) Then
                ' Show error message
                MessageBox.Show("Value must be positive",
                                "Data Entry Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
                ' Exit subroutine, do not run through rest of calculate subroutine
                Exit Sub
            End If

            ' Calculate Individual sale (10% of total sales + $200)
            SalaryDecimal = BASE_SALARY_DECIMAL + (WeeklySaleAmountDecimal * COMMISSION_RATE_DECIMAL)

            ' Calculate index integer
            TempArrayIndexInteger = Convert.ToInt32(SalaryDecimal / 100) - 2

            ' Update array counter (increment) at calculated array index
            SalesRangeIntegerArray(TempArrayIndexInteger) += 1

        Catch ex As FormatException
            ' Display error message
            MessageBox.Show("Non-numeric data entry error",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try

        ' Update labels with new results
        UpdateLabel()

        ' Clear and focus on data entry textbox
        With amountTextBox
            .Focus()
            .Clear()
        End With


    End Sub

    Private Sub SalarySurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add rangesLabel to form (only need to update once per application run)
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
                         "$1000+")

        ' Make sure that labels have been drawn before calculate button has been clicked
        UpdateLabel()
    End Sub

    Private Sub UpdateLabel()
        ' Declare string to hold temporary construct of array contents to
        ' eventually set valesLabel.Text equal to
        Dim LineString As String = ""

        ' Loop through array and append contents of array at that index to linestring
        For CounterInteger As Integer = 0 To SalesRangeIntegerArray.GetUpperBound(0)
            LineString &= SalesRangeIntegerArray(CounterInteger).ToString & vbCrLf
        Next

        ' Set label.text equal to linestring
        valuesLabel.Text = LineString
    End Sub
End Class ' SalarySurvey
