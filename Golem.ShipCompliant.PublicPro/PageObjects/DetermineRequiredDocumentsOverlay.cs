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
    public class DetermineRequiredDocumentsOverlay : BasePageObject
    {

        Element overlayTitle = new Element("OverlayTitle", By.XPath("//h2[@id='dialog-title' and contains(.,'Determine required documents for this brand')]"));
        Element brandOwnerRadioBtn = new Element("BrandOwnerRadioBtn", By.XPath("//input[@name='brandIsOwnedByThirdParty' and @checked='']"));
        Element brandProducerRadioBtn = new Element("BrandProducerRadioBtn", By.XPath("//input[@name='brandProducedByThirdParty' and @value='true']"));
        Element brandBottleRadioBtn = new Element("BrandBottleRadioBtn", By.XPath("//input[@name='brandIsBottledByThirdParty' and @value='true']"));
        Element brandAquiredRadioBtn = new Element("BrandAquiredRadioBtn", By.XPath("//input[@name='brandWasAcquiredFromThirdParty' and @value='false']"));
        Element brandTradeRadioBtn = new Element("BrandTradeRadioBtn", By.XPath("//input[@name='brandOperatesUnderTradeName' and @value='false']"));

        
        
        
        public override void WaitForElements()
        {

        }

        public DetermineRequiredDocumentsOverlay VerifyOverlayTitle()
        {
            overlayTitle.Verify().Visible();

            return this;
        }

        public DetermineRequiredDocumentsOverlay VerifyBrandOwnerRadioButtonSelected()
        {
            brandOwnerRadioBtn.Verify().Selected();

            return this;
        }

        public SupportingDocuments SelectRadioButtons()
        {
            brandProducerRadioBtn.Click();
            brandBottleRadioBtn.Click();
            brandAquiredRadioBtn.Click();
            brandTradeRadioBtn.Click();

            return new SupportingDocuments();
        }




    }
}
