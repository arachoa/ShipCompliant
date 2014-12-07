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
    public class SelectDistributors : BasePageObject
    {

        Element selectDistributorsSlider = new Element("SelectDistributorsSlider", By.XPath("//div[@class='step distributors-breadcrumb active']"));
        Element addNewDistributors = new Element("AddNewDistributors", By.XPath("//strong[@class='icon-background add' and contains(.,'Add a new distributor...')]"));
        Element distributorSearchField = new Element("DistributorSearchField", By.XPath("//input[@id='distributorName']"));
        Element selectAllStateLink = new Element("SelectAllStateLink", By.XPath("//a[@class='check-all']"));
        Checkbox firstStateCheckBox = new Checkbox((By.XPath("//div[1]/div[1]/input[@type='checkbox']")));
        Checkbox lastStateCheckBox = new Checkbox((By.XPath("//div[3]/div[34]/input[@type='checkbox']")));
        Button saveDistributorButton = new Button(By.XPath("//button[@class='button button-blue' and contains(.,'Save Distributor')]"));
        Button selectedDistributorBtn = new Button(By.XPath("//div[contains(@class, 'selected lighter-green-gradient')]"));
        Button deselectedDistributorBtn = new Button(By.XPath("//div[contains(@class, 'lighter-grey-gradient')]"));
        Button continueDocumentsBtn = new Button(By.XPath("//a[@id='continue']"));


        public override void WaitForElements()
        {

        }

        public SelectDistributors VerifySelectDistributorsHighlighted()
        {
            selectDistributorsSlider.Verify().Visible();
            selectDistributorsSlider.Highlight();

            return this;
        }

        public SelectDistributors SelectAddNewDistributors()
        {
            addNewDistributors.Click();

            return new SelectDistributors();
        }

        
        public SelectDistributors TypeDistributorNum(string text)
        {
            Thread.Sleep(1000);
            distributorSearchField.SendKeys(text);

            return new SelectDistributors();
        }

        public SelectDistributors SelectDistributorOption(string text)
        {
            Thread.Sleep(1000);
            distributorSearchField.SendKeys(Keys.ArrowDown);
            distributorSearchField.SendKeys(Keys.Enter);

            return new SelectDistributors();
        }

        public SelectDistributors VerifyDistributorName(string text)
        {
            distributorSearchField.Verify().Value(text);

            return this;
        }

        public SelectDistributors SelectAllStateLink()
        {
            selectAllStateLink.Click();

            return new SelectDistributors();
        }

        public SelectDistributors VerifyFirstLastStateChecked()
        {
            firstStateCheckBox.Verify().Selected();
            lastStateCheckBox.Verify().Selected();

            return this;
        }

        public SelectDistributors SelectSaveDistributorButton()
        {
            saveDistributorButton.Click();

            return new SelectDistributors();
        }

        public SelectDistributors ClickEnabledDistributorBtn()
        {
            selectedDistributorBtn.Click();

            return new SelectDistributors();
        }

        public SelectDistributors VerifyDistributorBtnDisabled()
        {
            deselectedDistributorBtn.Verify().Visible();

            return this;
        }

        public SelectDistributors SelectContinueDocumentsBtn()
        {
            continueDocumentsBtn.Click();

            Thread.Sleep(1000);
            var alert = driver.SwitchTo().Alert();
            if (alert.Text != "Please select at least one distributor before continuing.")
            {
                WebDriverTestBase.AddVerificationError(
                    "Alert not present with text 'Please select at least one distributor before continuing', actual text : " +
                    alert.Text);
            }
            alert.Accept();
            driver.SwitchTo().DefaultContent();

            return new SelectDistributors();
        }


        public SelectDistributors ClickDisabledDistributorBtn()
        {
            deselectedDistributorBtn.Click();

            return new SelectDistributors();
        }

        public DetermineRequiredDocumentsOverlay ReSelectContinueDocumentsBtn()
        {
            continueDocumentsBtn.Click();

            return new DetermineRequiredDocumentsOverlay();
        }
    }
}
