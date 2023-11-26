using UtlBuilder.Core.ValueObjects;
using UtlBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class CampaignTests
    {
        [TestMethod]
        [DataRow("", "", "", true)]
        [DataRow("src", "", "", true)]
        [DataRow("src", "med", "", true)]
        [DataRow("src", "med", "nam", false)]
        public void Campaign(string source, string medium, string name, bool expectExcpetion) 
        { 
            if(expectExcpetion)
            {
                try
                {
                    new Campaign(source, medium, name);
                    Assert.Fail();
                }
                catch(InvalidCampaignException)
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                new Campaign(source, medium, name);
                Assert.IsTrue(true);
            }
        }
    }
}
