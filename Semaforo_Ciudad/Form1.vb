Public Class Form1
    Dim vcarro1 = 12
    Dim vcarro2 = -2
    Private Sub IniciarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarToolStripMenuItem.Click
        'Panel_carro1.Left = Panel_carro1.Left + 15
       
        Timer1.Start()
        Timer4.Start()
        Timer6.Start()
        'rojo1.BackColor = Color.Red
    End Sub

    Private Sub PararToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PararToolStripMenuItem.Click
        Timer1.Stop()
        Timer4.Stop()
        Timer6.Stop()
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '*******************************************************************************************
        '********************************** < ROJO 1 & VERDE 2 > ***********************************
        '*******************************************************************************************
        rbdrojo1.Checked = True
        rbdamarillo1.Checked = False
        rbdverde1.Checked = False
        '**********************************      [ Extra ] fromulario  monito o control
        Monitorizacion.rdbcrojo1.Checked = True
        Monitorizacion.rdbcverde2.Checked = True
        '**********************************

        rbdverde2.Checked = True
        rbdrojo2.Checked = False
        rbdamarillo2.Checked = False
        '**********************************

        rojo1.BackColor = Color.Red
        amarillo1.BackColor = Color.Olive
        verde1.BackColor = Color.DarkGreen

        verde2.BackColor = Color.Lime
        rojo2.BackColor = Color.Maroon
        amarillo2.BackColor = Color.Olive

        Timer1.Stop()
        Timer3.Stop()
        Timer2.Start()   'Devido a un problema con los Timer....e decidido cambiar el intervalo
        'de una manera no convencional......
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        '**************************************************************************************************
        '********************************** < AMARILLO 1 & AMARILLO 2 > ***********************************
        '**************************************************************************************************
        rbdamarillo1.Checked = True
        rbdrojo1.Checked = False
        rbdverde1.Checked = False
        '**********************************        [ Extra ] fromulario  monito o control
        Monitorizacion.rdbcamarillo1.Checked = True
        Monitorizacion.rdbcamarillo2.Checked = True
        '**********************************
        rbdamarillo2.Checked = True
        rbdrojo2.Checked = False
        rbdverde2.Checked = False
        '**********************************

        amarillo1.BackColor = Color.Yellow
        rojo1.BackColor = Color.Maroon
        verde1.BackColor = Color.DarkGreen

        amarillo2.BackColor = Color.Yellow
        verde2.BackColor = Color.DarkGreen
        rojo2.BackColor = Color.Maroon
        'Panel_carro1.Left = Panel_carro1.Left + 15

        Timer3.Stop()
        'Timer3.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        '*******************************************************************************************
        '********************************** < VERDE 1 & ROJO 2 > ***********************************
        '*******************************************************************************************

        rbdverde1.Checked = True
        rbdrojo1.Checked = False
        rbdamarillo1.Checked = False
        '**********************************        [ Extra ] fromulario  monito o control
        Monitorizacion.rdbcverde1.Checked = True
        Monitorizacion.rdbcrojo2.Checked = True
        '********************************** 
        rbdrojo2.Checked = True
        rbdverde2.Checked = False
        rbdamarillo2.Checked = False
        '**********************************

        verde1.BackColor = Color.Lime
        rojo1.BackColor = Color.Maroon
        amarillo1.BackColor = Color.Olive

        rojo2.BackColor = Color.Red
        verde2.BackColor = Color.DarkGreen

        'Panel_carro1.Left = Panel_carro1.Left + 15

        Timer2.Stop()
        'Timer1.Stop()
        Timer3.Start()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        '************************************* <<<<<  CARRO 1 [PLOMO]  >>>>> ****************************

        lblcarro1.Left = lblcarro1.Left + 12 + Monitorizacion.cmbiv1.SelectedItem
        '****************************************************************************************
        '******************************** << VELOCIDAD ACTUAL >> ******************************
        Dim km1 As String = "Km/h"
        Monitorizacion.txtvactual1.Text = 12 + Monitorizacion.cmbiv1.SelectedItem & km1
        '******************************** << DISTANCIA OBJETIVO >> ******************************
        Dim m1 As String = "m"
        Monitorizacion.txtllegada1.Text = Val(880 - lblcarro1.Left) & m1
        '****************************************************************************************
        '******************************** << DISTANCIA RECORRIDA >> ******************************
        Dim d1 As String = "m"
        Label2.Left += 12 + Monitorizacion.cmbiv1.SelectedItem
        Monitorizacion.txtrecorrido1.Text = Label2.Left & d1
        '****************************************************************************************

        '....................310
        If lblcarro1.Left >= 214 And lblcarro1.Left < 325 And (rbdamarillo1.Checked = True Or rbdrojo1.Checked = True) Then

            Timer4.Stop() '** Esto significa que si nuestro semaforo se encuentra en [ Rojo ] y cumple las condiciones de las
            Timer5.Start() 'COORDENADAS, entonces ara todo esto...caso contrario el carro segura abanzando..tanto estando en
            '______________[ Verde ], como fuera de las COORDENADAS de la condicion..
        End If


        '********************************************************* con esta condicion tratamos de decir que....mientras el carro
        'se encuentre en la [INTERSECCION] ...el otro carro se detenga hasta que el otro haiga termiado de pasar completamente
        'una vez se cumpla el rango establesido entre la [INTERSECCION] ..el otro carro pasara [AUTOMÁTICAMENTE]...........
        'Ya que una vez fuera de ese rango expresado en coordenadas [Left - Top o X - Y] el cual se encuentran (CONDICIONADAS)
        'si no esta en ese rango....tomara o asumira ..no hacer eso y seguir en lo que estava antes de esa condición.....
        If lblcarro2.Top <= 332 And lblcarro2.Top > 282 And rbdverde2.Checked = True And lblcarro1.Left >= 325 And lblcarro1.Left < 494 Then
            Timer6.Stop()
        ElseIf rbdverde2.Checked = True And lblcarro1.Left > 493 Then

            Timer6.Start()
        End If

    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick

        If lblcarro1.Left >= 214 And lblcarro1.Left < 325 And rbdverde1.Checked = True Then

            Timer4.Start() 'Este [ Timer5 ] nadamas cumple con los color [ Verde ] para poder avanzar
        End If

        If lblcarro1.Left >= 880 Then
            Timer4.Stop() ' Esto lo que hace es que...cuando llegue a la maxima distancia..se vuelva a colocar en la posicion inicial
            lblcarro1.Left = 0
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick

        '************************************* <<<<<  CARRO 2 [AZUL] >>>>> ****************************

        lblcarro2.Top = lblcarro2.Top - 2 + (-Monitorizacion.cmbiv2.SelectedItem)
        '****************************************************************************************
        '******************************** << VELOCIDAD ACTUAL >> ******************************
        Dim km2 As String = "Km/h"
        Monitorizacion.txtvactual2.Text = 2 + Monitorizacion.cmbiv2.SelectedItem & km2
        '****************************************************************************************
        '******************************** << DISTANCIA OBJETIVO >> ******************************
        Dim m2 As String = "m"
        Monitorizacion.txtllegada2.Text = Val(lblcarro2.Top) & m2
        '****************************************************************************************
        '******************************** << DISTANCIA RECORRIDA >> ******************************
        Dim d2 As String = "m"
        Label1.Top += 2 + Monitorizacion.cmbiv2.SelectedItem 'Este Label se encuentra invisible...oculto
        Monitorizacion.txtrecorrido2.Text = Label1.Top & d2
        '****************************************************************************************

        '..............................................296......................284
        If rbdrojo2.Checked = True And lblcarro2.Top <= 330 And lblcarro2.Top > 302 Then

            Timer6.Stop() '** Esto significa que si nuestro semaforo se encuentra en [ Rojo ] y cumple las condiciones de las
            Timer7.Start() 'COORDENADAS, entonces ara todo esto...caso contrario el carro segura abanzando..tanto estando en
            '______________[ Verde ], como fuera de las COORDENADAS de la condicion..
        End If


        '********************************************************* con esta condicion tratamos decir que....mientras el carro
        'se encuentre en la [INTERSECCION] ...el otro carro se detenga hasta que el otro haiga termiado de pasar completamente
        'una vez se cumpla el rango establesido entre la [INTERSECCION] ..el otro carro pasara [AUTOMÁTICAMENTE]...........
        'Ya que una vez fuera de ese rango expresado en coordenadas [Left - Top o X - Y] el cual se encuentran (CONDICIONADAS)
        'si no esta en ese rango....tomara o asumira ..no hacer eso y seguir en lo que estava antes de esa condición.....

        If lblcarro1.Left >= 214 And lblcarro1.Left < 325 And rbdverde1.Checked = True And lblcarro2.Top <= 282 And lblcarro2.Top >= 132 Then
            Timer4.Stop()
        End If
        '*********************************************************
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        If lblcarro2.Top <= 330 And lblcarro2.Top > 302 And rbdverde2.Checked = True Then
            Timer6.Start() 'Este [ Timer5 ] nadamas cumple con los color [ Verde ] para poder avanzar
        End If
        If lblcarro2.Top <= -48 Then
            Timer6.Stop() ' Esto lo que hace es que...cuando llegue a la maxima distancia..se vuelva a colocar en la posicion inicial
            lblcarro2.Top = 446
            Timer6.Start()
        End If
    End Sub

    
    Private Sub ReiniciarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReiniciarToolStripMenuItem.Click
        lblcarro1.Left = 5
        lblcarro2.Top = 446
    End Sub

    Private Sub CuadroDeControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuadroDeControlToolStripMenuItem.Click
        Monitorizacion.Show()
       
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        '***********************
       
    End Sub

    Private Sub PararTodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PararTodoToolStripMenuItem.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
    End Sub
End Class
