Public Class Form1
    Private Sub BT_Click(sender As Object, e As EventArgs) Handles BT.Click

        MsgBox("Ouput and variables")
        MessageBox.Show("The new version")


    End Sub

    Private Sub btnvariables_Click(sender As Object, e As EventArgs) Handles btnvariables.Click

        Dim stFirstName As String
        Dim stLastname As String
        stFirstName = "BRIAN"
        stLastname = "MUTWIRI"

        Dim intFirst As Integer
        intFirst = 4





        MsgBox("Number1" & intFirst)

        MsgBox("Good Morning " & stFirstName & " " & stLastname & ", Welcome")




    End Sub

    Private Sub PORSCHBTN_Click(sender As Object, e As EventArgs) Handles PORSCHBTN.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim iSpeed As Integer
        Dim stHorsepower As String
        Dim stTorque As String
        Dim decPrice As Decimal
        Dim dtDataRegistered As Date


        stMake = "Porsche"
        stModel = "GT3RS"
        iDoors = 2
        iSpeed = 196
        stHorsepower = "525HP"
        stTorque = "456Nm"
        decPrice = "34724.99"
        dtDataRegistered = #10/9/2024#

        MsgBox("I present to you the" & " " & stMake & " " & stModel)
        MsgBox("Details" & vbNewLine & iDoors & vbNewLine & iSpeed & vbNewLine &
               stHorsepower & vbNewLine & stTorque & vbNewLine &
               decPrice & vbNewLine & dtDataRegistered)




    End Sub
End Class
