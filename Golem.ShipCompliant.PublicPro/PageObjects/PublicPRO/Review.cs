using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;
using System.Threading;

namespace Golem.ShipCompliant.PublicPro.PageObjects
{
    public class Review : BasePageObject
    {

        Element reviewSlider = new Element("ReviewSlider", By.XPath("//div[@class='step last active']"));
        Text kansasNewRegistration = new Text(By.XPath("//div[@class='fee-summary']/div[@class='cell c1' and contains(.,'Kansas New Registration')]"));
        Text expressFees = new Text(By.XPath("//div[@class='fee-summary']/div[@class='cell c2' and contains(.,'$10')]"));
        Text estStateFees = new Text(By.XPath("//div[@class='fee-summary']/div[@class='cell c3' and contains(.,'$50')]"));
        Text totalFeesSummary = new Text(By.XPath("//div[@class='fee-summary']/div[@class='cell c4' and contains(.,'$60')]"));
        Text totalFeesTotal = new Text(By.XPath("//div[@class='fee-total']/div[@class='cell c4' and contains(.,'$60')]"));
        Text creditCardName = new Text(By.XPath("//input[@name='creditCard.NameOnCard']"));
        Element creditCardNumberField = new Element("CreditCardNumberField", By.XPath("//input[@name='creditCard.CardNumber']"));
        Element ccvNumberField = new Element("CCVNumberField", By.XPath("//input[@name='creditCard.CVV']"));
        Dropdown monthExpirationField = new Dropdown(By.XPath("//select[@name='creditCard.ExpirationMonth']"));
        Dropdown yearExpirationField = new Dropdown(By.XPath("//select[@name='creditCard.ExpirationYear']"));
        Element billingZipField = new Element("BillingZipField", By.XPath("//input[@name='creditCard.BillingZip']"));
        Text applicantName = new Text(By.XPath("//div[@class='form-item review-box clearfix']/div[@class='clearfix']/div[contains(.,'PERNOD RICARD USA LLC')]"));
        Text applicantAddress1 = new Text(By.XPath("//div[@class='form-item review-box clearfix']/div[@class='clearfix']/div[3]"));
        Text applicantAddress2 = new Text(By.XPath("//div[@class='form-item review-box clearfix']/div[@class='clearfix']/div[4]"));
        Text applicantCityZip = new Text(By.XPath("//div[@class='form-item review-box clearfix']/div[@class='clearfix']/div[5]"));
        Text bottlingLetterDoc = new Text(By.XPath("//div[@class='form-item review-box clearfix']/div[2]/div/a"));
        Text appointmentLetterDoc = new Text(By.XPath("//div[@class='form-item review-box clearfix']/div[1]/div/a"));
        Text authorizationLetterDoc = new Text(By.XPath("//div[@class='form-item review-box clearfix']/div[3]/div/a"));
        Text distributorName = new Text(By.XPath("//span[@class='document-name' and contains(.,'EAGLE BEVERAGE')]"));
        Text comments = new Text(By.XPath("//div[@class='review-item span' and contains(.,'QA Test Comment for State Adminstrator')]"));
        Button submitButton = new Button(By.XPath("//a[@id='generateCaptureAndSubmit']"));
        Element submitMessage = new Element("SubmitMessage", "//h2[contains(.,'Kansas has received your registration!')]");
        
        
        



        public override void WaitForElements()
        {
            reviewSlider.WaitUntil().Present();
        }

        public Review VerifyReviewSlider()
        {
            reviewSlider.Verify().Visible();
            reviewSlider.Highlight();

            return this;
        }

        public Review VerifyStateRegistration()
        {
            kansasNewRegistration.Verify().Visible();
            kansasNewRegistration.Highlight();

            return this;
        }

        public Review VerifyFeesSummary()
        {
            expressFees.Verify().Visible();
            expressFees.Highlight();

            estStateFees.Verify().Visible();
            estStateFees.Highlight();

            totalFeesSummary.Verify().Visible();
            totalFeesSummary.Highlight();

            return this;
        }

        public Review VerifyTotalFees()
        {
            totalFeesTotal.Verify().Visible();
            totalFeesTotal.Highlight();

            return this;
        }

        public Review VerifyCreditCardName(string firstname, string lastname)
        {
            creditCardName.Verify().Value(firstname + " " + lastname);

            return this;
        }

        public Review TypeCreditCardInformation(string creditcardnum, string cvvnumber, string creditmonth, string zip)
        {
            creditCardNumberField.Text = creditcardnum;
            cvvNumberField.Text = cvvnumber;
            monthExpirationField.SelectOption(creditmonth);
            DateTime date = DateTime.Now;
            var currentYear = date.Year + 1;
            yearExpirationField.SelectOption(currentYear);
            billingZipField.Text = zip;

            return new Review();
        }

        public Review SelectSubmitButton()
        {
            submitButton.Click();

            return new Review()
        }

        public Review VerifySubmitMessage()
        {
            submitMessage.Verify().Visible();

            return this;
        }




    }
}
