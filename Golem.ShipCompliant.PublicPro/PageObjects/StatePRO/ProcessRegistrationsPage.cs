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
    public class ProcessRegistrationsPage : BasePageObject
    {

        Text welcomeMessage = new Text(By.XPath("//span[@class='welcome ']"));
        Element newFilterTab = new Element("NewFilterTab", By.XPath("//div[@class='filter-tab active']"));
        Element commentsIcon = new Element("CommentsIcon", By.XPath("//table[@id='search-results']/tbody/tr[1]//span[@class='new-comments-icon']"));
        Text stateCOLANumber = new Text(By.XPath("//tr[./td[text()='Pernod Ricard USA']]/td[6]"));
        Element viewDetailsIcon = new Element("ViewDetailsIcon", By.XPath("//table[@id='search-results']/tbody/tr[1]//span[@class='details-icon']"));
        Link clearSearch = new Link(By.XPath("//span[@class='fancy-link clear-filters' and contains(.,'Clear Search')]"));
        Link showFilters = new Link(By.XPath("//span[@class='fancy-link' and contains(.,'Show Filters')]"));
        Element labelTextBox = new Element("LabelTextBox", By.XPath("//input[@id='label-filters']"));
        Button searchButton = new Button(By.XPath("//span[@id='search-btn']"));
        Text searchRecordTTBID = new Text(By.XPath("//table[@id='search-results']/tbody/tr[1]/td[6]"));
        Element approvedStatus = new Element("ApprovedStatus", By.XPath("//td[@class='details-link registration-status-approved']"));
        Link logoutLink = new Link(By.XPath("//a[contains(.,'Logout')]"));


        public override void WaitForElements()
        {
            //newFilterTab.WaitUntil().Present();
        }

        public ProcessRegistrationsPage VerifyWelcomeMessage(string stateusername)
        {
            welcomeMessage.Verify().Text("Welcome " + stateusername);

            return this;
        }

        public ProcessRegistrationsPage VerifyStateCOLANumber(string statecolanum)
        {
            stateCOLANumber.Verify().Text(statecolanum);

            return this;
        }

        public ProcessRegistrationsPage VerifyCommentsIcon()
        {
            commentsIcon.Verify().Visible();
            commentsIcon.Highlight();

            return this;
        }

        public RegistrationDetailsPage SelectViewDetailsIcon()
        {
            viewDetailsIcon.Click();

            return new RegistrationDetailsPage();
        }

        public ProcessRegistrationsPage SelectClearSearchLink()
        {
            clearSearch.Click();

            return new ProcessRegistrationsPage();
        }

        public ProcessRegistrationsPage SelectShowFiltersLink()
        {
            showFilters.Click();

            return new ProcessRegistrationsPage();
        }

        public ProcessRegistrationsPage SearchTTBID(string statecolanum)
        {
            labelTextBox.Text = statecolanum;
            searchButton.Click();

            return new ProcessRegistrationsPage();
        }

        public ProcessRegistrationsPage VerifySearchRecordTTBID(string statecolanum)
        {
            searchRecordTTBID.Verify().Text(statecolanum);

            return this;
        }

        public ProcessRegistrationsPage VerifyApprovedStatus()
        {
            approvedStatus.Verify().Visible();
            approvedStatus.Highlight();

            return this;
        }

        public LoginPage SelectLogoutLink()
        {
            logoutLink.Click();

            return new LoginPage();
        }




    }
}
