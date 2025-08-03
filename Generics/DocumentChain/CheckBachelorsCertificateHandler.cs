namespace Generics.DocumentChain;

public class CheckBachelorsCertificateHandler: BaseHandler<CheckDocumentInfo>
{
    public override void Handle(CheckDocumentInfo request)
    {
        if (string.IsNullOrEmpty(request.BachelorsCertificate))
        {
            request.DocumentCheckStatus = DocumentCheckStatus.IncorrectBachelorsCertificate;
            return;
        }
        
        if (request.BachelorsCertificate.Length != 10 )
        {
            request.DocumentCheckStatus = DocumentCheckStatus.IncorrectBachelorsCertificate;
            return;
        }

        base.Handle(request);
    }
}