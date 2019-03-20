'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
Option Explicit On
Option Strict Off
Friend Class Form1
    Inherits System.Windows.Forms.Form

    Protected m_IsInitializing As Boolean
    Protected ReadOnly Property IsInitializing() As Boolean
        Get
            Return m_IsInitializing
        End Get
    End Property

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        ' Initialize the application as a Microsoft Dynamics SL Application
        Call ApplInit()

        Call SetAddr(LEVEL0, "bxtBranch", bxtBranch, nxtBranch)

        Call SqlCursorEx(Csr_xtBranch, LEVEL0, "Csr_xtBranch", "bxtBranch", "bxtBranch")

        ' Call the screen init function
        Call ScreenInit()


    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

    Private Sub dslmBranch_ChkEvent(ByRef ChkStrg As String, ByRef RetVal As Short) Handles dslmBranch.ChkEvent
        Dim sqlstr As String
        sqlstr = "select * from xtBranch where BranchId = " + SParm(Trim(ChkStrg))
        serr10 = SqlFetch1(Csr_xtBranch, sqlstr, bxtBranch)
        If serr1 = 0 Then
            Call DispFields(Me, PNULL, PNULL)
        End If
    End Sub

    Private Sub Update1_NewLevelEvent(Level As Short, ByRef RetVal As Short) Handles Update1.NewLevelEvent
        If Level = NEWROW Then
            bxtBranch.CpnyID = Trim(bpes.CpnyID)
        End If
    End Sub
End Class
