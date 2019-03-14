using NUnit.Framework;
using Postcodeio;
using System;
namespace Postcodeio
{
    [TestFixture()]
    public class SinglePostCodeServiceTests
    {
        SinglePostCodes singlePostCodesService = new SinglePostCodes();

        public SinglePostCodeServiceTests()
        {
            singlePostCodesService.GetSinglePostCode("se120nb");
        }

        [Test()]
        public void Status200()
        {
            Assert.AreEqual("200", singlePostCodesService.PostcodeSingleResponseContent["status"].ToString());
        }


        [Test()]
        public void ReturnCorrectPostcode()
        {
            Assert.AreEqual("SE12 0NB", singlePostCodesService.PostcodeSingleResponseContent["result"]["postcode"].ToString());
        }

    }   
}
