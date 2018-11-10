Imports System.Windows.Forms
Imports System.IO

Public Class generadorAutomatico

#Region "Singleton"
    Public Shared _instancia As New generadorAutomatico

    Private Sub New()

    End Sub

    Public Property Instancia As generadorAutomatico
        Get
            Return _instancia
        End Get
        Set(value As generadorAutomatico)
            _instancia = value
        End Set
    End Property
#End Region

#Region "Listas Y Objetos"
    Dim Random As New Random() 'genreador de numero random
    Dim script As New List(Of String) ' Lista con el script generado
    Dim idioma As Integer
    Dim motorBD As Integer

    'Listas Automaticas del Sistema
    Dim cedulas As New List(Of Integer)
    Dim nombres As New List(Of String)
    Dim apellidos As New List(Of String)
    Dim telefonos As New List(Of Integer)

    'Listas de las columnas
    Public listaColumna1 As New List(Of String)
    Public listaColumna2 As New List(Of String)
    Public listaColumna3 As New List(Of String)
    Public listaColumna4 As New List(Of String)
    Public listaColumna5 As New List(Of String)
    Public listaColumna6 As New List(Of String)
    Public listaColumna7 As New List(Of String)
    Public listaColumna8 As New List(Of String)


    Dim valoresCampos As New List(Of String)

#End Region

#Region "Logica interna"
    Public Sub cargarNombres()

        Dim ruta As String = Application.StartupPath & "\Lista Generadores\"
        Dim nombLista As String = "Nombres.txt"
        Dim fs As FileStream


        Try
            If Not File.Exists(ruta) Then
                'Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)
            End If

            'Si no existe el txt te lo creo y le agrego la base
            If Not File.Exists(ruta & nombLista) Then

                fs = File.Create(ruta & nombLista)
                fs.Close()

                Dim escribir As New StreamWriter(ruta & nombLista)
#Region "Nombres Bases"
                escribir.WriteLine("##################################################################")
                escribir.WriteLine("### LISTA CON 150 NOMBRES PARA GENERADOR AUTOMATICO DE NOMBRES ###")
                escribir.WriteLine("###------------------------------------------------------------###")
                escribir.WriteLine("###                     ELEMENTARY COMPANY                     ###")
                escribir.WriteLine("##################################################################")
                escribir.WriteLine("")
                escribir.WriteLine("")

                escribir.WriteLine("      <---- Comienzo de la lista ---->")
                escribir.WriteLine("")

                escribir.WriteLine("Aarón")
                escribir.WriteLine("Abel")
                escribir.WriteLine("Abelardo")
                escribir.WriteLine("Abraham")
                escribir.WriteLine("Adam")

                escribir.WriteLine("")

                escribir.WriteLine("Aida")
                escribir.WriteLine("Aisha")
                escribir.WriteLine("Alia")
                escribir.WriteLine("Amina")
                escribir.WriteLine("Ana Laura")

                escribir.WriteLine("")

                escribir.WriteLine("Agustin")
                escribir.WriteLine("Alejandro")
                escribir.WriteLine("Amadeo")
                escribir.WriteLine("Augusto")
                escribir.WriteLine("Baltasar")

                escribir.WriteLine("")

                escribir.WriteLine("Anabel")
                escribir.WriteLine("Ana Maria")
                escribir.WriteLine("Amira")
                escribir.WriteLine("Agustina")
                escribir.WriteLine("Daniela")

                escribir.WriteLine("")

                escribir.WriteLine("Bartolomeo")
                escribir.WriteLine("Blas")
                escribir.WriteLine("Bruno")
                escribir.WriteLine("Camilo")
                escribir.WriteLine("Carlos")

                escribir.WriteLine("")

                escribir.WriteLine("Abigail")
                escribir.WriteLine("Abril")
                escribir.WriteLine("Adriana")
                escribir.WriteLine("Aldana")
                escribir.WriteLine("Alfonsina")

                escribir.WriteLine("")

                escribir.WriteLine("Cayetano")
                escribir.WriteLine("César")
                escribir.WriteLine("Christian")
                escribir.WriteLine("Cristian")
                escribir.WriteLine("Clemente")

                escribir.WriteLine("")

                escribir.WriteLine("Barbara")
                escribir.WriteLine("Beatriz")
                escribir.WriteLine("Belen")
                escribir.WriteLine("Betiana")
                escribir.WriteLine("Betty")


                escribir.WriteLine("")

                escribir.WriteLine("Conrado")
                escribir.WriteLine("Joaquin")
                escribir.WriteLine("Joel")
                escribir.WriteLine("Jordi")
                escribir.WriteLine("Jorge")

                escribir.WriteLine("")

                escribir.WriteLine("Brenda")
                escribir.WriteLine("Camila")
                escribir.WriteLine("Carmen")
                escribir.WriteLine("Cecilia")
                escribir.WriteLine("Celestina")

                escribir.WriteLine("")

                escribir.WriteLine("Jose Luis")
                escribir.WriteLine("Juan")
                escribir.WriteLine("Brahim")
                escribir.WriteLine("Leonardo")
                escribir.WriteLine("Emiliano")

                escribir.WriteLine("")

                escribir.WriteLine("Casandra")
                escribir.WriteLine("Celeste")
                escribir.WriteLine("Cinthia")
                escribir.WriteLine("Clarisa")
                escribir.WriteLine("Consuelo")

                escribir.WriteLine("")

                escribir.WriteLine("Cayetano")
                escribir.WriteLine("Conrado")
                escribir.WriteLine("Fabricio")
                escribir.WriteLine("Facundo")
                escribir.WriteLine("Fabian")

                escribir.WriteLine("")

                escribir.WriteLine("Cristina")
                escribir.WriteLine("Dafne")
                escribir.WriteLine("Dalma")
                escribir.WriteLine("Debora")
                escribir.WriteLine("Dora")

                escribir.WriteLine("")

                escribir.WriteLine("Federico")
                escribir.WriteLine("Diego")
                escribir.WriteLine("Leopoldo")
                escribir.WriteLine("Enrique")
                escribir.WriteLine("Matias")

                escribir.WriteLine("")

                escribir.WriteLine("Doris")
                escribir.WriteLine("Edith")
                escribir.WriteLine("Elena")
                escribir.WriteLine("Elian")
                escribir.WriteLine("Eloisa")

                escribir.WriteLine("")

                escribir.WriteLine("Sebastian")
                escribir.WriteLine("Santiago")
                escribir.WriteLine("Lucas")
                escribir.WriteLine("Javier")
                escribir.WriteLine("Marcos")

                escribir.WriteLine("")

                escribir.WriteLine("Elizabeth")
                escribir.WriteLine("Emma")
                escribir.WriteLine("Erika")
                escribir.WriteLine("Esmeralda")
                escribir.WriteLine("Eugenia")

                escribir.WriteLine("")

                escribir.WriteLine("Martin")
                escribir.WriteLine("Luciano")
                escribir.WriteLine("Samuel")
                escribir.WriteLine("Pedro")
                escribir.WriteLine("Pablo")

                escribir.WriteLine("")

                escribir.WriteLine("Fabiana")
                escribir.WriteLine("Felicia")
                escribir.WriteLine("Fernanda")
                escribir.WriteLine("Fiorella")
                escribir.WriteLine("Frida")

                escribir.WriteLine("")

                escribir.WriteLine("Marcelo")
                escribir.WriteLine("Ignacio")
                escribir.WriteLine("Patricio")
                escribir.WriteLine("Alexis")
                escribir.WriteLine("Gaston")

                escribir.WriteLine("")

                escribir.WriteLine("Gabriela")
                escribir.WriteLine("Gala")
                escribir.WriteLine("Georgina")
                escribir.WriteLine("Giannina")
                escribir.WriteLine("Giselle")

                escribir.WriteLine("")

                escribir.WriteLine("Mario")
                escribir.WriteLine("Ramon")
                escribir.WriteLine("Ruben")
                escribir.WriteLine("Jaime")
                escribir.WriteLine("Damian")

                escribir.WriteLine("")

                escribir.WriteLine("Heidi")
                escribir.WriteLine("Hilaria")
                escribir.WriteLine("Helena")
                escribir.WriteLine("Ines")
                escribir.WriteLine("Iris")

                escribir.WriteLine("")

                escribir.WriteLine("Daniel")
                escribir.WriteLine("Fernado")
                escribir.WriteLine("Paul")
                escribir.WriteLine("Jesus")
                escribir.WriteLine("Walter")

                escribir.WriteLine("")

                escribir.WriteLine("Irma")
                escribir.WriteLine("Ivonne")
                escribir.WriteLine("Melissa")
                escribir.WriteLine("Leticia")
                escribir.WriteLine("Valeria")

                escribir.WriteLine("")

                escribir.WriteLine("Valerio")
                escribir.WriteLine("Victor")
                escribir.WriteLine("Vladimir")
                escribir.WriteLine("Williams")
                escribir.WriteLine("Washington")

                escribir.WriteLine("")

                escribir.WriteLine("Julia")
                escribir.WriteLine("Jimena")
                escribir.WriteLine("Lilian")
                escribir.WriteLine("Maite")
                escribir.WriteLine("Stella")

                escribir.WriteLine("")

                escribir.WriteLine("Woody")
                escribir.WriteLine("Wilson")
                escribir.WriteLine("Tyler")

                escribir.WriteLine("")

                escribir.WriteLine("Vanessa")
                escribir.WriteLine("Veronica")
                escribir.WriteLine("Ursula")

                escribir.WriteLine("")

#End Region

                escribir.Close()
            End If

            'Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
            Dim leer As New StreamReader(ruta & nombLista)
            'Si la lista ya existe o fue creada, voy a cargarla en la memoria
            Try
                Dim contador = 0
                'Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
                While leer.Peek <> -1

                    contador += 1
                    'Leemos cada linea del archivo TXT
                    Dim linea As String = leer.ReadLine()

                    'Validamos que la linea no este vacia
                    If String.IsNullOrEmpty(linea) Then
                        Continue While
                    End If
                    'Agregramos los registros encontrados

                    If contador > 9 Then
                        nombres.Add(linea)
                    End If



                End While

                leer.Close()

            Catch ex As Exception
                MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, "Data Base Assistent")
            End Try
        Catch ex As Exception

        End Try


    End Sub

    Public Sub cargarApellidos()

        Dim ruta As String = Application.StartupPath & "\Lista Generadores\"
        Dim nombLista As String = "Apellidos.txt"
        Dim fs As FileStream


        Try
            If Not File.Exists(ruta) Then
                'Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)
            End If

            'Si no existe el txt te lo creo y le agrego la base
            If Not File.Exists(ruta & nombLista) Then

                fs = File.Create(ruta & nombLista)
                fs.Close()

                Dim escribir As New StreamWriter(ruta & nombLista)
#Region "Apellidos Bases"
                escribir.WriteLine("######################################################################")
                escribir.WriteLine("### LISTA CON 100 APELLIDOS PARA GENERADOR AUTOMATICO DE APELLIDOS ###")
                escribir.WriteLine("###----------------------------------------------------------------###")
                escribir.WriteLine("###                       ELEMENTARY COMPANY                       ###")
                escribir.WriteLine("######################################################################")
                escribir.WriteLine("")
                escribir.WriteLine("")

                escribir.WriteLine("      <---- Comienzo de la lista ---->")
                escribir.WriteLine("")

                escribir.WriteLine("Abad")
                escribir.WriteLine("Abadia")
                escribir.WriteLine("Abajo")
                escribir.WriteLine("Abarca")
                escribir.WriteLine("Abellana")
                escribir.WriteLine("Abengoza")
                escribir.WriteLine("Abiego")
                escribir.WriteLine("Abina")
                escribir.WriteLine("Abréu")
                escribir.WriteLine("Abril")
                escribir.WriteLine("Acuña")
                escribir.WriteLine("Acosta")
                escribir.WriteLine("Acuña")
                escribir.WriteLine("Adán")
                escribir.WriteLine("Agar")
                escribir.WriteLine("Alvez")
                escribir.WriteLine("Aguado")
                escribir.WriteLine("Aguirre")
                escribir.WriteLine("Ahajadas")
                escribir.WriteLine("Aimerich")
                escribir.WriteLine("Agudo")
                escribir.WriteLine("Araújo")
                escribir.WriteLine("Araciel")
                escribir.WriteLine("Arauco")

                escribir.WriteLine("")

                escribir.WriteLine("Bacara")
                escribir.WriteLine("Bada")
                escribir.WriteLine("Badia")
                escribir.WriteLine("Balboa")
                escribir.WriteLine("Balbuena")
                escribir.WriteLine("Baldovinos")
                escribir.WriteLine("Ballero")
                escribir.WriteLine("Ballastros")
                escribir.WriteLine("Banda")
                escribir.WriteLine("Balzoa")
                escribir.WriteLine("Barahona")
                escribir.WriteLine("Barber")
                escribir.WriteLine("Barceló")
                escribir.WriteLine("Barnuevo")
                escribir.WriteLine("Bas")
                escribir.WriteLine("Bayer")
                escribir.WriteLine("Bautista")
                escribir.WriteLine("Bazan")
                escribir.WriteLine("Bascones")
                escribir.WriteLine("Bustamante")
                escribir.WriteLine("Busto")
                escribir.WriteLine("Burell")

                escribir.WriteLine("")

                escribir.WriteLine("Caballero")
                escribir.WriteLine("Cabezas")
                escribir.WriteLine("Cabra")
                escribir.WriteLine("Cabrales")
                escribir.WriteLine("Calella")
                escribir.WriteLine("Camero")
                escribir.WriteLine("Calvo")
                escribir.WriteLine("Caminero")
                escribir.WriteLine("Calatrava")
                escribir.WriteLine("Calleja")
                escribir.WriteLine("Carballo")
                escribir.WriteLine("Carbajal")
                escribir.WriteLine("Camparros")
                escribir.WriteLine("Canillas")
                escribir.WriteLine("Canal")
                escribir.WriteLine("Carrasco")
                escribir.WriteLine("Carreño")
                escribir.WriteLine("Carrillo")
                escribir.WriteLine("Casas")
                escribir.WriteLine("Cascos")
                escribir.WriteLine("Castañer")
                escribir.WriteLine("Castejon")
                escribir.WriteLine("Catalá")
                escribir.WriteLine("Castillo")
                escribir.WriteLine("Cesped")
                escribir.WriteLine("Cima")
                escribir.WriteLine("Clavijo")
                escribir.WriteLine("Cobo")

                escribir.WriteLine("")

                escribir.WriteLine("De Arcas")
                escribir.WriteLine("De Castro")
                escribir.WriteLine("Doliva")
                escribir.WriteLine("Donat")
                escribir.WriteLine("Donaire")
                escribir.WriteLine("Doncel")
                escribir.WriteLine("Donis")
                escribir.WriteLine("Dorcas")
                escribir.WriteLine("Dulce")
                escribir.WriteLine("Durán")
                escribir.WriteLine("Duero")
                escribir.WriteLine("Duque")
                escribir.WriteLine("De Rivero")
                escribir.WriteLine("Del Potro")
                escribir.WriteLine("Denis")
                escribir.WriteLine("Donate")
                escribir.WriteLine("Deglio")


                escribir.WriteLine("")

                escribir.WriteLine("Echague")
                escribir.WriteLine("Echábarri")
                escribir.WriteLine("Echanove")
                escribir.WriteLine("Eizaga")
                escribir.WriteLine("Elcano")
                escribir.WriteLine("Elizalde")
                escribir.WriteLine("Elias")
                escribir.WriteLine("Elordi")
                escribir.WriteLine("Elorriaga")
                escribir.WriteLine("Elorza")
                escribir.WriteLine("Ena")
                escribir.WriteLine("Encina")
                escribir.WriteLine("Enciso")
                escribir.WriteLine("Ercille")
                escribir.WriteLine("Escalante")
                escribir.WriteLine("Escobar")
                escribir.WriteLine("Escavias")
                escribir.WriteLine("Escama")
                escribir.WriteLine("Escudero")
                escribir.WriteLine("Espaser")
                escribir.WriteLine("Esquerdo")
                escribir.WriteLine("Espinosa")
                escribir.WriteLine("Estébanez")

                escribir.WriteLine("")

                escribir.WriteLine("Ferreri")
                escribir.WriteLine("Fernandez")
                escribir.WriteLine("Fagundez")
                escribir.WriteLine("Fieltro")

                escribir.WriteLine("")

                escribir.WriteLine("Gavira")
                escribir.WriteLine("Gaztelu")
                escribir.WriteLine("Giraldo")
                escribir.WriteLine("Gispert")
                escribir.WriteLine("Godoy")
                escribir.WriteLine("Goicoechea")
                escribir.WriteLine("Goiri")
                escribir.WriteLine("Golfín")
                escribir.WriteLine("Góngora")
                escribir.WriteLine("Goñi")
                escribir.WriteLine("Gordon")
                escribir.WriteLine("Gorostidi")
                escribir.WriteLine("Grandes")
                escribir.WriteLine("Guadalajara")
                escribir.WriteLine("Guerra")
                escribir.WriteLine("Guiral")
                escribir.WriteLine("Guirao")
                escribir.WriteLine("Gitano")
                escribir.WriteLine("Goya")
                escribir.WriteLine("Gurruchaga")

                escribir.WriteLine("")

                escribir.WriteLine("Hedilla")
                escribir.WriteLine("Hera")
                escribir.WriteLine("Hermosa")
                escribir.WriteLine("Hernani")
                escribir.WriteLine("Hermida")


                escribir.WriteLine("")

                escribir.WriteLine("Laborda")
                escribir.WriteLine("Lago")
                escribir.WriteLine("Lama")
                escribir.WriteLine("Lanza")
                escribir.WriteLine("Latorre")
                escribir.WriteLine("Lecumberri")
                escribir.WriteLine("Lecuona")
                escribir.WriteLine("Legazpi")
                escribir.WriteLine("León")
                escribir.WriteLine("Lerma")
                escribir.WriteLine("Liaño")
                escribir.WriteLine("Linares")
                escribir.WriteLine("Llamas")
                escribir.WriteLine("Llave")
                escribir.WriteLine("Llanos")

                escribir.WriteLine("")

                escribir.WriteLine("Nadal")
                escribir.WriteLine("Narváez")
                escribir.WriteLine("Navaja")
                escribir.WriteLine("Navarro")
                escribir.WriteLine("Naves")
                escribir.WriteLine("Neira")
                escribir.WriteLine("Neyra")
                escribir.WriteLine("Nogueira")
                escribir.WriteLine("Nogués")
                escribir.WriteLine("Nova")
                escribir.WriteLine("Nieto")
                escribir.WriteLine("Neyra")

                escribir.WriteLine("")

                escribir.WriteLine("O Donell")
                escribir.WriteLine("Ojeda")
                escribir.WriteLine("Oliva")
                escribir.WriteLine("Olivares")
                escribir.WriteLine("Oller")
                escribir.WriteLine("Olid")
                escribir.WriteLine("Olmedo")
                escribir.WriteLine("Olmo")
                escribir.WriteLine("Ontiveros")
                escribir.WriteLine("Oraa")
                escribir.WriteLine("Olivender")

                escribir.WriteLine("")

                escribir.WriteLine("Pereira")
                escribir.WriteLine("Pereyra")
                escribir.WriteLine("Perez")
                escribir.WriteLine("Pauloz")
                escribir.WriteLine("Porsime")

                escribir.WriteLine("")

                escribir.WriteLine("Quindós")
                escribir.WriteLine("Quintana")
                escribir.WriteLine("Quintero")
                escribir.WriteLine("Quiroga")
                escribir.WriteLine("Quirós")
                escribir.WriteLine("Quiñones")
                escribir.WriteLine("Quindós")
                escribir.WriteLine("Quiza")
                escribir.WriteLine("Quantum")

                escribir.WriteLine("")

                escribir.WriteLine("Redondo")
                escribir.WriteLine("Rendón")
                escribir.WriteLine("Requena")
                escribir.WriteLine("Revilla")
                escribir.WriteLine("Ribas")
                escribir.WriteLine("Rico")
                escribir.WriteLine("Rincón")
                escribir.WriteLine("Río")
                escribir.WriteLine("Ripol")
                escribir.WriteLine("Riquer")
                escribir.WriteLine("Rivelles")
                escribir.WriteLine("Rivero")
                escribir.WriteLine("Roa")
                escribir.WriteLine("Robles")
                escribir.WriteLine("Romay")
                escribir.WriteLine("Romany")
                escribir.WriteLine("Rojo")
                escribir.WriteLine("Roca")
                escribir.WriteLine("Roldán")
                escribir.WriteLine("Rosa")
                escribir.WriteLine("Romero")
                escribir.WriteLine("Rovira")
                escribir.WriteLine("Rubiales")
                escribir.WriteLine("Rubio")
                escribir.WriteLine("Rueda")
                escribir.WriteLine("Rubalcava")
                escribir.WriteLine("Rosales")

                escribir.WriteLine("")

                escribir.WriteLine("Saavedra")
                escribir.WriteLine("Sabater")
                escribir.WriteLine("Sacristán")
                escribir.WriteLine("Sáenz")
                escribir.WriteLine("Sagarra")
                escribir.WriteLine("Sainz")
                escribir.WriteLine("Sala")
                escribir.WriteLine("Salaberry")
                escribir.WriteLine("Salazar")
                escribir.WriteLine("Salcedo")
                escribir.WriteLine("Sales")
                escribir.WriteLine("Salgado")
                escribir.WriteLine("Salinas")
                escribir.WriteLine("Samaniego")
                escribir.WriteLine("Sanchez")
                escribir.WriteLine("Sanchiz")
                escribir.WriteLine("Santos")
                escribir.WriteLine("Sanz")
                escribir.WriteLine("Sardá")
                escribir.WriteLine("Sartorius")
                escribir.WriteLine("Schnieper")
                escribir.WriteLine("Segura")
                escribir.WriteLine("Seguro")
                escribir.WriteLine("Serna")

                escribir.WriteLine("")

                escribir.WriteLine("Vahamonde")
                escribir.WriteLine("Vegas")
                escribir.WriteLine("Vagano")


#End Region

                escribir.Close()
            End If

            'Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
            Dim leer As New StreamReader(ruta & nombLista)
            'Si la lista ya existe o fue creada, voy a cargarla en la memoria
            Try
                Dim contador = 0
                'Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
                While leer.Peek <> -1

                    contador += 1
                    'Leemos cada linea del archivo TXT
                    Dim linea As String = leer.ReadLine()

                    'Validamos que la linea no este vacia
                    If String.IsNullOrEmpty(linea) Then
                        Continue While
                    End If
                    'Agregramos los registros encontrados

                    If contador > 9 Then
                        apellidos.Add(linea)
                    End If



                End While

                leer.Close()

            Catch ex As Exception
                MsgBox("Se presento un problema al leer el archivo:  " & ex.Message, MsgBoxStyle.Critical, "Data Base Assistent")
            End Try
        Catch ex As Exception

        End Try


    End Sub

    Public Sub CargarListaTemplate()

        Dim ruta As String = Application.StartupPath & "\Lista Generadores\"
        Dim nombLista As String = "Template lista personalizada.txt"
        Dim fs As FileStream


        Try
            If Not File.Exists(ruta) Then
                'Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)
            End If

            'Si no existe el txt te lo creo y le agrego la base
            If Not File.Exists(ruta & nombLista) Then

                fs = File.Create(ruta & nombLista)
                fs.Close()

                Dim escribir As New StreamWriter(ruta & nombLista)

                escribir.WriteLine("##########################################################################")
                escribir.WriteLine("########### TEMPLATE PARA HACER TUS LISTAS PERSONALIZADAS ################")
                escribir.WriteLine("##########################################################################")
                escribir.WriteLine("###########    CADA LINEA ES UN DATO, TENLO EN CUENTA     ################")
                escribir.WriteLine("##########################################################################")
                escribir.WriteLine("###########             ELEMENTARY COMPANY                ################")
                escribir.WriteLine("##########################################################################")
                escribir.WriteLine("")
                escribir.WriteLine("           <---------- COMIENZO DE LA LISTA ---------->               ")

                escribir.Close()
            End If

        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo:  " & ex.Message, MsgBoxStyle.Critical, "Data Base Assistent")
        End Try

    End Sub
#End Region

#Region "VALIDACIONES"

    Private Function seguntipoDato(ByVal grupo As GroupBox, ByVal tipoDato As String) As String
        Dim contador = 0
        Dim fecha1, fecha2 As Date 'Valores que se usan en rangos de fecha
        Dim valor1, valor2 As Integer 'Valores que usan los rangos numericos
        Dim parametroSegunDato As String = ""

        For Each dato In grupo.Controls

            Select Case tipoDato

                Case "Cedula"

                    If TypeOf dato Is CheckBox Then

                        If dato.Checked Then
                            parametroSegunDato = "True"

                        Else
                            parametroSegunDato = "False"

                        End If

                    End If

                Case "Numerico Fijo"

                    If TypeOf dato Is NumericUpDown Then
                        parametroSegunDato = dato.Value
                    End If

                Case "Cadena Fija"

                    If TypeOf dato Is TextBox Then
                        parametroSegunDato = dato.Text
                    End If

                Case "Numerico entre Rangos"
                    If TypeOf dato Is NumericUpDown Then
                        If contador = 0 Then
                            valor1 = dato.value()
                        ElseIf contador = 1 Then
                            valor2 = dato.Value()
                        End If

                        contador += 1
                    End If


                Case "Fecha"

                    If TypeOf dato Is DateTimePicker Then
                        If contador = 0 Then
                            fecha1 = dato.value()
                        Else
                            fecha2 = dato.Value()
                        End If

                        contador += 1
                    End If

                Case "Personalizado"

                    parametroSegunDato = "lista"

            End Select
        Next

        If contador <> 0 Then
            If valor1 Or valor2 <> 0 Then
                parametroSegunDato = GenerarNumeroEntreRangos(valor1, valor2)
            Else
                parametroSegunDato = CStr(GenerarFecha(fecha1, fecha2))
            End If
        End If

        Return parametroSegunDato


    End Function

    Public Function existeScript(ByVal nombre As String)

        Dim ruta As String = Application.StartupPath & "\Inserts Generados\"
        Dim nombScript As String = nombre & ".sql"

        If Directory.Exists(ruta) Then

                If File.Exists(ruta & "\" & nombScript) Then
                    Return True
                End If


            End If

            Return False

    End Function

#End Region

    'Function que genera todos los insert y los tira en el archivo
    Public Function generarScript(ByVal paramTabla As String,
                                  ByVal cantQuerys As Integer,
                                  ByVal cantCampos As Integer,
                                  ByVal grupoCampos As GroupBox) As List(Of String)

        'Limpio la lista y configuro las variables que voy a usar
        script.Clear()
        Dim insert As String
        Dim columna As Integer = 0
        Dim tipoDato As String = "" 'TIPO DE DATO QUE QUIERE EN ESE DATO

        Dim objetoSegunDato As String = ""
        script.Add("--INSERTS DE LA TABLA " & paramTabla)
        script.Add("")


        For inserts = 1 To cantQuerys

            insert = "INSERT INTO " & paramTabla & " VALUES ("
            For campos = 1 To cantCampos

                columna = 0

                For Each dato In grupoCampos.Controls
                    columna += 1

                    If campos = columna Then

                        For Each control In dato.controls

                            If TypeOf control Is ComboBox Then
                                tipoDato = control.SelectedItem
                            End If

                        Next

                        objetoSegunDato = seguntipoDato(dato, tipoDato)


                    End If

                Next


                Select Case tipoDato


                    Case "Nombre"

                        insert &= "'" & generarNombre() & "'"
                        If campos < cantCampos Then
                            insert &= ", "
                        End If

                    Case "Apellido"

                        insert &= "'" & generarApellido() & "'"
                        If campos < cantCampos Then
                            insert &= ", "
                        End If

                    Case "Cedula"

                        If objetoSegunDato = "True" Then
                            insert &= generarCI(True)
                        Else
                            insert &= generarCI(False)
                        End If

                        If campos < cantCampos Then
                            insert &= ", "
                        End If


                    Case "Edad"

                        insert &= GenerarEdad()
                        If campos < cantCampos Then
                            insert &= ", "
                        End If

                    Case "Numerico Random"

                        insert &= GenerarNumeroRandomico()
                        If campos < cantCampos Then
                            insert &= ", "
                        End If

                    Case "Numerico entre Rangos"

                        insert &= objetoSegunDato
                        If campos < cantCampos Then
                            insert &= ", "
                        End If

                    Case "Numerico Fijo"

                        insert &= objetoSegunDato

                        If campos < cantCampos Then
                            insert &= ", "
                        End If

                    Case "Fecha"

                        insert &= "'" & objetoSegunDato & "'"
                        If campos < cantCampos Then
                            insert &= ", "
                        End If

                    Case "Cadena Fija"

                        insert &= "'" & objetoSegunDato & "'"
                        If campos < cantCampos Then
                            insert &= ", "
                        End If

                    Case "Booleano"

                        insert &= GenerarBooleano()
                        If campos < cantCampos Then
                            insert &= ", "
                        End If

                    Case "Personalizado"

                        Select Case campos

                            Case 1
                                insert &= "'" & GenerarRandomPersonalizado(listaColumna1) & "'"
                                If campos < cantCampos Then
                                    insert &= ", "
                                End If
                            Case 2
                                insert &= "'" & GenerarRandomPersonalizado(listaColumna2) & "'"
                                If campos < cantCampos Then
                                    insert &= ", "
                                End If
                            Case 3
                                insert &= "'" & GenerarRandomPersonalizado(listaColumna3) & "'"
                                If campos < cantCampos Then
                                    insert &= ", "
                                End If
                            Case 4
                                insert &= "'" & GenerarRandomPersonalizado(listaColumna4) & "'"
                                If campos < cantCampos Then
                                    insert &= ", "
                                End If
                            Case 5
                                insert &= "'" & GenerarRandomPersonalizado(listaColumna5) & "'"
                                If campos < cantCampos Then
                                    insert &= ", "
                                End If
                            Case 6
                                insert &= "'" & GenerarRandomPersonalizado(listaColumna6) & "'"
                                If campos < cantCampos Then
                                    insert &= ", "
                                End If
                            Case 7
                                insert &= "'" & GenerarRandomPersonalizado(listaColumna7) & "'"
                                If campos < cantCampos Then
                                    insert &= ", "
                                End If
                            Case 8
                                insert &= "'" & GenerarRandomPersonalizado(listaColumna8) & "'"
                                If campos < cantCampos Then
                                    insert &= ", "
                                End If
                                'Case 9 algun dia


                        End Select


                End Select



            Next

            insert &= ")"
            script.Add(insert)



        Next


        Return script
    End Function

    Public Sub cargarScriptIndividual(ByVal script As List(Of String), ByVal nombreTabla As String)
        Dim ruta As String = Application.StartupPath & "\Inserts Generados\"
        Dim nombScript As String = nombreTabla & ".sql"
        Dim fs As FileStream


        Try
            If File.Exists(ruta) Then

                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & nombScript)

            Else

                ':::Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)

                ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & nombScript)


            End If

            fs.Close()
            Dim escribir As New StreamWriter(ruta & nombScript)

            For Each linea In script
                escribir.WriteLine(linea)
            Next

            escribir.Close()

            MsgBox("Se genero el script " & nombreTabla & ".sql correctamente", MsgBoxStyle.Information, "DBA - Script generado")
        Catch ex As Exception

        End Try
    End Sub



#Region "Metodos Generadores"

    Public Function generarCI(ByVal paramUnico As Boolean) As Integer

        'Creo las variables necesarias para el calculo


        Dim ciValida As Boolean = False 'controlador de estado para salir si la ci ya existe (controlar que no se repitan)
        Dim ci As Integer ' variable que contiene la cedula generada
        Dim contador As Byte = 0 'contador de repeticion de cedula (no deberia ser mayor a 1)

        If paramUnico = True Then 'Si pide ser unico, lo controlamos

            While ciValida = False
                ci = Random.Next(10000000, 70000000)
                For Each cedula In cedulas
                    If cedula = ci Then
                        contador += 1
                    End If
                Next

                If contador = 0 Then
                    ciValida = True
                End If

            End While

            Return ci

        Else
            ci = Random.Next(10000000, 60000000)
            Return ci

        End If

    End Function

    Public Function generarNombre() As String
        Dim nomb As String
        nomb = nombres.Item(Random.Next(0, 74))

        Return nomb
    End Function

    Public Function generarApellido() As String
        Dim apell As String
        apell = apellidos.Item(Random.Next(0, 69))

        Return apell
    End Function

    Public Function GenerarEdad() As Integer
        Dim edad As Integer = Random.Next(18, 60)
        Return edad
    End Function

    Public Function GenerarNumeroRandomico() As Integer
        Dim numero = Random.Next(1, 1000000)
        Return numero
    End Function

    Public Function GenerarNumeroEntreRangos(paramMin As Integer, paramMax As Integer) As Integer
        Dim numero As Integer
        If paramMin > paramMax Then
            numero = Random.Next(paramMax, paramMin + 1)
        Else
            numero = Random.Next(paramMin, paramMax + 1)
        End If

        Return numero
    End Function

    Public Function GenerarBooleano() As Integer
        Dim bool As Integer = Random.Next(0, 2)
        Return bool
    End Function

    Public Function GenerarFecha(ByVal paramDesde As Date, ByVal paramHasta As Date) As String
        Dim temp As Date
        If paramDesde > paramHasta Then
            temp = paramHasta
            paramHasta = paramDesde
            paramDesde = temp
        End If

        Dim dias As Integer = DateDiff(DateInterval.Day, paramDesde, paramHasta)
        If dias = 0 Then
            dias = 1
        End If
        Dim fechaAleatoria As Date
        Dim numeroRandom As Integer = Random.Next(0, dias + 1)

        fechaAleatoria = DateAdd(DateInterval.Day, numeroRandom, paramDesde)

        Return fechaAleatoria.ToString("dd/MM/yyyy")
    End Function

    Public Function GenerarRandomPersonalizado(lista As List(Of String)) As String
        Dim randomPersonalizado As Integer = Random.Next(0, lista.Count)

        Return lista.Item(randomPersonalizado)
    End Function

#End Region



#Region "Metodos de los Controles"

    Public Sub cargarCombo(ByVal paramCombo As ComboBox)

        paramCombo.Items.Add("Nombre")
        paramCombo.Items.Add("Apellido")
        paramCombo.Items.Add("Cedula")
        paramCombo.Items.Add("Edad")
        paramCombo.Items.Add("Fecha")
        paramCombo.Items.Add("Numerico Random")
        paramCombo.Items.Add("Numerico entre Rangos")
        paramCombo.Items.Add("Numerico Fijo")
        paramCombo.Items.Add("Cadena Fija")
        paramCombo.Items.Add("Booleano")
        paramCombo.Items.Add("Personalizado")

        paramCombo.SelectedIndex = 0

    End Sub

#End Region

End Class
