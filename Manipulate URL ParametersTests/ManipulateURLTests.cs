using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Manipulate_URL_Parameters;

namespace Manipulate_URL_Parameters.Tests
{
    [TestFixture]
    public class ManipulateURLTests
    {
        [Test]
        public void addOrChangeUrlParameterTest()
        {
            Assert.AreEqual(ManipulateURL.addOrChangeUrlParameter("www.example.com", "key=value"), "www.example.com?key=value");
            Assert.AreEqual(ManipulateURL.addOrChangeUrlParameter("www.example.com?key=value", "key2=value2"), "www.example.com?key=value&key2=value2");
            Assert.AreEqual(ManipulateURL.addOrChangeUrlParameter("www.example.com?key=oldValue`", "key=newValue"), "www.example.com?key=newValue");
        }

        [Test]
        public void ParametersIsNullOrEmpty()
        {
            Assert.Throws<ArgumentNullException>(delegate { ManipulateURL.addOrChangeUrlParameter(null, null); });
            Assert.Throws<ArgumentException>(delegate { ManipulateURL.addOrChangeUrlParameter("", ""); });
        }
    }
}