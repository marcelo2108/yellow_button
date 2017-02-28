Imports System.ComponentModel

<DefaultEvent("Click")>
Public Class yButton

    Dim currentColor As Color
    Dim originalSize As Size

    Dim _imageSizeClicked As Integer = 50
    Public Property y_imageSizeClicked As Integer
        Get
            Return _imageSizeClicked
        End Get
        Set(value As Integer)
            _imageSizeClicked = value
        End Set
    End Property

    Dim _imageSize As Integer = 60
    Public Property y_imageSizePercent As Integer
        Get
            Return _imageSize
        End Get
        Set(value As Integer)
            _imageSize = value
            ResizeImage()
            centerImage()
        End Set
    End Property

    Property image As Image
        Get
            Return pb_image.Image
        End Get
        Set(value As Image)
            pb_image.Image = value
        End Set
    End Property

    Private Sub yellowButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            ResizeImage()
        Catch ex As Exception
            showError(ex)
        End Try
    End Sub

    Private Sub pb_image_MouseDown(sender As Object, e As MouseEventArgs) Handles pb_image.MouseDown, Me.MouseDown
        Try
            hoverImage()

        Catch ex As Exception
            showError(ex)
        End Try
    End Sub

    Private Sub pb_image_MouseUp(sender As Object, e As MouseEventArgs) Handles pb_image.MouseUp, Me.MouseUp
        Try
            leaveImage()
            RaiseEvent Click(sender, e)
        Catch ex As Exception
            showError(ex)
        End Try
    End Sub

    Public Shadows Event Click(sender As Object, e As EventArgs)

    'main functions
    Sub ResizeImage()
        Try
            pb_image.Height = (Me.Height * _imageSize) / 100
            pb_image.Width = (Me.Width * _imageSize) / 100
            centerImage()
        Catch ex As Exception
            showError(ex)
        End Try
    End Sub

    Sub centerImage()
        Try
            pb_image.Top = Height / 2 - (pb_image.Height / 2)
            pb_image.Left = Width / 2 - (pb_image.Width / 2)
        Catch ex As Exception
            showError(ex)
        End Try
    End Sub

    Sub hoverImage()
        Try
            pb_image.Height = (Me.Height * _imageSizeClicked) / 100
            pb_image.Width = (Me.Width * _imageSizeClicked) / 100
            centerImage()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub leaveImage()
        Try
            ResizeImage()
            centerImage()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    'auxiliar functions
    Sub showError(ex As Exception)
        Try
            MsgBox(ex)
        Catch ex1 As Exception

        End Try
    End Sub

    Private Sub yButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            originalSize = pb_image.Size
        Catch ex As Exception
            showError(ex)
        End Try
    End Sub

End Class
