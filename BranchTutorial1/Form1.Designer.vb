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
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        m_IsInitializing = true
        InitializeComponent()
        m_IsInitializing = False
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Update1 As Microsoft.Dynamics.SL.Controls.DSLUpdate
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Update1 = New Microsoft.Dynamics.SL.Controls.DSLUpdate()
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblContactPerson = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.dslmBranch = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.dslmDesc = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.dslmContPer = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.dslmPhone = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.dslmFax = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Update1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.Image = CType(resources.GetObject("Update1.Image"), System.Drawing.Image)
        Me.Update1.Levels = "Header;N"
        Me.Update1.Location = New System.Drawing.Point(396, 12)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(25, 25)
        Me.Update1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Update1.TabIndex = 0
        Me.Update1.TabStop = False
        Me.Update1.Visible = False
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Location = New System.Drawing.Point(16, 15)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(54, 13)
        Me.lblBranch.TabIndex = 1
        Me.lblBranch.Text = "Branch ID"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(16, 42)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description"
        '
        'lblContactPerson
        '
        Me.lblContactPerson.AutoSize = True
        Me.lblContactPerson.Location = New System.Drawing.Point(16, 68)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(81, 13)
        Me.lblContactPerson.TabIndex = 3
        Me.lblContactPerson.Text = "Contact Person"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(16, 94)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(37, 13)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(16, 120)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(25, 13)
        Me.lblFax.TabIndex = 5
        Me.lblFax.Text = "Fax"
        '
        'dslmBranch
        '
        Me.dslmBranch.Blankerr = True
        Me.dslmBranch.FieldName = """bxtBranch.BranchID""; 0; 0; 0"
        Me.dslmBranch.Level = "0,k"
        Me.dslmBranch.Location = New System.Drawing.Point(115, 12)
        Me.dslmBranch.Mask = "UUUUUUUUUU"
        Me.dslmBranch.Name = "dslmBranch"
        Me.dslmBranch.Size = New System.Drawing.Size(256, 20)
        Me.dslmBranch.TabIndex = 6
        Me.dslmBranch.TextLength = 10
        '
        'dslmDesc
        '
        Me.dslmDesc.FieldName = """bxtBranch.Descr""; 0; 0; 0"
        Me.dslmDesc.Location = New System.Drawing.Point(115, 39)
        Me.dslmDesc.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.dslmDesc.Name = "dslmDesc"
        Me.dslmDesc.Size = New System.Drawing.Size(256, 20)
        Me.dslmDesc.TabIndex = 7
        Me.dslmDesc.TextLength = 25
        '
        'dslmContPer
        '
        Me.dslmContPer.FieldName = """bxtBranch.Contact""; 0; 0; 0"
        Me.dslmContPer.Location = New System.Drawing.Point(115, 65)
        Me.dslmContPer.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.dslmContPer.Name = "dslmContPer"
        Me.dslmContPer.Size = New System.Drawing.Size(256, 20)
        Me.dslmContPer.TabIndex = 8
        Me.dslmContPer.TextLength = 25
        '
        'dslmPhone
        '
        Me.dslmPhone.FieldName = """bxtBranch.Phone""; 0; 0; 0"
        Me.dslmPhone.Location = New System.Drawing.Point(115, 91)
        Me.dslmPhone.Mask = "(999)99999-9999"
        Me.dslmPhone.Name = "dslmPhone"
        Me.dslmPhone.Size = New System.Drawing.Size(256, 20)
        Me.dslmPhone.TabIndex = 9
        Me.dslmPhone.TextLength = 15
        '
        'dslmFax
        '
        Me.dslmFax.FieldName = """bxtBranch.Fax""; 0; 0; 0"
        Me.dslmFax.Location = New System.Drawing.Point(115, 117)
        Me.dslmFax.Mask = "(999)99999-9999"
        Me.dslmFax.Name = "dslmFax"
        Me.dslmFax.Size = New System.Drawing.Size(256, 20)
        Me.dslmFax.TabIndex = 10
        Me.dslmFax.TextLength = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(433, 166)
        Me.Controls.Add(Me.dslmFax)
        Me.Controls.Add(Me.dslmPhone)
        Me.Controls.Add(Me.dslmContPer)
        Me.Controls.Add(Me.dslmDesc)
        Me.Controls.Add(Me.dslmBranch)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblContactPerson)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblBranch)
        Me.Controls.Add(Me.Update1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Branch Maintenance (TS.BMN.00)"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents lblBranch As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblContactPerson As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblFax As Label
    Friend WithEvents dslmBranch As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents dslmDesc As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents dslmContPer As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents dslmPhone As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents dslmFax As Microsoft.Dynamics.SL.Controls.DSLMaskedText
#End Region
End Class
