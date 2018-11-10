Imports System.Windows.Forms



Public Class ConfiguracionFormularios


    Public Sub limpioControles(grupBox As GroupBox)

    End Sub

    'Configura el formulario segun la cantidad de campos y el nombre de la tabla
    Public Sub configuroFormularioInsert(ByVal paramGroupBoxTabla As GroupBox,
                                         ByVal paramNombreTabla As String,
                                         ByVal paramCantidadCampos As Integer)

        'Limpio el formulario
        For Each columna In paramGroupBoxTabla.Controls

            If TypeOf columna Is GroupBox Then
                columna.Visible = False

                For Each datoColumna In columna.Controls

                    If TypeOf datoColumna Is ComboBox Then
                        datoColumna.Items.Clear()
                    End If
                Next

            End If
        Next


        paramGroupBoxTabla.Text = "Tabla " & paramNombreTabla
        Dim cantAtributos As Integer = paramCantidadCampos
        Dim columnas As Integer = 0


        For Each columna In paramGroupBoxTabla.Controls
            If TypeOf columna Is GroupBox Then
                columna.Visible = True
                columnas += 1

                'Cargo su comboBox
                For Each datosColumna In columna.Controls
                    If TypeOf datosColumna Is ComboBox Then
                        Logica.generadorAutomatico._instancia.cargarCombo(datosColumna)
                    End If
                Next


                If columnas = cantAtributos Then
                    Exit For
                End If
            End If

        Next
    End Sub

    'Configuro la columna segun el dato que vaya a ingresar
    Public Sub configuroSegunDato(ByVal paramColumna As GroupBox, ByVal paramDato As String)

        Select Case paramDato



            Case "Nombre"
                For Each control In paramColumna.Controls
                    If TypeOf control IsNot ComboBox And control.text <> "Tipo de Dato:" Then
                        control.Visible = False
                    End If

                    If TypeOf control Is NumericUpDown Then
                        If control.Size.Width = 138 Then
                            control.value = 1

                        Else
                            control.value = 0
                        End If
                    End If

                Next

            Case "Apellido"
                For Each control In paramColumna.Controls
                    If TypeOf control IsNot ComboBox And control.text <> "Tipo de Dato:" Then
                        control.Visible = False
                    End If

                    If TypeOf control Is NumericUpDown Then
                        If control.Size.Width = 138 Then
                            control.value = 1

                        Else
                            control.value = 0
                        End If
                    End If

                Next



            'Configura el grupo para generar las cedulas
            Case "Cedula"

                For Each check In paramColumna.Controls
                    If TypeOf check Is CheckBox Then
                        check.Checked = False
                        check.Visible = True

                    ElseIf TypeOf check IsNot ComboBox And check.text <> "Tipo de Dato:" Then
                        check.Visible = False
                        If TypeOf check Is NumericUpDown Then
                            If check.Size.Width = 138 Then
                                check.value = 1

                            Else
                                check.value = 0
                            End If
                        End If

                    End If
                Next

            Case "Edad"
                For Each control In paramColumna.Controls
                    If TypeOf control IsNot ComboBox And control.text <> "Tipo de Dato:" Then
                        control.Visible = False
                    End If

                    If TypeOf control Is NumericUpDown Then
                        If control.Size.Width = 138 Then
                            control.value = 1

                        Else
                            control.value = 0
                        End If
                    End If

                Next

            Case "Numerico Random"
                For Each check In paramColumna.Controls
                    If TypeOf check Is CheckBox Then
                        check.Checked = False
                        check.Visible = True

                    ElseIf TypeOf check IsNot ComboBox And check.text <> "Tipo de Dato:" Then
                        check.Visible = False

                    End If

                    If TypeOf check Is NumericUpDown Then
                        If check.Size.Width = 138 Then
                            check.value = 1

                        Else
                            check.value = 0
                        End If
                    End If
                Next

            Case "Numerico entre Rangos"

                For Each control In paramColumna.Controls
                    If TypeOf control Is NumericUpDown Then
                        If control.Value = 0 Then
                            control.Visible = True
                        Else
                            control.Visible = False
                        End If

                    ElseIf TypeOf control IsNot ComboBox And control.Text <> "Tipo de Dato:" And control.Text <> "Desde:" And control.Text <> "Hasta:" Then
                        control.Visible = False

                    Else
                        control.Visible = True
                    End If

                    If TypeOf control Is NumericUpDown Then
                        If control.Size.Width = 138 Then
                            control.value = 1

                        Else
                            control.value = 0
                        End If
                    End If
                Next


            ' El usuario desea colocar un numero fijo que se repite en cada insert
            Case "Numerico Fijo"

                For Each num In paramColumna.Controls
                    If TypeOf num Is NumericUpDown Then
                        If num.Value = 1 Then
                            num.Visible = True
                        Else
                            num.Visible = False
                        End If


                    ElseIf TypeOf num Is Label And num.text <> "Tipo de Dato:" And num.Text <> "Desde:" And num.Text <> "Hasta:" Then
                        num.visible = True
                        num.text = "Numero:"

                    ElseIf TypeOf num IsNot ComboBox And num.text <> "Numero:" And num.Text <> "Tipo de Dato:" Then
                        num.Visible = False

                    End If

                    If TypeOf num Is NumericUpDown Then
                        If num.Size.Width = 138 Then
                            num.value = 1

                        Else
                            num.value = 0
                        End If
                    End If
                Next

            'Una cadena fija que repetira en cada Insert
            Case "Cadena Fija"


                For Each txt In paramColumna.Controls
                    If TypeOf txt Is TextBox Then
                        txt.Visible = True

                    ElseIf TypeOf txt Is Label And txt.text <> "Tipo de Dato:" And txt.Text <> "Desde:" And txt.Text <> "Hasta:" Then
                        txt.text = "Cadena:"
                        txt.Visible = True

                    ElseIf TypeOf txt IsNot ComboBox And txt.text <> "Cadena:" And txt.Text <> "Tipo de Dato:" Then
                        txt.Visible = False

                    End If

                    If TypeOf txt Is NumericUpDown Then
                        If txt.Size.Width = 138 Then
                            txt.value = 1

                        Else
                            txt.value = 0
                        End If
                    End If
                Next

            Case "Booleano"

                For Each control In paramColumna.Controls
                    If TypeOf control IsNot ComboBox And control.text <> "Tipo de Dato:" Then
                        control.Visible = False
                    End If

                    If TypeOf control Is NumericUpDown Then
                        If control.Size.Width = 138 Then
                            control.value = 1

                        Else
                            control.value = 0
                        End If
                    End If
                Next

            Case "Fecha"

                For Each control In paramColumna.Controls
                    If TypeOf control IsNot ComboBox And control.Text <> "Tipo de Dato:" And control.Text <> "Desde:" And control.Text <> "Hasta:" And TypeOf control IsNot DateTimePicker Then
                        control.Visible = False

                    Else
                        control.Visible = True
                    End If

                    If TypeOf control Is NumericUpDown Then
                        If control.Size.Width = 138 Then
                            control.value = 1

                        Else
                            control.value = 0
                        End If
                    End If
                Next


            'Si la lista de datos la desea crear el usuario
            Case "Personalizado"

                For Each boton In paramColumna.Controls

                    If TypeOf boton Is Button Then
                        boton.Visible = True

                    ElseIf TypeOf boton IsNot ComboBox And boton.text <> "Tipo de Dato:" Then
                        boton.Visible = False
                    End If

                    If TypeOf boton Is NumericUpDown Then
                        If boton.Size.Width = 138 Then
                            boton.value = 1

                        Else
                            boton.value = 0
                        End If
                    End If

                Next



        End Select

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
