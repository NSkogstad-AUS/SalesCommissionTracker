Public Class Form1
    'Nicolai Skogstad - Peninsula Grammar - Y11 Student
    'Sales and Commission U3AOS1 SAC assignment
    'Version 1.3 (Part 4) of the 4 part exam.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Firstname As String     'Declaring all the variables needed to be used, Firstname being the name
        Dim saleDate As Date         'Variable for saleDate.
        Dim ridesBalloon As Integer 'Variable for number of rides of the Balloon
        Dim jumpsBungeee As Integer 'Vairable for number of bungee jumps
        Dim balloonCom As Single    'Variable for the Balloon commission
        Dim bungeeCom As Single     'Variable for the Bungee Commission
        Dim valid As Boolean
        Dim Identify As String


        Try
            Firstname = txtName.Text            'Stating where the variable FirstName will receive its value from.
            ridesBalloon = txtBalloonRides.Text 'Stating where the variable ridesBalloon will receive its value from.
            jumpsBungeee = txtBungeeJumps.Text  'Stating where the variable jumpsBungee will receive its value from.
            saleDate = dtpDate.Value


            ValidateData(ridesBalloon, jumpsBungeee, saleDate, valid)

            If radUK.Checked Then                                       'Checking to see if the Radio button for UK has been checked, if so do the lines below
                balloonCom = 22.5 * 0.511259 * ridesBalloon             'For both values it is doing the correct conversion from AUD to UK
                bungeeCom = 40 * 0.511259 * jumpsBungeee                'Once again doing the same thing, however for the Bungee Jumps value.
                txtBungeeCom.Text = "￡" + Format(bungeeCom, "###0.00") + " GBR" 'This is formatting the result in a way that gives two decimal places, an expected result, as well as having the correct GBP currency value.
                txtBalloonCom.Text = "￡" + Format(balloonCom, "###0.00") + " GBR" 'Doing the same as above but for the Balloon Commission.
                lblIdentify.Text = "GBR"
            ElseIf radUSA.Checked Then                                  'Doing same as above, for USA currency type conversion.
                balloonCom = 22.5 * 0.662548 * ridesBalloon
                bungeeCom = 40 * 0.662548 * jumpsBungeee
                txtBungeeCom.Text = "$" + Format(bungeeCom, "###0.00") + " USD"
                txtBalloonCom.Text = "$" + Format(balloonCom, "###0.00") + " USD"
                lblIdentify.Text = "USD"
            ElseIf radEU.Checked Then                                   'Doing same as above, for EU currency type conversion.
                balloonCom = 22.5 * 0.610739 * ridesBalloon
                bungeeCom = 40 * 0.610739 * jumpsBungeee
                txtBungeeCom.Text = "€" + Format(bungeeCom, "###0.00") + " EURO"
                txtBalloonCom.Text = "€" + Format(balloonCom, "###0.00") + " EURO"
                lblIdentify.Text = "EURO"
            ElseIf radAUD.Checked Then                                   'Doing same as above, for AUD currency type conversion (normal values).
                balloonCom = ridesBalloon * 22.5
                bungeeCom = jumpsBungeee * 40
                txtBungeeCom.Text = "$" + Format(bungeeCom, "###0.00") + " AUD"
                txtBalloonCom.Text = Format(balloonCom, "$###0.00") + " AUD"
                lblIdentify.Text = "AUD"
            End If

            Identify = lblIdentify.Text

            'Open measuresFile (text file) to save date, height and weight
            FileOpen(1, "dataStore", OpenMode.Append)                     'use append mode to add to existing file
            WriteLine(1, Firstname, saleDate, ridesBalloon, balloonCom, jumpsBungeee, bungeeCom)     'write one set of data on one line of the text file for easy retrieval
            FileClose(1)

            FileOpen(1, "dataStoreIdentify", OpenMode.Append)                     'use append mode to add to existing file
            WriteLine(1, Identify)     'write one set of data on one line of the text file for easy retrieval
            FileClose(1)

        Catch ex As Exception
            If String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtBungeeJumps.Text) Or String.IsNullOrEmpty(txtBalloonRides.Text) Then
                ' "Contains Empty value or Null Value" 
                Console.Beep()
                MsgBox("Please enter valid values in the blank fields")
                'Check for if the text boxes are empty, if so then do this error message.
                valid = False
            Else
                Console.Beep()
                MsgBox("Unexpected Error has occured, please try again")
                'If there are any other unexpected errors then this error message will appear.
            End If
        End Try

    End Sub

    'Following sub routine is used to check for any invalid data types and values.
    Public Sub ValidateData(ridesBallon As Integer, jumpsBungeee As Integer, saleDate As Date, ByRef Valid As Boolean)
        Valid = True
        'If else statement present to ensure that the amount of rides and jumps is within an expected range.
        'In this case, to ensure amount of rides and jumps is not greater than 800, else expect an error message
        If ridesBallon > 800 Or jumpsBungeee > 800 Then
            Valid = False
            Console.Beep()
            MessageBox.Show("Sales are too high for one day, Please Try Again")
        ElseIf ridesBallon < 0 Or jumpsBungeee < 0 Then
            'In this case, to ensure amoung of rides and jumps is not less than 0.
            'This was not exactly needed as validation data at the very bottom accounts for this. But as it was requested, it has been included.
            Valid = False
            Console.Beep()
            MessageBox.Show("Sales cannot be less than 0, Please Try again")
        End If

        'Below checking for the value within the sale date picker. This is ued to ensure that any date greater than present is not possible.
        If saleDate > #03/25/2021# Then
            'date no later than current date (24th of March, 2021))
            'or use dateEntered = dtpDate.Value.date above
            Valid = False
            Console.Beep()
            MessageBox.Show("This date has not occured yet, Please Try Again")            'Display message
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'End 'Ending the program is no longer needed, thus, we are just hiding the current form and opening the Menu form.
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub txtBalloonRides_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBalloonRides.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'Checking to ensure that any value between 48 or 57 (Ascii codes for numbers) is the only acceptable value.
                e.Handled = True 'Saying that it is possible to type these values into the textbox
            End If
        End If
    End Sub
    Private Sub txtBungeeJumps_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBungeeJumps.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'Checking to ensure that any value between 48 or 57 (Ascii codes for numbers) is the only acceptable value.
                e.Handled = True 'Saying that it is possible to type these values into the textbox
            End If
        End If
    End Sub
End Class
