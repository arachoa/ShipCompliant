using System.IO;
using System.Security.Cryptography;
using Golem.ShipCompliant.PublicPro.PageObjects;
using Golem.ShipCompliant.PublicPro.PageObjects.StatePRO;
using MbUnit.Framework;
using ProtoTest.Golem.Core;
using ProtoTest.Golem.WebDriver;

namespace Golem.ShipCompliant.PublicPro.Tests
{
    public class StatePROApplicationTest : WebDriverTestBase
    {

        private string stateproUrl = Config.GetConfigValue("StateProUrl", "http://ks-staging.productregistrationonline.com");
        private string stateusername = Config.GetConfigValue("StateUserName", "Prototest");
        private string statepassword = Config.GetConfigValue("StatePassword", "C0mpliant14");
        private string statecolanum = Config.GetConfigValue("StateCOLANumber", "13233001000111");
        private string statebottlesizes = Config.GetConfigValue("StateBottleSizes", "1 lt,750 ml");
        private string alcoholvalue = Config.GetConfigValue("AlcoholValue", "14%");
        private string feecollectedamount = Config.GetConfigValue("FeeCollectedAmount", "$50");
        private string statecomment = Config.GetConfigValue("StateComment", "QA Test Comment for State Administrator");
        private string statedistributor = Config.GetConfigValue("StateDistributor", "PERNOD RICARD USA, LLC");




        [Test]
        public void VerifyPublicProRegistration()
        {

            OpenPage<LoginPage>(stateproUrl)
                .LoginStatePro(stateusername, statepassword)
                .VerifyWelcomeMessage(stateusername)
                .VerifyStateCOLANumber(statecolanum)
                .VerifyCommentsIcon()
                .SelectViewDetailsIcon()

                //Verify Product Registration Data from Public PRO
                .VerifyTTBIDNumber(statecolanum)
                .VerifyBottleSizes(statebottlesizes)
                .VerifyAlcoholValue(alcoholvalue)
                .VerifyFeeCollected(feecollectedamount)
                .VerifyFilingDate(text)
                .VerifyComment(statecomment)
                .VerifyDistributor(statedistributor);

                

        }
    }
}
