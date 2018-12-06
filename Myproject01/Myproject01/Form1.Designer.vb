<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txthoure = New System.Windows.Forms.TextBox()
        Me.txtWork = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.btnCal2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมตัวอย่างการคิดค่าแรง" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชั่วโมงการทำงาน"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 39)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "อัตราค่าจ้างต่อชั่วโมง"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 39)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "คิดเป็นเงิน"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 39)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = " หักภาษี ณ ที่จ่าย"
        '
        'txthoure
        '
        Me.txthoure.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txthoure.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txthoure.Location = New System.Drawing.Point(320, 124)
        Me.txthoure.Multiline = True
        Me.txthoure.Name = "txthoure"
        Me.txthoure.Size = New System.Drawing.Size(183, 35)
        Me.txthoure.TabIndex = 0
        '
        'txtWork
        '
        Me.txtWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWork.Location = New System.Drawing.Point(320, 199)
        Me.txtWork.Multiline = True
        Me.txtWork.Name = "txtWork"
        Me.txtWork.Size = New System.Drawing.Size(183, 35)
        Me.txtWork.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(292, 423)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(96, 34)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClose.Location = New System.Drawing.Point(429, 423)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 34)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = " ปิด"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotal.Location = New System.Drawing.Point(315, 265)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(188, 39)
        Me.lblTotal.TabIndex = 2
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTax.Location = New System.Drawing.Point(315, 334)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(188, 39)
        Me.lblTax.TabIndex = 3
        Me.lblTax.Text = " "
        '
        'btnCal2
        '
        Me.btnCal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCal2.Location = New System.Drawing.Point(562, 423)
        Me.btnCal2.Name = "btnCal2"
        Me.btnCal2.Size = New System.Drawing.Size(96, 34)
        Me.btnCal2.TabIndex = 4
        Me.btnCal2.Text = "คำนวณ"
        Me.btnCal2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 494)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCal2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtWork)
        Me.Controls.Add(Me.txthoure)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txthoure As TextBox
    Friend WithEvents txtWork As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents btnCal2 As Button
End Class
