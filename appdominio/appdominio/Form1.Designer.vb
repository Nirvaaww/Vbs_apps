<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCrearUser = New System.Windows.Forms.Button()
        Me.txtOU = New System.Windows.Forms.TextBox()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPasswd = New System.Windows.Forms.Label()
        Me.lblOu = New System.Windows.Forms.Label()
        Me.Estado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCrearUser
        '
        Me.btnCrearUser.Location = New System.Drawing.Point(323, 323)
        Me.btnCrearUser.Name = "btnCrearUser"
        Me.btnCrearUser.Size = New System.Drawing.Size(109, 23)
        Me.btnCrearUser.TabIndex = 0
        Me.btnCrearUser.Text = "Crear Usuario"
        Me.btnCrearUser.UseVisualStyleBackColor = True
        '
        'txtOU
        '
        Me.txtOU.Location = New System.Drawing.Point(192, 170)
        Me.txtOU.Name = "txtOU"
        Me.txtOU.Size = New System.Drawing.Size(154, 20)
        Me.txtOU.TabIndex = 1
        '
        'txtPasswd
        '
        Me.txtPasswd.Location = New System.Drawing.Point(178, 131)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.Size = New System.Drawing.Size(242, 20)
        Me.txtPasswd.TabIndex = 2
        Me.txtPasswd.UseSystemPasswordChar = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(178, 91)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(242, 20)
        Me.txtName.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(178, 48)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(242, 20)
        Me.txtUser.TabIndex = 4
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(43, 55)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(86, 13)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "Nombre Usuario:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(43, 91)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 13)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Nombre Completo:"
        '
        'lblPasswd
        '
        Me.lblPasswd.AutoSize = True
        Me.lblPasswd.Location = New System.Drawing.Point(43, 131)
        Me.lblPasswd.Name = "lblPasswd"
        Me.lblPasswd.Size = New System.Drawing.Size(64, 13)
        Me.lblPasswd.TabIndex = 7
        Me.lblPasswd.Text = "Contraseña:"
        '
        'lblOu
        '
        Me.lblOu.AutoSize = True
        Me.lblOu.Location = New System.Drawing.Point(43, 173)
        Me.lblOu.Name = "lblOu"
        Me.lblOu.Size = New System.Drawing.Size(128, 13)
        Me.lblOu.TabIndex = 8
        Me.lblOu.Text = "Unidad Organizativa (OU)"
        '
        'Estado
        '
        Me.Estado.AutoSize = True
        Me.Estado.Location = New System.Drawing.Point(43, 255)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(0, 13)
        Me.Estado.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 397)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.lblOu)
        Me.Controls.Add(Me.lblPasswd)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPasswd)
        Me.Controls.Add(Me.txtOU)
        Me.Controls.Add(Me.btnCrearUser)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCrearUser As Button
    Friend WithEvents txtOU As TextBox
    Friend WithEvents txtPasswd As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPasswd As Label
    Friend WithEvents lblOu As Label
    Friend WithEvents Estado As Label
End Class
