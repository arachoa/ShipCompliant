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
        Text stateCOLANumber = new Text(By.XPath("//table[@id='search-results']/tbody/tr[1]/td[6]"));
        Element viewDetailsIcon = new Element("ViewDetailsIcon", By.XPath("//table[@id='search-results']/tbody/tr[1]//span[@class='details-icon']"));



        //public Element stateCOLANumber(string text)
        //{
        //    return new Element("COLANumber", By.XPath("//td[@class='details-link' and contains(.,'" + text + "')]"));
        //}


        public override void WaitForElements()
        {
            newFilterTab.WaitUntil().Present();
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






    }
}
