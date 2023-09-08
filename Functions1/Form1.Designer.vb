<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCalCulate = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        txtChoose = New TextBox()
        SuspendLayout()
        ' 
        ' btnCalCulate
        ' 
        btnCalCulate.Location = New Point(375, 270)
        btnCalCulate.Name = "btnCalCulate"
        btnCalCulate.Size = New Size(94, 29)
        btnCalCulate.TabIndex = 0
        btnCalCulate.Text = "Calculate"
        btnCalCulate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(185, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter First Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(185, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 20)
        Label2.TabIndex = 2
        Label2.Text = "Enter Second Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(185, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 20)
        Label3.TabIndex = 3
        Label3.Text = "Type Multiply or Add"
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Location = New Point(357, 83)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(125, 27)
        txtNumber1.TabIndex = 4
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Location = New Point(357, 149)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(125, 27)
        txtNumber2.TabIndex = 5
        ' 
        ' txtChoose
        ' 
        txtChoose.Location = New Point(357, 205)
        txtChoose.Name = "txtChoose"
        txtChoose.Size = New Size(125, 27)
        txtChoose.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtChoose)
        Controls.Add(txtNumber2)
        Controls.Add(txtNumber1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCalCulate)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalCulate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents txtChoose As TextBox
End Class
