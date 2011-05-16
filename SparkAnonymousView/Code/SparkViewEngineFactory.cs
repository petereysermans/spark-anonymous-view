using Spark;
using Spark.FileSystem;

namespace SparkAnonymousView.Code
{
    public class SparkViewEngineFactory
    {
        public T CreateFrom<T>()
        {
            var settings = new SparkSettings().SetPageBaseType(typeof(T));

            var templates = new FileSystemViewFolder(@"C:\Two to Tango\Internal\Labs\BlogAnonymousObjectAsModelForSparkView\WebApplication1\Templates");

            var engine = new SparkViewEngine(settings)
            {
                ViewFolder = templates
            };

            var descriptor = new SparkViewDescriptor();
            descriptor.AddTemplate("test.sprk.htm");

            return (T)engine.CreateInstance(descriptor);
        }
    }
}
