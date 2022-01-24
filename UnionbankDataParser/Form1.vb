Public Class Form1

    Public Sub New(ByVal rtb As RichTextBox, ByVal strPath As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.rtb = rtb
        Me.strPath = strPath

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private rtbDuplicate As RichTextBox
    Public dtDuplicate As DataTable
    Private rtb As New RichTextBox
    Private dtResult As DataTable
    Private strPath As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show("System found that the following have pending card(s) for printing. Check first and tag afterward as upload (if necessary).")
        CreateTable()
        CheckRTBForDuplicate()
    End Sub

    Private Sub CreateTable()
        If dtDuplicate Is Nothing Then
            dtDuplicate = New DataTable
            dtDuplicate.Columns.Add("CRN", Type.GetType("System.String"))
            dtDuplicate.Columns.Add("First", Type.GetType("System.String"))
            dtDuplicate.Columns.Add("Middle", Type.GetType("System.String"))
            dtDuplicate.Columns.Add("Last", Type.GetType("System.String"))
            dtDuplicate.Columns.Add("Batch", Type.GetType("System.String"))
            dtDuplicate.Columns.Add("ActivityDesc", Type.GetType("System.String"))
            dtDuplicate.Columns.Add("GSU", Type.GetType("System.String"))
            dtDuplicate.Columns.Add("IsUpload", Type.GetType("System.Boolean"))
            dtDuplicate.AcceptChanges()
        End If
    End Sub

    Private Sub AddToDuplicateTable()
        If dtResult.DefaultView.Count > 0 Then
            Dim rw As DataRow = dtDuplicate.NewRow
            rw("CRN") = dtResult.Rows(0)("CRN")
            rw("First") = dtResult.Rows(0)("first_name")
            rw("Middle") = dtResult.Rows(0)("middle_name")
            rw("Last") = dtResult.Rows(0)("last_name")
            rw("Batch") = dtResult.Rows(0)("BatchNo")
            rw("ActivityDesc") = dtResult.Rows(0)("ActivityDesc")
            rw("GSU") = dtResult.Rows(0)("GSUfilename")
            rw("IsUpload") = dtResult.Rows(0)("IsUpload")
            dtDuplicate.Rows.Add(rw)
            dtDuplicate.AcceptChanges()
        End If
    End Sub

    Private Sub SaveResultTable()
        Dim rtbSRT As New RichTextBox
        For Each rw As DataRow In dtDuplicate.Rows
            Dim strLine As String = ""
            For Each col As DataColumn In dtDuplicate.Columns
                If strLine = "" Then
                    strLine = rw(col)
                Else
                    strLine &= "|" & rw(col)
                End If
            Next

            rtbSRT.AppendText(strLine & Environment.NewLine)
        Next

        rtbSRT.SaveFile(strPath.Replace("_PARSED.txt", "_DUPLICATE.txt"), RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub CheckRTBForDuplicate()
        For Each strLine As String In rtb.Lines
            If strLine <> "" Then
                Dim strCRN As String = strLine.Split("|")(0).Replace("""", "")
                If strCRN <> "crn" Then
                    If SelectAndCheckExistingCRN(strCRN) Then
                        AddToDuplicateTable()
                        rtbDuplicate.AppendText(strLine & Environment.NewLine)
                    End If
                End If
            End If
        Next

        rtbDuplicate.SaveFile(strPath.Replace("_PARSED.txt", "_PARSED_DUPLICATE.txt"), RichTextBoxStreamType.PlainText)
        SaveResultTable()
        Label1.Text = dtDuplicate.DefaultView.Count.ToString & " record(s) found"
    End Sub

    Private Function SelectAndCheckExistingCRN(ByVal strCRN As String) As Boolean
        Try
            Dim ds As New DataSet
            Dim con As New SqlClient.SqlConnection("SERVER=EDEL-PC\MSSQLSERVERDEV; DATABASE=DataRepository; UI=sa; PASSWORD=password2008;")
            Dim cmd As New SqlClient.SqlCommand("prcSelectAndCheckExistingCRN", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CRN", strCRN)
            Dim da As New SqlClient.SqlDataAdapter(cmd)
            da.Fill(ds, "Result")

            dtResult = ds.Tables("Result")

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub BindGrid()
        DataGridView1.DataSource = dtDuplicate
    End Sub

    Private Sub cmdProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProceed.Click
        Close()
    End Sub

    Private Sub cmdDontInclude_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDontInclude.Click
        dtDuplicate.Rows(DataGridView1.CurrentRow.Index)("IsUpload") = False
        BindGrid()
    End Sub

    Private Sub cmdInclude_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInclude.Click
        dtDuplicate.Rows(DataGridView1.CurrentRow.Index)("IsUpload") = True
        BindGrid()
    End Sub

End Class