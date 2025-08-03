namespace Generics.DocumentChain;

public class CheckDocumentInfoChainBuilder: BaseBuilder<CheckDocumentInfo>
{
    public CheckDocumentInfoChainBuilder() : base(new CheckPassportHandler())
    {
    }

    public CheckDocumentInfoChainBuilder WithDriverLicence()
    { 
        AddHandler(new CheckDriverLicenceHandler());
        return this;
    }
    
    public CheckDocumentInfoChainBuilder WithSNN()
    { 
        AddHandler(new CheckSSNHandler());
        return this;
    }
    public CheckDocumentInfoChainBuilder WithMedicalCard()
    { 
        AddHandler(new CheckMedicalCardHandler());
        return this;
    }

    public CheckDocumentInfoChainBuilder WithBachelorsCertificate()
    {
        AddHandler(new CheckBachelorsCertificateHandler());
        return this;
    }
}