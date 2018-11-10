Public Class frmScriptEntidad
    Dim configurador As New Logica.ConfiguracionFormularios

    'Lista con las tablas creadas
    Dim listaTablas As New List(Of String)



#Region "METODOS"



    Private Sub CargarTabla()
        If txtNombreTabla.Text = "" Then
            MsgBox("Debe escribir el nombre de la tabla")

        Else
            Dim nombreTabla As String = validoEspaciosVacios(txtNombreTabla.Text)

            If nombreTabla <> txtNombreTabla.Text Then
                Dim resultado As Integer = MsgBox("El nombre: " & txtNombreTabla.Text & " no es valido para una tabla SQL" & vbNewLine &
                       "El sistema lo cambiara a: " & nombreTabla, vbOK, "Nombre de tabla invalido")

                If resultado = DialogResult.OK Then
                    txtNombreTabla.Text = nombreTabla
                    configurador.configuroFormularioInsert(gbNombreTabla, txtNombreTabla.Text, numCantidadCampos.Value)
                End If
            Else

                configurador.configuroFormularioInsert(gbNombreTabla, txtNombreTabla.Text, numCantidadCampos.Value)

            End If
        End If
    End Sub


    'Valido los espacios en blanco y los sustiuyo por _ (Los nombres de tablas SQL no tienen espacios en blanco)
    Private Function validoEspaciosVacios(ByVal nombreTabla As String) As String
        Dim nuevoNombre As String = ""
        For Each letra In nombreTabla
            If letra <> " " Then
                nuevoNombre &= letra
            Else
                nuevoNombre &= "_"
            End If
        Next

        Return nuevoNombre
    End Function

#End Region

#Region "EVENTOS"

    'Cuando cargo click, configuro el formulario segun la cantidad de campos y el nobmre de la tabla
    Private Sub btnCargarTabla_Click(sender As Object, e As EventArgs) Handles btnCargarTabla.Click
        CargarTabla()

    End Sub


    'Configuro la columna segun el tipo de datos que seleccione el usuario
#Region "ComboBox columnas"

    Private Sub cmbColumna1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColumna1.SelectedIndexChanged
        configurador.configuroSegunDato(cmbColumna1.Parent, cmbColumna1.SelectedItem)
    End Sub

    Private Sub cmbColumna2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColumna2.SelectedIndexChanged
        configurador.configuroSegunDato(cmbColumna2.Parent, cmbColumna2.SelectedItem)
    End Sub

    Private Sub cmbColumna3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColumna3.SelectedIndexChanged
        configurador.configuroSegunDato(cmbColumna3.Parent, cmbColumna3.SelectedItem)
    End Sub

    Private Sub cmbColumna4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColumna4.SelectedIndexChanged
        configurador.configuroSegunDato(cmbColumna4.Parent, cmbColumna4.SelectedItem)
    End Sub

    Private Sub cmbColumna5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColumna5.SelectedIndexChanged
        configurador.configuroSegunDato(cmbColumna5.Parent, cmbColumna5.SelectedItem)
    End Sub

    Private Sub cmbColumna6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColumna6.SelectedIndexChanged
        configurador.configuroSegunDato(cmbColumna6.Parent, cmbColumna6.SelectedItem)
    End Sub

    Private Sub cmbColumna7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColumna7.SelectedIndexChanged
        configurador.configuroSegunDato(cmbColumna7.Parent, cmbColumna7.SelectedItem)
    End Sub

    Private Sub cmbColumna8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColumna8.SelectedIndexChanged
        configurador.configuroSegunDato(cmbColumna8.Parent, cmbColumna8.SelectedItem)
    End Sub


#End Region


    'GENERO EL SCRIPT (INDIVIDUAL O MULTI)
    Private Sub btnGenerarScript_Click(sender As Object, e As EventArgs) Handles btnGenerarScript.Click
        Dim existeScript As Boolean = Logica.generadorAutomatico._instancia.existeScript(txtNombreTabla.Text)

        If existeScript Then
            Dim result As DialogResult = MsgBox("El script ya existe." & vbNewLine & "¿Desea sobrescribirlo?", vbYesNo, "Conflicto de Script")

            'Si al usuario le da igual, lo sobrescrivo
            If result = DialogResult.Yes Then
                Logica.generadorAutomatico._instancia.cargarScriptIndividual(Logica.generadorAutomatico._instancia.generarScript(txtNombreTabla.Text, numInserts.Value, numCantidadCampos.Value, gbNombreTabla), txtNombreTabla.Text)
            End If

        Else
            Logica.generadorAutomatico._instancia.cargarScriptIndividual(Logica.generadorAutomatico._instancia.generarScript(txtNombreTabla.Text, numInserts.Value, numCantidadCampos.Value, gbNombreTabla), txtNombreTabla.Text)
        End If





        'If chkIndividual.Checked Then
        'Dim script = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & txtNombreTabla.Text & ".sql"
        '    ' My.Computer.FileSystem.WriteAllText(script, generador.generarScript(txtNombreTabla.Text, numInserts.Value, numCantidadCampos.Value, gbNombreTabla))


        'End If

        '        Dim ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\scriptBD.sql"
        'My.Computer.FileSystem.WriteAllText(ruta, scripGenerado(numCantidadCampos, numInserts), True)
        'A RETOCAR!!!!!|
    End Sub

    Private Sub frmScriptEntidad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Resetear todo lo de generar entidad
        Me.Dispose()
        frmMenuPrincipal.Show()

    End Sub





#Region "Boton Lista Personalizada"


    Private Sub btnListaPersonalizadaC1_Click(sender As Object, e As EventArgs) Handles btnListaPersonalizadaC1.Click
        Dim frmLista As New frmLista
        frmLista.listaPersonalizada = Logica.generadorAutomatico._instancia.listaColumna1
        frmLista.Text = "Lista Personalizada - Columna 1"
        frmLista.ShowDialog()
    End Sub

    Private Sub btnListaPersonalizadaC2_Click(sender As Object, e As EventArgs) Handles btnListaPersonalizadaC2.Click

        Dim frmLista As New frmLista
        frmLista.listaPersonalizada = Logica.generadorAutomatico._instancia.listaColumna2
        frmLista.Text = "Lista Personalizada - Columna 2"
        frmLista.ShowDialog()

    End Sub

    Private Sub btnListaPersonalizadaC3_Click(sender As Object, e As EventArgs) Handles btnListaPersonalizadaC3.Click

        Dim frmLista As New frmLista
        frmLista.listaPersonalizada = Logica.generadorAutomatico._instancia.listaColumna3
        frmLista.Text = "Lista Personalizada - Columna 3"
        frmLista.ShowDialog()

    End Sub

    Private Sub btnListaPersonalizadaC4_Click(sender As Object, e As EventArgs) Handles btnListaPersonalizadaC4.Click

        Dim frmLista As New frmLista
        frmLista.listaPersonalizada = Logica.generadorAutomatico._instancia.listaColumna4
        frmLista.Text = "Lista Personalizada - Columna 4"
        frmLista.ShowDialog()

    End Sub

    Private Sub btnListaPersonalizadaC5_Click(sender As Object, e As EventArgs) Handles btnListaPersonalizadaC5.Click

        Dim frmLista As New frmLista
        frmLista.listaPersonalizada = Logica.generadorAutomatico._instancia.listaColumna5
        frmLista.Text = "Lista Personalizada - Columna 5"
        frmLista.ShowDialog()

    End Sub

    Private Sub btnListaPersonalizadaC6_Click(sender As Object, e As EventArgs) Handles btnListaPersonalizadaC6.Click

        Dim frmLista As New frmLista
        frmLista.listaPersonalizada = Logica.generadorAutomatico._instancia.listaColumna6
        frmLista.Text = "Lista Personalizada - Columna 6"
        frmLista.ShowDialog()

    End Sub

    Private Sub btnListaPersonalizadaC7_Click(sender As Object, e As EventArgs) Handles btnListaPersonalizadaC7.Click

        Dim frmLista As New frmLista
        frmLista.listaPersonalizada = Logica.generadorAutomatico._instancia.listaColumna7
        frmLista.Text = "Lista Personalizada - Columna 7"
        frmLista.ShowDialog()

    End Sub

    Private Sub btnListaPersonalizadaC8_Click(sender As Object, e As EventArgs) Handles btnListaPersonalizadaC8.Click

        Dim frmLista As New frmLista
        frmLista.listaPersonalizada = Logica.generadorAutomatico._instancia.listaColumna8
        frmLista.Text = "Lista Personalizada - Columna 8"
        frmLista.ShowDialog()

    End Sub

    Private Sub frmScriptEntidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


#End Region



















#End Region


End Class