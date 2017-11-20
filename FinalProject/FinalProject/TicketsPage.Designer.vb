<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketsPage
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
        Me.lblConcert = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSeats = New System.Windows.Forms.ComboBox()
        Me.chkParking = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblConcert
        '
        Me.lblConcert.AutoSize = True
        Me.lblConcert.Location = New System.Drawing.Point(28, 28)
        Me.lblConcert.Name = "lblConcert"
        Me.lblConcert.Size = New System.Drawing.Size(39, 13)
        Me.lblConcert.TabIndex = 0
        Me.lblConcert.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Seat Level:"
        '
        'cboLevel
        '
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Items.AddRange(New Object() {"A", "B", "C", "Stage"})
        Me.cboLevel.Location = New System.Drawing.Point(128, 71)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(121, 21)
        Me.cboLevel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Select # of Seats: "
        '
        'cboSeats
        '
        Me.cboSeats.FormattingEnabled = True
        Me.cboSeats.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboSeats.Location = New System.Drawing.Point(128, 114)
        Me.cboSeats.Name = "cboSeats"
        Me.cboSeats.Size = New System.Drawing.Size(121, 21)
        Me.cboSeats.TabIndex = 4
        '
        'chkParking
        '
        Me.chkParking.AutoSize = True
        Me.chkParking.Location = New System.Drawing.Point(128, 195)
        Me.chkParking.Name = "chkParking"
        Me.chkParking.Size = New System.Drawing.Size(62, 17)
        Me.chkParking.TabIndex = 5
        Me.chkParking.Text = "Parking"
        Me.chkParking.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(394, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Please check the following box if you wish to purchase a parking spot in advance:" &
    ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total Due:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(173, 243)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Label6"
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(289, 272)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(104, 23)
        Me.btnPurchase.TabIndex = 9
        Me.btnPurchase.Text = "Purchase Tickets"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Note: 10% discount on total price if parking is purchased in advance!"
        '
        'TicketsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 307)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkParking)
        Me.Controls.Add(Me.cboSeats)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboLevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblConcert)
        Me.Name = "TicketsPage"
        Me.Text = "Purchase Tickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConcert As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboLevel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSeats As ComboBox
    Friend WithEvents chkParking As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents Label1 As Label
End Class
