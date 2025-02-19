<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblOne = New Label()
        txtInputNumber = New TextBox()
        gpbOne = New GroupBox()
        radCurrency = New RadioButton()
        radThreeDecimals = New RadioButton()
        radTwoDecimals = New RadioButton()
        radWholeNumbers = New RadioButton()
        btnEnter = New Button()
        btnReset = New Button()
        btnExit = New Button()
        lblOutput = New Label()
        gpbOne.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblOne
        ' 
        lblOne.Location = New Point(27, 53)
        lblOne.Name = "lblOne"
        lblOne.Size = New Size(87, 18)
        lblOne.TabIndex = 0
        lblOne.Text = "Input Number"
        ' 
        ' txtInputNumber
        ' 
        txtInputNumber.Location = New Point(21, 78)
        txtInputNumber.Name = "txtInputNumber"
        txtInputNumber.Size = New Size(146, 23)
        txtInputNumber.TabIndex = 1
        ' 
        ' gpbOne
        ' 
        gpbOne.Controls.Add(radCurrency)
        gpbOne.Controls.Add(radThreeDecimals)
        gpbOne.Controls.Add(radTwoDecimals)
        gpbOne.Controls.Add(radWholeNumbers)
        gpbOne.Location = New Point(42, 144)
        gpbOne.Name = "gpbOne"
        gpbOne.Size = New Size(180, 174)
        gpbOne.TabIndex = 2
        gpbOne.TabStop = False
        gpbOne.Text = "Number Format Selection"
        ' 
        ' radCurrency
        ' 
        radCurrency.AutoSize = True
        radCurrency.Location = New Point(6, 140)
        radCurrency.Name = "radCurrency"
        radCurrency.Size = New Size(73, 19)
        radCurrency.TabIndex = 6
        radCurrency.TabStop = True
        radCurrency.Text = "Currency"
        radCurrency.UseVisualStyleBackColor = True
        ' 
        ' radThreeDecimals
        ' 
        radThreeDecimals.AutoSize = True
        radThreeDecimals.Location = New Point(6, 103)
        radThreeDecimals.Name = "radThreeDecimals"
        radThreeDecimals.Size = New Size(133, 19)
        radThreeDecimals.TabIndex = 5
        radThreeDecimals.TabStop = True
        radThreeDecimals.Text = "Round to 3 decimals"
        radThreeDecimals.UseVisualStyleBackColor = True
        ' 
        ' radTwoDecimals
        ' 
        radTwoDecimals.AutoSize = True
        radTwoDecimals.Location = New Point(6, 69)
        radTwoDecimals.Name = "radTwoDecimals"
        radTwoDecimals.Size = New Size(167, 19)
        radTwoDecimals.TabIndex = 4
        radTwoDecimals.TabStop = True
        radTwoDecimals.Text = "Rolund to 2 decimal places"
        radTwoDecimals.UseVisualStyleBackColor = True
        ' 
        ' radWholeNumbers
        ' 
        radWholeNumbers.AutoSize = True
        radWholeNumbers.Location = New Point(6, 35)
        radWholeNumbers.Name = "radWholeNumbers"
        radWholeNumbers.Size = New Size(159, 19)
        radWholeNumbers.TabIndex = 3
        radWholeNumbers.TabStop = True
        radWholeNumbers.Text = "Round to whole numbers"
        radWholeNumbers.UseVisualStyleBackColor = True
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(261, 247)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(99, 23)
        btnEnter.TabIndex = 3
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(261, 311)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(99, 27)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(261, 383)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(99, 37)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblOutput
        ' 
        lblOutput.Location = New Point(249, 73)
        lblOutput.Name = "lblOutput"
        lblOutput.Size = New Size(97, 74)
        lblOutput.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(372, 460)
        Controls.Add(lblOutput)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnEnter)
        Controls.Add(gpbOne)
        Controls.Add(txtInputNumber)
        Controls.Add(lblOne)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Number Formatter"
        gpbOne.ResumeLayout(False)
        gpbOne.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblOne As Label
    Friend WithEvents txtInputNumber As TextBox
    Friend WithEvents gpbOne As GroupBox
    Friend WithEvents radCurrency As RadioButton
    Friend WithEvents radThreeDecimals As RadioButton
    Friend WithEvents radTwoDecimals As RadioButton
    Friend WithEvents radWholeNumbers As RadioButton
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutput As Label

End Class
