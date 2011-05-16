using System;
using System.IO;
using System.Web.UI;
using SparkAnonymousView.Code;

namespace SparkAnonymousView
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sparkViewEngineFactory = new SparkViewEngineFactory();
            var view = sparkViewEngineFactory.CreateFrom<AnonymousSparkView>();

            var data = new
            {
                TestProperty1 = "Test Property 1 Value",
                TestProperty2 = "Test Property 2 Value",
                TestProperty3 = "Test Property 3 Value",
                TestProperty4 = "Test Property 4 Value"
            };

            view.Data = data;
            view.AnonymousType = data.GetType();

            var htmlStringWriter = new StringWriter();
            view.RenderView(htmlStringWriter);

            outputLiteral.Text = htmlStringWriter.ToString();
        }
    }
}