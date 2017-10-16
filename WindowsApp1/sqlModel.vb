Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class sqlModel
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=sqlModel")
    End Sub

    Public Overridable Property Customers As DbSet(Of Customer)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class
