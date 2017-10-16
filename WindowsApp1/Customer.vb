Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Customer")>
Partial Public Class Customer
    Public Property Id As Integer

    <StringLength(50)>
    Public Property firstName As String

    <StringLength(50)>
    Public Property lastName As String

    <StringLength(50)>
    Public Property streetNumber As String

    <StringLength(50)>
    Public Property city As String

    <StringLength(50)>
    Public Property province As String

    <StringLength(50)>
    Public Property country As String

    <StringLength(50)>
    Public Property postalCode As String

    <StringLength(50)>
    Public Property phoneNumber As String

    <StringLength(50)>
    Public Property emailAddress As String
End Class
