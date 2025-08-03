using Generics.Chain;
using Generics.DocumentChain;

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        ICalculator<Point> pointCalculator = new PointCalculator();
        Point a = new Point()
        {
            X = 1,
            Y = 2
        };
        Point b = new Point()
        {
            X = 3,
            Y = 4
        };
        Point c = pointCalculator.Add(a, b);

        Point[] points = [c, b, a];
        
        IComparer<Point> pointComparer = new PointComparer();
        
        Array.Sort(points, pointComparer);

        foreach (var p in points)
        {
            Console.WriteLine(p.ToString());
        }
        
        List<Product> products = new List<Product>();
        
        products.Add(new Product()
        {
            Name = "Product1",
            Price = 10,
        });

        ProductStorageHandler productStorageHandler = new ProductStorageHandler(products);
        MarkingProductHandler markingProductHandler = new MarkingProductHandler();
        CompletedHandler completedHandler = new CompletedHandler();

        productStorageHandler.Successor = markingProductHandler;
        markingProductHandler.Successor = completedHandler;
        Product finishedProduct = productStorageHandler.Handle(new Product()
        {
            Name = "Product1",
        });

        Console.WriteLine(finishedProduct.Name);
        
        CheckDocumentInfo documentInfo = new CheckDocumentInfo()
        {
            Passport = "2984 847362",
            DriverLicense = "7654356",
            SSN = "11987265-4356",
            MedicalCard = "19900809-4356",
            BachelorsCertificate = "1234567893"
        };
        
        CheckPassportHandler passportHandler = new CheckPassportHandler();
        CheckDriverLicenceHandler driverLicenceHandler = new CheckDriverLicenceHandler();
        CheckSSNHandler ssnHandler = new CheckSSNHandler();
        CheckMedicalCardHandler medicalCardHandler = new CheckMedicalCardHandler();
        
        // passportHandler.Successor = driverLicenceHandler;
        // driverLicenceHandler.Successor = ssnHandler;
        // ssnHandler.Successor = medicalCardHandler;
        //
        // passportHandler.Handle(documentInfo);
        //
        // Console.WriteLine(documentInfo.DocumentCheckStatus);

        // ICheckDocumentHandler<CheckDocumentInfo> startHandler = new BaseBuilder<CheckDocumentInfo>(passportHandler)
        //     .AddHandler(driverLicenceHandler)
        //     .AddHandler(ssnHandler)
        //     .AddHandler(medicalCardHandler)
        //     .Build();
        
        // builder.AddHandler(driverLicenceHandler);
        // builder.AddHandler(ssnHandler);
        // builder.AddHandler(medicalCardHandler);
        // var startHandler = builder.Build();
        
        // startHandler.Handle(documentInfo);

        var startHandler = new CheckDocumentInfoChainBuilder()
            .WithDriverLicence()
            .WithSNN()
            .WithMedicalCard()
            .WithBachelorsCertificate()
            .Build();
        startHandler.Handle(documentInfo);
        
        Console.WriteLine(documentInfo.DocumentCheckStatus);
        
        // add 2 more documents
        
    }
}