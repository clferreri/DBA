Public Class frmLista
    Public listaPersonalizada As New List(Of String)
    Dim listaTemporal As New List(Of String)
    Dim cambios As Boolean = False

    Private Sub configuroFormulario()
        lbPersonalizada.Items.Clear()

        For Each dato In listaTemporal
            lbPersonalizada.Items.Add(dato)
        Next

    End Sub

    Private Sub cargoListaTemporal()
        For Each dato In listaPersonalizada
            listaTemporal.Add(dato)
        Next
    End Sub



    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargoListaTemporal()
        configuroFormulario()

    End Sub


    Private Sub btnGuardarLista_Click(sender As Object, e As EventArgs) Handles btnGuardarLista.Click
        listaPersonalizada.Clear()

        For Each dato In listaTemporal
            listaPersonalizada.Add(dato)
        Next

        MsgBox("Lista personalizada con exito")
        cambios = False
        Me.Dispose()
    End Sub

    Private Sub btnAgregarElementoLista_Click(sender As Object, e As EventArgs) Handles btnAgregarElementoLista.Click
        cambios = True
        Dim datoRepetido As Boolean = False
        If txtNuevoDato.Text = "" Then
            MsgBox("El dato a agregar no puede ser vacio.")
        Else
            If listaTemporal.Count > 0 Then
                For Each dato In listaTemporal
                    If dato = txtNuevoDato.Text Then
                        MsgBox("El dato que intenta agregar ya existe.")
                        datoRepetido = True
                        Exit For
                    End If
                Next
            End If

            If Not datoRepetido Then
                listaTemporal.Add(txtNuevoDato.Text)
            End If

        End If

        configuroFormulario()
        txtNuevoDato.Clear()
    End Sub

    Private Sub btnEliminarElemento_Click(sender As Object, e As EventArgs) Handles btnEliminarElemento.Click
        Try
            listaTemporal.RemoveAt(lbPersonalizada.SelectedIndex)
            configuroFormulario()

        Catch ex As Exception

            MsgBox("Debe seleccionar un elemento de la lista a borrar")

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCargarLista_Click(sender As Object, e As EventArgs) Handles btnCargarLista.Click
        Dim NavegadorCargarLista As New OpenFileDialog()

        NavegadorCargarLista.InitialDirectory = "c:\"
        NavegadorCargarLista.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        NavegadorCargarLista.FilterIndex = 2
        NavegadorCargarLista.RestoreDirectory = True

        If NavegadorCargarLista.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            lblCargada.Visible = True
            MsgBox("NO FUNCIONA AUN!!! JAJA.... Proximaente en la version 0.2b")

        End If

    End Sub

    Private Sub lbPersonalizada_DoubleClick(sender As Object, e As EventArgs) Handles lbPersonalizada.DoubleClick
        Dim ampliacionLista As New frmAmpliacionLista
        ampliacionLista.listaAmpliada.DataSource = listaTemporal
        ampliacionLista.ShowDialog()

    End Sub




    'Dim cerrar As Integer = 1

    'If cambios = True Then

    '       cerrar = MsgBox("¿Desa cerrar el formulario sin guardar?", vbOKCancel)

    '    End If

    'If cerrar = 1 Then
    'Me.Dispose()
    'End If
End Class