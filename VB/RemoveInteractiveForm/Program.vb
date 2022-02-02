Imports DevExpress.Pdf

Namespace RemoveInteractiveForm

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Load a document with interactive form.
                processor.LoadDocument("..\..\InteractiveForm.pdf")
                ' Remove a form field by its name.
                processor.RemoveFormField("FirstName")
                ' Save the result document.
                processor.SaveDocument("..\..\Result.pdf")
            End Using
        End Sub
    End Class
End Namespace
