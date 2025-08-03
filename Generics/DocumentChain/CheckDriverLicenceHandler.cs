namespace Generics.DocumentChain;

public class CheckDriverLicenceHandler: BaseHandler<CheckDocumentInfo>
{
    public override void Handle(CheckDocumentInfo request)
    {
        foreach (var symbol in request.DriverLicense)
        {
            if (!char.IsDigit(symbol))
            {
                request.DocumentCheckStatus = DocumentCheckStatus.IncorrectDriverLicense;
                return;
            }
        }
        base.Handle(request);
    }
}