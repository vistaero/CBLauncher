﻿Public Class Favorite
    Public FavName As String
    Public FavPath As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal new_FavName As String, ByVal new_FavPath As String)
        FavName = new_FavName
        FavPath = new_FavPath

    End Sub
End Class
