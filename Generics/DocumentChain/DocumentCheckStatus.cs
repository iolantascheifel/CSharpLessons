using System.Diagnostics.CodeAnalysis;

namespace Generics.DocumentChain;

public enum DocumentCheckStatus
{
    Correct,
    IncorrectPassport,
    IncorrectDriverLicense,
    IncorrectSSN,
    IncorrectMedicalCard,
    IncorrectBachelorsCertificate,
}