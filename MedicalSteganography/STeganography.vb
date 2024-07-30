Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.IO

Public Class STeganography
    Dim opname, dept, doctor As String
    Private cryptObj As RijndaelManaged
    Private KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
    Private IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
    Private enc As System.Text.UTF8Encoding = New System.Text.UTF8Encoding()

    Private Sub STeganography_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select opCode from OutPatientTab order by opcode", Conn)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        While D1.Read
            ComboBox1.Items.Add(D1(0).ToString)
        End While

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select opName,deptname,doctorname from consultationTab where opcode=" & Val(ComboBox1.Text) & "", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.Read Then
            opname = D1(0).ToString
            dept = D1(1).ToString
            doctor = D1(2).ToString
            Dim sPlainText As String = "OP Name:" + opname + " Department:" + dept + " Doctor:" + doctor
            If Not String.IsNullOrEmpty(sPlainText) Then
                Dim bPlainText As Byte() = Me.enc.GetBytes(sPlainText)
                Dim ms As MemoryStream = New MemoryStream()
                ' Dim cs As CryptoStream = New CryptoStream(ms, cryptObj.CreateEncryptor(), CryptoStreamMode.Write)
                '  cs.Write(bPlainText, 0, sPlainText.Length)
                'cs.FlushFinalBlock()
                sPlainText = Me.enc.GetString(ms.ToArray())

            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = Image.FromFile("C:\Users\Harshan\Desktop\MedicalSteganography\MedicalSteganography\bin\Debug\trade.jpg")
        PictureBox1.Image.Save(Path.Combine("C:\FileUpload\", ComboBox1.Text + ".png"))
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select opName,deptname,doctorname from consultationTab where opcode=" & Val(ComboBox1.Text) & "", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.Read Then
            opname = D1(0).ToString
            dept = D1(1).ToString
            doctor = D1(2).ToString
            Dim sPlainText1 As String = "OP Name:" + opname + " Department:" + dept + " Doctor:" + doctor
            Dim sPlainText As String = "OP Name:" + opname + " Department:" + dept + " Doctor:" + doctor

            If Not String.IsNullOrEmpty(sPlainText) Then
                Dim bPlainText As Byte() = Me.enc.GetBytes(sPlainText1)
                Dim ms As MemoryStream = New MemoryStream()
                Dim cs As CryptoStream = New CryptoStream(ms, cryptObj.CreateEncryptor(), CryptoStreamMode.Write)
                '   cs.Write(bPlainText, 0, sPlainText.Length)
                'cs.FlushFinalBlock()
                sPlainText = Me.enc.GetString(ms.ToArray())
                TextBox2.Text = sPlainText1
            End If
        End If
    End Sub
End Class