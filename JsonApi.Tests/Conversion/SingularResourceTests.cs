﻿using JsonApi.Components;
using JsonApi.Tests.Data;
using JsonApi.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace JsonApi.Tests.Conversion
{
    [TestClass]
    public class SingularResourceTests
    {
        private JsonApiDocument<SimpleArticle> _document;

        [TestInitialize]
        public void TestInitialize()
        {
            _document = JsonConvert.DeserializeObject<JsonApiDocument<SimpleArticle>>(TestData.ValidDocumentSimpleJson());
        }

        [TestMethod]
        public void ConversionTest()
        {
            var article = _document.Resource;
            Assert.AreEqual("42", article.Id);
            Assert.AreEqual("JSON API paints my bikeshed!", article.Title);
        }
    }
}