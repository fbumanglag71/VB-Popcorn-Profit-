<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROJECT_5
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPopcorn = New System.Windows.Forms.TextBox()
        Me.txtButter = New System.Windows.Forms.TextBox()
        Me.txtBucket = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtProfit = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(134, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Determine Profit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(99, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cost of Popcorn"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(77, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cost Of Butter Substitute"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(259, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 55)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cost of Bucket"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Location = New System.Drawing.Point(278, 113)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(33, 15)
        Me.Price.TabIndex = 4
        Me.Price.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Profit"
        '
        'txtPopcorn
        '
        Me.txtPopcorn.Location = New System.Drawing.Point(171, 34)
        Me.txtPopcorn.Name = "txtPopcorn"
        Me.txtPopcorn.Size = New System.Drawing.Size(52, 23)
        Me.txtPopcorn.TabIndex = 6
        '
        'txtButter
        '
        Me.txtButter.Location = New System.Drawing.Point(172, 105)
        Me.txtButter.Name = "txtButter"
        Me.txtButter.Size = New System.Drawing.Size(52, 23)
        Me.txtButter.TabIndex = 7
        '
        'txtBucket
        '
        Me.txtBucket.Location = New System.Drawing.Point(317, 34)
        Me.txtBucket.Name = "txtBucket"
        Me.txtBucket.Size = New System.Drawing.Size(52, 23)
        Me.txtBucket.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(317, 110)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(52, 23)
        Me.txtPrice.TabIndex = 9
        '
        'txtProfit
        '
        Me.txtProfit.Enabled = False
        Me.txtProfit.Location = New System.Drawing.Point(270, 255)
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.Size = New System.Drawing.Size(52, 23)
        Me.txtProfit.TabIndex = 10
        '
        'PROJECT_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 312)
        Me.Controls.Add(Me.txtProfit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtBucket)
        Me.Controls.Add(Me.txtButter)
        Me.Controls.Add(Me.txtPopcorn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "PROJECT_5"
        Me.Text = "PROJECT_5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Price As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPopcorn As TextBox
    Friend WithEvents txtButter As TextBox
    Friend WithEvents txtBucket As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtProfit As TextBox
End Class
