'' Author: Francisco Bumanglag
'' Project: Popcorn Profit 
'' Assignment: Module 5 Homework
'' Course: Visual Basic, Santa Ana College
'' Class: CMPR105 Derendal Huynh 
'' Date: September 21, 2022


Public Class PROJECT_5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim popcorn, butter, bucket, price As Decimal 'amount in dollars

        popcorn = CDec(txtPopcorn.Text)
        bucket = CDec(txtBucket.Text)
        butter = CDec(txtButter.Text)
        price = CDec(txtPrice.Text)

        txtProfit.Text = (Profit(popcorn, butter, bucket, price)).ToString("C")

    End Sub

    Function Profit(popcorn As Decimal, butter As Decimal, bucket As Decimal, price As Decimal) As Decimal

        'Calculate the profit on a bucket of popcorn

        Return price - (popcorn + butter + bucket)

    End Function


End Class