'Project: Lab 6 
'Author: Anthony DePinto 
'Date: Fall 2014
'Description: Description of the form being created 

Public Class SalarySurvey
    Dim SalesRangeIntegerArray(8) As Integer

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim IndividualSaleDecimal As Decimal

        Try
            IndividualSaleDecimal = 200D + (Convert.ToInt32(amountTextBox.Text) * 0.1D)

            Select Case IndividualSaleDecimal
                Case 200 To 299
                    SalesRangeIntegerArray(0) += 1
                Case 300 To 399
                    SalesRangeIntegerArray(1) += 1
                Case 400 To 499
                    SalesRangeIntegerArray(2) += 1
                Case 500 To 599
                    SalesRangeIntegerArray(3) += 1
                Case 600 To 699
                    SalesRangeIntegerArray(4) += 1
                Case 700 To 799
                    SalesRangeIntegerArray(5) += 1
                Case 800 To 899
                    SalesRangeIntegerArray(6) += 1
                Case 900 To 999
                    SalesRangeIntegerArray(7) += 1
                Case Else
                    SalesRangeIntegerArray(8) += 1
            End Select
        Catch ex As Exception
            MessageBox.Show("Sale data entry error",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try

        rangesLabel.Text = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}",
                                         "$200-299",
                                         vbCrLf,
                                         "$300-399",
                                         "$400-499",
                                         "$500-599",
                                         "$600-699",
                                         "$700-799",
                                         "$800-899",
                                         "$900-999",
                                         "$999+")

        valuesLabel.Text = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}",
                                 SalesRangeIntegerArray(0),
                                 vbCrLf,
                                 SalesRangeIntegerArray(1),
                                 SalesRangeIntegerArray(2),
                                 SalesRangeIntegerArray(3),
                                 SalesRangeIntegerArray(4),
                                 SalesRangeIntegerArray(5),
                                 SalesRangeIntegerArray(6),
                                 SalesRangeIntegerArray(7),
                                 SalesRangeIntegerArray(8))

        With amountTextBox
            .Focus()
            .Clear()
        End With


    End Sub

    Private Sub SalarySurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rangesLabel.Text = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}",
                                 "$200-299",
                                 vbCrLf,
                                 "$300-399",
                                 "$400-499",
                                 "$500-599",
                                 "$600-699",
                                 "$700-799",
                                 "$800-899",
                                 "$900-999",
                                 "$999+")

        valuesLabel.Text = String.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}",
                                 SalesRangeIntegerArray(0),
                                 vbCrLf,
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
