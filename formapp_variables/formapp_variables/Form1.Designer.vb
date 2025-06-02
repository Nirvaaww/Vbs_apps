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
        lblUser = New Label()
        txtUser = New TextBox()
        lblName = New Label()
        txtName = New TextBox()
        lblpasswd = New Label()
        txtpasswd = New TextBox()
        lblOu = New Label()
        txtOu = New TextBox()
        btnCrearUser = New Button()
        estado = New Label()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Location = New Point(77, 65)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(112, 15)
        lblUser.TabIndex = 0
        lblUser.Text = "Nombre de usuario:"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(206, 62)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(197, 23)
        txtUser.TabIndex = 1
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(77, 104)
        lblName.Name = "lblName"
        lblName.Size = New Size(110, 15)
        lblName.TabIndex = 2
        lblName.Text = "Nombre Completo:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(206, 96)
        txtName.Name = "txtName"
        txtName.Size = New Size(197, 23)
        txtName.TabIndex = 3
        ' 
        ' lblpasswd
        ' 
        lblpasswd.AutoSize = True
        lblpasswd.Location = New Point(77, 138)
        lblpasswd.Name = "lblpasswd"
        lblpasswd.Size = New Size(70, 15)
        lblpasswd.TabIndex = 4
        lblpasswd.Text = "Contraseña:"
        ' 
        ' txtpasswd
        ' 
        txtpasswd.Location = New Point(207, 135)
        txtpasswd.Name = "txtpasswd"
        txtpasswd.Size = New Size(196, 23)
        txtpasswd.TabIndex = 5
        txtpasswd.UseSystemPasswordChar = True
        ' 
        ' lblOu
        ' 
        lblOu.AutoSize = True
        lblOu.Location = New Point(77, 175)
        lblOu.Name = "lblOu"
        lblOu.Size = New Size(145, 15)
        lblOu.TabIndex = 6
        lblOu.Text = "Unidad Organizativa (OU):"
        ' 
        ' txtOu
        ' 
        txtOu.Location = New Point(244, 172)
        txtOu.Name = "txtOu"
        txtOu.Size = New Size(157, 23)
        txtOu.TabIndex = 7
        ' 
        ' btnCrearUser
        ' 
        btnCrearUser.Location = New Point(300, 274)
        btnCrearUser.Name = "btnCrearUser"
        btnCrearUser.Size = New Size(103, 23)
        btnCrearUser.TabIndex = 8
        btnCrearUser.Text = "Crear Usuario"
        btnCrearUser.UseVisualStyleBackColor = True
        ' 
        ' estado
        ' 
        estado.AutoSize = True
        estado.Location = New Point(330, 210)
        estado.Name = "estado"
        estado.Size = New Size(0, 15)
        estado.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(484, 450)
        Controls.Add(estado)
        Controls.Add(btnCrearUser)
        Controls.Add(txtOu)
        Controls.Add(lblOu)
        Controls.Add(txtpasswd)
        Controls.Add(lblpasswd)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(txtUser)
        Controls.Add(lblUser)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblpasswd As Label
    Friend WithEvents txtpasswd As TextBox
    Friend WithEvents lblOu As Label
    Friend WithEvents txtOu As TextBox
    Friend WithEvents btnCrearUser As Button
    Friend WithEvents estado As Label

End Class
