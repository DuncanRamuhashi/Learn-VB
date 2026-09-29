<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbooking
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
        Me.grdbooking = New System.Windows.Forms.DataGridView()
        Me.addpatient = New System.Windows.Forms.Button()
        Me.btnname = New System.Windows.Forms.Button()
        Me.txtclinicname = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnpatientvisit = New System.Windows.Forms.Button()
        Me.btncancelvisit = New System.Windows.Forms.Button()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.grdbooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdbooking
        '
        Me.grdbooking.AllowUserToAddRows = False
        Me.grdbooking.AllowUserToDeleteRows = False
        Me.grdbooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdbooking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.grdbooking.Location = New System.Drawing.Point(201, 12)
        Me.grdbooking.Name = "grdbooking"
        Me.grdbooking.ReadOnly = True
        Me.grdbooking.Size = New System.Drawing.Size(1068, 540)
        Me.grdbooking.TabIndex = 4
        '
        'addpatient
        '
        Me.addpatient.Location = New System.Drawing.Point(12, 38)
        Me.addpatient.Name = "addpatient"
        Me.addpatient.Size = New System.Drawing.Size(183, 27)
        Me.addpatient.TabIndex = 3
        Me.addpatient.Text = "Add Patient"
        Me.addpatient.UseVisualStyleBackColor = True
        '
        'btnname
        '
        Me.btnname.Location = New System.Drawing.Point(12, 12)
        Me.btnname.Name = "btnname"
        Me.btnname.Size = New System.Drawing.Size(100, 23)
        Me.btnname.TabIndex = 5
        Me.btnname.Text = "Add Clinic Name"
        Me.btnname.UseVisualStyleBackColor = True
        '
        'txtclinicname
        '
        Me.txtclinicname.Location = New System.Drawing.Point(118, 12)
        Me.txtclinicname.Multiline = True
        Me.txtclinicname.Name = "txtclinicname"
        Me.txtclinicname.ReadOnly = True
        Me.txtclinicname.Size = New System.Drawing.Size(77, 23)
        Me.txtclinicname.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Patient Number"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID Number"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Surname"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Gender"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Contact"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Kin Contact"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Address"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Area"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'btnpatientvisit
        '
        Me.btnpatientvisit.Location = New System.Drawing.Point(12, 71)
        Me.btnpatientvisit.Name = "btnpatientvisit"
        Me.btnpatientvisit.Size = New System.Drawing.Size(183, 23)
        Me.btnpatientvisit.TabIndex = 7
        Me.btnpatientvisit.Text = "Patient Visit"
        Me.btnpatientvisit.UseVisualStyleBackColor = True
        '
        'btncancelvisit
        '
        Me.btncancelvisit.Location = New System.Drawing.Point(12, 100)
        Me.btncancelvisit.Name = "btncancelvisit"
        Me.btncancelvisit.Size = New System.Drawing.Size(183, 23)
        Me.btncancelvisit.TabIndex = 8
        Me.btncancelvisit.Text = "Cancel Visit"
        Me.btncancelvisit.UseVisualStyleBackColor = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Visits"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'frmbooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 564)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btncancelvisit)
        Me.Controls.Add(Me.btnpatientvisit)
        Me.Controls.Add(Me.txtclinicname)
        Me.Controls.Add(Me.btnname)
        Me.Controls.Add(Me.grdbooking)
        Me.Controls.Add(Me.addpatient)
        Me.Name = "frmbooking"
        Me.Text = "Booking System"
        CType(Me.grdbooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdbooking As DataGridView
    Friend WithEvents addpatient As Button
    Friend WithEvents btnname As Button
    Friend WithEvents txtclinicname As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents btnpatientvisit As Button
    Friend WithEvents btncancelvisit As Button
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
End Class
