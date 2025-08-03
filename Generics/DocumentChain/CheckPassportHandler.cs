namespace Generics.DocumentChain;

public class CheckPassportHandler: BaseHandler<CheckDocumentInfo>
{
    public override void Handle(CheckDocumentInfo request)
    {
        if (string.IsNullOrEmpty(request.Passport))
        {
            request.DocumentCheckStatus = DocumentCheckStatus.IncorrectPassport;
            return;
        }

        string[] partsOfPassport = request.Passport.Split();
        if (partsOfPassport.Length != 2 || partsOfPassport[0].Length != 4 || partsOfPassport[1].Length != 6)
        {
            request.DocumentCheckStatus = DocumentCheckStatus.IncorrectPassport;
            return;
        }
        
        base.Handle(request);
    }
}