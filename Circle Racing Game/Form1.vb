Public Class Form1
    'declare 7 globle integer variale which will be use in timer control.
    Dim i, a, a1, b, b1, c1, c As Integer
    Dim time As Integer = 0
    Dim totaltime As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'CODING OF RESET BUTTON.

        OvalShape1.Location = New Point(29, 67)
        OvalShape2.Location = New Point(29, 158)
        OvalShape3.Location = New Point(29, 252)
        lb.Text = ""

    End Sub
    'FOR APPLYING RANDOM NUMBER FOR DECIDING FAIR   WINNER 
    Dim r As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button2.Enabled = False
        'Enable all timer .
        TimerBlue.Start()
        TimerRed.Start()
        TimerGreen.Start()

    End Sub

    'FOR RED CIRCLE CODE.

    Private Sub TimerRed_Tick(sender As Object, e As EventArgs) Handles TimerRed.Tick

        'GET THE VALUE OF OVAL OR CIRCLE  AND STOER THEM TO GLOBLE VARIABLE "a" AND "a1"

        a = OvalShape1.Location.X
        a1 = OvalShape1.Location.Y

        'START OF LINESHAPE WIDTH IS "x1" AND END POINT IS "x2".
        'SIMILIAR TO START OF LINESHAPE HEIGHT IS "Y1" AND END POINT IS "Y2".




        'CHECK THE LINESHAPE(HORIZONTAL LINE) OF WIDTH  END POINT (X2) IS LESST THAN TO GLOBLE VARIABLE "a" OR NOT .

        If a <= LineShape1.X2 Then

            'HERE "r" IS RANDOM INTEGER NUMBER. WE DEFINE RANGE BETWEEN 1 AND 15.
            'SYNTAX TO MOVE CIRCLE FROM OLD POSITION TO NEW  POSITION

            ' CONTROLNAME.Location=
            'New Point(X-axix(IN INTEGER),Y-axis(IN INTEGER))


            OvalShape1.Location = New Point(a + (r.Next(1, 10)), a1)
            If OvalShape1.FillColor = Color.Red Then
                OvalShape1.FillColor = Color.DarkRed
                OvalShape1.BorderColor = Color.White
            ElseIf OvalShape1.FillColor = Color.DarkRed
                OvalShape1.FillColor = Color.DarkOrange
            Else
                OvalShape1.FillColor = Color.Red
                OvalShape1.BorderColor = Color.Red
            End If

            'FOR CALCULATING HOW MANY TIMES IT TAKES FOR FINISHING THE RACE.
            time += 1  'INCREMENT THE VALUE OF GLOBLE VARIABLE time

            'HERE TIMER INTERVAL IS 100ms BUT WE WANT 1s=1000. SO WE DIVIDE THIS VALUE TO BY 10 .MEANS 100*10=1000ms THAT IS 1s.
            lb.Text = "Total Time is:" + CStr((Math.Round(time / 10)))

        Else

            'IT MEANS CIRCLE REACH END POINT SO STOP  ALL TIMER AND DECLARE A WINNER.


            TimerRed.Enabled = False
            TimerBlue.Enabled = False
            Button2.Enabled = True
            TimerGreen.Enabled = False
            MsgBox("red is winner")

        End If

    End Sub

    'FOR BLUE CIRCLE CODE.


    Private Sub TimerBlue_Tick(sender As Object, e As EventArgs) Handles TimerBlue.Tick
        'GET THE VALUE OF OVAL OR CIRCLE  AND STOER THEM TO GLOBLE VARIABLE "b" AND "b1"

        b = OvalShape2.Location.X
        b1 = OvalShape2.Location.Y

        If b < LineShape2.X2 Then

            'START OF LINESHAPE WIDTH IS "x1" AND END POINT IS "x2".
            'SIMILIAR TO START OF LINESHAPE HEIGHT IS "Y1" AND END POINT IS "Y2".

            ' CONTROLNAME.Location=
            'New Point(X-axix(IN INTEGER),Y-axis(IN INTEGER))

            OvalShape2.Location = New Point(b + (r.Next(1, 10)), b1)
            If OvalShape2.FillColor = Color.Blue Then
                OvalShape2.FillColor = Color.MediumBlue
                OvalShape2.BorderColor = Color.White
            ElseIf OvalShape2.FillColor = Color.MediumBlue
                OvalShape2.FillColor = Color.LightBlue
            ElseIf OvalShape2.FillColor = Color.LightBlue
                OvalShape2.FillColor = Color.DarkCyan
            Else
                OvalShape2.FillColor = Color.Blue

            End If
        Else

            'IT MEANS CIRCLE REACH END POINT SO STOP  ALL TIMER AND DECLARE A WINNER.
            TimerBlue.Enabled = False
            TimerRed.Enabled = False
            TimerGreen.Enabled = False
            Button2.Enabled = True
            MsgBox("Blue is Winner")
        End If



    End Sub

    'CODE FOR GREEN CIRCLE.
    Private Sub TimerGreen_Tick(sender As Object, e As EventArgs) Handles TimerGreen.Tick
        'GET THE VALUE OF OVAL OR CIRCLE  AND STOER THEM TO GLOBLE VARIABLE "c" AND "c1"


        c = OvalShape3.Location.X
        c1 = OvalShape3.Location.Y

        If c <= LineShape3.X2 Then
            'START OF LINESHAPE WIDTH IS "x1" AND END POINT IS "x2".
            'SIMILIAR TO START OF LINESHAPE HEIGHT IS "Y1" AND END POINT IS "Y2".

            ' CONTROLNAME.Location=
            'New Point(X-axix(IN INTEGER),Y-axis(IN INTEGER))
            OvalShape3.Location = New Point(c + (r.Next(1, 10)), c1)
            If OvalShape3.FillColor = Color.Green Then
                OvalShape3.FillColor = Color.DarkGreen
                OvalShape3.BorderColor = Color.White
            ElseIf OvalShape3.FillColor = Color.DarkGreen
                OvalShape3.FillColor = Color.LightGreen

            ElseIf OvalShape3.FillColor = Color.LightGreen
                OvalShape3.FillColor = Color.LawnGreen
            Else
                OvalShape3.FillColor = Color.Green
            End If

        Else
            'IT MEANS CIRCLE REACH END POINT SO STOP  ALL TIMER AND DECLARE A WINNER.
            TimerBlue.Enabled = False
            TimerRed.Enabled = False
            TimerGreen.Enabled = False
            Button2.Enabled = True
            MsgBox("Green is Winner")

        End If


    End Sub

End Class
