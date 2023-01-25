Imports System.IO
Imports System.Runtime.InteropServices.ComTypes

Public Class Form1
    Dim currentuser As String = Environment.UserName
    Dim mx_prs As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Caricafile()

        TXT_User.Text = currentuser

        Call aggiornaval()

    End Sub

    Private Sub BTN_Aggiungi_Click(sender As Object, e As EventArgs) Handles BTN_Aggiungi.Click
        Dim User As String = TXT_User.Text
        Dim data As Date = CALENDAR.SelectionStart
        Dim otherItems As String() = {data}

        ListView1.Items.Add(User).SubItems.AddRange(otherItems)

        Call aggiornaval()

    End Sub

    Private Sub BTN_Rimuovi_Click(sender As Object, e As EventArgs) Handles BTN_Rimuovi.Click
        For Each item As ListViewItem In ListView1.SelectedItems
            If UCase(item.Text) = UCase(currentuser) Then
                ListView1.Items.Remove(item)
            Else
                MsgBox("puoi eliminare solo i record registrati con il tuo utente", vbExclamation, "Attenzione")
            End If
        Next

        Call aggiornaval()


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Using FILE As New StreamWriter("listview.txt")
            Dim LVRow As String

            For Each LVi As ListViewItem In ListView1.Items

                LVRow = ""
                For Each LVCell As ListViewItem.ListViewSubItem In LVi.SubItems
                    LVRow += LVCell.Text & vbTab
                Next
                LVRow = LVRow.Remove(LVRow.Length - 1, 1)
                FILE.WriteLine(LVRow)
            Next
        End Using

    End Sub

    Private Sub Caricafile()
        Dim filePath, line As String

        filePath = Path.Combine(Application.StartupPath, "listview.txt")
        If File.Exists(filePath) Then
            Using sr As New StreamReader("listview.txt")
                Do While sr.Peek() <> -1
                    line = sr.ReadLine()
                    Dim items() As String = line.Split(ControlChars.Tab)
                    Dim newItem As New ListViewItem(items(0))
                    For i As Integer = 1 To items.Length - 1
                        newItem.SubItems.Add(items(i))
                    Next
                    ListView1.Items.Add(newItem)
                Loop
            End Using
        End If
    End Sub
    Function datacount() As String
        Dim it, it2 As New ListViewItem
        Dim dt, dt2 As String
        Dim n, x, c As Integer
        Dim list As String

        mx_prs = 0
        For n = 0 To ListView1.Items.Count - 1
            it = ListView1.Items(n)
            dt = it.SubItems(1).Text
            c = 0
            list = ""
            For x = 0 To ListView1.Items.Count - 1
                it2 = ListView1.Items(x)
                If dt = it2.SubItems(1).Text And InStr(list, it2.Text) < 1 Then
                    c += 1
                    list += it2.Text & ","
                ElseIf dt = it2.SubItems(1).Text And InStr(list, it2.Text) > 0 Then
                    MsgBox("L'utente " & it2.Text & " ha segnato più volte la stessa data!!!")
                    mx_prs = 0
                    Exit Function
                End If
            Next
            If c > mx_prs Then
                mx_prs = c
                dt2 = dt
            End If
        Next

        Return dt2

    End Function
    Function Usercount() As Integer
        Dim us, listus As String
        Dim n, c As Integer

        If ListView1.Items.Count < 1 Then
            Return 0
            Exit Function
        End If

        listus = ""
        For n = 0 To ListView1.Items.Count - 1
            us = ListView1.Items(n).Text
            listus += us & ","
        Next
        listus = listus.Remove(listus.Length - 1, 1)

        For n = 0 To ListView1.Items.Count - 1
            us = ListView1.Items(n).Text
            If InStr(listus, us) > 0 Then
                listus = Replace(listus, us, "")
                c += 1
            End If
        Next

        Return c

    End Function

    Private Sub BTN_Calcola_Click(sender As Object, e As EventArgs) Handles BTN_Calcola.Click

        TXT_Data.Text = datacount()
        TXT_persone.Text = mx_prs

        If mx_prs > 0 Then
            Call conta_persone(datacount())
        End If
    End Sub

    Private Sub conta_persone(str As String)
        Dim it, it2 As New ListViewItem
        Dim dt, dt2, list As String
        Dim n, x As Integer
        Dim controllodata As Boolean = False

        If LIST_User.Items.Count > 0 Then
            LIST_User.Items.Clear()
        End If
        list = ""
        If ListView1.Items.Count > 0 Then
            For n = 0 To ListView1.Items.Count - 1
                it = ListView1.Items(n)
                dt = it.SubItems(1).Text
                If dt <> str And InStr(list, it.Text) < 1 Then
                    controllodata = False
                    For x = 0 To ListView1.Items.Count - 1
                        it2 = ListView1.Items(x)
                        dt2 = it2.SubItems(1).Text
                        If it2.Text = it.Text And dt2 = str Then
                            controllodata = True
                        End If
                    Next
                    If controllodata = False Then
                        LIST_User.Items.Add(it.Text)
                        list += it.Text & ","
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub aggiornaval()
        If ListView1.Items.Count > 0 Then
            TXT_registri.Text = Usercount()
        Else
            TXT_registri.Text = 0
        End If
    End Sub

    Private Sub BTN_DataSel_Click(sender As Object, e As EventArgs) Handles BTN_DataSel.Click
        Dim data As Date = CALENDAR.SelectionStart

        If ListView1.Items.Count > 0 Then
            TXT_Data.Text = Data
            Call conta_persone(Data)
            TXT_persone.Text = Usercount() - LIST_User.Items.Count
        End If

    End Sub
End Class