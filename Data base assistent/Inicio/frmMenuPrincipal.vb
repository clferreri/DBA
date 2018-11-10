Public Class frmMenuPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frm As New frmScriptEntidad
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Configurar()
        CargarListas()
        cmbIdioma.SelectedIndex = 0
        cmbMotorBD.SelectedIndex = 0


    End Sub

    Private Sub Configurar()

    End Sub

    Private Sub CargarListas()
        Logica.generadorAutomatico._instancia.cargarNombres()
        Logica.generadorAutomatico._instancia.cargarApellidos()
        Logica.generadorAutomatico._instancia.CargarListaTemplate()
    End Sub
End Class
