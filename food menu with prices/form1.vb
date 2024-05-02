Public Class Form1
    ' Deklarasi Variable
    Dim Total, Bayar, Kembali As Double
    Dim CBItem As CheckBox()
    Dim THarga As TextBox()
    Dim TJumlah As TextBox()


    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim i As Integer
        Total = 0
        For i = 0 To 9
            If CBItem(i).Checked = True Then

                Total = Total + Val(THarga(i).Text) * Val(TJumlah(i).Text)
            End If

        Next
        TextTotal.Text = "Rp. " & Format(Total, "#,#.##")
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBItem = New CheckBox() {PI1, PI2, PI3, PI4, PA1, PA2, PA3, M1, M2, M3}
        THarga = New TextBox() {HPI1, HPI2, HPI3, HPI4, HPA1, HPA2, HPA3, HM1, HM2, HM3}
        TJumlah = New TextBox() {JPI1, JPI2, JPI3, JPI4, JPA1, JPA2, JPA3, JM1, JM2, JM3}
    End Sub

    Private Sub TextBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            Bayar = Val(TextBayar.Text)
            Kembali = Bayar - Total
            TextKembali.Text = "Rp. " & Format(Kembali, "#,#.##")

        End If
    End Sub
End Class
