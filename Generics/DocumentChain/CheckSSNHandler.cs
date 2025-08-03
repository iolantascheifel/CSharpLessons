namespace Generics.DocumentChain;

public class CheckSSNHandler: BaseHandler<CheckDocumentInfo>
{
    public override void Handle(CheckDocumentInfo request)
    {
        if (string.IsNullOrEmpty(request.SSN))
        {
            request.DocumentCheckStatus = DocumentCheckStatus.IncorrectSSN;
            return;
        }

        string[] partsOfSNN = request.SSN.Split("-");
        if (partsOfSNN.Length != 2 || partsOfSNN[0].Length != 8 || partsOfSNN[1].Length != 4)
        {
            request.DocumentCheckStatus = DocumentCheckStatus.IncorrectSSN;
            return;
        }
        base.Handle(request);
    }
}