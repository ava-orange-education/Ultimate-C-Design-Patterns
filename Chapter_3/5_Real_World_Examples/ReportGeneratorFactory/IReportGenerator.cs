namespace Chapter_1._5_Real_World_Examples.ReportGeneratorFactory
{
    public interface IReportGenerator
    {
        void ApplyFormatting();
        void LoadDataFromDatabase();
    }
}