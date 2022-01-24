Public Class form_Decryption

#Region " Public Variable "

    Private CardType As String = ""
    Private dtDuplicateResult As DataTable

#End Region

#Region "Functions and Sub Routines"

    Function DetermineCardType(ByVal pFilePath As String) As String
        Try
            Dim temp() As String = IO.Path.GetFileNameWithoutExtension(pFilePath).Split("_")
            Return temp(0).Substring(temp(0).Length - 3, 3)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Sub LockButtons(ByVal Locked As Boolean)
        button_Browse.Enabled = Not Locked
        button_Decrypt.Enabled = Not Locked
        button_Save.Enabled = Not Locked
        button_Parse.Enabled = Not Locked
        button_SaveParsed.Enabled = Not Locked
    End Sub

    Sub ParseGSISData(ByVal pFreeText2 As String, ByRef pSignStatus As String, _
                           ByRef pEmployeeFlag As String, _
                           ByRef pGSISNum As String, _
                           ByRef pBPNum As String)

        Try
            pSignStatus = pFreeText2.Substring(0, 1).Trim
            pEmployeeFlag = pFreeText2.Substring(1, 1).Trim
            pGSISNum = pFreeText2.Substring(2, 11).Trim
            pBPNum = pFreeText2.Substring(13, 10).Trim
        Catch ex As Exception
            pSignStatus = ""
            pEmployeeFlag = ""
            pGSISNum = ""
            pBPNum = ""
        End Try

    End Sub

    Function ParseTrackData(ByVal TrackData As String, ByVal CardType As String) As String

        Try

            If CardType = "GSU" Then
                Return TrackData.Replace("P", ";").Replace("Q", "=").Replace("R", "?")
            ElseIf CardType = "GSI" Then
                Return TrackData.Replace("P", ";").Replace("Q", "=").Replace("R", "?").Replace("JC", "%B").Replace("L", "^").Replace("M", "^").Replace("N", "?")
            Else
                Return TrackData
            End If

        Catch ex As Exception
            Return TrackData
        End Try

    End Function

    Function ParseLine(ByVal pLine As String) As String

        Dim CRN, Name1, Name2, Name3, Name4, Bday, _
            AccountNumber, CardType, CardGroup, GenType, _
            CardNumber, FreeText1, FreeText2, FreeText3, _
            FreeText4, FreeText5, EmbossedName, ExpDate, _
            VC, Dummy, TDTEXT As String

        Dim SignatureStatus, EmployeeFlag, GsisNumber, BpNumber As String

        Dim GSUSeries As String = ""

        SignatureStatus = ""
        EmployeeFlag = ""
        GsisNumber = ""
        BpNumber = ""

        CRN = pLine.Substring(0, 20).Trim
        Name1 = """" + pLine.Substring(20, 40).Trim + """"
        Name2 = """" + pLine.Substring(60, 40).Trim + """"
        Name3 = """" + pLine.Substring(100, 40).Trim + """"
        Name4 = """" + pLine.Substring(140, 10).Trim + """"
        Bday = """" + pLine.Substring(150, 8).Trim + """"
        AccountNumber = """" + pLine.Substring(158, 12).Trim + """"
        CardType = pLine.Substring(170, 3).Trim
        CardGroup = """" + pLine.Substring(173, 5).Trim + """"
        GenType = """" + pLine.Substring(178, 3).Trim + """"
        CardNumber = """" + pLine.Substring(181, 20).Trim + """"
        FreeText1 = """" + pLine.Substring(201, 50).Trim + """"
        FreeText2 = pLine.Substring(251, 50)
        FreeText3 = """" + pLine.Substring(301, 50).Trim + """"
        FreeText4 = """" + pLine.Substring(351, 50).Trim + """"
        FreeText5 = """" + pLine.Substring(401, 50).Trim + """"
        EmbossedName = """" + pLine.Substring(451, 26).Trim + """"
        ExpDate = """" + pLine.Substring(477, 5).Trim + """"
        VC = """" + pLine.Substring(482, 7).Trim + """"
        Dummy = """" + pLine.Substring(489, 12) + """"
        GSUSeries = """" + pLine.Substring(401, 15) + """"

        TDTEXT = pLine.Substring(501, 117)

        TDTEXT = """" + ParseTrackData(TDTEXT, CardType).Trim + """"
        CardType = """" + CardType + """"

        ParseGSISData(FreeText2, SignatureStatus, EmployeeFlag, GsisNumber, BpNumber)

        If CRN.Length = 12 Then

            'CRN = CRN.Substring(0, 3) + "-" + _
            '      CRN.Substring(3, 3) + "-" + _
            '      CRN.Substring(6, 3) + "-" + _
            '      CRN.Substring(9, 3)

            CRN = CRN.Substring(0, 3) + "-" + _
                  CRN.Substring(3, 4) + "-" + _
                  CRN.Substring(7, 4) + "-" + _
                  CRN.Substring(11, 1)

        End If

        CRN = """" + CRN + """"


        Return CRN + "|" + _
               Name1 + "|" + _
               Name2 + "|" + _
               Name3 + "|" + _
               Name4 + "|" + _
               Bday + "|" + _
               AccountNumber + "|" + _
               CardType + "|" + _
               CardGroup + "|" + _
               GenType + "|" + _
               CardNumber + "|" + _
               FreeText1 + "|" + _
               SignatureStatus + "|" + _
               EmployeeFlag + "|" + _
               GsisNumber + "|" + _
               BpNumber + "|" + _
               FreeText3 + "|" + _
               FreeText4 + "|" + _
               FreeText5 + "|" + _
               EmbossedName + "|" + _
               ExpDate + "|" + _
               VC + "|" + _
               Dummy + "|" + _
               TDTEXT + "|" + _
               GSUSeries

        'Return CRN + "," + _
        '       Name1 + "," + _
        '       Name2 + "," + _
        '       Name3 + "," + _
        '       Name4 + "," + _
        '       Bday + "," + _
        '       AccountNumber + "," + _
        '       CardType + "," + _
        '       CardGroup + "," + _
        '       GenType + "," + _
        '       CardNumber + "," + _
        '       FreeText1 + "," + _
        '       FreeText2 + "," + _
        '       FreeText3 + "," + _
        '       FreeText4 + "," + _
        '       FreeText5 + "," + _
        '       EmbossedName + "," + _
        '       ExpDate + "," + _
        '       VC + "," + _
        '       Dummy + "," + _
        '       TDTEXT

    End Function

#End Region

    Private Sub button_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_Browse.Click
        'If Not IsForSegregation Then
        Dim OpenFile As New OpenFileDialog
        OpenFile.Title = "Unionbank Encrypted File"
        'OpenFile.Filter = "Text File | *.txt"

        richtextbox_Encrypted.Text = ""

        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            textbox_FilePath.Text = OpenFile.FileName
            CardType = DetermineCardType(OpenFile.FileName)

            Console.WriteLine("Current File: " + OpenFile.FileName)
            Console.WriteLine("Card Type: " + CardType)

            Cursor = Cursors.WaitCursor

            Application.DoEvents()

            If Not checkbox_FileDecrypted.Checked Then
                richtextbox_Encrypted.LoadFile(OpenFile.FileName, RichTextBoxStreamType.PlainText)
            Else
                richtextbox_Decrypted.LoadFile(OpenFile.FileName, RichTextBoxStreamType.PlainText)
            End If

            Cursor = Cursors.Arrow

        Else
            textbox_FilePath.Text = ""
            richtextbox_Encrypted.Text = ""
        End If

        OpenFile.Dispose()

        If checkbox_FileDecrypted.Checked Then
            tabcontrol_UBP.SelectedTab = tabpage_Decrypted
        End If
        'Else
        'OpenParsedTextfile()
        'End If
    End Sub

    Private Sub OpenParsedTextfile()

        Dim OpenFile As New OpenFileDialog
        OpenFile.Title = "Parsed File"
        OpenFile.Filter = "Text File | *.txt"

        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            textbox_FilePath.Text = OpenFile.FileName
            'CardType = DetermineCardType(OpenFile.FileName)

            If UCase(IO.Path.GetFileNameWithoutExtension(textbox_FilePath.Text).Split("_")(3)) <> "PARSED" Then
                MessageBox.Show("Please select the correct file", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                If Not IO.File.Exists(Replace(OpenFile.FileName, "_PARSED", "_DECRYPTED")) Then
                    MessageBox.Show("File with _DECRYPTED file format cannot be found.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            Cursor = Cursors.WaitCursor

            Application.DoEvents()

            strParsedFile = IO.Path.GetFileName(textbox_FilePath.Text)
            strDecryptedFile = IO.Path.GetFileName(Replace(OpenFile.FileName, "_PARSED", "_DECRYPTED"))

            rtbPARSED.LoadFile(OpenFile.FileName, RichTextBoxStreamType.PlainText)
            rtbDECRYPTED.LoadFile(Replace(OpenFile.FileName, "_PARSED", "_DECRYPTED"), RichTextBoxStreamType.PlainText)

            Cursor = Cursors.Arrow
        Else
            textbox_FilePath.Text = ""
        End If

        OpenFile.Dispose()
    End Sub

    Private Sub button_Decrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_Decrypt.Click

        If textbox_FilePath.Text.Trim = "" Then
            MessageBox.Show("Please select a file first...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Start decrypting now?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        richtextbox_Decrypted.Text = ""

        progress_Decryption.Visible = True

        LockButtons(True)

        Cursor = Cursors.WaitCursor

        Application.DoEvents()

        Dim TimeStarted As Date = Now
        Dim Elapse As String = ""
        Dim RecordCounter As Integer = 0

        Try

            Dim NFile As Short
            Dim sStreamLine As String
            'Dim UBP As New PrjADSCardFile.ADSCardFile
            Dim UBP As New UBPADSObject.clsUBP

            NFile = FreeFile()
            FileOpen(NFile, textbox_FilePath.Text.Trim, OpenMode.Input)

            Do Until EOF(NFile)
                RecordCounter += 1
                sStreamLine = LineInput(NFile)
                sStreamLine = UBP.Decrypt(sStreamLine)
                richtextbox_Decrypted.AppendText(sStreamLine + vbNewLine)
                Application.DoEvents()
                System.Threading.Thread.Sleep(1)
            Loop

            FileClose(NFile)

            Cursor = Cursors.Arrow

            Dim TimeEnded As Date = Now
            Dim ElapsedTime As TimeSpan = TimeEnded.Subtract(TimeStarted)
            Elapse = "Total Elapsed Time " + _
                     ElapsedTime.Hours.ToString + " Hour(s) " + ElapsedTime.Minutes.ToString + " Minute(s) " + _
                     ElapsedTime.Seconds.ToString + "." + ElapsedTime.Milliseconds.ToString + " Second(s)"

            UBP = Nothing
        Catch ex As Exception
            richtextbox_Decrypted.Text = "Unable to decrypt text file..."
        End Try

        Cursor = Cursors.Arrow

        progress_Decryption.Visible = False

        LockButtons(False)

        MessageBox.Show("Total Records Decrypted: " + RecordCounter.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Decryption of data complete..." + vbNewLine + vbNewLine + Elapse, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        tabcontrol_UBP.SelectedTab = tabpage_Decrypted
    End Sub

    Private Sub button_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_Save.Click

        If richtextbox_Decrypted.Text.Trim = "" Or richtextbox_Decrypted.Text = "Unable to decrypt text file..." Then
            MessageBox.Show("Nothing to save...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim SaveFile As New SaveFileDialog
        SaveFile.Title = "Save UBP Decrypted Data"
        SaveFile.Filter = "Text File | *.txt"

        If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            richtextbox_Decrypted.SaveFile(SaveFile.FileName, RichTextBoxStreamType.PlainText)
        End If

        SaveFile.Dispose()

    End Sub

    Private Sub button_Parse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_Parse.Click

        If richtextbox_Decrypted.Text.Trim = "" Or richtextbox_Decrypted.Text = "Unable to decrypt text file..." Then
            MessageBox.Show("Nothing to parse...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Start parsing now?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        richtextbox_Parsed.Text = ""

        progress_Parsing.Visible = True
        progress_Parsing.Minimum = 0
        progress_Parsing.Maximum = richtextbox_Decrypted.Lines.Length
        progress_Parsing.Value = 0

        Cursor = Cursors.WaitCursor

        Dim TimeStarted As Date = Now
        Dim Elapse As String = ""
        Dim RecordCounter As Integer = 0
        Dim ErrorCounter As Integer = 0

        LockButtons(True)

        richtextbox_Parsed.Text = ""

        richtextbox_Parsed.AppendText("crn|name1|name2|name3|name4|bday|account number|card type|card group|gentype|card number|freetext1|signature status|employee flag|gsis number|bp number|freetext3|freetext4|freetext5|embossed name|expdate|vc|dummy|trackdata|GSU Series" + vbNewLine)

        For Each Line As String In richtextbox_Decrypted.Lines

            Try
                If Not Line.Trim = "" Then
                    richtextbox_Parsed.AppendText(ParseLine(Line) + vbNewLine)
                End If
            Catch ex As Exception
                ErrorCounter += 1
            End Try

            progress_Parsing.Value += 1
            Application.DoEvents()
            System.Threading.Thread.Sleep(1)

        Next

        Dim TimeEnded As Date = Now
        Dim ElapsedTime As TimeSpan = TimeEnded.Subtract(TimeStarted)

        Elapse = "Total Elapsed Time " + _
                 ElapsedTime.Hours.ToString + " Hour(s) " + ElapsedTime.Minutes.ToString + " Minute(s) " + _
                 ElapsedTime.Seconds.ToString + "." + ElapsedTime.Milliseconds.ToString + " Second(s)"

        progress_Parsing.Minimum = 0
        progress_Parsing.Maximum = 0
        progress_Parsing.Value = 0
        progress_Parsing.Visible = False

        LockButtons(False)

        Cursor = Cursors.Arrow

        MessageBox.Show("Total Records Parsed: " + CStr(richtextbox_Decrypted.Lines.Length - 1 - ErrorCounter), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Parsing of data complete..." + vbNewLine + vbNewLine + Elapse, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        tabcontrol_UBP.SelectedTab = tabpage_Parsed

    End Sub

    Private Sub button_SaveParsed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_SaveParsed.Click

        If richtextbox_Parsed.Text.Trim = "" Or richtextbox_Parsed.Text = "Unable to parse text file..." Then
            MessageBox.Show("Nothing to save...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim SaveFile As New SaveFileDialog
        SaveFile.Title = "Save UBP Decrypted Data"
        SaveFile.Filter = "Text File | *.txt"

        If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            richtextbox_Parsed.SaveFile(SaveFile.FileName, RichTextBoxStreamType.PlainText)
        End If

        SaveFile.Dispose()

        Dim frm As New Form1(richtextbox_Parsed, SaveFile.FileName)
        frm.ShowDialog()
        dtDuplicateResult = frm.dtDuplicate

        tabcontrol_UBP.SelectedTab = tabpage_Segregate
        checkbox_FileDecrypted.Visible = False
    End Sub

    Private Sub form_Decryption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tabcontrol_UBP.TabPages.Remove(tabpage_Parsed)
        tabcontrol_UBP.TabPages.Remove(tabpage_Segregate)
    End Sub

    Private Sub cmdSegregate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSegregate.Click
        If textbox_FilePath.Text = "" Then
            MessageBox.Show("Please specify textfile.", "Segregation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        strParsedFile = Replace(textbox_FilePath.Text, ".txt", "_PARSED.txt")
        strDecryptedFile = Replace(textbox_FilePath.Text, ".txt", "_DECRYPTED.txt")

        If Not IO.File.Exists(strParsedFile) Then
            MessageBox.Show(strParsedFile & " do not exist.", "Segregation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Not IO.File.Exists(strDecryptedFile) Then
            MessageBox.Show(strDecryptedFile & " do not exist.", "Segregation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        rtbPARSED.LoadFile(strParsedFile, RichTextBoxStreamType.PlainText)
        rtbDECRYPTED.LoadFile(strDecryptedFile, RichTextBoxStreamType.PlainText)

        SegregateParseData()
    End Sub


    Private strParsedFile As String
    Private strDecryptedFile As String
    Private rtbDECRYPTED As New RichTextBox
    Private rtbDECRYPTED811 As New RichTextBox
    Private rtbDECRYPTED812 As New RichTextBox
    Private rtbDECRYPTED813 As New RichTextBox

    Private rtbPARSED As New RichTextBox
    Private rtbPARSED811 As New RichTextBox
    Private rtbPARSED812 As New RichTextBox
    Private rtbPARSED813 As New RichTextBox


    Private Sub SegregateDecryptedData(ByVal strGenType As String, ByVal strCRN As String)
        Select Case strGenType
            Case "811"
                rtbDECRYPTED811.AppendText(ExtractFromDecrypted(strCRN) & Environment.NewLine)
            Case "812"
                rtbDECRYPTED812.AppendText(ExtractFromDecrypted(strCRN) & Environment.NewLine)
            Case "813"
                rtbDECRYPTED813.AppendText(ExtractFromDecrypted(strCRN) & Environment.NewLine)
        End Select
    End Sub

    Private Function ExtractFromDecrypted(ByVal strCRN As String) As String
        strCRN = strCRN.Replace("-", "")
        strCRN = strCRN.Replace("""", "")
        For Each strLine As String In rtbDECRYPTED.Lines
            If strLine.Split(" ")(0) = strCRN Then
                Return strLine
            End If
        Next
    End Function

    Private Function CheckCRNIfInDuplicateRecordTable(ByVal strCRN As String) As Boolean
        If Not dtDuplicateResult Is Nothing Then
            If dtDuplicateResult.Select("CRN = '" & strCRN & "'").Length > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub SegregateParseData()
        'Dim strPARSEDFile As String = ""

        Dim strRootFolder As String = IO.Path.GetDirectoryName(textbox_FilePath.Text)
        Dim strREGFolder As String = strRootFolder & "\Regular"
        Dim strREPFolder As String = strRootFolder & "\Replacement"
        Dim strRENFolder As String = strRootFolder & "\Renewal"

        If IO.Directory.Exists(strREGFolder) Then IO.Directory.Delete(strREGFolder, True)
        IO.Directory.CreateDirectory(strREGFolder)

        If IO.Directory.Exists(strREPFolder) Then IO.Directory.Delete(strREPFolder, True)
        IO.Directory.CreateDirectory(strREPFolder)

        If IO.Directory.Exists(strRENFolder) Then IO.Directory.Delete(strRENFolder, True)
        IO.Directory.CreateDirectory(strRENFolder)

        'rtbPARSED.LoadFile(strPARSEDFile, RichTextBoxStreamType.PlainText)

        Dim rtbPARSED811 As New RichTextBox
        Dim rtbPARSED812 As New RichTextBox
        Dim rtbPARSED813 As New RichTextBox

        Dim Records() As String

        Try
            If rtbPARSED.Text.Trim = "" Then
                MessageBox.Show("Nothing to process...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim ErrorCount As Integer = 0
            Dim countRec As Integer = 0

            progressbarSegregate.Maximum = rtbPARSED.Lines.Length
            progressbarSegregate.Minimum = 0
            progressbarSegregate.Value = 0

            Cursor = Cursors.WaitCursor

            Dim i As Integer = 0

            For Each Line As String In rtbPARSED.Lines

                If Not Line.Trim = "" Then
                    Records = Line.Split("|")

                    If Records(0) = "crn" Then
                        rtbPARSED811.AppendText(Line & Environment.NewLine)
                        rtbPARSED812.AppendText(Line & Environment.NewLine)
                        rtbPARSED813.AppendText(Line & Environment.NewLine)
                    Else
                        If Not CheckCRNIfInDuplicateRecordTable(Records(0)) Then
                            Select Case Records(9).Replace("""", "")
                                Case "811"
                                    rtbPARSED811.AppendText(Line & Environment.NewLine)
                                Case "812"
                                    rtbPARSED812.AppendText(Line & Environment.NewLine)
                                Case "813"
                                    rtbPARSED813.AppendText(Line & Environment.NewLine)
                            End Select

                            SegregateDecryptedData(Records(9).Replace("""", ""), Records(0))
                        End If
                        
                    End If
                    '==================End UMID table============================
                End If

                progressbarSegregate.Value += 1
                'label_Status.Text = "Processing: " + objExdtl.crn
                Application.DoEvents()
                System.Threading.Thread.Sleep(1)

                i += 1
            Next

            strParsedFile = IO.Path.GetFileName(strParsedFile)
            strDecryptedFile = IO.Path.GetFileName(strDecryptedFile)

            rtbPARSED811.SaveFile(strREGFolder & "\" & strParsedFile, RichTextBoxStreamType.PlainText)
            rtbPARSED812.SaveFile(strREPFolder & "\" & strParsedFile, RichTextBoxStreamType.PlainText)
            rtbPARSED813.SaveFile(strRENFolder & "\" & strParsedFile, RichTextBoxStreamType.PlainText)
            rtbDECRYPTED811.SaveFile(strREGFolder & "\" & strDecryptedFile, RichTextBoxStreamType.PlainText)
            rtbDECRYPTED812.SaveFile(strREPFolder & "\" & strDecryptedFile, RichTextBoxStreamType.PlainText)
            rtbDECRYPTED813.SaveFile(strRENFolder & "\" & strDecryptedFile, RichTextBoxStreamType.PlainText)

            Cursor = Cursors.Arrow
            progressbarSegregate.Maximum = 0
            progressbarSegregate.Minimum = 0
            progressbarSegregate.Value = 0
            MessageBox.Show("Segregation of data complete", "Upload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub

    

End Class
