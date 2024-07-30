using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

[SetUpFixture]
public class ExtentManager
{
    public static ExtentReports extent;
    public static ExtentTest test;

    [OneTimeSetUp]
    public void SetUp()
    {
        try
        {
            // Get the path of the directory containing the project file
            var projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var reportPath = Path.Combine(projectDirectory, "test-output");

            // Ensure the output directory exists
            Directory.CreateDirectory(reportPath);

            // Initialize ExtentSparkReporter with a file path
            var reportFilePath = Path.Combine(reportPath, "extent.html");
            var htmlReporter = new ExtentSparkReporter(reportFilePath);

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during ExtentManager setup: {ex.Message}");
            throw;
        }
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        try
        {
            extent.Flush();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during ExtentManager teardown: {ex.Message}");
            throw;
        }
    }
}
