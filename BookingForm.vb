﻿Public Class BookingForm
    Private Sub BookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label8.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label10.BackColor = Color.Transparent
        Label11.BackColor = Color.Transparent
        Label12.BackColor = Color.Transparent
        LblTotal.BackColor = Color.Transparent

        '用於傳值給webform 
        Dim frm As New DetailsForm
        frm.SourceForm = Me
        'frm.ShowDialog() '未測試該功能
        ' LblTotal

    End Sub
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim mForm As New MenuForm
        Me.Hide()
        mForm.Show()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        '判斷欄位是否有空值，若無空值，則帶入值
        If TextBox1.Text IsNot Nothing And (Len(TextBox1.Text) = 10) Then


            '跳轉化面至下一頁
            Dim nForm As New MealsForm
            nForm.Visible = True
        Else
            '判斷是否有輸入是否合理
            Dim Input As DialogResult
            Input = MessageBox.Show("有欄位還沒被填寫或電話輸入不合理。A field has not been filled or the phone input is invalid.", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub LblTotal_Click(sender As Object, e As EventArgs) Handles LblTotal.Click

    End Sub
End Class