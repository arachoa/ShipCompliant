using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using Castle.Core.Resource;
using Gallio.Framework.Data;
using OpenQA.Selenium;
using ProtoTest.Golem.Core;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;


namespace Golem.ShipCompliant.PublicPro.PageObjects
{
    public class SupportingDocuments : BasePageObject
    {
        Element supportingDocumentsSlider = new Element("SupportingDocumentsSlider", By.XPath("//div[@class='step active']"));
        Button bottlingLetterUpload = new Button(By.XPath("//div[@data-documenttypename='Bottling Letter']"));
        Button authorizationLetterUpload = new Button(By.XPath("//div[@data-documenttypename='Brand Owner Authorization Letter']"));
        Button appointmentLetterUpload = new Button(By.XPath("//div[@data-documenttypename='Distributor Appointment Letter - EAGLE BEVERAGE']"));
        string PDFPathOne = Config.GetConfigValue("BottlingLetterPDF", Directory.GetCurrentDirectory() + @".\\DataSource\\Test Bottling Letter1.pdf");
        string PDFPathTwo = Config.GetConfigValue("BrandAuthorizationPDF", Directory.GetCurrentDirectory() + @".\\DataSource\\Test Brand Authorization Letter1.pdf");
        string PDFPathThree = Config.GetConfigValue("AppointmentPDF", Directory.GetCurrentDirectory() + @".\\DataSource\\Test Appointment Letter1.pdf");
        Element bottlingLetterFileName = new Element("BottlingLetterFileName", By.XPath("//div[@data-documenttypename='Bottling Letter' and contains(.,'Test Bottling Letter1.pdf')]"));
        Element authorizationLetterFileName = new Element("AuthorizationLetterFileName", By.XPath("//div[@data-documenttypename='Brand Owner Authorization Letter' and contains(.,'Test Brand Authorization Letter1.pdf')]"));
        Element appointmentLetterFileName = new Element("AppointmentLetterFileName", By.XPath("//div[@data-documenttypename='Distributor Appointment Letter - EAGLE BEVERAGE' and contains(.,'Test Appointment Letter1.pdf')]"));
        Button browseButton = new Button(By.XPath("//input[@name='file']"));
        Button saveDocumentButton = new Button(By.XPath("//button[@class='button button-blue' and contains(.,'Save document')]"));
        
        Element comments = new Element("Comments", By.XPath("//textarea[@id='comments']"));
        Button continueReview = new Button(By.XPath("//a[@class='button continue']"));
           

        public override void WaitForElements()
        {

        }

        public SupportingDocuments VerifySupportingDocumentsHighlighted()
        {
            supportingDocumentsSlider.Verify().Visible();
            supportingDocumentsSlider.Highlight();

            return this;
        }

        public SupportingDocuments UploadBottlingLetter()
        {
            bottlingLetterUpload.Click();
            browseButton.Click();
            
            Element filename = new Element("FileName field", By.Id("upField"));
            filename.SendKeys("C:\\Users\\Ara\\Documents\\sample.txt");
            filename.SendKeys(Keys.Enter);

            return new SupportingDocuments();
        }

        public SupportingDocuments TypeComments(string text)
        {
            comments.SendKeys(text);

            return this;
        }

        public eSignatureOverlay SelectContinueButton()
        {
            continueReview.Click();

            return new eSignatureOverlay();
        }


    }
}
