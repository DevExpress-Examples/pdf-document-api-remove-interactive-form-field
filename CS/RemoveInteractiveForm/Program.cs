using DevExpress.Pdf;

namespace RemoveInteractiveForm {
    class Program {
        static void Main(string[] args) {
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Load a document with interactive form.
                processor.LoadDocument("..\\..\\InteractiveForm.pdf");

                // Remove a form field by its name.
                processor.RemoveFormField("FirstName");

                // Save the result document.
                processor.SaveDocument("..\\..\\Result.pdf");
            }
        }
    }
}
