
'------------------------------------------------------------------------------
' <copyright file="xtBranch.sdo.vb" company="Microsoft">
'     Copyright (c) Microsoft Corporation.  All rights reserved.
' </copyright>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxtBranch

    Public Class xtBranch
        Inherits SolomonDataObject

        <
        DataBinding(PropertyIndex:=0, StringSize:=10)
        >
        Public Property BranchID() As String

            Get
                Return Me.GetPropertyValue("BranchID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("BranchID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=1, StringSize:=10)
        >
        Public Property CpnyID() As String

            Get
                Return Me.GetPropertyValue("CpnyID")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("CpnyID", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=2, StringSize:=30)
        >
        Public Property Contact() As String

            Get
                Return Me.GetPropertyValue("Contact")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Contact", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=3, StringSize:=30)
        >
        Public Property Descr() As String

            Get
                Return Me.GetPropertyValue("Descr")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Descr", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=4, StringSize:=30)
        >
        Public Property Fax() As String

            Get
                Return Me.GetPropertyValue("Fax")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Fax", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=5)
        >
        Public Property GrwPct() As Integer

            Get
                Return Me.GetPropertyValue("GrwPct")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("GrwPct", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=6)
        >
        Public Property GrwVal() As Double

            Get
                Return Me.GetPropertyValue("GrwVal")
            End Get

            Set(ByVal setval As Double)
                Me.SetPropertyValue("GrwVal", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=7, StringSize:=30)
        >
        Public Property Phone() As String

            Get
                Return Me.GetPropertyValue("Phone")
            End Get

            Set(ByVal setval As String)
                Me.SetPropertyValue("Phone", setval)
            End Set

        End Property
        <
        DataBinding(PropertyIndex:=8)
        >
        Public Property TranDate() As Integer

            Get
                Return Me.GetPropertyValue("TranDate")
            End Get

            Set(ByVal setval As Integer)
                Me.SetPropertyValue("TranDate", setval)
            End Set

        End Property
    End Class
    Public bxtBranch As xtBranch = New xtBranch, nxtBranch As xtBranch = New xtBranch
    Public Csr_xtBranch As Integer, Mem_xtBranch As Integer
End Module
