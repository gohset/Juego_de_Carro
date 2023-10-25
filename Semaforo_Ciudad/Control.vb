Public Class Monitorizacion

    Private Sub Control_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()

        cmbiv1.Items.Add(0)
        cmbiv1.Items.Add(10)
        cmbiv1.Items.Add(15)
        cmbiv1.Items.Add(20)
        cmbiv1.Items.Add(25)
        cmbiv1.Items.Add(30)
        cmbiv1.Items.Add(35)
        cmbiv1.Items.Add(40)
        cmbiv1.Items.Add(45)
        cmbiv1.Items.Add(50)
        cmbiv1.Items.Add(55)
        cmbiv1.Items.Add(60)
        cmbiv1.Items.Add(65)
        cmbiv1.Items.Add(70)

        cmbiv2.Items.Add(0)
        cmbiv2.Items.Add(10)
        cmbiv2.Items.Add(15)
        cmbiv2.Items.Add(20)
        cmbiv2.Items.Add(25)
        cmbiv2.Items.Add(30)

        '*****< TRANSPARENCIA >*******
        GroupBox1.Parent = PictureBox1
        GroupBox2.Parent = PictureBox1
        GroupBox3.Parent = PictureBox1
        GroupBox4.Parent = PictureBox1
        '*****************************

        '**************************************
        GroupBox1.BackColor = Color.Transparent
        GroupBox2.BackColor = Color.Transparent
        GroupBox3.BackColor = Color.Transparent
        GroupBox4.BackColor = Color.Transparent
        '**************************************
       
        txts1.Visible = False
        txts2.Visible = False
        txts3.Visible = False
        txts4.Visible = False
        txts5.Visible = False
        txts6.Visible = False
        txts7.Visible = False
        txts8.Visible = False
        txts9.Visible = False
        txts10.Visible = False
        txts11.Visible = False
        txts12.Visible = False
        txts13.Visible = False
        txts14.Visible = False
        txts15.Visible = False
        txts16.Visible = False
        txts17.Visible = False
        txts18.Visible = False
        txts19.Visible = False

        txts20.Visible = False
        txts21.Visible = False
        txts22.Visible = False
        txts23.Visible = False
        txts24.Visible = False
        txts25.Visible = False
        txts26.Visible = False
        txts27.Visible = False
        txts28.Visible = False
        txts29.Visible = False
        txts30.Visible = False
        txts31.Visible = False
        txts32.Visible = False
        txts33.Visible = False
        txts34.Visible = False
      
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtss1.Left += 1

        If txtss1.Left = 1 Then
            txts1.Visible = True
            txts1.BackColor = Color.Lime
        ElseIf txtss1.Left = 2 Then
            txts1.Visible = False
            txts2.Visible = True
            txts2.BackColor = Color.SeaShell
        ElseIf txtss1.Left = 3 Then
            txts2.Visible = False
            txts3.Visible = True
            txts3.BackColor = Color.Red
        ElseIf txtss1.Left = 4 Then
            txts3.Visible = False
            txts4.Visible = True
            txts4.BackColor = Color.Orange
        ElseIf txtss1.Left = 5 Then
            txts4.Visible = False
            txts5.Visible = True
            txts5.BackColor = Color.Aqua
        ElseIf txtss1.Left = 6 Then
            txts5.Visible = False
            txts6.Visible = True
            txts6.BackColor = Color.BlueViolet
        ElseIf txtss1.Left = 7 Then
            txts6.Visible = False
            txts7.Visible = True
            txts7.BackColor = Color.CadetBlue
        ElseIf txtss1.Left = 8 Then
            txts7.Visible = False
            txts8.Visible = True
            txts8.BackColor = Color.Brown
        ElseIf txtss1.Left = 9 Then
            txts8.Visible = False
            txts9.Visible = True
            txts9.BackColor = Color.CadetBlue
        ElseIf txtss1.Left = 10 Then
            txts9.Visible = False
            txts10.Visible = True
            txts10.BackColor = Color.Chocolate
        ElseIf txtss1.Left = 11 Then
            txts10.Visible = False
            txts11.Visible = True
            txts11.BackColor = Color.Coral
        ElseIf txtss1.Left = 12 Then
            txts11.Visible = False
            txts12.Visible = True
            txts12.BackColor = Color.CornflowerBlue
        ElseIf txtss1.Left = 13 Then
            txts12.Visible = False
            txts13.Visible = True
            txts13.BackColor = Color.Cornsilk
        ElseIf txtss1.Left = 14 Then
            txts13.Visible = False
            txts14.Visible = True
            txts14.BackColor = Color.DarkBlue
        ElseIf txtss1.Left = 15 Then
            txts14.Visible = False
            txts15.Visible = True
            txts15.BackColor = Color.DarkGoldenrod
        ElseIf txtss1.Left = 16 Then
            txts15.Visible = False
            txts16.Visible = True
            txts16.BackColor = Color.DarkKhaki
        ElseIf txtss1.Left = 17 Then
            txts16.Visible = False
            txts17.Visible = True
            txts17.BackColor = Color.DarkMagenta
        ElseIf txtss1.Left = 18 Then
            txts17.Visible = False
            txts18.Visible = True
            txts18.BackColor = Color.Pink
        ElseIf txtss1.Left = 19 Then
            txts18.Visible = False
            txts19.Visible = True
            txts19.BackColor = Color.Fuchsia
        End If



        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


       






        If txtss1.Left >= 19 Then
            Timer1.Stop()
            txts19.Visible = False
            txtss1.Left = 0
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        txtss2.Left += 1

        If txtss2.Left = 1 Then
            txts20.Visible = True
            txts20.BackColor = Color.Lime
        ElseIf txtss2.Left = 2 Then
            txts20.Visible = False
            txts21.Visible = True
            txts21.BackColor = Color.Yellow
        ElseIf txtss2.Left = 3 Then
            txts21.Visible = False
            txts22.Visible = True
            txts22.BackColor = Color.Red
        ElseIf txtss2.Left = 4 Then
            txts22.Visible = False
            txts23.Visible = True
            txts23.BackColor = Color.Orange
        ElseIf txtss2.Left = 5 Then
            txts23.Visible = False
            txts24.Visible = True
            txts24.BackColor = Color.Aqua
        ElseIf txtss2.Left = 6 Then
            txts24.Visible = False
            txts25.Visible = True
            txts25.BackColor = Color.BlueViolet
        ElseIf txtss2.Left = 7 Then
            txts25.Visible = False
            txts26.Visible = True
            txts26.BackColor = Color.CadetBlue
        ElseIf txtss2.Left = 8 Then
            txts26.Visible = False
            txts27.Visible = True
            txts27.BackColor = Color.Turquoise
        ElseIf txtss2.Left = 9 Then
            txts27.Visible = False
            txts28.Visible = True
            txts28.BackColor = Color.CadetBlue
        ElseIf txtss2.Left = 10 Then
            txts28.Visible = False
            txts29.Visible = True
            txts29.BackColor = Color.Tomato
        ElseIf txtss2.Left = 11 Then
            txts29.Visible = False
            txts30.Visible = True
            txts30.BackColor = Color.Honeydew
        ElseIf txtss2.Left = 12 Then
            txts30.Visible = False
            txts31.Visible = True
            txts31.BackColor = Color.CornflowerBlue
        ElseIf txtss2.Left = 13 Then
            txts31.Visible = False
            txts32.Visible = True
            txts32.BackColor = Color.Crimson
        ElseIf txtss2.Left = 14 Then
            txts32.Visible = False
            txts33.Visible = True
            txts33.BackColor = Color.DarkBlue
        ElseIf txtss2.Left = 15 Then
            txts33.Visible = False
            txts34.Visible = True
            txts34.BackColor = Color.Fuchsia

        End If


        If txtss2.Left >= 15 Then
            Timer2.Stop()
            txts34.Visible = False
            txtss2.Left = 0
            Timer2.Start()
        End If
    End Sub

    
End Class