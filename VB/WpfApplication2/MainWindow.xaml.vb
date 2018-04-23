Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.UI
Imports DevExpress.Mvvm.DataAnnotations

Namespace WpfApplication2
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class


    Public Class MyViewModel
        Public Overridable Property IsBold() As Boolean
        Public Overridable Property IsItalic() As Boolean
        Public Overridable Property IsUnderline() As Boolean
        Public Overridable Property Weight() As FontWeight
        Public Overridable Property Decorations() As TextDecorationCollection
        Public Overridable Property Style() As FontStyle
        Public Overridable Property Alignment() As TextAlignment
        Public Overridable Property Text() As String

        Public Sub OnIsBoldChanged()
            Weight = If(IsBold, FontWeights.Bold, FontWeights.Normal)
        End Sub
        Public Sub OnIsItalicChanged()
            Style = If(IsItalic, FontStyles.Italic, FontStyles.Normal)
        End Sub
        Public Sub OnIsUnderlineChanged()
            Decorations = If(IsUnderline, TextDecorations.Underline, New TextDecorationCollection())
        End Sub

        Public Sub New()
            Alignment = TextAlignment.Left
            SetDefaultText()
        End Sub

        Private Sub SetDefaultText()
            Text = "Text"
        End Sub

        ' An OpenFileCommand will be generated from the following method by POCO.
        Public Sub OpenFile()
            SetDefaultText()
        End Sub
        ' A NewFileCommand will be generated from the following methods by POCO.
        Public Function CanNewFile() As Boolean
            Return True
        End Function
        Public Sub NewFile()
            Text = Nothing
        End Sub
        ' A SetAlignmentCommand will be generated from the following method by POCO.
        Public Sub SetAlignment(ByVal parameter As Object)
            Alignment = (DirectCast(parameter, TextAlignment))
        End Sub

    End Class
End Namespace
