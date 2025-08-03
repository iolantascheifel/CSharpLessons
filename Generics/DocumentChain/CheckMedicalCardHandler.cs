namespace Generics.DocumentChain;

public class CheckMedicalCardHandler: BaseHandler<CheckDocumentInfo>
{
    public override void Handle(CheckDocumentInfo request)
    {
        if (string.IsNullOrEmpty(request.MedicalCard))
        {
            request.DocumentCheckStatus = DocumentCheckStatus.IncorrectMedicalCard;
            return;
        }

        string[] partsOfSSN = request.MedicalCard.Split("-");
        if (partsOfSSN.Length != 2 || partsOfSSN[0].Length != 8 || partsOfSSN[1].Length != 4)
        {
            request.DocumentCheckStatus = DocumentCheckStatus.IncorrectMedicalCard;
            return;
        }
       
        request.DocumentCheckStatus = DocumentCheckStatus.Correct;
    }
}