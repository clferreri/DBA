<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLista
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbPersonalizada = New System.Windows.Forms.ListBox()
        Me.txtNuevoDato = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCargada = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAyuda = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEliminarElemento = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnGuardarLista = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCargarLista = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAgregarElementoLista = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAyuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminarElemento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardarLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCargarLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarElementoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbPersonalizada
        '
        Me.lbPersonalizada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbPersonalizada.FormattingEnabled = True
        Me.lbPersonalizada.Location = New System.Drawing.Point(12, 12)
        Me.lbPersonalizada.Name = "lbPersonalizada"
        Me.lbPersonalizada.Size = New System.Drawing.Size(142, 225)
        Me.lbPersonalizada.TabIndex = 0
        '
        'txtNuevoDato
        '
        Me.txtNuevoDato.Location = New System.Drawing.Point(15, 27)
        Me.txtNuevoDato.Name = "txtNuevoDato"
        Me.txtNuevoDato.Size = New System.Drawing.Size(117, 20)
        Me.txtNuevoDato.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnAgregarElementoLista)
        Me.GroupBox1.Controls.Add(Me.txtNuevoDato)
        Me.GroupBox1.Location = New System.Drawing.Point(167, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 97)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo dato"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblCargada)
        Me.GroupBox2.Controls.Add(Me.btnCargarLista)
        Me.GroupBox2.Location = New System.Drawing.Point(167, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 73)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cargar lista local"
        '
        'lblCargada
        '
        Me.lblCargada.AutoSize = True
        Me.lblCargada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargada.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblCargada.Location = New System.Drawing.Point(12, 38)
        Me.lblCargada.Name = "lblCargada"
        Me.lblCargada.Size = New System.Drawing.Size(71, 13)
        Me.lblCargada.TabIndex = 1
        Me.lblCargada.Text = "Lista cargada"
        Me.lblCargada.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Descartar"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton2.Image = Global.Data_base_assistent.My.Resources.Resources.ExportarArchivo
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(242, 207)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 15
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = Global.Data_base_assistent.My.Resources.Resources.BuscarArchiv
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(205, 207)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 14
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.Transparent
        Me.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAyuda.Image = Global.Data_base_assistent.My.Resources.Resources.info
        Me.btnAyuda.ImageActive = Nothing
        Me.btnAyuda.Location = New System.Drawing.Point(280, 207)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(30, 30)
        Me.btnAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAyuda.TabIndex = 13
        Me.btnAyuda.TabStop = False
        Me.btnAyuda.Zoom = 10
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleDescription = "Guardar"
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Image = Global.Data_base_assistent.My.Resources.Resources.txt
        Me.btnCancelar.ImageActive = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(39, 272)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(50, 50)
        Me.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Zoom = 10
        '
        'btnEliminarElemento
        '
        Me.btnEliminarElemento.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarElemento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarElemento.Image = Global.Data_base_assistent.My.Resources.Resources.goma_de_borrar
        Me.btnEliminarElemento.ImageActive = Nothing
        Me.btnEliminarElemento.Location = New System.Drawing.Point(167, 207)
        Me.btnEliminarElemento.Name = "btnEliminarElemento"
        Me.btnEliminarElemento.Size = New System.Drawing.Size(30, 30)
        Me.btnEliminarElemento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEliminarElemento.TabIndex = 9
        Me.btnEliminarElemento.TabStop = False
        Me.btnEliminarElemento.Zoom = 10
        '
        'btnGuardarLista
        '
        Me.btnGuardarLista.AccessibleDescription = "Guardar"
        Me.btnGuardarLista.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarLista.Image = Global.Data_base_assistent.My.Resources.Resources.guardar
        Me.btnGuardarLista.ImageActive = Nothing
        Me.btnGuardarLista.Location = New System.Drawing.Point(229, 272)
        Me.btnGuardarLista.Name = "btnGuardarLista"
        Me.btnGuardarLista.Size = New System.Drawing.Size(50, 50)
        Me.btnGuardarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGuardarLista.TabIndex = 8
        Me.btnGuardarLista.TabStop = False
        Me.btnGuardarLista.Zoom = 10
        '
        'btnCargarLista
        '
        Me.btnCargarLista.BackColor = System.Drawing.Color.Transparent
        Me.btnCargarLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarLista.Image = Global.Data_base_assistent.My.Resources.Resources.carpeta
        Me.btnCargarLista.ImageActive = Nothing
        Me.btnCargarLista.Location = New System.Drawing.Point(102, 29)
        Me.btnCargarLista.Name = "btnCargarLista"
        Me.btnCargarLista.Size = New System.Drawing.Size(30, 30)
        Me.btnCargarLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCargarLista.TabIndex = 0
        Me.btnCargarLista.TabStop = False
        Me.btnCargarLista.Zoom = 10
        '
        'btnAgregarElementoLista
        '
        Me.btnAgregarElementoLista.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarElementoLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarElementoLista.Image = Global.Data_base_assistent.My.Resources.Resources.mas
        Me.btnAgregarElementoLista.ImageActive = Nothing
        Me.btnAgregarElementoLista.Location = New System.Drawing.Point(102, 53)
        Me.btnAgregarElementoLista.Name = "btnAgregarElementoLista"
        Me.btnAgregarElementoLista.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarElementoLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAgregarElementoLista.TabIndex = 9
        Me.btnAgregarElementoLista.TabStop = False
        Me.btnAgregarElementoLista.Zoom = 10
        '
        'frmLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(322, 354)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminarElemento)
        Me.Controls.Add(Me.btnGuardarLista)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbPersonalizada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAyuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminarElemento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardarLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCargarLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarElementoLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPersonalizada As ListBox
    Friend WithEvents txtNuevoDato As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardarLista As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCargarLista As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAgregarElementoLista As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnEliminarElemento As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAyuda As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblCargada As Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
End Class
