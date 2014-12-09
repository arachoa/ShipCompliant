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
        Text commentTextOne = new Text(By.XPath("//div[@class='comment-body']"));
        Text distributorName = new Text(By.XPath("//div[@id='licensee']/div/div[2]"));
        Element homeTab = new Element("HomeTab", By.XPath("//div[@id='home-tab']/a[contains(.,'Home')]"));
        Link editRegistration = new Link(By.XPath("//a[@class='fancy-link edit-registration' and contains(.,'Edit Registration')]"));
        Text commentTextTwo = new Text(By.XPath("//div[@class='comment-list-item public-comment']/div[@class='comment-body']"));
        Button approveButton = new Button(By.XPath("//span[@id='approve-button']"));
        Button revokeButton = new Button(By.XPath("//a[@id='revoke-button']"));
        Text commentOverlay = new Text(By.XPath("//textarea[@id='revoke-comment-text']"));
        Button okButtonOverlay = new Button(By.XPath("//input[@id='ok-revoke-button']"));


        



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

        public RegistrationDetailsPage VerifyFilingDate()
        {
            DateTime date = DateTime.Today;
            string currentDate = date.ToString();
            filingDate.Verify().Text(currentDate);

            return this;
        }

        public RegistrationDetailsPage VerifyComment(string statecomment)
        {
            commentTextOne.Verify().Text(statecomment);

            return this;
        }

        public RegistrationDetailsPage VerifyDistributor(string statedistributor)
        {
            distributorName.Verify().Text(statedistributor);

            return this;
        }

        public ProcessRegistrationsPage SelectHomeMenu()
        {
            homeTab.Click();

            return new ProcessRegistrationsPage();
        }

        public EditRegistrationPage SelectEditRegistration()
        {
            editRegistration.Click();

            return new EditRegistrationPage();
        }

        public RegistrationDetailsPage VerifyCommentTwo(string franchisecomment)
        {
            commentTextTwo.Verify().Text(franchisecomment);

            return this;
        }

        public ProcessRegistrationsPage SelectApproveButton()
        {
            approveButton.Click();

            return new ProcessRegistrationsPage();
        }

        public ProcessRegistrationsPage RevokeRegistration(string testcommentoverlay)
        {
            revokeButton.Click();
            commentOverlay.Text = testcommentoverlay;
            okButtonOverlay.Click();

            return new ProcessRegistrationsPage();
        }








    }
}
