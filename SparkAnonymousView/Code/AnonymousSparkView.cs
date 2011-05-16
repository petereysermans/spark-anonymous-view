using System;
using Spark;

namespace SparkAnonymousView.Code
{
    public abstract class AnonymousSparkView : AbstractSparkView
    {
        public object Data { get; set;  }
        public Type AnonymousType { get; set; }
    }
}
