using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;

namespace Golem.ShipCompliant.PublicPro.PageObjects.StatePRO
{
    public class RegistrationDetailsPage : BasePageObject
    {
        Text ttbID = new Text(By.XPath("//table[@id='additional']/tbody/tr[1]/td[2]"));
        Text bottleSizes = new Text(By.XPath("//table[@id='additional']/tbody/tr[3]/td[2]"));
        Text alcoholPercentage = new Text(By.XPath("//table[@id='additional']/tbody/tr[4]/td[2]"));
        Text feeCollected = new Text(By.XPath("//table[@id='application-type-details']/tbody/tr/td[2]/div[@class='detail-data']"));
        Text filingDate = new Text(By.XPath("//table[@id='application-type-details']/tbody/tr/td[1]/div[10]"));
        Text commentText = new Text(By.XPath("//div[@class='comment-body']"));
        Text distributorName = new Text(By.XPath("//div[@id='licensee']/div/div[2]"));


        



        public override void WaitForElements()
        {
            
        }

        public RegistrationDetailsPage VerifyTTBIDNumber(string text)
        {
            ttbID.Verify().Text(text);

            return this;
        }

        public RegistrationDetailsPage VerifyBottleSizes(string statebottlesizes)
        {
            bottleSizes.Verify().Text(statebottlesizes);

            return this;
        }

        public RegistrationDetailsPage VerifyAlcoholValue(string alcoholvalue)
        {
            alcoholPercentage.Verify().Text(alcoholvalue);

            return this;
        }

        public RegistrationDetailsPage VerifyFeeCollected(string feecollectedamount)
        {
            feeCollected.Verify().Text(feecollectedamount);

            return this;
        }

        public RegistrationDetailsPage VerifyFilingDate(string text)
        {
            DateTime date = DateTime.Today;
            string currentDate = date;
            filingDate(text).Verify().Text(currentDate);

            return this;
        }

        public RegistrationDetailsPage VerifyComment(string statecomment)
        {
            commentText.Verify().Text(statecomment);

            return this;
        }

        public RegistrationDetailsPage VerifyDistributor(string statedistributor)
        {
            distributorName.Verify().Text(statedistributor);

            return this;
        }





    }
}
