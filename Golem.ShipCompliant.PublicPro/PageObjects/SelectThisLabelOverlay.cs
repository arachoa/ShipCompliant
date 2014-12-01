using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;

namespace Golem.ShipCompliant.PublicPro.PageObjects
{
    public class SelectThisLabelOverlay : BasePageObject
    {

        Element selectThisLabelButton = new Element("SelectThisLabelButton", By.XPath("//span[@class='button continue']"));
        public Text ColaNumOverlayText = new Text(By.XPath("//div[contains(@class,'float-left')]/p[2]/strong"));
        
        
        //public SelectCOLA selectcola;

        //public Element colaNumOverlay(string text)
        //{
        //    new Element("COLANumOverlay", By.XPath("//div[contains(@class,"float-left")]/p[2]/strong"));
        //    ////div[contains(@class,"float-left")]/p[2]/strong
        //    //div[contains(@class,"float-left")]//strong[contains(.,"13233001000111")]
        //    ////div[@class='float-left label-info']//strong[contains(.,'" + text + "')]
        //}


        public override void WaitForElements()
        {

        }

        public SelectThisLabelOverlay VerifySelectLabelButton()
        {
            selectThisLabelButton.Verify().Present();

            return this;
        }

        public SelectThisLabelOverlay VerifyColanumOverlay(string colanumber)
        {
            ColaNumOverlayText.Verify().Visible();
            ColaNumOverlayText.Verify().Text(colanumber);
           

            return this;
        }

        public CreateNewAccountOverlay ClickSelectLabelButton()
        {
            selectThisLabelButton.Click();

            return new CreateNewAccountOverlay();
        }

        
    }
}
