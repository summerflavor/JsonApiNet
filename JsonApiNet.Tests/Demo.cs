using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonApiNet.Tests.Data;
using JsonApiNet;

namespace JsonApiNet.Tests
{
    [TestClass]
    public class Demo
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sessionJson = TestData.ValidDocumentSessioinJson();
            var user = JsonApi.ResourceFromDocument<Sessions>(sessionJson, ignoreMissingRelationships:true);
        }
    }
}
