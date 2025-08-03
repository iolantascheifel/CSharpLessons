namespace Generics.DocumentChain;

public class CheckDocumentInfo
{
    public string Passport { get; set; }
    public string DriverLicense  { get; set; }
    public string SSN { get; set; }
    public string MedicalCard  { get; set; }
    
    public string BachelorsCertificate { get; set; }
    public DocumentCheckStatus DocumentCheckStatus { get; set; }
}